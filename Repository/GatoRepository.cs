using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    
    public class GatoRepository: IGatoRepository
    {
        
        public async Task<IEnumerable<Gato>> GetGatosAsync()
        {
            var gatos = new DataGatos();
            return gatos.GetGatos();
        }
    }
}
