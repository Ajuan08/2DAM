/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.psproexamen;

import Conexion.BD1;
import Vista.VistaPrincipal;
import java.awt.EventQueue;

/**
 *
 * @author dam
 */
public class PSPROExamen {

    public static  BD1 bdConnection;
    public static void main(String[] args) {
        EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {
                    Vista.VistaPrincipal frame = new VistaPrincipal();
                    frame.setVisible(true);
                    bdConnection = new BD1();
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
    }
}
