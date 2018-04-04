<template>
  <div class="Home">
    <h1>Please Register:</h1>
    <div>
      <form action="submit" @submit.prevent="register">
        <input type="text" v-model="newUser.name" placeholder="Name">
        <input type="text" v-model="newUser.email" placeholder="Email" required>
        <input type="password" v-model="newUser.password" placeholder="Password" required>
        <button class="btn btn-primary" type="submit">Register</button>
      </form>
    </div>
    <h1>Please Login:</h1>
    <div>
      <form action="submit" @submit.prevent="login">
        <input type="text" v-model="loginUser.email" placeholder="Email" required>
        <input type="password" v-model="loginUser.password" placeholder="Password" required>
        <button class="btn btn-primary" type="submit">Login</button>
      </form>
    </div>
  </div>
</template>

<script>
  export default {
    name: 'Home',
    data() {
      return {
        newUser: {
          name: '',
          email: '',
          password: ''
        },
        loginUser: {
          email: '',
          password: ''
        },
      }
    },
    methods: {
      register() {
        this.$store.dispatch('createUser', this.newUser)
      },
      login() {
        this.$store.dispatch('login', this.loginUser)
      },
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>