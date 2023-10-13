package museo;

import java.time.LocalDate;

public class Pinturas extends ObrasArtisticas{

	private Integer dimensiones;
	private String soporte;
	
	public Pinturas(String titulo, Integer num_inventario, Artistas autor, LocalDate ano, Integer dimensiones, String soporte) 
	{
		super(titulo, num_inventario, autor, ano);
		this.dimensiones=dimensiones;
		this.soporte=soporte;
	}
	
	@Override
	public String toString() {
		return "Pinturas [dimensiones=" + dimensiones + ", soporte=" + soporte + "]";
	}

	public Integer getDimensiones() {
		return dimensiones;
	}

	public void setDimensiones(Integer dimensiones) {
		this.dimensiones = dimensiones;
	}

	public String getSoporte() {
		return soporte;
	}

	public void setSoporte(String soporte) {
		this.soporte = soporte;
	}


	
	
	
}
