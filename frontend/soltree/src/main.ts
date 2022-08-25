import { createApp } from 'vue';
import App from './App.vue'
import primevue from './plugins/primevue'
import { createPinia } from 'pinia'
import urql from '@urql/vue';
import router from './router'
import './assets/main.scss'
import ToastService from 'primevue/toastservice';

const app = createApp(App);

app.use(primevue)
app.use(createPinia())
app.use(router)
app.use(ToastService)

app.use(urql, {
  url: 'https://localhost:6001/graphql',
  requestPolicy: 'network-only'
});

app.mount('#app');

