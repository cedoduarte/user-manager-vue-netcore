<template>
    <div class="card">
        <div class="card-body">
            <span>ID: {{ id }}</span>
            <br />
            <span>Full name: {{ firstName }} {{ lastName }}</span>            
            <br />
            <span>Location: {{ country }}, {{ province }}, {{ city }}</span>
            <br />
            <span>Zip code: {{ zipCode }}</span>
            <br />
            <span>Birthdate: {{ birthdate }}</span>
            <br />
            <span>Phone number: {{ phoneNumber }}</span>
            <br />
            <span>Email: {{ email }}</span>
            <br />
            <span>Username: <strong>{{ username }}</strong></span>
            <br />
            <a :href="linkedInProfileUrl" target="_blank" rel="noopener noreferrer">LinkedIn profile</a>
            <div class="user-card-view-buttons">
                <button class="btn btn-warning" @click="goToEdit">Edit</button>
                <button class="btn btn-danger" @click="openDialog">Delete</button>
                <DialogModalComponent 
                    v-if="dialogVisible" 
                    @dialogAccepted="deletionAccepted" 
                    @dialogRejected="deletionRejected"
                >
                    <h1>User deletion</h1>
                    <p>Do you want to delete the user <strong>{{ username }}</strong> with email: <strong>{{ email }}?</strong></p>
                </DialogModalComponent>
            </div>
        </div>
    </div>
</template>

<script setup lang="ts">
import { ref, defineProps } from "vue";
import { useRouter } from "vue-router";
import DialogModalComponent from "./DialogModalComponent.vue";
import { USER_DELETE_URL } from "../shared/Constants";
import { useToast } from "vue-toastification";

const props = defineProps({
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

const toast = useToast();
const router = useRouter();
const dialogVisible = ref<boolean>(false);

const goToEdit = () => {
    router.push(`/update/${props.id}`);
}

const openDialog = () => {
    dialogVisible.value = true;
}

const fetchDeletionUser = async (userId: number | undefined) => {
    try {
        const response = await fetch(`${USER_DELETE_URL}/${userId}`, {
            method: "DELETE",
            headers: {
                "Content-Type": "application/json"
            }
        });
        if (response.ok) {
            dialogVisible.value = false;
            toast.info("User deleted successfully!");
        } else {
            toast.error(`Error: ${response.statusText}`);
        }
    } catch (error: any) {
        toast.error(`Error: ${error.message}`);
    }    
}

const deletionAccepted = async () => {
    fetchDeletionUser(props.id);   
}

const deletionRejected = () => {
    dialogVisible.value = false;
}
</script>

<style scoped>
.user-card-view-buttons {
    text-align: right;
}

.user-card-view-buttons button {
    margin: 5px;
    width: 80px;
    height: 40px;
    display: inline-block;
}
</style>