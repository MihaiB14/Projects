<template>
<div>
  <div id = "display-value">{{displayValue}}</div>
  <button @click = "increment(1)"> Increment 1</button>
  <button @click = "increment(2)"> Increment 2</button> 
</div>
  
</template>
  
<script>
export default {
  data() {
    return{
      displayValue: 0
    }
  },
  methods: {
    increment(incrementable) {
      this.displayValue+=incrementable;
    },
    decrement() {
      this.displayValue--;
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#display-value {
  font-size: 40px;
  color: red;
}
</style>
