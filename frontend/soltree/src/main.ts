import { createApp } from 'vue'
import App from './App.vue'
import primevue from './plugins/primevue'

const app = createApp(App);

app.use(primevue)
app.mount('#app');