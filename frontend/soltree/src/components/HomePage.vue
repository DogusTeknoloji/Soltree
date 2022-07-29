<template>
  <div id="home">
    <!-- <img src=""></img> -->
    <Navbar></Navbar>

    <h3 id="title">Hata çözümleme işlemine hoşgeldiniz</h3>
    <h3 id="choice">Aşağıdan telefon markanızı seçiniz</h3>
    <!-- <ul>
      <li v-for="brand in brandsList" :key="brand.name">{{ brand['name'] }}</li>
    </ul> -->
    <!-- <Dropdown :options="brandsList" option-label="brandNames" placeholder="Select a Brand"></Dropdown> -->
    <div id="brandDropdown">
      <Dropdown v-model="selectedBrand" :options="brands" option-label="name" option-value="id"
        placeholder="Select a Brand"></Dropdown>
    </div>
    <div id="basla">
      <Button label="BASLA"></Button>
    </div>
    <div>
      {{ selectedBrand }}
    </div>

    <div>
      {{result.fetching}}
      
      {{brands}}

    </div>
  </div>
</template>

<script setup lang="ts">
import Dropdown from 'primevue/dropdown';
import { computed, onMounted, ref } from 'vue';
import Navbar from './Navbar.vue';

import { useGetBrandsQuery } from '../graphql'


const result = useGetBrandsQuery();

const brands = computed(() => result.data.value?.brands?.items ?? []);
const selectedBrand = ref<string>();

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
}
</style>