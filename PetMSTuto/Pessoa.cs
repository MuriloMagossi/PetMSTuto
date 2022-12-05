using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdtest
{
    public class Pessoa
    {
        private int id;
        private string nome;
        private string endereco;
        private string telefone;

        public Pessoa(int id, string nome, string endereco, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public int getId() { return id; }
        public string getNome() { return nome; }
        public string getEndereco() { return endereco; }
        public string getTelefone() { return telefone; }
    }
}
