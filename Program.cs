public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Empleado 1: ");
        Empleado empleado1 = new Empleado("Juan", 30, "12345678", "juan@example.com", "Entrenador", 1200);
        empleado1.MostrarInfo();
        empleado1.CalcularSueldo(0.5);
        
        Console.WriteLine("======================");

        Console.Write("Cliente 1: ");
        Cliente cliente1 = new Cliente("Maria", 25, "87654321", "maria@example.com", "Plan A", "2023-01-01");
        cliente1.MostrarInfo();
    }
}