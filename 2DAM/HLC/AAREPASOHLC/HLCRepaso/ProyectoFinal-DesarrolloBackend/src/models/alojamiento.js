const mongoose = require('mongoose');

const alojamientoSchema = new mongoose.Schema({
    titulo: {
        type: String,
        required: true,
        trim: true
    },
    descripcion: {
        type: String,
        required: false,
        trim: true
    },
    imagenURL: {
        type: String,
        required: false,
        trim: true
    },
    precio: {
        type: String,
        required: true,
        trim: true
    },
    propietario: {
        type: mongoose.Schema.Types.ObjectId,
        required: true,
        ref: 'Usuario'
    },
    alquilador: {
        type: mongoose.Schema.Types.ObjectId,
        required: false,
        ref: 'Usuario'
    }
}, {
    timestamps: true
});

const Alojamiento = mongoose.model('Alojamiento', alojamientoSchema);

module.exports = Alojamiento;