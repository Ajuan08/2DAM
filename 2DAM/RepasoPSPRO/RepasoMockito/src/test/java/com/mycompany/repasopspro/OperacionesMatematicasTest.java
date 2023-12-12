/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.mycompany.repasopspro;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;

/**
 *
 * @author anton
 */
public class OperacionesMatematicasTest {
    
    public OperacionesMatematicasTest() {
    }

    @InjectMocks
    private static OperacionesMatematicas operaciones;
    
    @Mock
    private static ClaseFALSAServicio claseFalsa;
    
    
    @BeforeAll
    public static void setUpClass() {
        claseFalsa = Mockito.mock(ClaseFALSAServicio.class);
        operaciones = new OperacionesMatematicas(claseFalsa);
    }
    
   

    /**
     * Test of sumar method, of class OperacionesMatematicas.
     */
    @org.junit.jupiter.api.Test
    
    //MOCKITO
    public void testSumar() {
        Mockito.when(claseFalsa.sumar(3, 2)).thenReturn(5);
        System.out.println("sumar");
        int a = 3;
        int b = 2;
        int expResult = 5;
        int result = operaciones.sumar(a, b);
        assertEquals(expResult, result);
       
    }
    
}
