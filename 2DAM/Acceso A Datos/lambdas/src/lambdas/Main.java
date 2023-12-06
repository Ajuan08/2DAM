package lambdas;

public class Main {

	public static void main(String[] args) {
		// 1.- Crear una función anónima que nos permita calcular el promedio de un arreglo de números enteros.
		Interfaz mediaEnteros = (int... numeros) -> {
			if (numeros.length == 0) {
                return 0;
            }

            int suma = 0;
            
            for (int numero : numeros) {
                suma += numero;
            }

            return (double) suma / numeros.length;
		};
		
		System.out.println(mediaEnteros.calcular(1, 2, 3, 4));
		
		
		// 2.-Crear una función anónima que calcule el factorial dado un número entero.
		Interfaz factorial = (int... numeros) -> {
			int factorialNumero = 1;
			
            for (int numero = numeros[0]; numero > 1; numero--) {
                factorialNumero *= numero;
            }

            return factorialNumero;
		};
		
		System.out.println(factorial.calcular(4));
		
		
		// 3.-Crear una función anónima que permita conocer si un número es par.
		Interfaz numeroPar = (int... numeros) -> numeros[0] % 2 == 0;
		
		System.out.println(numeroPar.calcular(3));
		
		
		// 4.-Dado un arreglo de números enteros, crear una función anónima que retorne el número mayor.
		Interfaz numeroMayor = (int... numeros) -> {
			if (numeros.length == 0) {
                return null;
            }

            int mayor = numeros[0];
            
            for (int numero : numeros) {
                if (numero > mayor) mayor = numero;
            }

            return mayor;
		};
		
		Object mayor = numeroMayor.calcular(3, 5, 2, 4, 6);
		
		if (mayor == null) {
			System.out.println("No ha introducido ningún número");
		} else {
			System.out.println(mayor);
		}
		
		
		// 5.-Dado un arreglo de números enteros, crear una función anónima que retorne el número menor.
		Interfaz numeroMenor = (int... numeros) -> {
			if (numeros.length == 0) {
                return null;
            }

            int menor = numeros[0];
            
            for (int numero : numeros) {
                if (numero < menor) menor = numero;
            }

            return menor;
		};
		
		Object menor = numeroMenor.calcular(2, 4, 6, 4, 5);
		
		if (menor == null) {
			System.out.println("No ha introducido ningún número");
		} else {
			System.out.println(menor);
		}
		
		
		// 6.-Dado un arreglo de números enteros, crear una función anónima que retorne el número que más se repite.
		Interfaz moda = (int... numeros) -> {
			if (numeros.length == 0) {
                return null;
            }

            int numeroModa = 0;
            int contNumeroModa = 0;
            
            for (int numero : numeros) {
                int cont = 0;
                
                for (int numeroBucle : numeros) {
                	if (numeroBucle == numero) cont++;
                }
                
                if (cont > contNumeroModa) {
                	numeroModa = numero;
                	contNumeroModa = cont;
                }
            }

            return numeroModa;
		};
		
		Object numeroModa = moda.calcular(1, 2, 2, 5, 6, 3, 2, 1);
		
		if (numeroModa == null) {
			System.out.println("No ha introducido ningún número");
		} else {
			System.out.println(numeroModa);
		}
		
		
		// 7.-Crear una función anónima que reciba como parámetro 3 numeros enteros. La función retorna el número mayor.
		InterfazNumMayor numeroMayorEntre3 = (int num1, int num2, int num3) -> {
			int numMayor = num1;			
            
            if (num2 > numMayor) numMayor = num2;
            if (num3 > numMayor) numMayor = num3;

            return numMayor;
		};
		
		int numMayor = numeroMayorEntre3.obtenerMayor(10, 2, 24);
		
		System.out.println(numMayor);
		
		
		// 8.-Crear una función anónima que reciba dos parámetros, un String y un numero entero. La función retorna un String el cual será el resultado de multiplicar ambos parámetros.
		InterfazMultiplicacion multiplicacion = (String cadena, int numero) -> {
			String cadenaMultiplicacion = "";
			
			for (int i = 0; i < numero; i++) {
				cadenaMultiplicacion += cadena;
			}
			
			return cadenaMultiplicacion;
		};
		
		System.out.println(multiplicacion.multiplicar("prueba ", 3));
	}

}
