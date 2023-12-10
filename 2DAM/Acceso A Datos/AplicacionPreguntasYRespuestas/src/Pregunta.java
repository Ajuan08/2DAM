public class Pregunta {
    private String enunciado;
    private String[] opciones;
    private int respuestaCorrecta;
    
	public Pregunta(String enunciado, String[] opciones, int respuestaCorrecta) {
		super();
		this.enunciado = enunciado;
		this.opciones = opciones;
		this.respuestaCorrecta = respuestaCorrecta;
	}
	
	public String getEnunciado() {
		return enunciado;
	}
	public void setEnunciado(String enunciado) {
		this.enunciado = enunciado;
	}
	public String[] getOpciones() {
		return opciones;
	}
	public void setOpciones(String[] opciones) {
		this.opciones = opciones;
	}
	public int getRespuestaCorrecta() {
		return respuestaCorrecta;
	}
	public void setRespuestaCorrecta(int respuestaCorrecta) {
		this.respuestaCorrecta = respuestaCorrecta;
	}

    
}

