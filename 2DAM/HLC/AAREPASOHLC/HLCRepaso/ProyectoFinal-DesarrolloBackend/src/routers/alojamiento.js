const express = require('express')
const Alojamiento = require('../models/alojamiento')
const auth = require('../middlewares/auth')
const router = new express.Router()

router.get('/alojamiento', async (req, res) => {
    try {
        res.send(await Alojamiento.find({}))
    } catch (e) {
        res.status(400).send(e)
    }
})

router.post('/alojamiento/anadir', auth, async (req, res) => {
    req.body.propietario = req.usuario
    const alojamiento = new Alojamiento(req.body)
    try {
        await alojamiento.save();
        res.status(201).send({ alojamiento })
    } catch (e) {
        res.status(400).send(e)
    }
})

router.patch('/alojamiento/editar', auth, async (req, res) => {
    const alojamiento = await Alojamiento.findById(req.body._id)
    let updates = Object.keys(req.body)
    updates = updates.filter(update => update !== '_id')
    const allowedUpdates = ['titulo', 'descripcion', 'imagenURL', 'precio']
    const isValidOperation = updates.every((update) => allowedUpdates.includes(update))

    if (!isValidOperation) {
        return res.status(400).send({ error: 'Cambios erroneos' })
    }

    try {
        updates.forEach((update) => alojamiento[update] = req.body[update])
        await alojamiento.save()
        res.send()
    } catch (e) {
        res.status(400).send(e)
    }
})

router.patch('/alojamiento/mostrar', auth, async (req, res) => {
    const alojamiento = await Alojamiento.findById(req.body.id)
    try {
        alojamiento.alquilador = req.user._id;
        await alojamiento.save();
        res.send()
    } catch (e) {
        res.status(400).send(e)
    }
})

router.patch('/alojamiento/borrar', auth, async (req, res) => {
    const alojamiento = await Alojamiento.findById(req.body.id)
    try {
        alojamiento.alquilador = undefined;
        await alojamiento.save();
        res.send()
    } catch (e) {
        res.status(400).send(e)
    }
})

module.exports = router