class ServicioPreguntas {
    constructor() {
      this.frase = ['Hola!!', 'Si ves esto', 'Es porque funciona!!'];
      this.indicePreguntaActual = 0;
    }
  
    obtenerFrase() {
      const frases = this.frase[this.indicePreguntaActual];
      this.indicePreguntaActual = (this.indicePreguntaActual + 1) % this.frase.length;
      return frases;
    }
  }
  
  module.exports = ServicioPreguntas;
  