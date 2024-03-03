/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/EmptyTestNGTest.java to edit this template
 */
package DAO;

import java.sql.ResultSet;
import javax.swing.JComboBox;
import static org.testng.Assert.*;
import org.testng.annotations.AfterClass;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;

/**
 *
 * @author anton
 */
public class DAOPersonasNGTest {
    
    @Test
    public void testGetPersonas() {
        System.out.println("getPersonas");
        DAOPersonas instance = new DAOPersonas();
        ResultSet result = instance.getPersonas();
        assertNotNull(result);
    }

    @Test
    public void testInsertarPersona() {
        System.out.println("insertarPersona");
        int id = 1;
        String nombre = "NombrePersona";
        DAOPersonas instance = new DAOPersonas();
        try {
            instance.insertarPersona(id, nombre);
        } catch (Exception ex) {
            fail("Excepción no esperada: " + ex.getMessage());
        }
    }

    @Test
    public void testBorrarPersona() {
        System.out.println("borrarPersona");
        int idpersona = 1; 
        String nombre = "NombrePersona"; 
        DAOPersonas instance = new DAOPersonas();
        try {
            instance.borrarPersona(idpersona, nombre);
        } catch (Exception ex) {
            fail("Excepción no esperada: " + ex.getMessage());
        }
       
    }

    @Test
    public void testModificarPersona() {
        System.out.println("modificarPersona");
        int idAnterior = 1; // ID de persona existente
        int nuevoId = 2; // ID nuevo válido
        String nombre = "NuevoNombre"; // Nombre válido
        DAOPersonas instance = new DAOPersonas();
        try {
            instance.modificarPersona(idAnterior, nuevoId, nombre);
        } catch (Exception ex) {
            fail("Excepción no esperada: " + ex.getMessage());
        }
        // Puedes agregar más aserciones si es necesario
    }

    @Test
    public void testCargarComboBox() {
        System.out.println("cargarComboBox");
        JComboBox<String> combo = new JComboBox<>(); // Combo box válido
        DAOPersonas instance = new DAOPersonas();
        ResultSet result = instance.cargarComboBox(combo);
        assertNotNull(result);
        // Puedes agregar más aserciones si es necesario
    }
}
