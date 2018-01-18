<template>
    <div class="vaultkeep">
        <!-- BEGIN KEEPS -->
        <div v-for="keep in keeps">
            <div class="card col-lg-2 " v-if="user.id == keep.userId">
                <div class="thumbnail" v-if="keep.imageurl === null">
                    <img src="https://images.unsplash.com/reserve/wrev1ljvQ6KlfyljCQG0_lion.jpg?auto=format&fit=crop&w=1355&q=80">
                </div>
                <div class="thumbnail" v-else="">
                    <img :src="keep.imageurl">
                </div>
                <div style="display: inline-flex" class="text-center">
                    <h4>K: {{keep.saves}} |</h4>
                    <h4>| V: {{keep.viewed}} |</h4>
                    <h4>| S: {{keep.shares}}</h4>
                </div>
                <div class="row text-center">
                    <h3>{{keep.name}}</h3>
                    <h5>{{keep.description}}</h5>
                </div>

                <div class="text-center">
                    <button class="btn btn-warning" data-toggle="modal" data-target="#myModal1">Save</button>
                    <button class="btn btn-primary" @click="">View</button>
                    <button class="btn btn-success" @click="">Share</button>
                </div>
            </div>
        </div>
        <!-- END KEEPS -->
    </div>
</template>


<script>
    export default {
        name: 'vaultkeep',
        data() {
            return {}
        },
        computed: {
            user() {
                return this.$store.state.user
            },
            keeps() {
                return this.$store.state.keeps
            },
            vaults(){
                return this.$store.state.vaults
            }
        },
        methods: {},
        components: {},
        mounted() {
            this.$store.dispatch("getKeeps")

        },
    }
</script>


<style scoped>
    .card {
        padding: 15px;
        margin: 25px;
        height: 400px;
        background-color: rgba(190, 190, 190, 0.884);
        box-shadow: 5px 5px rgb(138, 138, 138);
        border-radius: 6%
    }

    .card:hover {
        cursor: pointer;
        background-color: rgba(255, 255, 255, 0.651);
        box-shadow: 5px 5px rgb(44, 44, 44);
    }

    .glyphicon {
        font-size: 8rem;
        padding-top: 125px;
    }

    .text-center {
        /* text-align: center; */
        margin: 0 auto;
    }
</style>