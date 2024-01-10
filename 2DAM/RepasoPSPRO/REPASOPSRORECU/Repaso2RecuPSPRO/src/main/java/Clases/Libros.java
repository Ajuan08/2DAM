/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

/**
 *
 * @author anton
 */
public class Libros {
    
    int id;
    String nombre;
    int categoria;

    public Libros(int id, String nombre, int categoria) {
        this.id = id;
        this.nombre = nombre;
        this.categoria = categoria;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getCategoria() {
        return categoria;
    }

    public void setCategoria(int categoria) {
        this.categoria = categoria;
    }
    
    public int compareTo(Libros otroLibro) {
        // Comparar primero por categoría y luego por nombre
        if (this.categoria != otroLibro.categoria) {
            return Integer.compare(this.categoria, otroLibro.categoria);
        } else {
            return this.nombre.compareTo(otroLibro.nombre);
        }
    }
    
}
