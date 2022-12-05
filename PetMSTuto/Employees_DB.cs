using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMSTuto
{
    internal class Employees_DB
    {
        private int id;
        private DateTime dt_nasc;
        private string senha;
        private int id_pessoa;
        public Employees_DB (int id, DateTime dt_nasc, string senha, int id_pessoa)
        {
            this.id = id;
            this.dt_nasc = dt_nasc;
            this.senha = senha;
            this.id_pessoa = id_pessoa;

        }

        public int getId() { return id; }
        public DateTime getDt_nasc() { return dt_nasc; }
        public string getSenha() { return senha; }
        public int getId_pessoa() { return id_pessoa; }

    }
}
