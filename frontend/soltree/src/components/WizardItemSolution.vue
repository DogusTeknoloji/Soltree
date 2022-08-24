<template>
  <Card v-if="solutions.length > 0" style="width: 100%" class="fadein animation-duration-300">
    <template #content>
      <div class="text-center">
        <h1>Bunları Uygulayın:</h1>
      </div>
      <h2 class="title">{{ solutions[index].title }}:</h2>
      <p class="description">{{ solutions[index].description }}</p>
      <div class="text-center">
        <Button id="solved" @click="solved" label="Çözüldü" icon="pi pi-check" iconPos="right"></Button>
        <Button id="unsolved" @click="unsolved" label="Çözülmedi" icon="pi pi-times" iconPos="right"></Button>
      </div>
      
    </template>
    <template #footer>
      <div class="text-center">
        <Button id="geri" label="Geri" icon="pi pi-angle-left" iconPos="right" @click="prevPage()"></Button>
      </div>
    </template>
  </Card>
</template>

<script setup lang="ts">

import { graphql } from 'graphql';
import { useWizardStore } from '../store/wizardStore';
import { useBrandStore } from '../store/brandStore';
import { useGetSolutionbySymptomIdQuery } from '../graphql';
import { computed, onActivated, ref, watch } from 'vue';
import { storeToRefs } from 'pinia';


const wizardStore = useWizardStore();
const brandStore = useBrandStore();


const { selectedSymptom } = storeToRefs(brandStore);

const GetSolutionbySymptomIdQueryResult = useGetSolutionbySymptomIdQuery({
  pause: false,
  variables: { symptomId: selectedSymptom }
});

const solutions = computed(() => GetSolutionbySymptomIdQueryResult.data.value?.solutions?.items ?? []);
let index = ref(0);



onActivated(() => {
  GetSolutionbySymptomIdQueryResult.executeQuery();
});


const solved = () => {
  brandStore.isSolved = true;
  wizardStore.next();
}

const unsolved = () => {
  brandStore.isSolved = false;
  if(index.value === solutions.value.length - 1) {
    wizardStore.next();
  }
  else {
    index.value++;
  }
}


const prevPage = () => {
  wizardStore.prev();
};

</script>

<style>
  .title {
    height: 30px;
  }
  .description {
    width: 100%;
    font-size: 18px;
    margin-bottom: 30px;
  }
  #solved {
    margin-right: 5px;
    background-color: green;
    border-color: aliceblue;
  }
  #unsolved {
    margin-left: 5px;
    background-color: firebrick;
    border-color: aliceblue
    ;
  }
</style>