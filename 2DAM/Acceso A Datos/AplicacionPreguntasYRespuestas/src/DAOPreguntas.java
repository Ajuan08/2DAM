import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class DAOPreguntas {
    private List<Pregunta> listaPreguntas;
    private int preguntaActual;

    public DAOPreguntas() {
        listaPreguntas = new ArrayList<>();
        listaPreguntas.add(new Pregunta("¿Cuál es la capital de Francia?", new String[]{"Madrid", "Berlín", "París", "Londres"}, 2));
        listaPreguntas.add(new Pregunta("¿En qué año fue la independencia de Estados Unidos?", new String[]{"1776", "1789", "1800", "1812"}, 0));
        listaPreguntas.add(new Pregunta("¿Como se llama la capital de España?", new String[]{"Egipto", "Madrid", "Segovia", "Jerez"}, 1));

        Collections.shuffle(listaPreguntas);
        preguntaActual = 0;
    }

    public Pregunta obtenerPreguntaActual() {
        if (preguntaActual < listaPreguntas.size()) {
            return listaPreguntas.get(preguntaActual);
        }
        return null;
    }

    public void avanzarPregunta() {
        preguntaActual++;
    }

    public boolean hayMasPreguntas() {
        return preguntaActual < listaPreguntas.size();
    }
}

