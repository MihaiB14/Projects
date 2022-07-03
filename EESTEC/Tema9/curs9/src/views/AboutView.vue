<template>
  <div class="about">
    <div v-for="(item, index) in $store.getters.completedItems" :key = "index">
        <p>Complete {{item.name}}</p>
        <p>Status: {{item.status}}</p>
        <button @click="decompleteItem(item.id)">Complete</button>
      </div>
  </div>
</template>

<script>
  export default {
    methods: {
      decompleteItem(decompleteItemId) {
          this.$store.commit('decompleteItem', decompleteItemId);
      }
    }
  }
</script>

