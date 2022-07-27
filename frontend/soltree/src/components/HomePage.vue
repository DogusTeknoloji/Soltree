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
      <Dropdown :options="brands" option-label="name" option-value="id" placeholder="Select a Brand"></Dropdown>
    </div>
    <div id="basla">
      <Button label="BASLA"></Button>
    </div>

  </div>
</template>

<script setup lang="ts">import { useQuery } from '@vue/apollo-composable';
import gql from 'graphql-tag';
import Dropdown from 'primevue/dropdown';
import { computed } from 'vue';
import Navbar from './Navbar.vue';

const ALL_BRANDS_QUERY = gql`
query getBrands{
    brands {
      items{
        id
        name
      }
    }
  }
`;

const { result } = useQuery(ALL_BRANDS_QUERY);

const brands = computed(() => result.value?.brands ?? [])
setTimeout(() => {
  console.log(brands.value)
}, 2500);
// const brandsList: Array<any> = brands.value['items']
// const brandsName: Array<String> = []
// setTimeout(() => {

// }, 2100);
// brandsList.forEach(element => {
//   brandsName.push(element['name'])
// });
// console.log(brandsName)
// console.log(brands.value['items'])
// console.log(brandsList)


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