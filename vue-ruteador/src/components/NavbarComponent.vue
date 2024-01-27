<template>
    <header>
        <nav :class="{
                'navbar': true,
                'navbar-expand-lg': true,
                'navbar-dark': selectedNavbarStyle == NavbarStyle.DARK,
                'bg-dark': selectedNavbarStyle == NavbarStyle.DARK,
                'navbar-light': selectedNavbarStyle == NavbarStyle.LIGHT,
                'bg-light': selectedNavbarStyle == NavbarStyle.LIGHT
        }">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Navbar</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <RouterLink class="nav-link" to="/home">Home</RouterLink>
                        </li>
                        <li class="nav-item">
                            <RouterLink class="nav-link" to="/users">Users</RouterLink>
                        </li>                        
                        <li class="nav-item">
                            <RouterLink class="nav-link" to="/contact">Contact</RouterLink>
                        </li>
                        <li class="nav-item">
                            <RouterLink class="nav-link" to="/about">About</RouterLink>
                        </li>
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                Style
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                                <li class="dropdown-item">
                                    <button class="navbar-change-style" @click="navbarChangeStyle(NavbarStyle.LIGHT)">Light</button>
                                </li>
                                <li class="dropdown-item">
                                    <button class="navbar-change-style" @click="navbarChangeStyle(NavbarStyle.DARK)">Dark</button>
                                </li>
                            </ul>
                        </li>
                    </ul>
                    <form class="d-flex">
                        <input class="form-control me-2" 
                               type="search" 
                               placeholder="Search" 
                               aria-label="Search"
                               v-model="searchText" />
                        <button class="btn btn-outline-success" 
                                type="button" 
                                @click="searchButtonClicked">
                            Search
                        </button>
                    </form>
                </div>
            </div>
        </nav>
    </header>
</template>

<script setup lang="ts">
import { ref, onBeforeMount } from "vue";
import { RouterLink } from 'vue-router';
import { useStore } from "vuex";
import { key } from "../store";

enum NavbarStyle {
    LIGHT = "light",
    DARK = "dark"
}

const store = useStore(key);
const selectedNavbarStyle = ref<NavbarStyle>(NavbarStyle.LIGHT);
const searchText = ref<string>("");

onBeforeMount(() => {
    const storedValue: string | null = localStorage.getItem("selectedNavbarStyle");
    if (storedValue === NavbarStyle.DARK) {
        selectedNavbarStyle.value = NavbarStyle.DARK;
    } else {
        selectedNavbarStyle.value = NavbarStyle.LIGHT;
    }    
});

const navbarChangeStyle = (newStyle: NavbarStyle) => {
    selectedNavbarStyle.value = newStyle;
    localStorage.setItem("selectedNavbarStyle", selectedNavbarStyle.value);
}

const searchButtonClicked = () => {
    store.state.searchText = searchText.value;
}
</script>

<style scoped>
.navbar-change-style {
    border-style: none;
    background-color: transparent;
}
</style>