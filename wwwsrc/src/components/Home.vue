<template>
    <div class="Home">
        <div class="row search-bar">
            <br></br>
            <div class="text-center">
                <button class="btn btn-default">Add a Keep</button>
                <button class="btn btn-default">Add a vault</button>
            </div>
            <br></br>
            <!-- <form @submit.prevent="getKeeps()" class="text-center">
                <input class="search" type="text" placeholder="Search for Keeps"> -->
            <!-- <input class="search" type="text" v-model="keep" placeholder="Search for Keeps"> -->
            <!-- <button type="submit" class="submit btn-sm btn-default">
                    <span class="glyphicon glyphicon-search"></span> Search</button>
            </form> -->
            
                <div class="col-sm-4 col-sm-offset-4">
                    <div class="input-group text">
                        <input type="text" class="form-control " placeholder="Search for Keeps">
                        <span class="input-group-btn">
                            <button class="btn btn-default" type="submit">Search</button>
                        </span>
                    </div>
                </div>
           


        </div>
        <keeps></keeps>
    </div>
</template>


<script>
    import keeps from './keeps'
    export default {
        name: 'home',
        data() {
            return {}
        },
        computed: {},
        methods: {},
        components: {
            keeps,
        }
    }
</script>


<style scoped>
    .text-center {
        /* text-align: center; */
        margin: 0 auto;
    }
</style>