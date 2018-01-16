<template>

    <div class="navbar navbar-default">
        <div>
            <div class="col-xs-8">
                <h3>Keepr.</h3>
            </div>
            <div class="col-xs-2">
                <h3 v-if="user.username">Welcome, {{user.username}}</h3>
                <h3 v-if="!user.username">Welcome, guest</h3>
            </div>

            <h3 class="col-xs-1">
                <a @click="logout">Log Out</a>
            </h3>

            <h3 class="col-xs-1">
                <a href="#login">Log In</a>
            </h3>
        </div>
    </div>

</template>


<script>
    export default {
        name: 'navbar',
        data() {
            return {}
        },
        computed: {
            user() {
                
                // debugger
                return this.$store.state.user
            },
        },
        methods: {
            // login() {
                //     debugger
                //     this.$store.dispatch('authenticate')
                // },
                logout() {
                    // debugger
                    this.$store.dispatch('logout')
                }
            },
            components: {

            },
            mounted() {
                this.$store.dispatch('authenticate')
            },
        }
        
        </script>


<style scoped>
</style>