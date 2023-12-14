const express = require('express')
const tasks = require('./tasks.js')
const cors = require('cors')

const app = express()

app.use(cors())

app.get('/', (req, res) => {
    res.json(tasks.getTasks())
})

app.post('/addTask', (req, res) => {
    const { name, description } = req.body;

    if (!name || !description) {
        return res.status(400).json({ error: 'Name and description are required.' });
    }

    const newTask = tasks.addTask(name, description);
    res.status(201).json(newTask);
})

app.get('/task/:nTask', (req, res) => {
    res.json(tasks.getTasksN(req.params.nTask))
})

app.get('/removeTask/:nTask', (req, res) => {
    res.send(tasks.removeTask(req.params.nTask))
})

app.listen(3000, () => {
    console.log('Server is up on port 3000.')
})