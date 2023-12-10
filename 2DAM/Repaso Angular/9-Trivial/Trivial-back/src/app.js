const Servicio = require('./servicio/servicio.js');
const express = require('express');

const servicio = new Servicio();
const app = express();

app.get('/obtenerPreguntas', (req, res) => {
    res.json(servicio.obtenerPreguntas());
})

const port = 3000;
app.listen(port, () => {
  console.log(`Servidor corriendo en:  http://localhost:${port}`);
});