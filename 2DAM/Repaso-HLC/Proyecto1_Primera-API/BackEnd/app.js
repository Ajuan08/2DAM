const express = require('express');
const cors = require('cors');
const app = express();
const port = 3000;

const ServicioPreguntas = require('./ServicioPreguntas');
const servicioPreguntas = new ServicioPreguntas();

app.use(cors());
app.get('/obtenerFrase',(req, res) =>{
    const pregunta = servicioPreguntas.obtenerFrase();
    res.json({ pregunta });
});

app.listen(port, () => {
  console.log(`Servidor escuchando en http://localhost:${port}`);
});
