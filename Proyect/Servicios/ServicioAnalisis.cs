using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.Servicios
{
    public class ServicioAnalisis
    {
        public async Task<string> ObtenerAnalisisAsync()
        {
            await Task.Delay(2500);
            return "Análisis: Expertos opinan que el crecimiento es sostenible.";
        }
    }
}
