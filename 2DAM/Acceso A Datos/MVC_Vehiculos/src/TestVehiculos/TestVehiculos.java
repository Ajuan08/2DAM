package TestVehiculos;

import java.awt.EventQueue;

import Vista.VentanaPrincipal;
import Vista.VentanaPrincipal;
import bd.BD1;

public class TestVehiculos {

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
                BD1 bd = new BS1();
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaPrincipal frame = new VentanaPrincipal();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	

	}

}
