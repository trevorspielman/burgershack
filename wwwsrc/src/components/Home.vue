<template>
  <div class="Home">
    <h1>Please Login/Register:</h1>
    <div>
      <form action="submit">
        <input type="text" placeholder="Email" required>
        <input type="text" placeholder="Password" required>
        <button class="btn btn-primary" type="submit">Login</button>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: 'Home',
  data () {
    return {
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
