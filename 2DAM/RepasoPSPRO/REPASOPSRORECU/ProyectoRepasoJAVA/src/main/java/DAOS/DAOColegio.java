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
public class DAOColegio {
    
    BD1 bd1 = new BD1();
    Connection conexion = BD1.enlace();

    public DAOColegio() {
    }
    
    public ResultSet getColegio(){
        Statement statement;
        ResultSet resultset;
        try {
            statement=conexion.createStatement();
            resultset=statement.executeQuery("select * from colegio");
            return resultset;
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
        
        return null;
    } 
    
    public void EliminarColegio(int idColegio){
        try {
            String sqlQuery = "DELETE FROM colegio WHERE idColegio = "+idColegio;
            PreparedStatement statement = conexion.prepareStatement(sqlQuery);
            statement.executeUpdate();
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
    }
    
    public void DeshacerColegioEliminado(int idColegio, String nombre){
        String sqlQuery = "INSERT INTO colegio (idColegio, nombre) VALUES (?, ?)";

            try (PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
                statement.setInt(1, idColegio);
                statement.setString(2, nombre);
                statement.executeUpdate();
       
            } catch (SQLException e) {
                e.printStackTrace();
            }
    }
    
    public ResultSet getColegioAntesDeEliminar(int idColegio) {
        try {
            PreparedStatement statement = conexion.prepareStatement("SELECT * FROM colegio WHERE idColegio = ?");
            statement.setInt(1, idColegio);
            return statement.executeQuery();
        } catch (SQLException ex) {
            System.out.println("Error al obtener datos del colegio antes de eliminar");
            ex.printStackTrace();
        }
        return null;
    }
}
