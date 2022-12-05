using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMSTuto
{
    internal class Customers_animal
    {
        private int id_cliente_animais;
        private int id_cliente;
        private int id_animais;
        public Customers_animal(int id_cliente_animais, int id_cliente, int id_animais)
        {
            this.id_cliente_animais = id_cliente_animais;
            this.id_cliente = id_cliente;
            this.id_animais = id_animais;
        }

        public int getCliente_Animais() { return id_cliente_animais; }
        public int getId_Cliente() { return id_cliente; }
        public int getId_animais() { return id_animais; }

    }
}
