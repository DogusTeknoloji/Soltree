<template>
  <Card style="width: 100%" class="fadein animation-duration-300">
    <template #content>
      <div class="text-center">
        selam smsmsmsms
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
import { useWizardStore } from '../store/wizardStore';

const wizardStore = useWizardStore();

const nextPage = () => {
  wizardStore.next();
};

const prevPage = () => {
  wizardStore.prev();
};

</script>