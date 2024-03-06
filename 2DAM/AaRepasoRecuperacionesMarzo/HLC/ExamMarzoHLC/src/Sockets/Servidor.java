package Sockets;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor {

	public static void main(String[] args) {
		
		try {
			ServerSocket serverSocket = new ServerSocket(2000);
			System.out.println("Servidor esperando clientes en el puerto 2000");
			
			while(true) {
				Socket clienteSocket;
				clienteSocket = serverSocket.accept();
				
				HiloServidor hiloServidor = new HiloServidor(clienteSocket);
				hiloServidor.run();
			}
		} catch (IOException e) {
			e.printStackTrace();
		}

	}

}
