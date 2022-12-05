using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMSTuto
{
    internal class Customers_DB
    {
        private int id;
        private int id_pessoa;
        public Customers_DB(int id, int id_pessoa) 
        {
            this.id = id;
            this.id_pessoa = id_pessoa;
        }

        public int getId() { return id; }
        public int getId_pessoa() { return id_pessoa; }
    }
}
