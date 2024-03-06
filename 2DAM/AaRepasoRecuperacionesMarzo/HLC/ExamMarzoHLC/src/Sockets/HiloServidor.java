package Sockets;
import java.net.Socket;

public class HiloServidor extends Thread{

	Socket cliente;
	
	
	public HiloServidor(Socket cliente) {
		this.cliente = cliente;
	}
	
	
	public void run() {
		String cadenaTexto = "";
	}
	
}
