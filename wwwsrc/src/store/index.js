import axios from 'axios'
import vue from 'vue'
import vuex from 'vuex'
import router from '../router'
import debug from 'util'


let api = axios.create({
    baseURL: 'http://localhost:5000/api/',
    timeout: 2000,
    withCredentials: true
})

let auth = axios.create({
    baseURL: 'http://localhost:5000/',
    timeout: 2000,
    withCredentials: true
})

vue.use(vuex)
vue.use(router)


var store = new vuex.Store({
    state: {
        user: {},
        keeps: [],
    },
    mutations: {
        setUser(state, user) {
            // debugger
            state.user = user
        },
        handleError(state, err) {
            // debugger
            state.err = err
        }
    },
    actions: {
        register({ commit, dispatch }, payload) {
            // debugger
            auth.post('accounts/register', payload)
                .then(res => {
                    commit('setUser', res.data)
                    router.push({ name: 'Home' })
                    console.log('User account successfully created')
                })
                .catch(err => {
                    commit('handleError', err)
                })

        },
        login({ commit, dispatch }, payload) {
            // debugger
            auth.post('accounts/login', payload)
                .then(res => {
                    commit('setUser', res.data)
                    router.push({ name: 'Home' })
                    console.log(res)
                })

                .catch(err => {
                    commit('handleError', err)
                })
        },
        authenticate({ commit, dispatch }) {
            auth.get('accounts/authenticate')
                .then(res => {
                    // debugger
                    commit('setUser', res.data)
                    router.push({ name: 'Home' })
                    console.log(res.data.data)



                })
                .catch(err => {

                    commit('handleError', err)
                    router.push({ name: 'Login' })
                })

        },
        logout({ commit, dispatch }) {
            auth.delete('accounts/logout')
                .then(res => {
                    commit('setUser', {})
                    router.push({ name: 'Home' })
                    console.log('User session terminated')
                })
                .catch(err => {
                    commit('handleError', err)
                })

        },

    }
})

export default store