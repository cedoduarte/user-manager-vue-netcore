import { createApp } from 'vue'
import App from './App.vue'
import { createRouter, createWebHistory } from 'vue-router'
import 'vue-toastification/dist/index.css'
import Toast from 'vue-toastification'
import { createPinia } from 'pinia'

const router = createRouter({
    history: createWebHistory(),
    routes: [
        { name: "home", path: "/home", component: () => import("./components/HomeComponent.vue") }, 
        { name: "users", path: "/users", component: () => import("./components/UserListViewComponent.vue") },
        { name: "contact", path: "/contact", component: () => import("./components/ContactComponent.vue") },
        { name: "about", path: "/about", component: () => import("./components/AboutComponent.vue") },
        { name: "update", path: "/update/:userId", component: () => import("./components/UpdateUserViewComponent.vue") }
    ]
});

const app = createApp(App);
app.use(router);
app.use(Toast);
app.use(createPinia());
app.mount('#app');