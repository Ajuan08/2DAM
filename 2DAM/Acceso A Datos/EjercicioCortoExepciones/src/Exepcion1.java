
public class Exepcion1 {

	 public static void main(String args[]) {
	        try {
	            int numero[] = new int[5];
	            numero[7] = 0;
	        } catch (ArrayIndexOutOfBoundsException excep) {
	            System.out.println("Se ha producido un error!");
	        }
	    }
}
