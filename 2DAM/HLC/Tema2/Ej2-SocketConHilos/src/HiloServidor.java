import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.Socket;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class HiloServidor extends Thread {
    private Socket clienteSocket;

    public HiloServidor(Socket clienteSocket) {
        this.clienteSocket = clienteSocket;
    }

    @Override
    public void run() {
        try {
            BufferedReader entradaDesdeCliente = new BufferedReader(new InputStreamReader(clienteSocket.getInputStream()));
            OutputStream salidaCliente = clienteSocket.getOutputStream();

            String mensajeDesdeCliente = entradaDesdeCliente.readLine();

            if (mensajeDesdeCliente.startsWith("GET")) {
                String[] partes = mensajeDesdeCliente.split(" ");
                String url = partes[1].substring(1);

                Path rutaArchivo = Paths.get(url);

                if (Files.exists(rutaArchivo)) {
                    String contenido = new String(Files.readAllBytes(rutaArchivo));
                    String respuesta = "HTTP/1.1 200 OK\r\n\r\n" + contenido;
                    salidaCliente.write(respuesta.getBytes());
                } else {
                    String respuesta = "HTTP/1.1 404 Not Found\r\n\r\n";
                    salidaCliente.write(respuesta.getBytes());
                }
            }

            clienteSocket.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
