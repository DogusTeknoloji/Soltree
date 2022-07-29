import { createApp } from 'vue'
import App from './App.vue'
import primevue from './plugins/primevue'
import { createPinia } from 'pinia'
import urql from '@urql/vue';

const app = createApp(App);

const pinia = createPinia()

app.use(primevue)
app.use(pinia)

app.use(urql, {
  url: 'https://localhost:6001/graphql',
});

app.mount('#app');