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

        <div v-if="loginForm" class="login">
            <form class="form" @submit.prevent="submitLogin">
                <div class="form-group">
                    <label for="email">Email</label>
                    <input class="form-control" type="email" name="email" placeholder="bob@bob.com" v-model='login.email' required>
                </div>
                <div class="form-group">
                    <label for="password">Password</label>
                    <input class="form-control" type="password" placeholder="********" name="password" v-model='login.password' required>
                </div>
                <div class="form-group">
                    <button type="submit">Login</button>
                </div>
            </form>
        </div>
        <!-- Register Form -->
        <div v-else class="register">
            <form class="form" @submit.prevent="submitRegister">
                <div class="form-group">
                    <label for="name">Name</label>
                    <input class="form-control" type="text" name="name" placeholder="Bob" v-model='register.username' required>
                </div>
                <div class="form-group">
                    <label for="email">Email</label>
                    <input class="form-control" type="email" name="email" placeholder="bob@email.com" v-model='register.email' required>
                </div>
                <div class="form-group">
                    <label for="password">Password</label>
                    <input class="form-control" type="password" name="password" placeholder="********" v-model='register.password' required>
                </div>
                <div class="form-group">
                    <button type="submit">Register</button>
                </div>
            </form>
        </div>
        <p v-if="loginForm" @click="toggleLoginForm" class="action">Don't have an account?
            <a><strong>Sign up!</strong></a>
        </p>
        <p v-else @click="toggleLoginForm" class="action">Already a user?
            <a><b>Click here to login</b></a>
        </p>
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
        color: #42b983;
    }
</style>