using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.Servicios
{
    public class ServicioImagenes
    {
        public async Task<string> ObtenerImagenesAsync()
        {
            await Task.Delay(1500);
            return "Imagenes cargadas correctamente.";
        }
    }
    
}
