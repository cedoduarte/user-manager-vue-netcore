<template>
    <div class="card">
        <div class="card-body">
            {{ firstName }}
        </div>
    </div>
</template>

<script setup lang="ts">
import { defineProps } from "vue";

defineProps({
    id: Number,
    firstName: String,
    lastName: String,
    country: String,
    province: String,
    city: String,
    zipCode: String,
    birthdate: String,
    phoneNumber: String,
    email: String,
    username: String,
    linkedInProfileUrl: String
});
</script>