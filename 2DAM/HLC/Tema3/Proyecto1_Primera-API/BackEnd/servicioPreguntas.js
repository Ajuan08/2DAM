
class ServicioPreguntas {
    async obtenerPregunta() {
      return new Promise((resolve) => {
        const preguntas = ['¿Cómo estás?', '¿Cuál es tu color favorito?', '¿Qué día es hoy?'];
        const preguntaAleatoria = preguntas[Math.floor(Math.random() * preguntas.length)];
        resolve(preguntaAleatoria);
      });
    }
  }
  
  module.exports = ServicioPreguntas;
  
  