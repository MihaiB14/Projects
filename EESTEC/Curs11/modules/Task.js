const mongoose = require("mongoose")

const TaskSchema = new mongoose.Schema({
    title: {
        type: String,
        required: true,
        max: 50,
    },
    description: {
        type: String,
    },
    completed: {
        type: Boolean,
        default: false
    }
})

module.exports = Task = mongoose.model('Task', TaskSchema)