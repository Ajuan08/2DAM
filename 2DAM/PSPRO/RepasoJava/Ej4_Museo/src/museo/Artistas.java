package museo;

import java.util.Date;

public class Artistas {

	private String nombre;
	private String lugar_nacimiento;
	private Date fecha_nacimiento;
	private Date fecha_fallecimiento;
	
	
	public Artistas(String nombre, String lugar_nacimiento, Date fecha_nacimiento, Date fecha_fallecimiento) {
		super();
		this.nombre = nombre;
		this.lugar_nacimiento = lugar_nacimiento;
		this.fecha_nacimiento = fecha_nacimiento;
		this.fecha_fallecimiento = fecha_fallecimiento;
	}
	
}
