package titanic;

import java.time.LocalDate;

public class Pasajero extends Persona {
    private int numeroHabitacion;

    public Pasajero(int dni, String pais, String zona, String nombre, boolean minusvalia, LocalDate fechaNacimiento, int numeroHabitacion) {
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
