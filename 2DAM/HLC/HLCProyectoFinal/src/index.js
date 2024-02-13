const express = require('express')
const cors = require('cors');
const userRouter = require('./routers/user')
const placeRouter = require('./routers/place')

require('./db/mongoose')

const app = express()
const port = process.env.PORT || 3000

app.use(cors());
app.use(express.json())
app.use(userRouter)
app.use(placeRouter)

app.listen(port, () => {
    console.log('El servidor esta escuchando en el: ' + port)
})