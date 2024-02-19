const mongoose = require('mongoose')
const validator = require('validator')
const bcrypt = require('bcryptjs')
const jwt = require('jsonwebtoken')
const Alojamiento = require('./alojamiento')

const usuarioSchema = new mongoose.Schema({
    nombre: {
        type: String,
        required: true,
        trim: true
    },
    email: {
        type: String,
        unique: true,
        required: true,
        trim: true,
        lowercase: true,
        validate(value) {
            if (!validator.isEmail(value)) {
                throw new Error('Email es incorrecto')
            }
        }
    },
    contrasena: {
        type: String,
        required: true,
        minlength: 8,
        trim: true,
        validate(value) {
            if (value.toLowerCase().includes('contrasena')) {
                throw new Error('La contraseña no puede contener "contrasena"')
            }
        }
    },
    edad: {
        type: Number,
        default: 0,
        validate(value) {
            if (value < 0) {
                throw new Error('La edad no puede ser un numero negativo')
            }
        }
    },
    tokens: [{
        token: {
            type: String,
            required: true
        }
    }]
})

userSchema.virtual('alojamiento', {
    ref: 'Alojamiento',
    localField: '_id',
    foreignField: 'propietario'
})

usuarioSchema.methods.toJSON = function () {
    const user = this
    const userObject = user.toObject()

    delete userObject.contrasena
    delete userObject.tokens

    return userObject
}

usuarioSchema.methods.generateAuthToken = async function () {
    const user = this
    const token = jwt.sign({ _id: user._id.toString() }, 'PalabraSecretaBooking')

    user.tokens = user.tokens.concat({ token })
    await user.save()

    return token
}

usuarioSchema.statics.findByCredentials = async (email, contrasena) => {
    const user = await User.findOne({ email })

    if (!user) {
        throw new Error('Es imposible loguearse')
    }

    const isMatch = await bcrypt.compare(contrasena, user.contrasena)

    if (!isMatch) {
        throw new Error('Es imposible loguearse')
    }

    return user
}

usuarioSchema.pre('save', async function (next) {
    const user = this

    if (user.isModified('contrasena')) {
        user.contrasena = await bcrypt.hash(user.contrasena, 8)
    }

    next()
})

usuarioSchema.pre('remove', async function (next) {
    const user = this
    await Alojamiento.deleteMany({ owner: user._id })
    next()
})

const Usuario = mongoose.model('Usuario', usuarioSchema)

module.exports = Usuario;