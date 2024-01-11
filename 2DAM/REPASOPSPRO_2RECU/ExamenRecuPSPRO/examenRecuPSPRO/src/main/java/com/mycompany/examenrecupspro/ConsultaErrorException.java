/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.examenrecupspro;

/**
 *
 * @author dam
 */
public class ConsultaErrorException extends Exception {
    public ConsultaErrorException() {
        super("Error al ejecutar la consulta: ");
    }
}
