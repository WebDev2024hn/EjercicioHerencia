using System;

class Program
{
    static void Main(string[] args)
    {
        // Carros
        Carro carro1 = new Carro
        {
            Marca = "Toyota",
            Modelo = "Corolla",
            Año = 2020,
            NumeroPuertas = 4,
            TipoCombustible = "Gasolina"
        };

        Carro carro2 = new Carro
        {
            Marca = "Tesla",
            Modelo = "Model 3",
            Año = 2023,
            NumeroPuertas = 4,
            TipoCombustible = "Eléctrico"
        };

        // Motos
        Moto moto1 = new Moto
        {
            Marca = "Yamaha",
            Modelo = "MT-07",
            Año = 2021,
            Cilindrada = 689,
            TieneMaletero = true
        };

        Moto moto2 = new Moto
        {
            Marca = "Honda",
            Modelo = "CBR250R",
            Año = 2019,
            Cilindrada = 250,
            TieneMaletero = false
        };

        // Mostrar información
        carro1.MostrarInformacion();
        carro2.MostrarInformacion();

        moto1.MostrarInformacion();
        moto2.MostrarInformacion();
    }
}