import java.io.IOException;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.List;

public class ServidorCarrera {
    private static final int puerto = 2402;
    private static final int duracion_carrera_segundos = 60;

    public static void main(String[] args) {
        try {
            ServerSocket serverSocket = new ServerSocket(puerto);
            System.out.println("Servidor esperando conexiones...");

            List<Thread> threads = new ArrayList<>();

            
            long tiempoInicio = System.currentTimeMillis();
            long tiempoFinal = tiempoInicio + (duracion_carrera_segundos * 1000);

            while (System.currentTimeMillis() < tiempoFinal) {
                Socket clienteSocket = serverSocket.accept();
                HiloServidor hiloServidor = new HiloServidor(clienteSocket);
                threads.add(hiloServidor);
                hiloServidor.start();
            }
            for (Thread thread : threads) {
                thread.join();
            }
            serverSocket.close();
            System.out.println("Carrera finalizada.");

        } catch (IOException | InterruptedException e) {
            e.printStackTrace();
        }
    }
}
