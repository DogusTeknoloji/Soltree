import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router'

export enum Route {
  Home = "home",
  Solution = "solution",
}

const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    name: Route.Home,
    component: () => import('@/views/Home.vue'),
    children: [
      {
        path: 'select-brand',
        name: "select-brand",
        component: () => import('@/components/SelectBrand.vue')
      },
    ]
  },
  {
    path: '/solution',
    name: Route.Solution,
    component: () => import('@/views/Solution.vue')
  },
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes
})

export default router