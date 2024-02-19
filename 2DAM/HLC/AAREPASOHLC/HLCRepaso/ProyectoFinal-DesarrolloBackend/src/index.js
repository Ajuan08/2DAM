const express = require('express')
const cors = require('cors');
require('./db/mongoose')
const usuRouter = require('./routers/usuario')
const aloRouter = require('./routers/alojamiento')

const app = express()
const port = process.env.PORT || 3000

app.use(cors());
app.use(usuRouter)
app.use(aloRouter)

app.listen(port, () => {
    console.log('Servidor escuchando en el puerto:  ' + port)
})