const Task = require("../modules/Task")
const createTask = async(req, res) => {
    console.log(req.body)
    const task = new Task(req.body)
    await task.save()
    res.status(200).json({message: "Task created"})
}

module.exports = {
    createTask
}