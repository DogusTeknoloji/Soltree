import { defineStore } from "pinia";

export const useBrandStore = defineStore("brandStore", {
  state: () => {
    return {
      selectedBrand: null as String | undefined | null,
      selectedModel: null,
      toast: false,
    };
  },
});
