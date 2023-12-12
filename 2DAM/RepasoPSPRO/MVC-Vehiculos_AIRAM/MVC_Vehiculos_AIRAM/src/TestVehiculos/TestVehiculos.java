package TestVehiculos;

import Conexion.BD1;
import java.awt.EventQueue;
import Vista.VentanaPrincipal;

public class TestVehiculos {
    /**
     * Launch the application.
     */
    public static  BD1 bdConnection;
    public static void main(String[] args) {
        EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {
                    VentanaPrincipal frame = new VentanaPrincipal();
                    frame.setVisible(true);
                    bdConnection = new BD1();
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
    }
}
