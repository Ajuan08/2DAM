import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.Socket;

public class ClienteWeb {
    public static void main(String[] args) {
        try {
            Socket socket = new Socket("localhost", 90);
            socket.getOutputStream().write("GET /index.html HTTP/1.1\r\n\r\n".getBytes());

            BufferedReader reader = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            String line;
            while ((line = reader.readLine()) != null) {
                System.out.println(line);
            }

            socket.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
