<template>
  <div class="flex flex-column align-content-center justify-content-center flex-wrap" style="min-height: 100%">
    <div class="flex align-items-center justify-content-center" style="width: 50%;">
      <Card style="width: 100%; margin-bottom: 2rem">
        <template #content>
          <Button label="Marka Seçimi" />
        </template>
      </Card>
    </div>

    <div class="flex align-items-center justify-content-center" style="width: 50%;">
      <SelectBrand></SelectBrand>
    </div>
  </div>
</template>

<script setup lang="ts">
import { ref } from 'vue';
import { useRouter } from 'vue-router';
import SelectBrand from '../components/SelectBrand.vue';

const router = useRouter()

const items = ref([
  {
    label: 'Marka Seçimi',
    component: () => import('@/components/SelectBrand.vue')
  },
  {
    label: 'Model Seçimi',
  },
  {
    label: 'Sorun Seçimi',
  },
  {
    label: 'Çözüm Önerileri',
  }
]);

// const nextPage = (event: any) => {
//   router.push(items.value[event.pageIndex + 1].to);
// };

// const prevPage = (event: any) => {
//   router.push(items.value[event.pageIndex - 1].to);
// };

</script>

<style lang="scss" scoped>
.p-dropdown {
  width: 14rem;
}
</style>