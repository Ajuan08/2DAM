import java.util.*;

class Persona {
    private int dni;
    private String pais;
    private String zona;
    private String nombre;
    private boolean minusvalia;
    private Date fechaNacimiento;

    public Persona(int dni, String pais, String zona, String nombre, boolean minusvalia, Date fechaNacimiento) {
        this.dni = dni;
        this.pais = pais;
        this.zona = zona;
        this.nombre = nombre;
        this.minusvalia = minusvalia;
        this.fechaNacimiento = fechaNacimiento;
    }
}

class Tripulacion extends Persona {
    private String nivelResponsabilidad;

    public Tripulacion(int dni, String pais, String zona, String nombre, boolean minusvalia, Date fechaNacimiento, String nivelResponsabilidad) {
        super(dni, pais, zona, nombre, minusvalia, fechaNacimiento);
        this.nivelResponsabilidad = nivelResponsabilidad;
    }

    public String getNivelResponsabilidad() {
        return nivelResponsabilidad;
    }

    public void setNivelResponsabilidad(String nivelResponsabilidad) {
        this.nivelResponsabilidad = nivelResponsabilidad;
    }
}

class Pasajero extends Persona {
    private int numeroHabitacion;

    public Pasajero(int dni, String pais, String zona, String nombre, boolean minusvalia, Date fechaNacimiento, int numeroHabitacion) {
        super(dni, pais, zona, nombre, minusvalia, fechaNacimiento);
        this.numeroHabitacion = numeroHabitacion;
    }

    public int getNumeroHabitacion() {
        return numeroHabitacion;
    }

    public void setNumeroHabitacion(int numeroHabitacion) {
        this.numeroHabitacion = numeroHabitacion;
    }
}

class BoteSalvavidas {
    private int id;
    private int numeroPlazas;
    private String zona;

    public BoteSalvavidas(int id, int numeroPlazas, String zona) {
        this.id = id;
        this.numeroPlazas = numeroPlazas;
        this.zona = zona;
    }

    public int getId() {
        return id;
    }

    public int getNumeroPlazas() {
        return numeroPlazas;
    }

    public String getZona() {
        return zona;
    }
}

class DAOPersonas {
    public static List<Persona> obtenerPersonas() {
        List<Persona> personas = new ArrayList<>();

         //Persona persona1 = new Persona(123456789, "España","proa", "Juan", false, 2001/09/08);

        return personas;
    }
}

class DAOBotes {
    public static List<BoteSalvavidas> obtenerBotes() {
        List<BoteSalvavidas> botes = new ArrayList<>();

        // Genera y agrega botes a la lista

        return botes;
    }
}

public class posible_solucion {
    public static void main(String[] args) {
        List<Persona> personas = DAOPersonas.obtenerPersonas();
        List<BoteSalvavidas> botes = DAOBotes.obtenerBotes();

        // Implementa el algoritmo de evacuación

        // Imprime las asignaciones de botes y personas
    }
}