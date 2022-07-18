import { createApp } from 'vue'
import App from './App.vue'
import primevue from './plugins/primevue'
import axios from 'axios'

axios.defaults.baseURL = "https://localhost:5555"


axios.interceptors.request.use(async request => {
  request.url = request.url?.replace("http://localhost", axios.defaults.baseURL || "")

  return request;
});

const app = createApp(App);

app.use(primevue)
app.mount('#app');