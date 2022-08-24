<template>
  <Card style="width: 100%" class="fadein animation-duration-300">
    <template #content>
      <div class="text-center">
        <!--<div><span>Marka: {{ brandStore.selectedBrand }}</span> <br>
        <span>Cihaz tipi: {{ brandStore.selectedDeviceType }}</span> <br>
        <span>Model: {{ brandStore.selectedModel }}</span><br></div>-->
        <h3>Yaşadığınız problemin kategorisini seçiniz.</h3>
        <Dropdown v-model="selectedSymptomCategory" :options="symptomCategories" option-label="name"
        option-value="id" placeholder="Sorun kategorisi seçiniz" aria-required="true" class="text-left"></Dropdown>
        <h3 v-if="symptoms.length > 0">Yaşadığınız problemi seçiniz.</h3>
        <Dropdown v-if="symptoms.length > 0" v-model="selectedSymptom" :options="symptoms" option-label="name" 
        option-value="id" placeholder="Sorun seçiniz" aria-required="true" class="text-left"></Dropdown>
      </div>
    </template>
    <template #footer>
      <div class="text-center">
        <Button label="Geri" icon="pi pi-angle-left" iconPos="right" @click="prevPage()"></Button>
        <Button label="Devam" icon="pi pi-angle-right" iconPos="right" @click="nextPage()"></Button>
      </div>
    </template>
  </Card>
</template>

<script setup lang="ts">
import { graphql } from 'graphql';
import { useWizardStore } from '../store/wizardStore';
import { useBrandStore } from '../store/brandStore';
import { useGetSymptomCategorybyModelQuery, useGetSymptombyCategoryQuery } from '../graphql';
import { computed, onActivated, ref } from 'vue';
import { storeToRefs } from 'pinia';


const wizardStore = useWizardStore();
const brandStore = useBrandStore();

const { selectedModel } = storeToRefs(brandStore);

const selectedSymptomCategory = ref<string | null>();

const getSymptomCategoryResult = useGetSymptomCategorybyModelQuery({
  pause: true,
  variables: { modelId: selectedModel }
});
const symptomCategories = computed(() => getSymptomCategoryResult.data.value?.symptomCategorys?.items ?? []);

const getSymptombyCategoryResult = useGetSymptombyCategoryQuery({
  pause: true,
  variables: { symptomCategoryId: selectedSymptomCategory}
});

const symptoms = computed(() => getSymptombyCategoryResult.data.value?.symptoms?.items ?? []);
const selectedSymptom = ref<string | null>();


onActivated(() => {
  getSymptomCategoryResult.executeQuery();
  selectedSymptomCategory.value = null;
  getSymptombyCategoryResult.executeQuery();
  selectedSymptom.value = null;
});


const nextPage = () => {
  brandStore.selectedSymptom = selectedSymptom.value;
  if (brandStore.selectedSymptom != null) {
      wizardStore.next();
  }
};

const prevPage = () => {
  wizardStore.prev();
};

</script>
