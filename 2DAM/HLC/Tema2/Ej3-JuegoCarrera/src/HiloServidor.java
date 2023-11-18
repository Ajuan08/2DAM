import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;

public class HiloServidor extends Thread {
    private static int contadorCoche = 0;
    private Socket clienteSocket;
    private int idCoche;

    public HiloServidor(Socket clienteSocket) {
        this.clienteSocket = clienteSocket;
        this.idCoche = ++contadorCoche;
    }

    @Override
    public void run() {
        try {
            System.out.println("Nuevo coche conectado - ID: " + idCoche);

            ObjectOutputStream salida = new ObjectOutputStream(clienteSocket.getOutputStream());
            ObjectInputStream entrada = new ObjectInputStream(clienteSocket.getInputStream());

            while (true) {
                
                String movimiento = (String) entrada.readObject();
                System.out.println("Coche " + idCoche + " - Movimiento: " + movimiento);

                for (int i = 1; i <= contadorCoche; i++) {
                    if (i != idCoche) {
                        salida.writeObject("Coche " + i + " - Movimiento: " + movimiento);
                    }
                }
            }
        } catch (Exception e) {
            System.out.println("Coche " + idCoche + " desconectado.");
        }
    }
}
