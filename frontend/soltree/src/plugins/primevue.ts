
import Vue from 'vue'
import PrimeVue from 'primevue/config';
import Button from 'primevue/button';
import InputText from 'primevue/inputtext';

import 'primevue/resources/themes/bootstrap4-light-blue/theme.css';
import 'primevue/resources/primevue.min.css';
import 'primeicons/primeicons.css';

export default {
    install: (app: Vue.App<Element>, options: any[]) => {
        app.use(PrimeVue)
        app.component('Button', Button)
        app.component('InputText', InputText)
    }
}