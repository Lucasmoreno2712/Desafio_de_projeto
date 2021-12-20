using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    {
        void Nome(string name);
        void NomeDono(string nomedono);
        void Especie(string especie);
    }
    class animal : IAnimal
    {
        public string nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }
        public string Nome { get; private set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.NomeDono(string nomedono)
        {
            this.NomeDono = nomedono;
        }
        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }
    } 
}