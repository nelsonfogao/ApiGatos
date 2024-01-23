using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataGatos
    {
        public List<Gato> GetGatos()
        {
            var listaGatos = new List<Gato>();
            var gato = new Gato("bolinha", 5);
            listaGatos.Add(gato);
            gato = new Gato("flokinho", 3);
            listaGatos.Add(gato);
            return listaGatos;
        }
    }
}
