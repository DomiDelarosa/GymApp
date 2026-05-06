public class Empleado : Persona
{
    public string Cargo { get; set; }
    private double sueldo;
    public double Sueldo
    {
        get { return sueldo; }
        set
        {
            if (value > 0)
                sueldo = value;
            else Console.Write("Error, el salario no puede ser negativo.");
        }
    }
    public Empleado(string nombre, int edad, string documento, string correo, string cargo, double sueldo)
       : base(nombre, documento, correo, edad)
    {
        Cargo = cargo;
        Sueldo = sueldo;
    }
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Sueldo: " + sueldo);
    }
}