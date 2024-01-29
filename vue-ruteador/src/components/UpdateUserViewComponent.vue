<template>
    <h1>Update user with ID {{ userId }}</h1>
</template>

<script setup lang="ts">
import { ref, onMounted } from "vue";
import { useRoute } from "vue-router";

const userId = ref<string | string[]>("");

const route = useRoute();

onMounted(() => {
    userId.value = route.params.userId;
});

</script>