// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import axios from 'axios'
import store from './store'

var server = axios.create({
  baseURL: window.location.host.includes("localhost") ? '//localhost:5000/' : '/',
  timeout: 2000, 
  withCredentials: true
})

// server.post('accounts/login', { email: 't@t.com', password: 'test123' }).then(res => {
//   console.log(res)
// }).catch(er => console.log(er))

// server.get('accounts/authenticate').then(x => console.log(x))




Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  store,
  router,
  template: '<App/>',
  components: { App }
})
