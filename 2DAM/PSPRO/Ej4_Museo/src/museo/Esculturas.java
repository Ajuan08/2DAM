package museo;

import java.time.LocalDate;

public class Esculturas extends ObrasArtisticas {
	
	private String material;
	private Integer altura;
	
	public Esculturas(String titulo, Integer num_inventario, Artistas artistaa, LocalDate ano, String material, Integer altura) 
	{
		super(titulo, num_inventario, artistaa, ano);
		this.material=material;
		this.altura=altura;
		
	}
	

	@Override
	public String toString() {
		return "Esculturas [material=" + material + ", altura=" + altura + "]";
	}


	public String getMaterial() {
		return material;
	}

	public void setMaterial(String material) {
		this.material = material;
	}

	public Integer getAltura() {
		return altura;
	}

	public void setAltura(Integer altura) {
		this.altura = altura;
	}

	

}
