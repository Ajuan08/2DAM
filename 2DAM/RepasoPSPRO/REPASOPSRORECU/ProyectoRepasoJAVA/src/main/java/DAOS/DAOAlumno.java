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

/**
 *
 * @author anton
 */
public class DAOAlumno {
    
    BD1 bd1 = new BD1();
    Connection conexion = BD1.enlace();

    public DAOAlumno() {
    }
    
    public void InsertarAlumno(int idColegio, String nombre, int edad, boolean feo ){
       
            String sqlQuery = "INSERT INTO alumnos (idColegio, Nombre, Edad, Feo) VALUES (?, ?, ?, ?)";

            try (PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
                statement.setInt(1, idColegio);
                statement.setString(2, nombre);
                statement.setInt(3, edad);
                statement.setBoolean(4, feo);
                statement.executeUpdate();
       
            } catch (SQLException e) {
                e.printStackTrace();
            }
    }
    
    public ResultSet getAlumnos(int codigoColegio){
        Statement statement;
        ResultSet resultset;
        try {
            statement=conexion.createStatement();
            resultset=statement.executeQuery("select * from alumnos where idColegio = " + codigoColegio);
            return resultset;
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
        
        return null;
    } 
    
    public boolean ComprobarAlumnosFeos(int codigoColegio){
        
        Statement statement;
        ResultSet resultset;
        boolean hayfeo = false;
        try {
            statement=conexion.createStatement();
            resultset=statement.executeQuery("select * from alumnos where idColegio = " + codigoColegio);
            while(resultset.next()) {
                if(resultset.getBoolean("feo")){
                    hayfeo = true;
                }
            
            }
            return hayfeo;
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
        
        return false;
        
    }
}
