package titanic;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

public class DAOPersonas {
     public static List<Persona> obtenerPersonas() {
        List<Persona> personas = new ArrayList<>();

        Persona persona1 = new Persona(123456789, "España","proa", "Juan", false,LocalDate.of(2017, 2, 24));
        Persona persona2 = new Persona(987654321, "Francia","popa", "Airam", false,LocalDate.of(2001, 8, 12));
        Persona persona3 = new Persona(543876214, "Alemania","babor", "Silvia", false,LocalDate.of(2002, 12, 30));
        Persona persona4 = new Persona(987654321, "Italia","estribor", "Isra", false,LocalDate.of(2005, 2, 4));
        Persona persona5 = new Persona(987654321, "Inglaterra","popa", "Alvaro", true,LocalDate.of(2001, 8, 9));

        return personas;
    }
}
