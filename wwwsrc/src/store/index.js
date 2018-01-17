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
        vaults: []
    },
    mutations: {
        setUser(state, user) {
            // debugger
            state.user = user
        },
        handleError(state, err) {
            // debugger
            state.err = err
        },
        setKeeps(state, data) {
            console.log(data)
            state.keeps = data
        },
        setVaults(state, data) {
            state.vaults = data
        },
    },
    actions: {
        // AUTH
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
        // END OF AUTH

        // Gets
        createKeep({ commit, dispatch }, payload) {
            // debugger
            api.post('keeps', payload)
                .then(res => {
                    dispatch('getKeeps')
                })
        },
        getKeeps({ commit, dispatch }) {
            api('keeps')
                .then(res => {
                    // debugger
                    commit('setKeeps', res.data)
                })

        },
        createVault({ commit, dispatch }, payload) {
            // debugger
            api.post('vaults', payload)
                .then(res => {
                    dispatch('getVaults')
                })
        },
        getVaults({ commit, dispatch }) {
            api('vaults')
                .then(res => {
                    // debugger
                    commit('setVaults', res.data)
                    console.log(res)
                })


        },
    }
})


export default store

