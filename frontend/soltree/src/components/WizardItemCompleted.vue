<template>
  <Card style="width: 100%" class="fadein animation-duration-300">
    <template #content>
      <div class="text-center">
        <div v-if="brandStore.isSolved">
          <h2>Sorun çözüm işlemi tamamlandı, ana sayfaya yönlendiriliyorsunuz...</h2>
        </div>
        <div v-if="!brandStore.isSolved">
          <h2>Ne yazık ki sorun çözüm işlemi tamamlanamadı, ana sayfaya yönlendiriliyorsunuz...</h2>
        </div>

        <div class="timer">
          {{ timer }} 
        </div>
      </div>
    </template>
  </Card>
</template>


<script setup lang="ts">
    import { useWizardStore } from '../store/wizardStore';
    import { useBrandStore } from '../store/brandStore';
    import { onActivated, ref } from 'vue';
    
    
    const wizardStore = useWizardStore();
    const brandStore = useBrandStore();
    let timer = ref();

    onActivated(() => {
      timer.value = 3;
      let interval = setInterval(() => {
        if (timer.value === 0) {
          clearInterval(interval) 
          wizardStore.index = 0;
          brandStore.selectedBrand = null;           
        } else {
          timer.value--
          console.log(timer)
        }             
      }, 1000)
    })
</script>


<style>
  .timer {
    width: 50px;
    height: 50px;
    margin: auto;
    font-size: 38px;
  }
</style>