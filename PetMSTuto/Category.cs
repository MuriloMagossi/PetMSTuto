using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMSTuto
{
    internal class Category
    {
        private int id;
        private string nome;
        public Category(int id, string nome) 
        {
            this.id = id;
            this.nome = nome;
        }

        public int getId() { return id; }
        public string getNome() { return nome; }
    }
}
