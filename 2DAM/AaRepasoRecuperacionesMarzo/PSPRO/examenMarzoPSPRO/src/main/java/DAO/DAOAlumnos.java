/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAO;

import Conexion.BD1;
import Excepciones.ExcepcionDNIDuplicado;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author dam
 */
public class DAOAlumnos {
    BD1 bd1 = new BD1();
    Connection conexion = BD1.enlace();
    
    public DAOAlumnos() {}
    
    public ResultSet getAlumnos() {
    Statement statement;
    ResultSet resultSet = null;
    try {
        statement = conexion.createStatement();
        resultSet = statement.executeQuery("SELECT * FROM alumno");
    } catch (SQLException ex) {
        System.out.println("Error en la consulta SQL: " + ex.getMessage());
        ex.printStackTrace();
    }
    return resultSet;
    }
    
    public ResultSet getNotasAlumnos(int idAlumno) {
    try {
        String query = "SELECT * FROM notas WHERE idAlumno = ?";
        PreparedStatement statement = conexion.prepareStatement(query);
        statement.setInt(1, idAlumno);
        ResultSet resultSet = statement.executeQuery();
        return resultSet;
    } catch (SQLException ex) {
        System.out.println("Error al obtener los datos de la vivienda de la persona: " + ex.getMessage());
        ex.printStackTrace();
        return null;
    }
    }
    
    public void insertarAlumno(int id, String nombre, String dni) throws ExcepcionDNIDuplicado{
         String sqlQuery = "INSERT INTO alumno (idalumno, nombre, dni) VALUES (?,?,?)";

            try (PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
                statement.setInt(1, id);
                statement.setString(2, nombre);
                statement.setString(3, dni);
                statement.executeUpdate();
       
            } catch (SQLException e) {
                throw new ExcepcionDNIDuplicado();
            }
    }
    
    public boolean existeDNI(String dni) {
    String query = "SELECT COUNT(*) AS count FROM alumno WHERE dni = ?";
    try (PreparedStatement statement = conexion.prepareStatement(query)) {
        statement.setString(1, dni);
        ResultSet resultSet = statement.executeQuery();
        if (resultSet.next()) {
            int count = resultSet.getInt("count");
            return count > 0;
        }
    } catch (SQLException ex) {
        System.out.println("Error al verificar el DNI duplicado: " + ex.getMessage());
        ex.printStackTrace();
    }
    return false;
}
    
    
    public void modificarAlumno(int idAnterior, int nuevoId, String nombre, String dni) {
    String sqlQuery = "UPDATE alumno SET idalumno = ?, nombre = ?, dni = ? WHERE idalumno = ?";
    try (PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
        statement.setInt(1, nuevoId);
        statement.setString(2, nombre);
        statement.setString(3, dni);
        statement.setInt(4, idAnterior);
        statement.executeUpdate();
    } catch (SQLException ex) {
        System.out.println("Error al modificar la persona: " + ex.getMessage());
        ex.printStackTrace();
    }
    }
    
    public ResultSet getNotasAlumnosById(int idAlumno) {
    try {
        String query = "SELECT * FROM notas WHERE idAlumno = ?";
        PreparedStatement statement = conexion.prepareStatement(query);
        statement.setInt(1, idAlumno);
        ResultSet resultSet = statement.executeQuery();
        return resultSet;
    } catch (SQLException ex) {
        System.out.println("Error al obtener los datos de las notas del alumno: " + ex.getMessage());
        ex.printStackTrace();
        return null;
    }
}


    
}
