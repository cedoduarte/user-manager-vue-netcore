import { ref } from "vue";
import { defineStore } from "pinia";

export const useSearchStore = defineStore("searchText", () => {
    const searchText = ref<string>("");

    const setSearchText = (text: string) => {
        searchText.value = text;
    }

    const getSearchText = (): string => {
        return searchText.value
    }
    
    return {
        searchText,
        setSearchText,
        getSearchText
    }
});