package titanic;

import java.time.LocalDate;

public class Persona {
    private int dni;
    private String pais;
    private String zona;
    private String nombre;
    private boolean minusvalia;
    private LocalDate fechaNacimiento;

    

    public Persona(int dni, String pais, String zona, String nombre, boolean minusvalia, LocalDate localDate) {
        this.dni = dni;
        this.pais = pais;
        this.zona = zona;
        this.nombre = nombre;
        this.minusvalia = minusvalia;
        this.fechaNacimiento = localDate;
    }

     public int getDni() {
        return dni;
    }

    public void setDni(int dni) {
        this.dni = dni;
    }
    public String getPais() {
        return pais;
    }

    public void setPais(String pais) {
        this.pais = pais;
    }
    public String getZona() {
        return zona;
    }

    public void setZona(String zona) {
        this.zona = zona;
    }
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    public boolean isMinusvalia() {
        return minusvalia;
    }

    public void setMinusvalia(boolean minusvalia) {
        this.minusvalia = minusvalia;
    }
    public LocalDate getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(LocalDate fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }
}

