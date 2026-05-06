public class Cliente : Persona
{
      public string plan { get; set; }
      public string fechaIngreso { get; }
      public bool activo { get; set; }
      public Cliente(string nombre, int edad, string documento, string correo, string plan, string fecha)
         : base(nombre, documento, correo, edad)
      {
         this.plan = plan;
         this.fechaIngreso = fecha;
         this.activo = true; 
      }
      public override void MostrarInfo()
      {
         base.MostrarInfo();
         Console.WriteLine(plan);
      }
}