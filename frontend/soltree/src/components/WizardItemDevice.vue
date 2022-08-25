<template>
  <Toast />
  
  <Card style="width: 100%" class="fadein animation-duration-300">
    <template #content>
      <div class="text-center">
        
        <h2>Lütfen cihaz türünüzü seçiniz</h2>
        <SelectButton v-model="selectedDeviceType" :options="deviceTypes" dataKey="value" option-value="id"
          style="margin-bottom: 20px;">
          <template #option="slotProps">
            <div class="device-option">
              <img :alt="slotProps.option.name" :src="slotProps.option.image" style="width: 150px; height:130px;" />
            </div>
          </template>
        </SelectButton>

        <Dropdown v-if="models.length > 0" v-model="selectedModel" :options="models" option-label="name"
          option-value="id" placeholder="Model seçiniz" aria-required="true" class="text-left"></Dropdown>
      </div>
    </template>
    <template #footer>
      <div class="flex justify-content-between text-center">
        <Button label="Geri" icon="pi pi-angle-left" iconPos="right" @click="prevPage()"></Button>
        <Button label="Devam" icon="pi pi-angle-right" iconPos="right" @click="nextPage()"></Button>
      </div>
    </template>
  </Card>
</template>

<script setup lang="ts">
import { storeToRefs } from 'pinia';
import { computed, onActivated, ref, watch } from 'vue';
import { useGetModelsByBrandandDeviceQuery, useDeviceTypeImageQuery } from '../graphql';
import { useBrandStore } from '../store/brandStore';
import { useWizardStore } from '../store/wizardStore';
import { useToast } from 'primevue/usetoast'

const wizardStore = useWizardStore();
const brandStore = useBrandStore();

const toast = useToast();


const { selectedBrand } = storeToRefs(brandStore);

const selectedDeviceType = ref<string | null>();

const getModelsByBrandIdQueryResult = useGetModelsByBrandandDeviceQuery({
  pause: true,
  variables: { brandId: selectedBrand, deviceTypeId: selectedDeviceType }
});

const models = computed(() => getModelsByBrandIdQueryResult.data.value?.models?.items ?? [])
const selectedModel = ref<string | null>();
const getDeviceTypeImageQueryResult = useDeviceTypeImageQuery();
const deviceTypes = computed(() => getDeviceTypeImageQueryResult.data.value?.deviceTypes?.items ?? [])

watch(selectedDeviceType, () => {
  if (selectedDeviceType.value) {
    getModelsByBrandIdQueryResult.executeQuery()
  }
})

onActivated(() => {
  if (selectedDeviceType.value) {
    getModelsByBrandIdQueryResult.executeQuery()
  }

  selectedDeviceType.value = null;
  selectedModel.value = null;
});

const nextPage = () => {
  brandStore.selectedDeviceType = selectedDeviceType.value;
  brandStore.selectedModel = selectedModel.value;
  if (brandStore.selectedModel != null) {
    wizardStore.next();
  }
  else {
    toast.add({severity:'error', summary: 'Hata Mesajı', detail:'Cihaz tipinizi ve modelinizi seçmeden bir sonraki adıma devam edemezsiniz.', life: 3000});

  }
};

const prevPage = () => {
  wizardStore.prev();
};

</script>

<style>
p-selectbutton p-buttonset p-component {
  margin-bottom: 10px !important;
}

h2 {
  margin-top: -10px;
}
</style>