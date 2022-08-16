<template>
  <div class="flex flex-column align-content-center justify-content-center flex-wrap" style="min-height: 100%">
    <div class="flex align-items-center justify-content-center" style="width: 50%;">
      <Card style="width: 100%; margin-bottom: 2rem">
        <template #content>
          <div class="flex justify-content-around flex-wrap">

            <Button label="Marka Seçimi" class="p-button-link flex flex-column" v-for="(item, index) in items"
              :disabled="wizardStore.index != index">
              <div>{{ index + 1 }}</div>
              <div>{{ item.label }}</div>
            </Button>
          </div>
        </template>
      </Card>
    </div>

    <div>
      <CircleMenu :items="circleMenuItems"/>
    </div>

    <div class="flex align-items-center justify-content-center" style="width: 50%;">
      <KeepAlive>
        <component :is="items[wizardStore.index].component" />
      </KeepAlive>
    </div>
  </div>
</template>

<script setup lang="ts">
import { ref, shallowRef, defineAsyncComponent } from 'vue';
import { useRouter } from 'vue-router';
import { useWizardStore } from "../store/wizardStore";
import CircleMenu from '../components/CircleMenu.vue';

const circleMenuItems = ref<any[]>([
  { Label: "Güç ve Şarj", Rotate: -360 },
  { Label: "Görüntü ve Ekran", Rotate: -360 },
  { Label: "Ses ve Müzik", Rotate: -360 },
  { Label: "Şebeke ve Sinyal", Rotate: -360 },
  { Label: "Fotoğraf Video Çekimi", Rotate: -360 },
  { Label: "Hafıza ve Uygulamalar", Rotate: -360 },
  { Label: "Diğerleri", Rotate: -360 },
]);

const wizardStore = useWizardStore();

const items = ref([
  {
    label: 'Marka Seçimi',
    component: shallowRef(defineAsyncComponent(() => import('@/components/WizardItemBrand.vue')))
  },
  {
    label: 'Cihaz Seçimi',
    component: shallowRef(defineAsyncComponent(() => import('@/components/WizardItemDevice.vue')))
  },
  {
    label: 'Problem Seçimi',
    component: shallowRef(defineAsyncComponent(() => import('@/components/WizardItemSymptom.vue')))
  },
  {
    label: 'Çözüm Önerileri',
    component: shallowRef(defineAsyncComponent(() => import('@/components/WizardItemSolution.vue')))
  }
]);


</script>

<style lang="scss" scoped>
.p-dropdown {
  width: 14rem;
}
</style>