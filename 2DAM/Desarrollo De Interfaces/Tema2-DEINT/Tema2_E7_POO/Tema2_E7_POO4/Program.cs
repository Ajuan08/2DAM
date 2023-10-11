using Tema2_E7_POO4;

public class Program
{
    public static void Main()
    {
        Persona persona = new Persona("Juan",22);
        Console.WriteLine(persona.ToString());
        Empleado empleado = new Empleado("Alba",30,1800);
        Console.WriteLine(empleado.ToString());
    }
}
