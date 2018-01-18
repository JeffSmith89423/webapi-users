<template>
    <div class="vaults">
        <!-- BEGIN ADD A VAULT -->
        <div class="row text-center">
            <div class="card col-lg-2 glyphicon glyphicon-plus" data-toggle="modal" data-target="#myModal">
                <div class="row glyphicon-glyphicon-plus"></div>
                <div class="row">
                    <h1>Add a Vault</h1>
                </div>
            </div>
        </div>
        <!-- END ADD A VAULT -->

        <!-- BEGIN VAULTS -->
        <div v-for="vault in vaults">
            <router-link to="/vaultkeep">
                <div class="card col-lg-2 " v-if="user.id == vault.userId">
                    <div class="row text-center">
                        <h3>{{vault.name}}</h3>
                        <h5>{{vault.description}}</h5>
                        <button class="btn btn-danger" @click="deleteVault">DELETE</button>
                    </div>
                </div>
            </router-link>


        </div>
        <!-- END VAULTS -->

        <!-- Modal -->
        <div id="myModal" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h1 class="modal-title text-center">
                            <strong>Add a Vault</strong>
                        </h1>
                    </div>
                    <div class="modal-body">
                        <form class="form" @submit.prevent="createVault">
                            <div class="form-group">
                                <label for="Title">Vault Name:</label>
                                <input type="text" class="form-control" id="Name" v-model="vault.name">
                            </div>
                            <div class="form-group">
                                <label for="Description">Description:</label>
                                <input type="text" class="form-control" id="Description" v-model="vault.description">
                            </div>

                            <button type="submit" class="btn btn-default">Submit</button>
                        </form>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
        <!-- MODAL END -->
    </div>
</template>


<script>
    export default {
        name: 'vaults',
        data() {
            return {
                vault: {
                    name: '',
                    description: '',
                }
            }
        },
        computed: {
            user() {
                return this.$store.state.user
            },
            vaults() {
                return this.$store.state.vaults
            }
        },
        methods: {
            createVault() {
                var myVault = {
                    name: this.vault.name,
                    description: this.vault.description,
                    userId: this.user.id
                }
                this.$store.dispatch('createVault', myVault)
            },
            deleteVault() {
                this.$store.dispatch('deleteVault')
            }
        },
        components: {},
        mounted() {
            this.$store.dispatch("getVaults")
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