package Vista;


import javax.swing.GroupLayout;
import javax.swing.LayoutStyle;

import Controller.ControllerCRUD;
import static Controller.ControllerCRUD.obtainRowValue;
import java.awt.event.ActionEvent;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JTable;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Luis
 */
public class PanelCRUD extends javax.swing.JPanel {

    private ControllerCRUD controller;
    
    public PanelCRUD() {
        initComponents();
        this.inicializarPanel();
        try {  
            ControllerCRUD.cargarTabla(tablaVehiculos);
        } catch (SQLException ex) {
            Logger.getLogger(PanelCRUD.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

 
    private void txtModeloActionPerformed(java.awt.event.ActionEvent evt) {
        // TODO add your handling code here:
    }										



    private void btRegistrarActionPerformed(java.awt.event.ActionEvent evt) throws SQLException {
        ControllerCRUD.insertarVehiculo(this, tablaVehiculos);
    }										

    private void btModificarActionPerformed(ActionEvent evt) throws SQLException {
        String id = tablaVehiculos.getValueAt(ControllerCRUD.getRow(this), 0).toString();
        int sendedId = Integer.parseInt(id);
        ControllerCRUD.modificarVehiculo(this, tablaVehiculos, sendedId);
    }
    
    private void btBorrarActionPerformed(ActionEvent evt) throws SQLException {
        String id = tablaVehiculos.getValueAt(ControllerCRUD.getRow(this), 0).toString();
        int sendedId = Integer.parseInt(id);
        ControllerCRUD.borrarVehiculo(tablaVehiculos, sendedId);
    }
    
    private void btSeleccionarActionPerformed(ActionEvent evt) {
        ArrayList<Object> registroLeido = obtainRowValue(this);
        
        txtMarca.setText(registroLeido.get(1).toString());
        txtModelo.setText(registroLeido.get(2).toString());
        txtMatricula.setText(registroLeido.get(3).toString());
    }
    
    private void btLeerActionPerformed(ActionEvent evt) {
        //TODO:
    }

    public javax.swing.JTextField getTxtMatricula() {
        return txtMatricula;
    }

    public JTable getTablaVehiculos() {
        return tablaVehiculos;
    }

    public void setTablaVehiculos(JTable tablaVehiculos) {
        this.tablaVehiculos = tablaVehiculos;
    }

    

    public void setTxtMatricula(javax.swing.JTextField txtMatricula) {
        this.txtMatricula = txtMatricula;
    }



    public javax.swing.JTextField getTxtMarca() {
        return txtMarca;
    }



    public void setTxtMarca(javax.swing.JTextField txtMarca) {
        this.txtMarca = txtMarca;
    }



    public javax.swing.JTextField getTxtModelo() {
            return txtModelo;
    }



    public void setTxtModelo(javax.swing.JTextField txtModelo) {
            this.txtModelo = txtModelo;
    }

private javax.swing.JButton btLeer;
 
private javax.swing.JButton btRegistrar;

private javax.swing.JButton btModificar;

private javax.swing.JButton btBorrar;

private javax.swing.JButton btSeleccionar;
 
private javax.swing.JLabel jLabel1;
 
private javax.swing.JLabel jLabel2;
 
private javax.swing.JLabel jLabelMatricula;
 
private javax.swing.JScrollPane jScrollPane1;
 
private javax.swing.JTable tablaVehiculos;
 
private javax.swing.JTextField txtMatricula;
 
private javax.swing.JTextField txtMarca;
 
private javax.swing.JTextField txtModelo;
    /**
     * Creates new form PanelCRUD
     */
 
    
    
    
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 547, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 386, Short.MAX_VALUE)
        );
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables


private void inicializarPanel() {
	 jLabel1 = new javax.swing.JLabel();
 
	 jScrollPane1 = new javax.swing.JScrollPane();
 
	 tablaVehiculos = new javax.swing.JTable();
 
	 txtMarca = new javax.swing.JTextField();
 
	 txtModelo = new javax.swing.JTextField();
 
	 jLabel2 = new javax.swing.JLabel();
 
	 jLabelMatricula = new javax.swing.JLabel();
 
	 txtMatricula = new javax.swing.JTextField();
 
	 btRegistrar = new javax.swing.JButton();
 
	 btLeer = new javax.swing.JButton();
         
         btSeleccionar = new javax.swing.JButton();
         
         btModificar = new javax.swing.JButton();
         
         btBorrar = new javax.swing.JButton();
         
	 jLabel1.setText("Marca");
         
	 tablaVehiculos.setModel(new javax.swing.table.DefaultTableModel(
 
		 new Object [][] {
 
			 {null, null, null, null},
 
			 {null, null, null, null},
 
			 {null, null, null, null},
 
			 {null, null, null, null}
 
		 },
 
		 new String [] {
 
			 "Title 1", "Title 2", "Title 3", "Title 4"
 
		 }
 
	 ));
 
	 jScrollPane1.setViewportView(tablaVehiculos);
 
	 txtMarca.setName("marca"); // NOI18N
 
	 txtModelo.setToolTipText("");
 
	 txtModelo.setName("modelo"); // NOI18N
 
	 txtModelo.addActionListener(new java.awt.event.ActionListener() {
 
		 public void actionPerformed(java.awt.event.ActionEvent evt) {
 
			 txtModeloActionPerformed(evt);
 
		 }
 
	 });
 
 
 
	 jLabel2.setText("Modelo");
 
	 jLabelMatricula.setText("Matricula");
 
	 txtMatricula.setToolTipText("");
 
	 btRegistrar.setText("Registrar");
	 btRegistrar.setActionCommand("btRegistrar");
	 btRegistrar.setName("btRegistrar"); // NOI18N
	 btRegistrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                try {
                    btRegistrarActionPerformed(evt);
                } catch (SQLException ex) {
                    Logger.getLogger(PanelCRUD.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
	 });
 
         btModificar.setText("Modificar");
         btModificar.setActionCommand("btModificar");
         btModificar.setName("btModificar");
         btModificar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                try {
                    btModificarActionPerformed(evt);
                } catch (SQLException ex) {
                    Logger.getLogger(PanelCRUD.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
	 });
         
         btBorrar.setText("Borrar");
         btBorrar.setActionCommand("btBorrar");
         btBorrar.setName("btBorrar");
         btBorrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                try {
                    btBorrarActionPerformed(evt);
                } catch (SQLException ex) {
                    Logger.getLogger(PanelCRUD.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
	 });
 
	 btLeer.setText("Leer");
         btLeer.setActionCommand("btLeer");
	 btLeer.setName("btLeer"); // NOI18N
         btLeer.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                    btLeerActionPerformed(evt);
            }
	 });
         
         btSeleccionar.setText("Seleccionar");
         btSeleccionar.setActionCommand("btSeleccionar");
	 btSeleccionar.setName("btLeer"); // NOI18N
         btSeleccionar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                    btSeleccionarActionPerformed(evt);
            }
	 });
 
 
 
	 javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
	 layout.setHorizontalGroup(
	 	layout.createParallelGroup(GroupLayout.Alignment.LEADING)
	 		.addGroup(layout.createSequentialGroup()
	 			.addContainerGap()
	 			.addGroup(layout.createParallelGroup(GroupLayout.Alignment.LEADING)
	 				.addComponent(jScrollPane1, GroupLayout.PREFERRED_SIZE, 375, GroupLayout.PREFERRED_SIZE)
	 				.addGroup(layout.createSequentialGroup()
	 					.addGroup(layout.createParallelGroup(GroupLayout.Alignment.LEADING)
	 						.addComponent(jLabel1)
	 						.addComponent(jLabel2)
	 						.addComponent(jLabelMatricula))
	 					.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
	 					.addGroup(layout.createParallelGroup(GroupLayout.Alignment.LEADING)
	 						.addComponent(txtModelo)
	 						.addGroup(layout.createParallelGroup(GroupLayout.Alignment.LEADING, false)
	 							.addComponent(txtMarca)
	 							.addComponent(txtMatricula, GroupLayout.DEFAULT_SIZE, 196, Short.MAX_VALUE)))
	 					.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED, 49, Short.MAX_VALUE)
	 					.addGroup(layout.createParallelGroup(GroupLayout.Alignment.LEADING, false)
	 						.addComponent(btRegistrar, GroupLayout.DEFAULT_SIZE, GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
	 						.addComponent(btLeer, GroupLayout.DEFAULT_SIZE, GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                                        .addComponent(btModificar, GroupLayout.DEFAULT_SIZE, GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                                        .addComponent(btBorrar, GroupLayout.DEFAULT_SIZE, GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                                        .addComponent(btSeleccionar, GroupLayout.DEFAULT_SIZE, GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
	 			.addContainerGap(GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
	 );
	 layout.setVerticalGroup(
	 	layout.createParallelGroup(GroupLayout.Alignment.LEADING)
	 		.addGroup(layout.createSequentialGroup()
	 			.addContainerGap()
	 			.addGroup(layout.createParallelGroup(GroupLayout.Alignment.LEADING)
	 				.addGroup(layout.createParallelGroup(GroupLayout.Alignment.BASELINE)
	 					.addComponent(jLabel1)
	 					.addComponent(txtMarca, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
	 				.addComponent(btRegistrar))
	 			.addGroup(layout.createParallelGroup(GroupLayout.Alignment.LEADING)
	 				.addGroup(layout.createSequentialGroup()
	 					.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
	 					.addGroup(layout.createParallelGroup(GroupLayout.Alignment.BASELINE)
	 						.addComponent(jLabel2)
	 						.addComponent(txtModelo, GroupLayout.PREFERRED_SIZE, 25, GroupLayout.PREFERRED_SIZE))
	 					.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
	 					.addGroup(layout.createParallelGroup(GroupLayout.Alignment.BASELINE)
	 						.addComponent(jLabelMatricula)
	 						.addComponent(txtMatricula, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
                                            .addGroup(layout.createSequentialGroup()
	 					.addGap(15)
	 					.addComponent(btLeer)
                                                .addGap(15)
                                                .addComponent(btModificar)
                                                .addGap(15)
                                                .addComponent(btBorrar)
                                                .addGap(15)
	 					.addComponent(btSeleccionar)))
                                
	 			.addGap(26)
	 			.addComponent(jScrollPane1, GroupLayout.PREFERRED_SIZE, 181, GroupLayout.PREFERRED_SIZE)
	 			.addContainerGap(32, Short.MAX_VALUE))
	 );
 
	 this.setLayout(layout);
 
 
 
	 
 
}// </editor-fold>
}
