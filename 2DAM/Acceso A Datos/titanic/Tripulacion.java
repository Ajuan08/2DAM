package titanic;

import java.time.LocalDate;

public class Tripulacion extends Persona {
    private String nivelResponsabilidad;

    public Tripulacion(int dni, String pais, String zona, String nombre, boolean minusvalia, LocalDate fechaNacimiento, String nivelResponsabilidad) {
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
