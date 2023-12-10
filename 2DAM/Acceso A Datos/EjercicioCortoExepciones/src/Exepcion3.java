
public class Exepcion3 {

	static void divide() {
        int num[] = {4, 8, 16, 32, 64, 128, 256};
        int den[] = {2, 0, 4, 4, 0, 8, 16};
        for (int i = 0; i < num.length; i++) {
            try {
                System.out.println(num[i] + "/" + den[i] + "=" + num[i] / den[i]);
            } catch (java.lang.ArithmeticException excepcion) {
                System.out.println("Dividiendo por cero");
            }
        }
    }
}

// ¿Qué ocurre después de que el programa responde a un error?

//Que se seguira ejecutando el bucle for hasta que se complete