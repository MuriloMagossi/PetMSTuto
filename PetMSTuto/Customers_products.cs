using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMSTuto
{
    internal class Customers_products
    {
        private int id_cliente_produto;
        private int id_cliente;
        private int id_produto;
        public Customers_products(int id_cliente_produto, int id_cliente, int id_produto)
        {
            this.id_cliente_produto = id_cliente_produto;
            this.id_cliente = id_cliente;
            this.id_produto = id_produto;
        }

        public int getCliente_Produto() { return id_cliente_produto; }
        public int getId_Cliente() { return id_cliente; }
        public int getId_Produto() { return id_produto; }

    }
}
