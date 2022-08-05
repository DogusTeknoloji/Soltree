import Vue from 'vue'
import PrimeVue from 'primevue/config';
import Button from 'primevue/button';
import InputText from 'primevue/inputtext';
import Dropdown from 'primevue/dropdown';
import Menubar from 'primevue/menubar';
import Toast from 'primevue/toast';
import Steps from 'primevue/steps';
import Card from 'primevue/card';
import SelectButton from 'primevue/selectbutton';

import 'primevue/resources/themes/bootstrap4-light-blue/theme.css';
import 'primevue/resources/primevue.min.css';
import 'primeicons/primeicons.css';
import 'primeflex/primeflex.scss';

export default {
    install: (app: Vue.App<Element>, options: any[]) => {
        app.use(PrimeVue)
        app.component('Button', Button)
        app.component('InputText', InputText)
        app.component('Dropdown', Dropdown)
        app.component('Menubar', Menubar)
        app.component('Toast', Toast)
        app.component('Steps', Steps)
        app.component('Card', Card)
        app.component('SelectButton', SelectButton)
    }
}