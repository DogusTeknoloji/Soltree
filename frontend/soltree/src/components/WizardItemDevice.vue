<template>
  <Card style="width: 100%" class="fadein animation-duration-300">
    <template #content>
      <div class="text-center">

        <!-- <div v-for="deviceType in deviceTypes">
          <img :src="deviceType.image!" :alt="deviceType.name" style="height: 120px; width: 150px;" />
        </div> -->
        <SelectButton :options="deviceTypes" dataKey="value" option-value="id" @change="displayHandler"
          style="margin-bottom: 20px;">
          <template #option="slotProps">
            <div class="device-option">
              <img :alt="slotProps.option.name" :src="slotProps.option.image" style="width: 150px; height:130px" />
            </div>
          </template>
        </SelectButton>
        <div v-if="brandStore.selectedDeviceType === 'type-2'">
          <Dropdown v-model="selectedModel" :options="models" option-label="name" option-value="id"
            placeholder="Select a Model" aria-required="true" class="text-left"></Dropdown>
        </div>
        <div v-else-if="brandStore.selectedDeviceType === 'Tablet'">
          <Dropdown v-model="selectedModel" :options="models" option-label="name" option-value="id"
            placeholder="Select a Model" aria-required="true" class="text-left"></Dropdown>

        </div>
        <div v-else-if="brandStore.selectedDeviceType === 'Giyilebilir'">
          <Dropdown v-model="selectedModel" :options="models" option-label="name" option-value="id"
            placeholder="Select a Model" aria-required="true" class="text-left"></Dropdown>
        </div>

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
import { computed, onActivated, ref } from 'vue';
import { useGetModelsByBrandandDeviceQuery, useDeviceTypeImageQuery } from '../graphql';
import { useBrandStore } from '../store/brandStore';
import { useWizardStore } from '../store/wizardStore';

const wizardStore = useWizardStore();
const brandStore = useBrandStore();


let models = computed(() => getModelsByBrandIdQueryResult.data.value?.models?.items ?? [])
const selectedModel = ref<string>();

const getDeviceTypeImageQueryResult = useDeviceTypeImageQuery();
const deviceTypes = computed(() => getDeviceTypeImageQueryResult.data.value?.deviceTypes?.items ?? [])
console.log(deviceTypes)
let selectedDeviceType = ref<string>();
console.log(selectedDeviceType)

const displayHandler = (e: any) => {
  brandStore.selectedDeviceType = e.value;
  let getModelsByBrandIdQueryResult = useGetModelsByBrandandDeviceQuery({ variables: { brandId: brandStore.selectedBrand, deviceTypeId: brandStore.selectedDeviceType } });
  console.log(brandStore.selectedDeviceType)
}



const nextPage = () => {
  wizardStore.next();
};

const prevPage = () => {
  wizardStore.prev();
};

</script>

<style>
p-selectbutton p-buttonset p-component {
  margin-bottom: 10px !important;
}
</style>