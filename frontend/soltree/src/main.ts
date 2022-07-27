import { createApp, h, provide } from 'vue'
import App from './App.vue'
import primevue from './plugins/primevue'
import axios from 'axios'
import { ApolloClient } from 'apollo-client'
import { createHttpLink } from 'apollo-link-http'
import { InMemoryCache } from 'apollo-cache-inmemory'
import { DefaultApolloClient} from '@vue/apollo-composable'
import { createPinia } from 'pinia'
// axios.defaults.baseURL = "https://localhost:5555"


// axios.interceptors.request.use(async request => {
//   request.url = request.url?.replace("http://localhost", axios.defaults.baseURL || "")

//   return request;
// });

const httpLink = createHttpLink({

  uri: 'https://localhost:62509/graphql',
})

const cache = new InMemoryCache()

const apolloClient = new ApolloClient({
  link: httpLink,
  cache,
})

const app = createApp({
  setup(){
    provide(DefaultApolloClient, apolloClient)
  },

  render: () => h(App)
})

const pinia = createPinia()

app.use(primevue)
app.use(pinia)

app.mount('#app');