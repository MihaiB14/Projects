import { createRouter, createWebHashHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import IT from '../views/IT.vue'
import HR from '../views/HR.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/IT',
    name: 'IT',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: IT
  },
  {
    path: '/HR',
    name: 'HR',
    component: HR
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
