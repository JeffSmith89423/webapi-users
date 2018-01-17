<template>
    <div class="vaults">
        <div class="row text-center">
            <div class="card col-lg-2 glyphicon glyphicon-plus" data-toggle="modal" data-target="#myModal">
                <div class="row glyphicon-glyphicon-plus"></div>
                <div class="row">
                    <h1>Add a Vault</h1>
                </div>
            </div>
        </div>
        <!-- MODAL BEGIN -->
        <!-- Trigger the modal with a button -->


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
                        <form>
                            <div class="form-group">
                                <label for="Title">Keep Name:</label>
                                <input type="text" class="form-control" id="Name">
                            </div>
                            <div class="form-group">
                                <label for="Description">Description:</label>
                                <input type="text" class="form-control" id="Description">
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
            return {}
        },
        computed: {},
        methods: {},
        components: {}
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
</style>