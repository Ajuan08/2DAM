/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Excepciones;

/**
 *
 * @author anton
 */
public class ExcepcionInsertVacio extends Exception {
    public ExcepcionInsertVacio() {
        super("Error, no se puede introducir campos vacios ");
    }
}
