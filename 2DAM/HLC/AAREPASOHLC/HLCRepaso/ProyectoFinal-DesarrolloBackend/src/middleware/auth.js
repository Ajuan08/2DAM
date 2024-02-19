const jwt = require('jsonwebtoken')
const Usuario = require('../models/usuario')

const auth = async (req, res, next) => {
    try {
        const token = req.header('Autorizacion').replace('Bearer ', '');
        const decoded = jwt.verify(token, process.env.JWT_SECRET);
        const usu = await Usuario.findOne({_id: decoded._id,'tokens.token': token});

        if (!usu) {
            throw new Error()
        }

        req.token = token;
        req.usu = usu;
        next();
    } catch (e) {
        res.status(401).send({ error: e.message });
    }
}

module.exports = auth;