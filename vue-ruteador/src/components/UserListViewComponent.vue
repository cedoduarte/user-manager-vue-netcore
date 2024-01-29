<template>
    <h1 class="user-list-view-title">Users</h1>
    <div class="user-list-view-container">
        <ul>
            <li v-for="userItem in userList" :key="userItem.id">
                <UserCardViewComponent 
                    :id="userItem.id"
                    :firstName="userItem.firstName"
                    :lastName="userItem.lastName"
                    :country="userItem.country"
                    :province="userItem.province"
                    :city="userItem.city"
                    :zipCode="userItem.zipCode"
                    :birthdate="userItem.birthdate"
                    :phoneNumber="userItem.phoneNumber"
                    :email="userItem.email"
                    :username="userItem.username"
                    :linkedInProfileUrl="userItem.linkedInProfileUrl" />
            </li>
        </ul>
    </div>
</template>

<script setup lang="ts">
import UserCardViewComponent from "./UserCardViewComponent.vue";
import { USER_USER_LIST_URL } from "../shared/Constants";
import { ref, watch, onBeforeMount, onMounted, onBeforeUpdate, onUpdated, onBeforeUnmount, onUnmounted } from "vue";
import { useToast } from "vue-toastification";
import { useSearchStore } from "../store/store";
import { User } from "../models/User";

const searchStore = useSearchStore();
const toast = useToast();
const userList = ref<User[]>([]);

watch(() => searchStore.searchText, async (newValue: string, oldValue: string) => {
    try {
        const response = await fetch(`${USER_USER_LIST_URL}?getAll=false&keyword=${newValue}`);
        if (!response.ok) {
            throw new Error(response.statusText);
        }
        const content = await response.json();
        userList.value = content;
    } catch (error: any) {
        toast.error(`Error searching user: ${error.message}`);
    }
});

console.log("created");

onBeforeMount(() => {
    console.log("onBeforeMount");
});

onMounted(async () => {
    console.log("onMounted");
});

onBeforeUpdate(() => {
    console.log("onBeforeUpdate");
});

onUpdated(() => {
    console.log("onUpdated");
});

onBeforeUnmount(() => {
    console.log("onBeforeUnmount");
});

onUnmounted(() => {
    console.log("onUnmounted");
});
</script>

<style scoped>
.user-list-view-title {
    margin: 5px;
}

.user-list-view-container {
    width: auto;
    height: 80vh;
    overflow-y: auto; /* Enable vertical scrolling */
}

.user-list-view-container ul {
    list-style-type: none;
}

.user-list-view-container li {
    margin: 2px;
}
</style>