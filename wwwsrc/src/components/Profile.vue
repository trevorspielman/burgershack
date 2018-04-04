<template>
  <div class="Profile">
    <h1>Welcome {{user.name}}</h1>
    <button class="btn btn-danger" @click="logout">Log Out</button>
  </div>
</template>

<script>
  export default {
    name: 'Profile',
    mounted() {
      this.$store.dispatch('authenticate')
    },
    data() {
      return {
      }
    },
    methods: {
      logout() {
        this.$store.dispatch('logout')
      }
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