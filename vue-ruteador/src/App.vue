<template>
  <header>
    <NavbarComponent />
  </header>
  <RouterView />
</template>

<script setup lang="ts">
import { RouterView } from 'vue-router';
import NavbarComponent from './components/NavbarComponent.vue';
</script>