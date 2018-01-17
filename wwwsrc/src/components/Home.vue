<template>
    <div class="Home">
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
                    <h3>Keep Title Here</h3>
                </div>

                <div>
                    <button class="btn btn-warning">add to vault</button>
                    <button class="btn btn-danger">view</button>
                    <button class="btn btn-success">share</button>
                </div>
            </div>
        </div>
    </div>
</template>


<script>
    import keeps from './keeps'
    import vaults from './vaults'
    export default {
        name: 'home',
        data() {
            return {}
        },
        computed: {
            user() {
                return this.$store.state.user
            },
        },
        methods: {},
        components: {
            keeps,
            vaults
        }
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