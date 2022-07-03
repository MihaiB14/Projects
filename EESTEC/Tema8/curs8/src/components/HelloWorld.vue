<template>
  <div class = "hello">
    <h1>{{parentMessage}}</h1>
    <div v-if = "isShown">{{displayValue}}</div>
    <div v-else>Altceva</div>
    <button @click="changeShown">Show other</button>
    <div v-bind:class = "{'is-true': isShown, 'is-false': !isShown}">Colorful text</div>
    <input v-model = "inputValue">
    <p>{{inputValue}}</p>
    <input type="checkbox" v-model="inputBoxValue">
    <div v-for="(person, index) in persons2" :key = "index">
      <p :class = "{person: true, 'selected-person': index == selectPersonIndex}" @click="selectPerson(index)"> {{person.name}}  has {{person.age}} years</p>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      displayValue: 'ceva',
      isShown: false,
      inputValue: 'some value',
      inputBoxValue: false,
      persons: ['Anita', 'Dorel', 'Ion', 'Nicu', 'Dorel'], 
      persons2: [{
        name: 'Anita',
        age: 18

      },{
        name:'Dorel',
        age: 22
      },{
        name: 'Ion',
        age: 24
      }
      ],
      selectPersonIndex: -1
    }
  },

  methods: {
    changeShown() {
      this.isShown = !this.isShown;
    },
    selectPerson(personIndex) {
      this.inputValue = this.persons2[personIndex].name;
      this.selectPersonIndex = personIndex;
    }},

    props: [
      'parentMessage', 'anotherParentMessege'
    ]
  
}
</script>



<style scoped>
  .is-true {
    background-color: red;
  }

  .is-false {
    background-color: blue;
  }

  .person:hover {
    cursor: pointer;
  }

  .selected-person {
    color: red;
  }
</style>
