package museo;

import java.time.LocalDate;

public class Artistas {

	private String nombre;
	private String lugar_nac;
	private LocalDate fecha_nac;
	private LocalDate fecha_muerte;
	
	public Artistas(String nombre, String lugar_nac, LocalDate fecha_nac, LocalDate fecha_muerte) 
	{
		this.nombre = nombre;
		this.lugar_nac = lugar_nac;
		this.fecha_nac = fecha_nac;
		this.fecha_muerte = fecha_muerte;
	}

	@Override
	public String toString() {
		return "Artistas [nombre=" + nombre + ", lugar_nac=" + lugar_nac + ", fecha_nac=" + fecha_nac
				+ ", fecha_muerte=" + fecha_muerte + "]";
	}
	
	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getLugar_nac() {
		return lugar_nac;
	}

	public void setLugar_nac(String lugar_nac) {
		this.lugar_nac = lugar_nac;
	}

	public LocalDate getFecha_nac() {
		return fecha_nac;
	}

	public void setFecha_nac(LocalDate fecha_nac) {
		this.fecha_nac = fecha_nac;
	}

	public LocalDate getFecha_muerte() {
		return fecha_muerte;
	}

	public void setFecha_muerte(LocalDate fecha_muerte) {
		this.fecha_muerte = fecha_muerte;
	}
}
