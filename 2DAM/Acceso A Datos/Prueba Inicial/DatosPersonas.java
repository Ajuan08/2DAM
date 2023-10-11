class Persona {
    private  String dni;
    private  String pais;
    private  String zona;
    private  String nombre;
    private  Boolean minusvalia;
    private  Date fecha_nac;

    public Persona(String dni, String pais, String zona, String nombre, boolean minusvalia, Date fecha_nac) {
        this.dni = dni;
        this.pais = pais;
        this.zona = zona;
        this.nombre = nombre;
        this.minusvalia = minusvalia;
        this.fecha_nac = fecha_nac;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getPais() {
        return pais;
    }

    public void setPais(String pais) {
        this.pais = pais;
    }

    public String getZona() {
        return zona;
    }

    public void setZona(String zona) {
        this.zona = zona;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Boolean getMinusvalia() {
        return minusvalia;
    }

    public void setMinusvalia(Boolean minusvalia) {
        this.minusvalia = minusvalia;
    }
    
     public Date getFecha_nac() {
        return fecha_nac;
    }

    public void setFecha_nac(Date fecha_nac) {
        this.fecha_nac = fecha_nac;
    }
}

class Tripulacion extends Persona {
    private String nivelResponsabilidad;

    public Tripulacion(String dni, String pais, String zona, String nombre, boolean minusvalia, Date fechaNacimiento, String nivelResponsabilidad) {
        super(dni, pais, zona, nombre, minusvalia, fechaNacimiento);
        this.nivelResponsabilidad = nivelResponsabilidad;
    }

   
    public String getNivelResponsabilidad() {
        return nivelResponsabilidad;
    }

    public void setNivelResponsabilidad(String nivelResponsabilidad) {
        this.nivelResponsabilidad = nivelResponsabilidad;
    }
}

class Pasajero extends Persona {
    private int num_hab;

    public Pasajero(String dni, String pais, String zona, String nombre, boolean minusvalia, Date fechaNacimiento, int num_hab) {
        super(dni, pais, zona, nombre, minusvalia, fechaNacimiento);
        this.num_hab = num_hab;
    }

   public int getNum_hab() {
        return num_hab;
    }

    public void setNum_hab(int num_hab) {
        this.num_hab = num_hab;
    }
}

class Date {

}

class DAOBotes{

}