/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Excepciones;

/**
 *
 * @author dam
 */
public class ExcepcionDNIDuplicado extends Exception {
     public ExcepcionDNIDuplicado() {
        super("Error, no se puede introducir el mismo dni");
    }
}
