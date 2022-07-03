<template>
<div>
  <nav>
    <router-link to="/">Home</router-link> |
    <router-link to="/IT">IT Department Member</router-link> |
    <router-link to="/HR">HR Department Members</router-link>
  </nav>
  <router-view :people="people"
                @roleAssignement="roleAssignement"/>
</div>
</template>

<script>
export default {
  data() {
    return {
      people: [],
    }
  },
  methods: {
    roleAssignement(role, index) {
     while(true) {
        if(role == 'reset') { 
          this.people[index].role = "Unassigned"
          break;
        }
        if(role == 'it') {
          this.people[index].role = "IT Templar"
          break;
        }
        if(role == 'hr') {
          this.people[index].role = "HR Member"
          break;
        }
        break;
      }
    }
  },
  created() {
    fetch('https://jsonplaceholder.typicode.com/users').then( promise => {
      promise.json().then( data => {
        this.people = data;
        for(let i in this.people) {
          this.people[i] = {...this.people[i], role: 'Unassigned'}
        }
      })
    });
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

nav {
  padding: 30px;
}

nav a {
  font-weight: bold;
  color: #2c3e50;
}

nav a.router-link-exact-active {
  color: #42b983;
}
</style>
