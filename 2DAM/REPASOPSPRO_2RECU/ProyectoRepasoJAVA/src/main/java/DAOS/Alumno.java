/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOS;

/**
 *
 * @author anton
 */
public class Alumno {
    
    int codigoColegio;
    String Nombre;
    int edad;
    Boolean feo;

    public Alumno(int codigoColegio, String Nombre, int edad, Boolean feo) {
        this.codigoColegio = codigoColegio;
        this.Nombre = Nombre;
        this.edad = edad;
        this.feo = feo;
    }

    public int getCodigoColegio() {
        return codigoColegio;
    }

    public void setCodigoColegio(int codigoColegio) {
        this.codigoColegio = codigoColegio;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public Boolean getFeo() {
        return feo;
    }

    public void setFeo(Boolean feo) {
        this.feo = feo;
    }
    
    
    
    
    
}
