class Pregunta {
    constructor(tituloPregunta, respuestCorrecta, respuestaIncorrecta) {
        this.tituloPregunta = tituloPregunta;
        this.respuestCorrecta = respuestCorrecta;
        this.respuestaIncorrecta = respuestaIncorrecta;
    }

    obtenertituloPreguntas() {
        return this.tituloPregunta;
    }

    obtenerPreguntasCorrectas() {
        return this.respuestCorrecta;
    }

    obtenerPreguntasIncorrectas() {
        return this.respuestaIncorrecta;
    }
}

module.exports = Pregunta;