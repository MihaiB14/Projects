const mongoose = require("mongoose")

const connect = () => {
    try {
        mongoose.connect("mongodb+srv://MihaiB14:14092@cluster0.0g8wf.mongodb.net/ceva?retryWrites=true&w=majority")
    }catch(error) {
        console.log(error)
    }
}

connect()