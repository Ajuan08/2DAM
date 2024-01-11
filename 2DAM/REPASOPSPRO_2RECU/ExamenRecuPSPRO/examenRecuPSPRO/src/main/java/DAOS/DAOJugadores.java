/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOS;

import Conexion.BD1;
import com.mycompany.examenrecupspro.ConsultaErrorException;
import com.mycompany.examenrecupspro.ConsultaVaciaException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import javax.swing.JComboBox;

/**
 *
 * @author dam
 */
public class DAOJugadores {
    BD1 bd1 = new BD1();
    Connection conexion = BD1.enlace();
    private ArrayList<String> historialConsultas = new ArrayList<>();

    public DAOJugadores() {
    }
    
    public ResultSet getJugadores(){
        Statement statement;
        ResultSet resultset;
        try {
            statement=conexion.createStatement();
            resultset=statement.executeQuery("select * from jugadores");
            return resultset;
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
        
        return null;
    }
    
    
     public ResultSet realizarConsulta(String consulta) throws ConsultaVaciaException, ConsultaErrorException {
        try {
            Statement statement = conexion.createStatement();
            ResultSet resultSet = statement.executeQuery(consulta);

            if (!resultSet.next()) {
                throw new ConsultaVaciaException();
            }

            return resultSet;
        } catch (SQLException ex) {
            throw new ConsultaErrorException();
        }
    }
    
    public ArrayList<String> getHistorialConsultas() {
        return historialConsultas;
    }

    public void agregarConsultaAlHistorial(String consulta) {
        historialConsultas.add(consulta);
    }
    
    public ArrayList<String> obtenerJugadores(){
        
        return null;
        
    }
    
}