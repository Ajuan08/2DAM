const express = require('express');
const servicio = require('./servicio');
const cors = require('cors');
const app = express();
const port = 3000;
const servicio = servicio;

app.use(cors());

app.get('/prueba', async(req, res) => {
    try{
        const prueba = await servicio.getApiData();
        res.json(prueba);
    }catch(error){
        console.error(error);
        res.status(500).send('Error al obtener datos de la API externa de prueba');
    }
});

app.listen(port, () => {
    console.log(`Example app listening at http://localhost:${port}`);
});
