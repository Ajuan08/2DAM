import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;

public class ServidorMain {
	
	public static void main(String[] args) throws IOException{
		
		int puerto = 12345;
		int conexion = 0;
		int maximo = 5;
		ServerSocket servidor = new ServerSocket(puerto);
		
		ArrayList<Socket> arraySocket = new ArrayList<Socket>();
		
		while(conexion < maximo) {
			conexion++;
			Socket socket = new Socket();
			socket = servidor.accept();
			arraySocket.add(socket);
			
			HiloServidor hilo = new HiloServidor(socket, arraySocket);
			hilo.start();
		}
	}
	
	

}
