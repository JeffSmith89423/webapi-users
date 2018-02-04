<template>
    <div class="home">
        <div v-for="keep in keeps">
            <div class="card col-lg-2">
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
                    <h5>{{keep.userId}}</h5>
                    
                </div>

                <div class="text-center" v-if="user.username">
                    <button class="btn btn-warning" data-toggle="modal" data-target="#myModal1">Save</button>
                    <button class="btn btn-primary" @click="">View</button>
                    <!-- <button class="btn btn-success" @click="">Share</button> -->
                </div>
                <div class="text-center" v-else="!user.username">
                    <!-- <button class="btn btn-warning" data-toggle="modal" data-target="#myModal1">Save</button> -->
                    <button class="btn btn-primary" @click="">View</button>
                    <!-- <button class="btn btn-success" @click="">Share</button> -->
                </div>
            </div>
        </div>
        <div id="myModal1" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h1 class="modal-title text-center">
                            <strong>Choose a Vault</strong>
                        </h1>
                    </div>
                    <div>
                        <div  v-for="vault in vaults">
                            <ul >

                                <li v-if="user.id == vault.userId">
                                    <button class="btn btn-default" @click>{{vault.name}}</button>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
    </div>
</template>


<script>
    import keeps from './Keeps'
    import vaults from './Vaults'
    export default {
        name: 'home',
        data() {
            return {
                keep: {
                    name: '',
                    description: '',
                    imageurl: '',
                    saves: '',
                    viewed: '',

                }
            }
        },
        computed: {
            user() {
                return this.$store.state.user
            },
            keeps() {
                return this.$store.state.keeps
            },
            vaults() {
                return this.$store.state.vaults
            }
        },
        methods: {},
        components: {
            keeps,
            vaults
        },
        mounted() {
            this.$store.dispatch("getKeeps")
            this.$store.dispatch("getVaults")
        },
    }
</script>


<style scoped>
    .text-center {
        /* text-align: center; */
        margin: 0 auto;
    }

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
</style>