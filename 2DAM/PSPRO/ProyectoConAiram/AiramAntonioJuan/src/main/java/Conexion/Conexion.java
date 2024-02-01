/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Conexion;

/**
 *
 * @author USUARIO
 */
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.sql.Connection;
import java.sql.DriverManager;


public class Conexion {

    static Connection conn=null;
    static Statement st=null;
    static ResultSet rs=null;
    static String bd="gesLibros";
    static String login="root";
    static String password="";  
    static String url="jdbc:mysql://localhost/"+bd;

    
    public static Connection enlace() 
    {
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            conn=DriverManager.getConnection(url,login,password);
            System.out.println("Conectado");
        } catch (SQLException ex) {
            System.out.println("Excepcion en la conexión");
        } catch (ClassNotFoundException ex) {
            System.out.println("No se encuentra la clase");
        }
        return conn;
    }
    
    public static ResultSet consulta(String command) {
        conn = enlace();
        try {
            st=conn.createStatement();
        } catch (SQLException ex) {
            System.out.println("excepcion");
        }
        try {
            rs=st.executeQuery(command);
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
        
        return rs;
    }
    
    public static void executeCommand(String command) {
        conn = enlace();
        try {
            st=conn.createStatement();
        } catch (SQLException ex) {
            System.out.println("excepcion al crear statement");
        }
        try {
            st.executeUpdate(command);
        } catch (SQLException ex) {
           System.out.println("error en el comando");
           ex.printStackTrace();
        }
    }


     public static void imprimirConsulta(ResultSet rs){
        try {
            while (rs.next()){
                System.out.print(rs.getInt(1)+"    ");
                System.out.print(rs.getString("marca")+"     ");
                System.out.print(rs.getString("modelo")+"     ");
                System.out.println(rs.getString("matricula"));
            }
        } catch (SQLException ex) {
            System.out.println("Error en el resultset");
            ex.printStackTrace();
        }
     }
     
     public static void cerrarSesion() {
        try {
            rs.close();
            st.close();
            conn.close();
        } catch (SQLException ex) {
            Logger.getLogger(Conexion.class.getName()).log(Level.SEVERE, null, ex);
        }
     }
}
