<template>
  <Card style="width: 100%" class="fadein animation-duration-300">
    <template #content>
      <div class="text-center">
        <SelectButton :options="deviceTypes" dataKey="value" option-value="id" @change="displayHandler"
          style="margin-bottom: 20px;">
          <template #option="slotProps">
            <div class="device-option">
              <img :alt="slotProps.option.name" :src="slotProps.option.image" style="width: 150px; height:130px" />
            </div>
          </template>
        </SelectButton>

        <Dropdown v-if="models.length > 0" v-model="selectedModel" :options="models" option-label="name" option-value="id"
          placeholder="Select a Model" aria-required="true" class="text-left"></Dropdown>
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

const selectedDeviceType = ref<string>();

const getModelsByBrandIdQueryResult = useGetModelsByBrandandDeviceQuery({
  pause: true,
  variables: { brandId: brandStore.selectedBrand, deviceTypeId: selectedDeviceType }
});

const models = computed(() => getModelsByBrandIdQueryResult.data.value?.models?.items ?? [])
const selectedModel = ref<string>();
const getDeviceTypeImageQueryResult = useDeviceTypeImageQuery();
const deviceTypes = computed(() => getDeviceTypeImageQueryResult.data.value?.deviceTypes?.items ?? [])

const displayHandler = (e: any) => {
  selectedDeviceType.value = e.value;
  getModelsByBrandIdQueryResult.executeQuery()
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