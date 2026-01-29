using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyect.Excepciones; 

namespace Proyect.Servicios
{
    public class ServicioTexto
    {
        public async Task<string> ObtenerTextoAsync()
        {
            await Task.Delay(2000); 

            if (new Random().Next(1, 5) == 1)
                throw new ErrorRedException("Error al obtener el texto de la noticia.");

            return "Noticia: Economía dominicana crece un 5%.";
        }
    }
}
