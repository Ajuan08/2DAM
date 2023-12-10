
public class Excepcion4 {
    static void divide() {
        int num[] = {4, 8, 16, 32, 64, 128, 256};
        int den[] = {2, 0, 4, 4, 0, 8};
        for (int i = 0; i < num.length + 1; i++) {
            try {
                System.out.println(num[i] + "/" + den[i] + "=" + num[i] / den[i]);
            } catch (ArithmeticException e) {
                System.out.println("Error: División por cero");
            } catch (ArrayIndexOutOfBoundsException e) {
                System.out.println("Error: Se ha ido fuera del array");
            }
        }
    }
}