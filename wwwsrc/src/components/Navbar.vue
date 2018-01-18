<template>

    <div class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="col-xs-9 breadcrumbs">

                <router-link to="/">
                    <img class="brand navbar-brand push-left" src="../assets/image.png" srcset="">
                </router-link>


                <ul class="nav navbar-nav">
                    <li class="brand" v-if="user.username">
                        <router-link to="/keeps">
                            <a  >
                                <strong class="active brand">My Keeps</strong>
                            </a>
                        </router-link>
                    </li>
                    <li class="brand" v-if="user.username"la>
                        <router-link to="/vaults">
                            <a  >
                                <strong class="active brand">My Vaults</strong>
                            </a>
                        </router-link>
                    </li>
                </ul>
            </div>
            <div class="col-xs-2">
                <p class="navbar-text " v-if="user.username">
                    <strong>Welcome, {{user.username}}</strong>
                </p>
                <p class="navbar-text " v-if="!user.username">
                    <strong>Welcome, Guest</strong>
                </p>
            </div>
            <div class="push-right col-xs-1">
                <button v-if="user.username" class="btn btn-default navbar-btn ">
                    <a @click="logout">
                        <strong>Log Out</strong>
                    </a>
                </button>

                <button v-else="!user.username" class="btn btn-default navbar-btn">
                    <router-link to="/login">
                        <strong>Log in</strong>
                    </router-link>
                </button>
            </div>
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
                this.$store.dispatch('login')
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
    .push-right {
        text-align: right;
    }

    .push-left {
        text-align: left;
    }

    .navbar {
        color: silver;
    }

    .brand:hover {
        background-color: darkgray;
    }
</style>