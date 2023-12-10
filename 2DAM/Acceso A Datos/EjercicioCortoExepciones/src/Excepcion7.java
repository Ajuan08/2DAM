
public class Excepcion7 {
    public static void generaExcepcion(int i) {
        int t;
        int num[] = {2, 4, 6};
        System.out.println("Recibiendo " + i);
        try {
            switch (i) {
                case 0:
                    t = 10 / i; 
                    break;
                case 1:
                    num[4] = 4;
                    break;
                case 2:
                    return;
            }
        } catch (ArithmeticException e) {
            System.out.println("Error: División por cero");
        } catch (ArrayIndexOutOfBoundsException e) {
            System.out.println("Error: Se ha ido fuera del array");
        } finally {
            System.out.println(" ");
        }
    }
}
