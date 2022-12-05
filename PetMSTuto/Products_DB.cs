using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMSTuto
{
    internal class Products_DB
    {
        private int id;
        private string nome;
        private int quantidade;
        private float preco;
        private int id_categoria;
        public Products_DB(int id, string nome, int quantidade, float preco, int id_categoria)
        {
            this.id = id;
            this.nome = nome;   
            this.quantidade = quantidade;
            this.preco = preco;
            this.id_categoria = id_categoria;
        }

        public int getId() { return id; }
        public string getNome() { return nome; }
        public int getQuantidade() { return quantidade; }
        public float getPreco() { return preco; }
        public int getId_categoria() { return id_categoria; }

            
    }
}
