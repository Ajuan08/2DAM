/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Controller;

import java.sql.SQLException;
import javax.swing.JTable;
import Vista.VistaPrincipal;
import java.sql.ResultSet;
import javax.swing.table.DefaultTableModel;
/**
 *
 * @author dam
 */
public class ControllerCRUD {

    private static JTable tablavivienda;
    
    public static void cargarTabla( JTable tablavivienda) throws SQLException {
        ResultSet rs = com.mycompany.psproexamen.PSPROExamen.bdConnection.consulta();

        DefaultTableModel modelo=new DefaultTableModel();
        modelo.addColumn("Código");
        modelo.addColumn("Piso");
        modelo.addColumn("Letra");
        modelo.addColumn("Propietario");
        modelo.addColumn("Tarifa");
        modelo.addColumn("Moroso");
        
        Object[] registroLeido = new Object[6];
        while(rs.next()) {
            registroLeido[0] = rs.getString("idvivienda");
            registroLeido[1] = rs.getString("piso");
            registroLeido[2] = rs.getString("letra");
            registroLeido[3] = rs.getString("propietario");
            registroLeido[4] = rs.getString("tarifa");
            registroLeido[5] = rs.getString("moroso");
                        
            modelo.addRow(registroLeido);
        }
        tablavivienda.setModel(modelo);
    }
    
    public static void anadirPropietario(VistaPrincipal vista, JTable tabla1) throws SQLException{
        String codigo = vista.getTxtCodigo().getText();
        String piso = vista.getTxtPiso().getText();
        String letra = vista.getTxtLetra().getText();
        String propietario = vista.getTxtPropietario().getText();
        String tarifa = vista.getTxtTarifa().getText();
        String moroso = vista.getTxtMoroso().getText();
        if (codigo != "" && piso != "" && letra != "" && propietario != "" && tarifa != "" && moroso != "") {
            com.mycompany.psproexamen.PSPROExamen.bdConnection.executeCommand("INSERT INTO vivienda (idvivienda, piso, letra, propietario, tarifa, moroso) VALUES ('" + codigo + "', '" + piso + "', '" + letra + "', '" + propietario + "', '" + tarifa + "','" + moroso + "')");
        }
        cargarTabla(tablavivienda);	
    }
    
}
