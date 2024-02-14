const mongoose = require('mongoose')
const validator = require('validator')
const bcrypt = require('bcryptjs')
const jwt = require('jsonwebtoken')
const Place = require('./place')

const userSchema = new mongoose.Schema({
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
                throw new Error('El e-mail no es válido.')
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
                throw new Error('La edad debe ser un número positivo.')
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

userSchema.methods.toJSON = function () {
    const user = this
    const userObject = user.toObject()

    delete userObject.contrasena
    delete userObject.tokens

    return userObject
}

userSchema.methods.generateAuthToken = async function () {
    const user = this
    const token = jwt.sign({ _id: user._id.toString() }, 'PalabraSecretaBooking')

    user.tokens = user.tokens.concat({ token })
    await user.save()

    return token
}

userSchema.statics.findByCredentials = async (email, contrasena) => {
    const user = await User.findOne({ email })

    if (!user) {
        throw new Error('Impossible logearse.')
    }

    const isMatch = await bcrypt.compare(contrasena, user.contrasena)

    if (!isMatch) {
        throw new Error('Impossible logearse.')
    }

    return user
}

userSchema.pre('save', async function (next) {
    const user = this

    if (user.isModified('contrasena')) {
        user.contrasena = await bcrypt.hash(user.contrasena, 8)
    }

    next()
})

userSchema.pre('remove', async function (next) {
    const user = this
    await Place.deleteMany({ propietario: user._id })
    next()
})

const User = mongoose.model('User', userSchema)

module.exports = User;