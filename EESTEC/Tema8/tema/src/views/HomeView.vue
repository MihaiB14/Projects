<template>
  <div id="home">
    <h1> ALL MEMBERS </h1>
    <div class="persons">
      <Card 
        class="card"
        v-for="(person, index) in people" :key="index"
        :people = "person"
        :index = "index"
        @roleAssignement="roleAssignement"
      ></Card>
    </div>
  </div>
</template>

<script>

import Card from '@/components/Card.vue'

export default {
  name: 'home',
  components: {
    Card
  },
  props: ['people'],
  methods: {
    roleAssignement(role, index) {
      this.$emit('roleAssignement',role,index);
    }
  }
}
</script>

<style scoped>
.persons {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-around;
  gap: 20px;
}

.card {
  width: 200px;
  height: 200px;
}
</style>