<template>
  
</template>

<script>

export default {
   created() {
     console.log("D");
     fetch("http://localhost:3000/tasks").then(data => {
       console.log(data);
     })
   }
}
</script>

<style>

</style>
