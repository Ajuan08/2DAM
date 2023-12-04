const express = require('express');
const app = express();
const puerto = 3000;

const ServicioPreguntas = require('./servicioPreguntas');
const servicioPreguntas = new ServicioPreguntas();

app.use(express.json());

app.get('/api/pregunta', async (req, res) => {
  try {
    const pregunta = await servicioPreguntas.obtenerPregunta();
    res.json({ texto: pregunta });
  } catch (error) {
    console.error('Error al obtener la pregunta:', error);
    res.status(500).json({ error: 'Error al obtener la pregunta' });
  }
});

app.listen(puerto, () => {
  console.log(`Servidor escuchando en http://localhost:${puerto}`);
});
