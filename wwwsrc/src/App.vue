<template>
  <div id="app" class="container-fluid">
    <navbar></navbar>
    <router-view></router-view>
  </div>
</template>

<script>
  import Navbar from './components/navbar'
  export default {
    
    name: 'app',
    components: {
      // Login,
      Navbar,
    },
    mounted() {
            this.$store.dispatch('authenticate')
        }
  }
</script>

<style>
  body{
    background-image: url("./assets/background.jpg");
    height: 100vh;
    /* background-size: cover; */
    /* background-repeat: no-repeat; */
    /* background-position: center center; */
    /* background-attachment: fixed; */
  }
    
    
  
</style>