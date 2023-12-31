package museo.museo;

import java.time.LocalDate;
import java.util.Objects;

public class Artista {
	private String nombre;
	private String lugarNac;
	private LocalDate fechaNac;
	private LocalDate fechaFall;
	
	public Artista(String nombre, String lugarNac, LocalDate fechaNac, LocalDate fechaFall) {
		super();
		this.nombre = nombre;
		this.lugarNac = lugarNac;
		this.fechaNac = fechaNac;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getLugarNac() {
		return lugarNac;
	}

	public void setLugarNac(String lugarNac) {
		this.lugarNac = lugarNac;
	}

	public LocalDate getFechaNac() {
		return fechaNac;
	}

	public void setFechaNac(LocalDate fechaNac) {
		this.fechaNac = fechaNac;
	}

	public LocalDate getFechaFall() {
		return fechaFall;
	}

	public void setFechaFall(LocalDate fechaFall) {
		this.fechaFall = fechaFall;
	}

	@Override
	public int hashCode() {
		return Objects.hash(fechaFall, fechaNac, lugarNac, nombre);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Artista other = (Artista) obj;
		return Objects.equals(fechaFall, other.fechaFall) && Objects.equals(fechaNac, other.fechaNac)
				&& Objects.equals(lugarNac, other.lugarNac) && Objects.equals(nombre, other.nombre);
	}

	@Override
	public String toString() {
		return "Nombre: " + nombre + "\nLugar de nacimiento: " + lugarNac + "\nFecha de nacimiento: " + fechaNac + "\nFecha de fallecimiento: "
				+ fechaFall;
	}
	
	public void muestra(Artista ar) {
		ar.toString();
	}
}