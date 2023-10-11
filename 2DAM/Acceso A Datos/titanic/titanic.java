package titanic;

import java.util.List;

public class titanic {
    public static void main(String[] args) {
        List<Persona> personas = DAOPersonas.obtenerPersonas();
        List<BoteSalvavidas> botes = DAOBotes.obtenerBotes();

        // Implementa el algoritmo de evacuación

        // Imprime las asignaciones de botes y personas
    }
}
