import { defineStore } from "pinia";

export const useWizardStore = defineStore("wizardStore", {
  state: () => {
    return {
      index: 0
    };
  },
  actions: {
    next() {
      this.index++
    },
    prev() {
      this.index--
    },
  }
});
