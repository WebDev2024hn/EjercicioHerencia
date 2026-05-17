using System;

public class Moto : Vehiculo
{
    public int Cilindrada { get; set; }
    public bool TieneMaletero { get; set; }

    public override void MostrarInformacion()
    {
        Console.WriteLine("=== MOTO ===");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Año: " + Año);
        Console.WriteLine("Cilindrada: " + Cilindrada + " cc");
        Console.WriteLine("Tiene Maletero: " + (TieneMaletero ? "Si" : "No"));
        Console.WriteLine();
    }
}