import Vue from 'vue'
import Router from 'vue-router'
import Login from '@/components/Login'
import Home from '@/components/Home'
import Keeps from '@/components/Keeps'
import Vaults  from '@/components/Vaults'
import VaultKeep from '@/components/VaultKeep'


Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    } , 
    {
      path: '/login',
      name: 'Login',
      component: Login
    } , 
    {
      path: '/keeps',
      name: 'Keeps',
      component: Keeps
    } , 
    {
      path: '/vaults',
      name: 'Vaults',
      component: Vaults
    } , 
    {
      path: '/vaultkeep',
      name: 'VaultKeep',
      component: VaultKeep
    } , 
  ]
})

