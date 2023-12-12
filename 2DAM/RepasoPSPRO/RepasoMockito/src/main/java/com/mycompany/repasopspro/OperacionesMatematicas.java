/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.repasopspro;

/**
 *
 * @author anton
 */
public class OperacionesMatematicas {
   private ClaseFALSAServicio claseFalsa;
   
   public OperacionesMatematicas(ClaseFALSAServicio claseFalsa){
       this.claseFalsa = claseFalsa;
   }
   
   public int sumar(int num1, int num2){
       int resultado = claseFalsa.sumar(num1, num2);
       System.out.println(resultado);
       return resultado;
   }
}
