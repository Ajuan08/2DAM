const express = require('express')
const Usuario = require('../models/usuario')
const auth = require('../middlewares/auth')
const router = new express.Router()

router.post('/usuario/anadir', async (req, res) => {
    const usu = new Usuario(req.body)
    try {
        await usu.save()
        res.status(201).send({ usu })
    } catch (e) {
        res.status(400).send(e)
    }
})

router.post('/usuario/login', async (req, res) => {
    try {
        const usu = await Usuario.findByCredentials(req.body.email, req.body.contrasena)
        const token = await usu.generateAuthToken()
        res.send({ usu, token })
    } catch (e) {
        res.status(400).send()
    }
})

router.post('/usuario/logout', auth, async (req, res) => {
    try {
        req.usu.tokens = req.usu.tokens.filter((token) => {
            return token.token !== req.token
        })
        await req.usu.save()

        res.send()
    } catch (e) {
        res.status(500).send()
    }
})

module.exports = router