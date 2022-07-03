<template>
  <div class="home">
      <div v-for="(item, index) in $store.state.toDoItems" :key = "index">
        <p>Complete {{item.name}}</p>
        <p>Status: {{item.status}}</p>
        <button @click="completeItem(item.id)">Complete</button>
      </div>
      <div v-for="(item, index) in variabila" :key="index">
        <p>{{item.description}}</p>
      </div>
      <input type="text" v-model="inputValue">
      <p>{{inputValue}}</p>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'HomeView',
  components: {
    HelloWorld
  },
  data() {
    return {
      data: {
        description: 'hhihihihiassgm s,dfbajkvhajvhskv',
        title: 'azi a fost soare',
        completed: false
      },
      variabila: [],
      inputValue: 'nimic',
    }
  },
  methods: {
    completeItem(completedItemId) {
      this.$store.commit('completeItem', completedItemId);
    }
  },
  created() {
    // fetch('http://localhost:3000/tasks', {
    //   method: 'POST',
    //   headers: {
    //   'Content-Type': 'application/json'
    //   // 'Content-Type': 'application/x-www-form-urlencoded',
    //   },
    //   body: JSON.stringify(this.data),
    // })
    fetch('http://localhost:3000/tasks').then( response => response.json().then(tasks => {
        this.variabila = tasks;
    }))
    this.$store.state.toDoItems.push('nkjhkj')
    console.log(this.$store.state.toDoItems);
  }
}
</script>
