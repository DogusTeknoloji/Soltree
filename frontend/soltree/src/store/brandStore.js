import { defineStore } from "pinia";

export const useBrandStore = defineStore("brandStore", {
  state: () => {
    return {
      selectedBrand: null,
      selectedModel: null,
      toast: false,
    };
  },
});
