<template>
    <div class="keeps">
        <div class="row text-center">
            <div class="card col-lg-2">
                <div class="thumbnail">
                    <img src="https://images.unsplash.com/reserve/wrev1ljvQ6KlfyljCQG0_lion.jpg?auto=format&fit=crop&w=1355&q=80">
                </div>
                <div style="display: inline-flex">
                    <h4>K: {{0}} |</h4>
                    <h4>| V: {{0}} |</h4>
                    <h4>| S: {{0}}</h4>
                </div>
                <div class="row">
                    <h3>description here</h3>
                </div>

                <div class="button">
                    <button class="btn btn-warning">add to vault</button>
                    <button class="btn btn-danger">view</button>
                    <button class="btn btn-success">share</button>
                </div>
            </div>

        </div>

        <!-- DELETE BELOW THIS LINE -->

        <!-- <div class="row text-center">
            <div @click="setActiveRecipe(result)" class="card col-lg-8" style="width: 28rem;" v-for="result in results" draggable="true"
                v-on:dragstart.capture="moving">
                <img data-toggle="modal" data-target="#myModal" class="card-img-top" :src="result.recipe.image" alt="Card image cap">
                <div class="card-block">
                    <a>
                        <h5 data-toggle="modal" data-target="#myModal" class="card-title">
                            <strong>{{result.recipe.label}}</strong>
                        </h5>
                    </a>

                    <button v-if="user.name" class="btn btn-warning wide" @click="addToCookBook(result)">Add to Cookbook</button>
                    <button v-if="!user.name" class="btn btn-warning wide" @click="please()">Add to Cookbook</button>
                    <a :href="result.recipe.url" target="_blank" class="btn btn-primary wide">View Recipe
                        <span class="glyphicon glyphicon-new-window"></span>
                    </a>

                </div>
            </div>
        </div> -->

        <!-- DELETE ABOVE THIS LINE -->

    </div>
</template>


<script>
    export default {
        name: 'keeps',
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

    .button:hover {
        display: none;
        /* width: 100px;
        height: 100px; */
    }

    .button {
        display: block;
        /* width: 100px;
        height: 100px; */
    }
</style>