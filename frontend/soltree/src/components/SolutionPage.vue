<template>

    <div id="solution">
        <Steps class="mySteps" :model="steps"></Steps>
        <div class="container">
            <div id="deviceTypes" class="container position-relative">
                <label for="radio-phone">
                    <input type="radio" id="radio-wearable" name="type" data-vv-as="Cihaz Türü" value="3"
                        aria-required="true" aria-invalid="false">
                    <img class="test" src="../assets/phones.png" alt="phones" width="150" height="130">
                </label>
                <label for="radio-tablet">
                    <input type="radio" id="radio-wearable" name="type" data-vv-as="Cihaz Türü" value="3"
                        aria-required="true" aria-invalid="false">
                    <img class="test" src="../assets/tablets.png" alt="tablets" width="150" height="130">
                </label>
                <label for="radio-wearable">
                    <input type="radio" id="radio-wearable" name="type" data-vv-as="Cihaz Türü" value="3"
                        aria-required="true" aria-invalid="false">
                    <img class="test" src="../assets/watch.png" alt="watch" width="150" height="130">
                </label>



            </div>
            <div id="deviceType">Cihazın türünü seçiniz</div>
            <div>{{ store.selectedBrand }}</div>

        </div>
    </div>
</template>

<script setup lang="ts">
import { ref } from 'vue';
import { useBrandStore } from '../store/brandStore';
const store = useBrandStore();

const steps = ref([
    {
        label: '',
        to: "/solution"
    },
    {
        label: '',
        to: "/seat",
    },
    {
        label: '',
        to: "/payment",
    }
]);

const formObject = ref({});

</script>


<style scoped>
#deviceType {
    margin-top: 40px;
    text-align: center;
    color: black;
    font-size: 25px;
}

#deviceTypes {
    text-align: center;
    margin-top: 100px;
}

.p-steps {
    padding-top: 30px;
}

input {
    opacity: 0;
    pointer-events: none;
}

label:hover {
    opacity: 80%;
}


img:hover {
    border: 3px solid blue;
}

::v-deep(.mySteps .p-steps-item .p-steps-number) {
    color: rgb(3, 87, 243);
    border: 1px rgb(3, 87, 243);
    border-radius: 95px;
    background-color: rgb(233, 244, 250);
    font-size: 30px;
    padding: 30px 25px 30px 25px;
}

::v-deep(.mySteps .p-steps-item::before) {
    margin: auto;
    content: " ";
    border-top: 2px solid black;
    opacity: 60%;
}

::v-deep(.mySteps) {
    margin-right: 350px;
    margin-left: 350px;
}
</style>