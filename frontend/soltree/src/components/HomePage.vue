<template>

  <div id="home">
    <h3 id="title">Hata çözümleme işlemine hoşgeldiniz</h3>
    <h3 id="choice">Aşağıdan telefon markanızı seçiniz</h3>
    <div id="brandDropdown">

      <Dropdown v-model="selectedBrand" :options="brands" option-label="name" option-value="id"
        placeholder="Select a Brand" :filter="true" aria-required="true"></Dropdown>
    </div>
    <Toast />
    <div id="basla">
      <!-- <router-link style="text-decoration: none" to="/solution">
        <Button label="BASLA" @click="handler"></Button>
      </router-link> -->
    </div>

    <div>



    </div>
  </div>
</template>

<script setup lang="ts">
import Dropdown from 'primevue/dropdown';
import Toast from 'primevue/toast';
import { computed, ref } from 'vue';
import { useGetBrandsQuery } from '../graphql'
import { useBrandStore } from '../store/brandStore'
import { useToast } from "primevue/usetoast";


const toast = useToast();
const warnUser = () => {
  toast.add({ severity: "warn", summary: "Marka Seçilmedi", detail: "Lütfen marka seçiniz", life: 3000 })
}
const handler = () => {
  if (selectedBrand) {
    warnUser();
  }
}




const result = useGetBrandsQuery();

const brands = computed(() => result.data.value?.brands?.items ?? []);
const selectedBrand = ref<string>();
const store = useBrandStore();
store.selectedBrand = selectedBrand.value;




</script>

<style scoped>
#title {
  margin-top: 300px !important;
  text-align: center;
  color: black;
  font-size: 30px;
}

#choice {
  margin-top: 10px;
  text-align: center;
  opacity: 70%;
  color: brown;
}

ul {
  list-style-type: none;
}


#brandDropdown,
#basla {
  display: flex !important;
  align-items: center !important;
  justify-content: center !important;
}

.p-button {
  margin-top: 20px;
  width: 120px;
  text-decoration: none;
}
</style>