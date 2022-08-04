<template>
  <Card style="width: 100%" class="fadein animation-duration-300">
    <template #content>
      <div class="text-center">
        <div>
          <img :src="phoneImage" class="base64img" alt="Telefon" style="width: 150px; height: 120px;" />
          <img src="" class="base64img" alt="Tablet" />
          <img src="" class="base64img" alt="Giyilebilir" />
        </div>
        <Dropdown v-model="selectedModel" :options="models" option-label="name" option-value="id"
          placeholder="Select a Model" aria-required="true" class="text-left"></Dropdown>
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
import { computed, ref } from 'vue';
import { useGetModelsByBrandIdQuery, useDeviceTypeImageQuery } from '../graphql';
import { useBrandStore } from '../store/brandStore';
import { useWizardStore } from '../store/wizardStore';

const wizardStore = useWizardStore();
const brandStore = useBrandStore();

const getModelsByBrandIdQueryResult = useGetModelsByBrandIdQuery({ variables: { brandId: brandStore.selectedBrand } });
const models = computed(() => getModelsByBrandIdQueryResult.data.value?.models?.items ?? [])
const selectedModel = ref<string>();

const getDeviceTypeImageQueryResult = useDeviceTypeImageQuery();
const images = computed(() => getDeviceTypeImageQueryResult.data.value?.deviceTypes?.items ?? [])

const phoneImage: string = images.value[0].image!


console.log(phoneImage)
const nextPage = () => {
  wizardStore.next();
};

const prevPage = () => {
  wizardStore.prev();
};

</script>