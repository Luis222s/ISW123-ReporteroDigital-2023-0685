using System;
using Proyect;

class Program
{
    static async Task Main(string[] args)
    {
        var reportero = new Reportero();

        reportero.FuenteProcesada += mensaje =>
        {
            Console.WriteLine($"Evento: {mensaje}");
        };

        await reportero.CrearArticuloAsync();

        Console.WriteLine("\nProceso finalizado. Presione una tecla...");
        Console.ReadKey();
    }
}