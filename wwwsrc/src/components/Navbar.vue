<template>

    <div class="navbar navbar-inverse">
        <div>
            <div class="col-xs-8">
               <a href="#"><h3>Keepr.</h3></a>
            </div>
            <div class="col-xs-3 push-right">
                <h3 v-if="user.username">Welcome, {{user.username}}</h3>
                <h3 v-if="!user.username">Welcome, guest</h3>
            </div>

            <h3 v-if="user.username" class="col-xs-1 push-right">
                <a @click="logout">Log Out</a>
            </h3>

            <h3 v-else="!user.username" class="col-xs-1 push-right">
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
            },
            login() {
                // debugger
                this.$store.dispatch('')
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
.push-right{
    text-align: right;
}
.navbar{
    color: silver;
}
</style>