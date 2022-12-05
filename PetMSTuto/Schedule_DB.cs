using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMSTuto
{
    internal class Schedule_DB
    {
        private int id;
        private DateTime data_agenda;
        private int hora_agendamento;
        private string servicos;
        private int id_cliente;
        public Schedule_DB(int id, DateTime data_agenda, int hora_agendamento, string servicos, int id_cliente) 
        {
            this.id = id;
            this.data_agenda = data_agenda;
            this.hora_agendamento = hora_agendamento;
            this.servicos = servicos;
            this.id_cliente = id_cliente;
        }

        public int getId() { return id; }
        public DateTime getData_agenda() { return data_agenda; }
        public int getHora_agendamento() { return hora_agendamento; }
        public string getServicos() { return servicos; }
        public int getId_cliente() { return id_cliente; }
    }
}
