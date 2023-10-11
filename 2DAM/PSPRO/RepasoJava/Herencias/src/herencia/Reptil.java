package herencia;

public class Reptil extends Animal {

	private float temperatura;
	
	public Reptil (String nombre, String especie, float temperatura) 
	
	{
		super(nombre, especie);
		this.temperatura = temperatura;
	}

	@Override
	public String toString() {
		return super.toString()+ " Temperatura= "+temperatura + " grados";
	}

	@Override
	public void cualquiera() {
		
	}
	
	public float temperaturaMortal()
	{
		return temperatura * 0.80F;
	}
	
	
}
