import java.io.DataInputStream;
import java.io.DataOutput;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.ArrayList;

public class HiloServidor extends Thread {
	
	DataInputStream fentrada;
	DataOutputStream fsalida;
	
	Socket socket = null;
	
	ArrayList<Socket> arraySocket = new ArrayList<Socket>();
	
	public HiloServidor(Socket socket, ArrayList<Socket> array) {
		this.socket = socket;
		this.arraySocket = array;
	}
	
	
	
	public void run() {
		
		try {
			fentrada = new DataInputStream(socket.getInputStream());
			fsalida = new DataOutputStream(socket.getOutputStream());
		}catch(IOException e) {
			e.printStackTrace();
		}
	}

}
