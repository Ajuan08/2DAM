const express = require('express');
const app = express();
const Servicio = require('./service');
app.use(express.json());

app.post('/crearcontacto', async (req, res) => {
    await Servicio.crearContacto(req.body);
    res.send('Se ha creado correctamente');
});

app.get('/buscarcontacto/:id', async (req, res) => {
    const contacto = await Servicio.buscarContacto(req.params.id);
    res.json(contacto);
});

app.put('/actualizarcontacto/:id', async (req, res) => {
    const { dni, nombre, edad, telefono } = req.body;
    const datos = { dni, nombre, edad, telefono };
    
    await Servicio.actualizarContacto(req.params.id, datos);
    
    res.send('Se ha actualizado correctamente');
});


app.delete('/borrarcontacto/:id', async (req, res) => {
    await Servicio.eliminarContacto(req.params.id);
    res.send('Se ha borrado el contacto correctamente');
});

app.listen(3000, () => {
    console.log('Servidor en puerto 3000');
});
