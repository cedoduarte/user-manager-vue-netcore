<template>
    <div class="dialog-modal-popup">
        <div class="dialog-modal-popup-inner">
            <slot />
            <button class="dialog-modal-button btn btn-primary" @click="dialogAccepted">Yes</button>
            <button class="dialog-modal-button btn btn-danger" @click="dialogRejected">No</button>
        </div>
    </div>
</template>

<script setup lang="ts">
import { defineEmits } from 'vue';

const emit = defineEmits(["dialogRejected", "dialogAccepted"]);

const dialogRejected = () => {
    emit("dialogRejected");
}

const dialogAccepted = () => {
    emit("dialogAccepted");
}
</script>

<style scoped>
.dialog-modal-popup {
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    z-index: 99;
    background-color: rgba(0,0,0,0.2);
    display: flex;
    align-items: center;
    justify-content: center;
}

.dialog-modal-popup-inner {
    background: #fff;
    padding: 32px;
}

.dialog-modal-button {
    margin: 2px;
}
</style>