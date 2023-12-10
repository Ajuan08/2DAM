
public class Excepcion2 {

	 void miMetodo() {
	        int numero[] = new int[5];
	        try {
	            System.out.println("Accediendo a una posición fuera del vector");
	            numero[7] = 0;
	        } catch (ArrayIndexOutOfBoundsException excep) {
	            System.out.println("Ocurrió una excepción: Acceso a una posición fuera del vector");
	        }
	    }
	}

	

//¿En qué método se genera la excepción?
	//Se genera en el método miMetodo().

//¿Qué método la captura?

//En el mismo metodo con el catch

//¿Vuelve el control del programa al main, después de la captura?

//Sí, después de capturar la excepción, el control del programa regresa al método main de la clase PruebaExcepcion2 ya que el método miMetodo() se ejecuta desde el main.