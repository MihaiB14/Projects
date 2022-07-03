const express= require("express")
const taskRouters = require("./routes/taskRoutes.js")
require('./db/mongoose.js')
const app = express()
app.use(express.json())
const PORT = 3000

app.use(taskRouters)

app.listen(PORT, () => {
    console.log(`Server started at ${PORT}`)
})