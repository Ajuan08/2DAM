package Sockets;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class Cliente {

	public static void main(String[] args) {
		
		try {
			Socket cliente = new Socket("localhost",2000);
			
			PrintWriter flujoSalida = new PrintWriter(cliente.getOutputStream());
			
			BufferedReader flujoEntrada = new BufferedReader(new InputStreamReader(cliente.getInputStream()));
			
			String cadenaTexto = "";
			System.out.println("Introduce la cadena de texto que quieras pasarle");
			flujoEntrada.readLine();
			
			cliente.close();
			
		}catch (IOException e) {
			e.printStackTrace();
		}
	}

}
