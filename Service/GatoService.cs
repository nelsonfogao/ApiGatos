using Domain;
using Domain.Interfaces;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class GatoService:IGatoService
    {
        private readonly IGatoRepository _gatoRepository;
        public GatoService(IGatoRepository gatoRepository)
        {
            _gatoRepository = gatoRepository;
        }
        public async Task<IEnumerable<Gato>> GetGatosAsync()
        {
            var gatos = await _gatoRepository.GetGatosAsync();
            return gatos;
        }
    }
}
