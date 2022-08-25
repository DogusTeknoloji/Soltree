<template>
  <Toast />
        <Toast position="top-left" group="tl">
            <template #message="slotProps">
                <div class="flex flex-column">
                    <div class="text-center">
                        <i class="pi pi-exclamation-triangle" style="font-size: 3rem"></i>
                        <h4>{{slotProps.message.summary}}</h4>
                        <p>{{slotProps.message.detail}}</p>
                    </div>
                    <div class="grid p-fluid">
                        <div class="col-6">
                            <Button class="p-button-success" label="Yes" @click="nextPage"></Button>
                        </div>
                    </div>
                </div>
            </template>
        </Toast>


  <Card style="width: 100%" class="fadein animation-duration-300">
    <template #content>
      <div class="text-center">
        <h3>Hata çözümleme işlemine hoşgeldiniz</h3>
        <h3>Aşağıdan cihaz markanızı seçiniz</h3>
        <Dropdown v-model="selectedBrand" :options="brands" option-label="name" option-value="id"
          placeholder="Marka Seçiniz" :filter="true" aria-required="true" class="text-left"></Dropdown>
      </div>
    </template>
    <template #footer>
      <div class="text-center">
        <Button label="Devam" icon="pi pi-angle-right" iconPos="right" @click="nextPage()"></Button>
      </div>
    </template>
  </Card>
</template>

<script setup lang="ts">
import { computed, onActivated, ref } from 'vue';
import { useGetBrandsQuery } from '../graphql'
import { useBrandStore } from '../store/brandStore';
import { useWizardStore } from '../store/wizardStore';
import { useToast } from 'primevue/usetoast'

const wizardStore = useWizardStore();

const brandStore = useBrandStore();



const getBrandsQueryResult = useGetBrandsQuery();
const brands = computed(() => getBrandsQueryResult.data.value?.brands?.items ?? []);
const selectedBrand = ref<string | null>();

const toast = useToast();


onActivated(() => {
  getBrandsQueryResult.executeQuery();
  selectedBrand.value = null
})


const nextPage = () => {
  brandStore.selectedBrand = selectedBrand.value;
  if (brandStore.selectedBrand != null) {
    wizardStore.next();
  }
  else {
    toast.add({severity:'error', summary: 'Hata Mesajı', detail:'Markanızı seçmeden bir sonraki adıma devam edemezsiniz.', life: 3000});
  }
};
</script>