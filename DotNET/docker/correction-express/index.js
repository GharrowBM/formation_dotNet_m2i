const express = require("express")
const app = express()

app.get("/", (req,res) => {
    res.end("Hello form express")
})

app.listen(4000, () => {
    console.log("Application is working")
})