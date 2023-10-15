package museo.museo;

import java.time.LocalDate;
import java.util.Scanner;

public class Vista {

	public int elegirOpcion(String ... opciones) {
		int ind,opcion=0;
		Scanner scanner = new Scanner (System.in);
		
		for ( ind=0; ind<opciones.length; ind++)
			System.out.println((ind+1) +" - " + opciones[ind]);
		
		System.out.println((ind+1) +" - Salir");
		
		System.out.println("\n\n Elija opcion: ");
		
		do{
			opcion = scanner.nextInt();
			
			
		}while(opcion>opciones.length);
		
		return opcion;
	}

	public void mostrar(Catalogo catalogo) {
		System.out.println(catalogo);
		
	}

	public Obra leerObra() {
		
		
		Artista artista = new Artista ("Silvia","Guijo", LocalDate.of(2002, 12, 30),null);
		Obra pintura = new Pintura("Mona Lisa",3,artista,2022,24,24,"Lienzo");
		
		return pintura;
	}

	public int pedirNumInventario() {
		
		Scanner scanner = new Scanner (System.in);
		System.out.println("Introduzca n�mero de inventario");
		return scanner.nextInt();
	}
	
	
	

}