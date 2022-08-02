<template>
  <Card style="width: 100%">
    <template #content>
      <div class="text-center">
        <h3>Hata çözümleme işlemine hoşgeldiniz</h3>
        <h3>Aşağıdan cihaz markanızı seçiniz</h3>
        <Dropdown v-model="selectedBrand" :options="brands" option-label="name" option-value="id"
          placeholder="Select a Brand" :filter="true" aria-required="true" class="text-left"></Dropdown>
      </div>
    </template>
    <template #footer>
      <div class="text-center">
        <Button label="Devam" icon="pi pi-angle-right" iconPos="right" @click="nextPage()"></Button>
      </div>
    </template>
  </Card>
</template>

<script setup lang="ts">
import { computed, ref } from 'vue';
import { useGetBrandsQuery } from '../graphql'

const emit = defineEmits(['next-page'])

const getBrandsQueryResult = useGetBrandsQuery();
const brands = computed(() => getBrandsQueryResult.data.value?.brands?.items ?? []);
const selectedBrand = ref<string>();

const nextPage = () => {
  emit('next-page', { selectedBrand: selectedBrand });
};
</script>