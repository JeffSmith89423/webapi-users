<template>
    <div class="login">
        <div class="row text-center">
            <div class="col-xs-12">
                <h1 v-if="loginForm">Login to Keepr.</h1>
                <h1 v-else>Please register to log in to Keepr.</h1>
            </div>
        </div>
        <!-- Add error message if login fails -->
        <!-- <h5 class="text-danger" v-if="error">
            <b>error</b>
        </h5> -->

        <div v-if="loginForm" class="login col-sm-4 col-sm-offset-4">
            <form class="form" @submit.prevent="submitLogin">
                <div class="form-group">
                    <label for="email">Email</label>
                    <input class="form-control" type="email" name="email" placeholder="User@email.com" v-model='login.email' required>
                </div>
                <div class="form-group">
                    <label for="password">Password</label>
                    <input class="form-control" type="password" placeholder="********" name="password" v-model='login.password' required>
                </div>
                <div class="form-group">
                    <button type="submit" class="btn btn-default">Login</button>
                </div>
            </form>
        </div>

        <!-- Register Form -->
        <div v-else class="register col-sm-4 col-sm-offset-4">
            <form class="form" @submit.prevent="submitRegister">
                <div class="form-group">
                    <label for="name">Name</label>
                    <input class="form-control" type="text" name="name" placeholder="User" v-model='register.username' required>
                </div>
                <div class="form-group">
                    <label for="email">Email</label>
                    <input class="form-control" type="email" name="email" placeholder="user@email.com" v-model='register.email' required>
                </div>
                <div class="form-group">
                    <label for="password">Password</label>
                    <input class="form-control" type="password" name="password" placeholder="********" v-model='register.password' required>
                </div>
                <div class="form-group">
                    <button type="submit" class="btn btn-default">Register</button>
                </div>
            </form>
        </div>
        <div class="panel panel-default col-sm-2 col-sm-offset-5 text-center">
            <p v-if="loginForm" @click="toggleLoginForm" class="action"><strong>Don't have an account?</strong>
                <a>
                    <strong>Sign up!</strong>
                </a>
            </p>
            <p v-else @click="toggleLoginForm" class="action"><strong>Already a user?</strong>
                <a>
                    <b>Click here to login</b>
                </a>
            </p>
        </div>
    </div>
</template>

<script>
    export default {

        data() {
            return {
                loginForm: true,
                login: {
                    email: '',
                    password: ''
                },
                register: {
                    username: '',
                    email: '',
                    password: ''
                }

            }
        },
        methods: {
            toggleLoginForm() {
                this.loginForm = !this.loginForm
            },
            submitLogin() {
                this.$store.dispatch('login', this.login)
                this.login = {
                    email: '',
                    password: ''
                }
            },
            submitRegister() {
                // debugger
                this.$store.dispatch('register', this.register)

            }
        },
        computed: {
            // error() {
            //     return this.$store.state.error
            // }
        }
    }

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    h1,
    h2 {
        font-weight: normal;
    }

    ul {
        list-style-type: none;
        padding: 0;
    }

    li {
        display: inline-block;
        margin: 0 10px;
    }

    a {
        color:rgb(51, 122, 183);
    }
    .panel{
        background-color:rgba(240, 248, 255, 0.63);
    }
</style>