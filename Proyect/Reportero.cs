using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyect.Servicios;

namespace Proyect
{
    public class Reportero
    {
        public event Action<string> FuenteProcesada;

        public async Task CrearArticuloAsync()
        {
            var textoSrv = new ServicioTexto();
            var imgSrv = new ServicioImagenes();
            var analisisSrv = new ServicioAnalisis();

            try
            {
                var tareaTexto = textoSrv.ObtenerTextoAsync();
                var tareaImg = imgSrv.ObtenerImagenesAsync();
                var tareaAnalisis = analisisSrv.ObtenerAnalisisAsync();

                await Task.WhenAll(tareaTexto, tareaImg, tareaAnalisis);

                FuenteProcesada?.Invoke("Texto listo");
                FuenteProcesada?.Invoke("Imágenes listas");
                FuenteProcesada?.Invoke("Análisis listo");

                Console.WriteLine("\n ARTÍCULO FINAL:\n");
                Console.WriteLine(tareaTexto.Result);
                Console.WriteLine(tareaImg.Result);
                Console.WriteLine(tareaAnalisis.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
