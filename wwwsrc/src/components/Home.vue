<template>
    <div class="Home">
            <div class="row search-bar">
                    <form @submit.prevent="getKeeps()" class="text-center">
                        <input class="search" type="text" v-model="keep" placeholder="Search for Keeps">
                        <button type="submit" class="submit btn btn-default"><span class="glyphicon glyphicon-search"></span> Search</button>
                    </form>
                </div>
        <keeps></keeps>
    </div>
</template>


<script>
import keeps from './keeps'
export default {
    name: 'home',
    data(){
        return {}
    },
    computed:{},
    methods:{},
    components:{
        keeps,
    }
}
</script>


<style scoped>

</style>