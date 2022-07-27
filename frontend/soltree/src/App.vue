<template>
  <div>
    <HomePage></HomePage>
    <!-- <ul>
      <li v-for="brand in brandsList" :key="brand.name">{{brand["name"]}}</li>
    </ul>
    <Dropdown :options="brandsList" option-label="brandNames" placeholder="Select a Brand"></Dropdown> -->
  </div>



</template>
<script setup lang="ts">
import HomePage from './components/HomePage.vue';

// const ALL_BRANDS_QUERY = gql`
// query getBrands{
//     brands {
//       items{
//         name
//       }
//     }
//   }
// `;

// const { result } = useQuery(ALL_BRANDS_QUERY);

// const brands = computed(() =>  result.value?.brands ?? 'empty array')
// const brandsList: Array<any> = brands.value['items']

// watchEffect(() => {
//   console.log(brandsList)
// })
</script>


<style scoped>
ul {
  list-style-type: none;
}
</style>
