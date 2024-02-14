const mongoose = require('mongoose');

const placeSchema = new mongoose.Schema({
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
    imagen: {
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
        ref: 'User'
    },
    alquilador: {
        type: mongoose.Schema.Types.ObjectId,
        required: false,
        ref: 'User'
    }
}, {
    timestamps: true
});

const Place = mongoose.model('Place', placeSchema);

module.exports = Place;