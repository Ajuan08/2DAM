package Controller;

import java.util.List;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import Vista.PanelCRUD;
import java.sql.SQLException;
import java.sql.*;
import java.util.ArrayList;


public class ControllerCRUD
{
    public static void cargarTabla( JTable tablaVehiculos) throws SQLException {
        ResultSet rs = TestVehiculos.TestVehiculos.bdConnection.consulta();

        DefaultTableModel modelo=new DefaultTableModel();
        modelo.addColumn("Marca");
        modelo.addColumn("Modelo");
        modelo.addColumn("Matricula");
        modelo.addColumn("ID");
        
        Object[] registroLeido = new Object[4];
        while(rs.next()) {
            registroLeido[0] = rs.getString("id");
            registroLeido[1] = rs.getString("marca");
            registroLeido[2] = rs.getString("modelo");
            registroLeido[3] = rs.getString("matricula");
                        
            modelo.addRow(registroLeido);
        }
        tablaVehiculos.setModel(modelo);
    }
	
	
    public static void insertarVehiculo( PanelCRUD frmVehiculo, JTable tablaVehiculos) throws SQLException
    { 
        String marca = frmVehiculo.getTxtMarca().getText();
        String modelo = frmVehiculo.getTxtModelo().getText();
        String matricula = frmVehiculo.getTxtMatricula().getText();
        if (marca != "" && modelo != "" && matricula != "") {
            TestVehiculos.TestVehiculos.bdConnection.executeCommand("INSERT INTO vehiculos (id, marca, modelo, matricula) VALUES (null, '" + marca + "', '" + modelo + "', '" + matricula + "')");
        }
        cargarTabla(tablaVehiculos);		
    }
    
    public static void modificarVehiculo( PanelCRUD frmVehiculo, JTable tablaVehiculos, int id) throws SQLException
    {        
        String marca = frmVehiculo.getTxtMarca().getText();
        String modelo = frmVehiculo.getTxtModelo().getText();
        String matricula = frmVehiculo.getTxtMatricula().getText();
        
        if (marca != "" && modelo != "" && matricula != "") {
            TestVehiculos.TestVehiculos.bdConnection.executeCommand("UPDATE vehiculos SET marca = '" + marca + "', modelo = '" + modelo + "', matricula = '" + matricula + "' WHERE id = " + id);
        }
        cargarTabla(tablaVehiculos);		
    }
    
    public static void borrarVehiculo(JTable tablaVehiculos, int id) throws SQLException
    {
        if (id > 0) {
            TestVehiculos.TestVehiculos.bdConnection.executeCommand("DELETE FROM vehiculos WHERE id = "+id);
        }
        cargarTabla(tablaVehiculos);		
    }
	
    public static ArrayList obtainRowValue(PanelCRUD frmVehiculo) {
        int rowSelected = getRow(frmVehiculo);
        
        ArrayList<Object> registroLeido = new ArrayList<Object>(); 
        
        Object id = frmVehiculo.getTablaVehiculos().getValueAt(rowSelected, 0);
        Object marca = frmVehiculo.getTablaVehiculos().getValueAt(rowSelected, 1);
        Object modelo = frmVehiculo.getTablaVehiculos().getValueAt(rowSelected, 2);
        Object matricula = frmVehiculo.getTablaVehiculos().getValueAt(rowSelected, 3);
        
        registroLeido.add(id);
        registroLeido.add(marca);
        registroLeido.add(modelo);
        registroLeido.add(matricula);
        
        return registroLeido;
    }
    
    public static int getRow(PanelCRUD frmVehiculo) {
        return frmVehiculo.getTablaVehiculos().getSelectedRow();
    }
}
