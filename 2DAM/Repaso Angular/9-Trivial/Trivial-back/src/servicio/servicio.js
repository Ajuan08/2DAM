const Pregunta = require('../clases/pregunta.js');

class Servicio {
    constructor() {
        this.preguntas = [
            new Pregunta('¿Cuál es la capital de Francia?', 'París', ['Londres', 'Madrid', 'Roma']),
            new Pregunta('¿Cuál es el río más largo del mundo?', 'Nilo', ['Amazonas', 'Mississipi', 'Ebro']),
            new Pregunta('¿En qué año se llevó a cabo la Revolución Rusa?', '1917', ['1776', '2017', '1492']),
            new Pregunta('¿Quién escribió "Romeo y Julieta"?', 'William Shakespeare', ['Charles Dickens', 'Jane Austen', 'Francisco Franco']),
            new Pregunta('¿Cuál es el elemento más abundante en la corteza terrestre?', 'Silicio', ['Hierro', 'Oxígeno', 'Aluminio'])
        ];
    }

    obtenerPreguntas() {
        let numeroRandom = Math.floor(Math.random() * this.preguntas.length);
        let preg = this.preguntas[numeroRandom];

        return {
            tituloPregunta: preg.obtenertituloPreguntas(),
            respuestCorrecta: preg.obtenerPreguntasCorrectas(),
            respuestaIncorrecta: preg.obtenerPreguntasIncorrectas()
        };
    }
}

module.exports = Servicio;