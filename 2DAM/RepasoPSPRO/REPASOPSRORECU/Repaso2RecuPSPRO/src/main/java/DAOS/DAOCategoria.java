/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOS;

import Conexion.BD1;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author anton
 */
public class DAOCategoria {
    BD1 bd1 = new BD1();
    Connection conexion = BD1.enlace();

    public DAOCategoria() {
    }
    
    public ResultSet getCategoria(){
        Statement statement;
        ResultSet resultset;
        try {
            statement=conexion.createStatement();
            resultset=statement.executeQuery("select * from categoria");
            return resultset;
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
        
        return null;
    } 
    
    public void insertarCategoria(int id, String nombre){
         String sqlQuery = "INSERT INTO categoria (id, nombre) VALUES (?, ?)";

            try (PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
                statement.setInt(1, id);
                statement.setString(2, nombre);
                statement.executeUpdate();
       
            } catch (SQLException e) {
                e.printStackTrace();
            }
    }
    
    public void borrarCategoria(int id, String nombre){
        try {
            String sqlQuery = "DELETE FROM categoria WHERE id = "+id;
            PreparedStatement statement = conexion.prepareStatement(sqlQuery);
            statement.executeUpdate();
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
    }
    
    public void modificarCategoria(int id, String nombre){
        try {
            String sqlQuery = "UPDATE categoria SET nombre = '"+nombre+"' WHERE id="+id;
            PreparedStatement statement = conexion.prepareStatement(sqlQuery);
            statement.executeUpdate();
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
    }
    
    public void listadoOrdenado(){
    ArrayList<String> lista = new ArrayList<String>();
    try {
        String query = "SELECT nombre FROM categoria";
        Statement statement = conexion.createStatement();
        ResultSet resultSet = statement.executeQuery(query);

        while(resultSet.next()) {
            String nombre = resultSet.getString("nombre");       
            lista.add(nombre);
        }

        Collections.sort(lista, String.CASE_INSENSITIVE_ORDER);

        for (String cadena : lista) {
            System.out.println(cadena);
        }
    } catch(Exception e) {
        e.printStackTrace();
    }  
}
       
}
