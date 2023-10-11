package herencia;

public class TestAnimal {

	public static void main(String[] args) {
		//
		//System.out.println(a.toString());
		
		
		Animal zoo[] = {new Reptil("Alvaro","Gecko",24),new Mamifero("Lucia","Ballena",2)};
		
		
		for(Animal animal:zoo) 
		{
			System.out.println(animal);
			if(animal instanceof Reptil) 
			{
				Reptil reptil = (Reptil) animal;
				System.out.println(reptil.temperaturaMortal());
			}
		}
		
	}

}
