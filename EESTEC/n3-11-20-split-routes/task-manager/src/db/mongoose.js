const mongoose = require('mongoose')

mongoose.connect('mongodb+srv://MihaiB14:14092@cluster0.0g8wf.mongodb.net/myFirstDatabase?retryWrites=true&w=majority', {
    useNewUrlParser: true,
    useCreateIndex: true,
    useFindAndModify: false
})