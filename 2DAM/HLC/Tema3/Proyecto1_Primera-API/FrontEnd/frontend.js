class ServicioPreguntas {
  async obtenerPregunta() {
    const response = await fetch('/api/pregunta');
    const data = await response.json();
    return data.texto;
  }
}

async function obtenerPregunta() {
  const servicioPreguntas = new ServicioPreguntas();
  const questionContainer = document.getElementById('questionContainer');

  try {
    const pregunta = await servicioPreguntas.obtenerPregunta();
    questionContainer.innerText = pregunta;
  } catch (error) {
    console.error('Error al obtener la pregunta:', error);
  }
}
