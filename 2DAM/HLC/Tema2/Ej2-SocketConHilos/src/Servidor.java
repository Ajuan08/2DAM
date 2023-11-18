import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor {
	public static void main(String[] args) {
        try{
            ServerSocket servidor;
            servidor = new ServerSocket(90);
            System.out.println("Servidor escuchando peticiones....");
            while (true) {
                Socket cliente = servidor.accept();
                HiloServidor hilo = new HiloServidor(cliente);
                hilo.start();
            }
        }catch(IOException ex){
            System.err.println(ex.getMessage());
        }
    }
}
