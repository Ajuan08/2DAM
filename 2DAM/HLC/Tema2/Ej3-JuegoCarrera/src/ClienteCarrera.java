import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.util.Scanner;

public class ClienteCarrera {
    private static final String servidor_ip = "localhost";
    private static final int puerto = 2402;

    public static void main(String[] args) {
        try {
            Socket socket = new Socket(servidor_ip, puerto);

            ObjectOutputStream salida = new ObjectOutputStream(socket.getOutputStream());
            ObjectInputStream entrada = new ObjectInputStream(socket.getInputStream());

            Thread hiloInterfaz = new Thread(() -> {
                Scanner scanner = new Scanner(System.in);

                while (true) {
                    System.out.println("Ingrese el movimiento (izquierda/derecha): ");
                    String movimiento = scanner.nextLine();

                    try {
                        salida.writeObject(movimiento);
                    } catch (IOException e) {
                        e.printStackTrace();
                    }
                }
            });
            hiloInterfaz.start();

            Thread hiloCliente = new Thread(() -> {
                try {
                    while (true) {
                        String mensaje = (String) entrada.readObject();
                        System.out.println("Actualización del servidor: " + mensaje);
                    }
                } catch (IOException | ClassNotFoundException e) {
                    e.printStackTrace();
                }
            });
            hiloCliente.start();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
