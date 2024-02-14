const express = require('express')
const Place = require('../models/place')
const User = require('../models/user')
const auth = require('../middlewares/auth')
const router = new express.Router()

router.get('/places', async (req, res) => {
    try {
        res.send(await Place.find({}))
    } catch (e) {
        res.status(400).send(e)
    }
})

router.post('/places/add', auth, async (req, res) => {
    req.body.propietario = req.user
    const place = new Place(req.body)
    try {
        await place.save();
        res.status(201).send({ place })
    } catch (e) {
        res.status(400).send(e)
    }
})

router.post('/users/login', async (req, res) => {
    try {
        const usuario = await User.findByCredentials(req.body.email, req.body.contrasena)
        const token = await user.generateAuthToken()
        res.send({ usuario, token })
    } catch (e) {
        res.status(400).send()
    }
})

router.post('/users/logout', auth, async (req, res) => {
    try {
        req.user.tokens = req.user.tokens.filter((token) => {
            return token.token !== req.token
        })
        await req.user.save()

        res.send()
    } catch (e) {
        res.status(500).send()
    }
})

router.post('/users/logoutAll', auth, async (req, res) => {
    try {
        req.user.tokens = []
        await req.user.save()
        res.send()
    } catch (e) {
        res.status(500).send()
    }
})

router.get('/users/me', auth, async (req, res) => {
    res.send(req.user)
})

router.patch('/users/me', auth, async (req, res) => {
    const updates = Object.keys(req.body)
    const allowedUpdates = ['nombre', 'email', 'contrasena', 'edad']
    const isValidOperation = updates.every((update) => allowedUpdates.includes(update))

    if (!isValidOperation) {
        return res.status(400).send({ error: 'Cambios Invalidos!' })
    }

    try {
        updates.forEach((update) => req.user[update] = req.body[update])
        await req.user.save()
        res.send(req.user)
    } catch (e) {
        res.status(400).send(e)
    }
})

router.delete('/users/me', auth, async (req, res) => {
    try {
        await req.user.remove()
        res.send(req.user)
    } catch (e) {
        res.status(500).send()
    }
})

module.exports = router