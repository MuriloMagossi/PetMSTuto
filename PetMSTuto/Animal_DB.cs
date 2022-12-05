using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMSTuto
{
    internal class Animal_DB
    {
        private int id;
        private string nome;
        private string raca;
        private string especie;
        private string sexo;
        private float peso;
        public Animal_DB (int id, string nome, string raca, string especie, string sexo, float peso)
        {
            this.id = id;
            this.nome = nome;
            this.raca = raca;
            this.especie= especie;
            this.sexo = sexo;
            this.peso = peso;
        }

        public int getId() { return id; }
        public string getNome() { return nome; }
        public string getRaca() { return raca; }
        public string getEspecie() { return especie; }
        public string getSexo() { return sexo; }
        public float getPeso() { return peso; }
    }
}
