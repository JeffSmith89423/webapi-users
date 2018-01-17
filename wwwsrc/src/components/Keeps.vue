<template>
    <div class="keeps">
        <!-- BEGIN ADD A KEEP -->
        <div class="row text-center">
            <div class="card col-lg-2 glyphicon glyphicon-plus" data-toggle="modal" data-target="#myModal">
                <div class="row glyphicon-glyphicon-plus"></div>
                <div class="row">
                    <h1>Add a Keep</h1>
                </div>
            </div>
        </div>
        <!-- END ADD A KEEP -->

        <!-- BEGIN KEEP -->
        <div class="card col-lg-2" v-for="keep in keeps">
            <div  class="thumbnail" v-if="keep.imageurl == keep.imageurl">
                <img :src="keep.imageurl" >
            </div>
            <div  class="thumbnail" v-else="">
                    
                </div>
            <div style="display: inline-flex">
                <h4>K: {{keep.saves}} |</h4>
                <h4>| V: {{keep.viewed}} |</h4>
                <h4>| S: {{keep.shares}}</h4>
            </div>
            <div class="row">
                <h3>{{keep.name}}</h3>
                <h5>{{keep.description}}</h5>
            </div>

            <div>
                <button class="btn btn-warning">add to vault</button>
                <button class="btn btn-danger">view</button>
                <button class="btn btn-success">share</button>
            </div>
        </div>
        <!-- END KEEP -->

        <!-- Modal -->
        <div id="myModal" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h1 class="modal-title text-center">
                            <strong>Add a Keep</strong>
                        </h1>
                    </div>
                    <div class="modal-body">
                        <form class="form" @submit.prevent="createKeep">
                            <div class="form-group">
                                <label for="Title">Keep Name:</label>
                                <input type="text" class="form-control" name="name" placeholder="Title" v-model="keep.name">
                            </div>
                            <div class="form-group">
                                <label for="Description">Description:</label>
                                <input type="text" class="form-control" id="Description" v-model="keep.description">
                            </div>
                            <div class="form-group">
                                <label for="Image Url">Image Url:</label>
                                <input type="text" class="form-control" id="Image" v-model="keep.imageurl" v>
                            </div>

                            <div class="checkbox">
                                <label>
                                    <input type="checkbox"> Keep Private?</label>
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
        name: 'keeps',
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
        computed:
            {
                user() {
                    return this.$store.state.user
                },
                keeps(){
                    return this.$store.state.keeps
                }
            },
        methods: {
            createKeep() {
                var myKeep = {
                    name: this.keep.name,
                    imageurl: this.keep.imageurl,
                    description: this.keep.description,
                    userId: this.user.id
                }
                this.$store.dispatch('createKeep', myKeep)
            }
        },
        components: {},
        mounted(){
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



    /* .button:hover {
        display: none;
        width: 100px;
        height: 100px;
    }

    .button {
        display: block;
        width: 100px;
        height: 100px;
    } */
</style>