using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Gato
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Gato(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
