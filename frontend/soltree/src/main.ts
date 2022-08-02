import { createApp } from 'vue/dist/vue.esm-bundler.js';
import App from './App.vue'
import primevue from './plugins/primevue'
import { createPinia } from 'pinia'
import urql from '@urql/vue';
import {createRouter, createWebHashHistory}  from 'vue-router'
import HomePage from './components/HomePage.vue'
import SolutionPage from './components/SolutionPage.vue';
import {useBrandStore} from '../src/store/brandStore';
import ToastService from 'primevue/toastservice';



const Home = { template: '<HomePage></HomePage>' }
const Solution = { template: '<SolutionPage></SolutionPage>' }

const routes = [
  { path: '/', component: Home },
  { path: '/solution',
    component: Solution,
    beforeEnter: (to: any, from: any) => {
      if(store.selectedBrand){
        return true
      }
      else{
        return false;
      }
      
      }
    },
]

const router = createRouter({
  
  history: createWebHashHistory(),
  routes, 
})

const app = createApp(App);
app.use(ToastService)
const pinia = createPinia()


app.component('HomePage', HomePage)
app.component('SolutionPage', SolutionPage)
app.use(primevue)
app.use(pinia)
app.use(router)


const store = useBrandStore();

app.use(urql, {
  url: 'https://localhost:6001/graphql',
});

app.mount('#app');

