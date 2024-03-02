/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAO;

import Conexion.BD1;
import Excepciones.ExcepcionInsertVacio;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JComboBox;

/**
 *
 * @author anton
 */
public class DAOPersonas {
    
    BD1 bd1 = new BD1();
    Connection conexion = BD1.enlace();
    
    public DAOPersonas(){}
    
   public ResultSet getPersonas() {
    Statement statement;
    ResultSet resultSet = null;
    try {
        statement = conexion.createStatement();
        resultSet = statement.executeQuery("SELECT * FROM persona");
    } catch (SQLException ex) {
        System.out.println("Error en la consulta SQL: " + ex.getMessage());
        ex.printStackTrace();
    }
    return resultSet;
}
   
    public void insertarPersona(int id, String nombre) throws ExcepcionInsertVacio{
         String sqlQuery = "INSERT INTO persona (idpersona, nombre) VALUES (?,?)";

            try (PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
                statement.setInt(1, id);
                statement.setString(2, nombre);
                statement.executeUpdate();
       
            } catch (SQLException e) {
                throw new ExcepcionInsertVacio();
            }
    }
    
    public void borrarPersona(int idpersona, String nombre){
        try {
            String sqlQuery = "DELETE FROM persona WHERE idpersona = "+idpersona;
            PreparedStatement statement = conexion.prepareStatement(sqlQuery);
            statement.executeUpdate();
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
    }
    
    public void modificarPersona(int idAnterior, int nuevoId, String nombre) {
    String sqlQuery = "UPDATE persona SET idpersona = ?, nombre = ? WHERE idpersona = ?";
    try (PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
        statement.setInt(1, nuevoId);
        statement.setString(2, nombre);
        statement.setInt(3, idAnterior);
        statement.executeUpdate();
    } catch (SQLException ex) {
        System.out.println("Error al modificar la persona: " + ex.getMessage());
        ex.printStackTrace();
    }
    }
    
    public ResultSet cargarComboBox(JComboBox<String> combo){
        try {
        String query = "SELECT nombre FROM persona";
        Statement statement = conexion.createStatement();
        ResultSet resultSet = statement.executeQuery(query);

        while (resultSet.next()) {
            String nombrePersona = resultSet.getString("nombre");
            combo.addItem(nombrePersona);
        }

        return resultSet;
    } catch (SQLException ex) {
        System.out.println("Error al cargar el ComboBox");
        ex.printStackTrace();
    }

    return null;
   }
}
