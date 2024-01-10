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
import java.util.Collection;
import java.util.Collections;
import java.util.Comparator;
import javax.swing.JComboBox;

/**
 *
 * @author anton
 */
public class DAOLibros {
    BD1 bd = new BD1();
    Connection conexion = BD1.enlace();

    public DAOLibros() {
    }
    
   public ResultSet getLibros(){
        Statement statement;
        ResultSet resultset;
        try {
            statement=conexion.createStatement();
            resultset=statement.executeQuery("SELECT l.idlibros, l.nombre, categoria.nombre AS categoria FROM libros AS l LEFT JOIN categoria ON l.categoria = categoria.id");
            return resultset;
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
        
        return null;
    }
   
   
   
   public ResultSet cargarComboBox(JComboBox<String> combo){
        try {
        String query = "SELECT nombre FROM categoria";
        Statement statement = conexion.createStatement();
        ResultSet resultSet = statement.executeQuery(query);

        while (resultSet.next()) {
            String nombreCategoria = resultSet.getString("nombre");
            combo.addItem(nombreCategoria);
        }

        return resultSet;
    } catch (SQLException ex) {
        System.out.println("Error al cargar el ComboBox");
        ex.printStackTrace();
    }

    return null;
   }
   
   public void insertarLibro(int id, String nombre,int categoria){
         String sqlQuery = "INSERT INTO libros (idlibros, nombre,categoria) VALUES (?, ?,?)";

            try (PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
                statement.setInt(1, id);
                statement.setString(2, nombre);
                statement.setInt(3, categoria);
                statement.executeUpdate();
       
            } catch (SQLException e) {
                e.printStackTrace();
            }
    }
    
    public void borrarLibros(int idlibros, String nombre,int categoria){
        try {
            String sqlQuery = "DELETE FROM libros WHERE idlibros = "+idlibros;
            PreparedStatement statement = conexion.prepareStatement(sqlQuery);
            statement.executeUpdate();
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
    }
    
    public void modificarLibros(int idlibros, String nombre,int categoria){
        try {
            String sqlQuery = "UPDATE libros SET nombre = '"+nombre+"',categoria = '"+categoria+"' WHERE idlibros="+idlibros;
            PreparedStatement statement = conexion.prepareStatement(sqlQuery);
            statement.executeUpdate();
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
    }
    
}