<template>
    <div id= "contact-page">
        This is a contact page
        <div v-for= "(person, index) in persons" :key = "index">
            <p>{{person.name}} works at {{person.company.name}} on street {{person.address.street}}</p>
        </div>
    </div>
</template>

<script>
export default {
    data() {
            return {
                persons: []
            }
        
    },
    beforeCreate() {
        console.log('beforeCreate');
    },
    created() {
        console.log('created');
        fetch("https://jsonplaceholder.typicode.com/users").then( response => {
            response.json().then(date => {
                console.log(date);
                this.persons = date;
            })
        })
    }
}
</script>
