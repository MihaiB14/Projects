<template>
  <div
    :class="{'person-card': true,
              'it-card': people.role == 'IT Templar',
              'hr-card': people.role == 'HR Member'}">
    <div class="wrapper">
      <div class="person-name"> Name: {{people.name}}</div>
      <div class="person-role"> Role: {{people.role}}</div>
      <div class="button-wrapper" v-if="!isSimplified">
        <button id="reset-button" @click="switchRole('reset')" :class="{'inactive-button': people.role == 'Unassigned'}"> Reset Role </button>
        <button id="it-button" @click="switchRole('it')" :class="{'inactive-button': people.role == 'IT Templar'}"> Assign to IT </button>
        <button id="hr-button" @click="switchRole('hr')" :class="{'inactive-button': people.role == 'HR Member'}"> Assign to HR </button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: ['people', 'index'],
  data() {
    return {

    }
  },
  methods: {
    switchRole(role) {
      this.$emit('roleAssignement', role, this.index);
    }
  }
}
</script>

<style scoped>
.person-card {
  border: 1px solid black;
  border-radius: 10px;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  justify-items: center;
  align-items: center;
  background-color: lightgrey;
}

.it-card {
  background-color: lightsalmon;
}

.hr-card {
  background-color: lightyellow;
}

.button-wrapper {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  gap: 10px;

  margin-top: 20px;
}

button {
  background-color: lightgoldenrodyellow;
  color: black;
}
.inactive-button {
  pointer-events: none;
  background-color: lightcyan;
  color: black;
}
</style>