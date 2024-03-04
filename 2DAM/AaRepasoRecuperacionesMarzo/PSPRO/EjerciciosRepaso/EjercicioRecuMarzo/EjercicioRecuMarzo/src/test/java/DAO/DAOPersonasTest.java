/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit4TestClass.java to edit this template
 */
package DAO;

import java.sql.ResultSet;
import javax.swing.JComboBox;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author dam
 */
public class DAOPersonasTest {
    
    public DAOPersonasTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }

    /**
     * Test of getPersonas method, of class DAOPersonas.
     */
    @Test
    public void testGetPersonas() {
        System.out.println("getPersonas");
        DAOPersonas instance = new DAOPersonas();
        ResultSet expResult = null;
        ResultSet result = instance.getPersonas();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of getViviendas method, of class DAOPersonas.
     */
    @Test
    public void testGetViviendas() {
        System.out.println("getViviendas");
        DAOPersonas instance = new DAOPersonas();
        ResultSet expResult = null;
        ResultSet result = instance.getViviendas();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of insertarPersona method, of class DAOPersonas.
     */
    @Test
    public void testInsertarPersona() throws Exception {
        System.out.println("insertarPersona");
        int id = 0;
        String nombre = "";
        DAOPersonas instance = new DAOPersonas();
        instance.insertarPersona(id, nombre);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of borrarPersona method, of class DAOPersonas.
     */
    @Test
    public void testBorrarPersona() {
        System.out.println("borrarPersona");
        int idpersona = 0;
        String nombre = "";
        DAOPersonas instance = new DAOPersonas();
        instance.borrarPersona(idpersona, nombre);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of modificarPersona method, of class DAOPersonas.
     */
    @Test
    public void testModificarPersona() {
        System.out.println("modificarPersona");
        int idAnterior = 0;
        int nuevoId = 0;
        String nombre = "";
        DAOPersonas instance = new DAOPersonas();
        instance.modificarPersona(idAnterior, nuevoId, nombre);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of cargarComboBox method, of class DAOPersonas.
     */
    @Test
    public void testCargarComboBox() {
        System.out.println("cargarComboBox");
        JComboBox<String> combo = null;
        DAOPersonas instance = new DAOPersonas();
        ResultSet expResult = null;
        ResultSet result = instance.cargarComboBox(combo);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of getViviendaPersona method, of class DAOPersonas.
     */
    @Test
    public void testGetViviendaPersona() {
        System.out.println("getViviendaPersona");
        int idPersona = 0;
        DAOPersonas instance = new DAOPersonas();
        ResultSet expResult = null;
        ResultSet result = instance.getViviendaPersona(idPersona);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of insertarVivienda method, of class DAOPersonas.
     */
    @Test
    public void testInsertarVivienda() throws Exception {
        System.out.println("insertarVivienda");
        int id = 0;
        String direccion = "";
        int numero = 0;
        boolean esChungo = false;
        int idpersona = 0;
        DAOPersonas instance = new DAOPersonas();
        instance.insertarVivienda(id, direccion, numero, esChungo, idpersona);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of borrarVivienda method, of class DAOPersonas.
     */
    @Test
    public void testBorrarVivienda() {
        System.out.println("borrarVivienda");
        int idvivienda = 0;
        String direccion = "";
        int numero = 0;
        boolean esChungo = false;
        int idpersona = 0;
        DAOPersonas instance = new DAOPersonas();
        instance.borrarVivienda(idvivienda, direccion, numero, esChungo, idpersona);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of modificarVivienda method, of class DAOPersonas.
     */
    @Test
    public void testModificarVivienda() {
        System.out.println("modificarVivienda");
        int idAnterior = 0;
        int nuevoId = 0;
        String direccion = "";
        int numero = 0;
        boolean esChungo = false;
        int idpersona = 0;
        DAOPersonas instance = new DAOPersonas();
        instance.modificarVivienda(idAnterior, nuevoId, direccion, numero, esChungo, idpersona);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}
