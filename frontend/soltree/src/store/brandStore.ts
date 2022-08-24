import { defineStore } from "pinia";

export const useBrandStore = defineStore("brandStore", {
  state: () => {
    return {
      selectedBrand: null as string | undefined | null,
      selectedModel: null as string | undefined | null,
      selectedDeviceType: null as string | undefined | null,
      selectedSymptom: null as string | undefined | null,
      isSolved: null as boolean | undefined | null
    };
  },
});
