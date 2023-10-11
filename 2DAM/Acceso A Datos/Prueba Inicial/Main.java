// Definición de la clase Persona
class Persona {
    // Atributos de la clase
    String nombre;
    int edad;
    String apellido;

    // Constructor
    public Persona(String nombre, int edad, String apellido) {
        this.nombre = nombre;
        this.edad = edad;
        this.apellido = apellido;
    }

    // Método para imprimir los datos de la persona
    public void imprimirDatos() {
        System.out.println("Nombre: " + nombre);
        System.out.println("Edad: " + edad);
        System.out.println("Apellido: " + apellido);
    }

    // Método para actualizar la edad
    public void actualizarEdad(int nuevaEdad) {
        edad = nuevaEdad;
    }
}

// Clase principal (main)
public class Main {
    public static void main(String[] args) {
        // Crear una instancia de Persona
        Persona persona1 = new Persona("Juan", 30, "Pérez");

        // Imprimir los datos de la persona
        System.out.println("Datos de la persona:");
        persona1.imprimirDatos();

        // Actualizar la edad de la persona
        persona1.actualizarEdad(31);

        // Imprimir los datos actualizados
        System.out.println("\nDatos actualizados de la persona:");
        persona1.imprimirDatos();
    }
}
