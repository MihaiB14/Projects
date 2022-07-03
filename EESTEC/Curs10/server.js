const express = require("express");

const server = express()

const PORT = 3000
// http:localhost:3000/getMasini
const cars = [
    "Mercedes", "Logan", "BMW"
]

server.get("/getMasini", (req, res) => {
    res.json(cars);
});

server.post("/getMasini", (req, res) => {
    cars.push("Toyota");
});

server.listen(PORT, () => {
    console.log(`Server started at ${PORT}`)
})