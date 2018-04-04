<template>
  <div class="Profile">
    <h1>Welcome {{user.name}}</h1>
    </div>
</template>

<script>
  export default {
    name: 'Profile',
    data() {
      return {
      }
    },
    methods: {

    },
    computed: {
      user() {
        return this.$store.state.user
      }
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>