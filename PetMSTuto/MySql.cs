using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bdtest;
using MySql.Data.MySqlClient;


namespace PetMSTuto
{
    internal class MySql
    {
        private string connMySql;

        public MySql()
        {
            connMySql = "server=localhost;User Id=root;password='1234';database=petshop";
        }

        public void insertEmployee(Employees_DB employees_DB, Pessoa pessoa)
        {
            MySqlConnection ConnMySql = null;
            MySqlCommand cmd = null;

            try
            {
                ConnMySql = new MySqlConnection (connMySql);

                ConnMySql.Open();

                cmd = new MySqlCommand();

                cmd.Connection = ConnMySql;

                cmd.CommandText = "INSERT INTO pessoa (nome, endereco, telefone) " +
                    "VALUES (@nome, @endereco, @telefone)";

                cmd.Parameters.AddWithValue("@nome", pessoa.getNome());
                cmd.Parameters.AddWithValue("@endereco", pessoa.getEndereco());
                cmd.Parameters.AddWithValue("@telefone", pessoa.getTelefone());

                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO funcionarios (nascimento, senha) " +
                    "VALUES (@nascimento, @senha, @id_pessoa) SET @id_pessoa = LAST_INSERT_ID()";
                cmd.Parameters.AddWithValue("@nascimento", employees_DB.getDt_nasc());
                cmd.Parameters.AddWithValue("@senha", employees_DB.getSenha());

                cmd.ExecuteNonQuery();

            }
            finally
            {
                if (cmd != null) cmd.Dispose();

                if (ConnMySql != null) ConnMySql.Close();
            }
        }
        public int getEmpIdPessoa()
        {
            MySqlConnection ConnMySql = null;
            MySqlCommand cmd = null;
            int id_pessoa = 0;

            try
            {
                ConnMySql = new MySqlConnection(connMySql);

                ConnMySql.Open();

                cmd = new MySqlCommand();

                cmd.Connection = ConnMySql;

                cmd.CommandText = "SELECT * FROM petshop.funcionarios ORDER BY id_pessoa DESC LIMIT 1;";

                cmd.ExecuteReader();
                return id_pessoa;

            }
            finally
            {
                ConnMySql.Close();
            }

        }

        public int geIdPessoa()
        {
            MySqlConnection ConnMySql = null;
            MySqlCommand cmd = null;
            int id = 0;

            try
            {
                ConnMySql = new MySqlConnection(connMySql);

                ConnMySql.Open();

                cmd = new MySqlCommand();

                cmd.Connection = ConnMySql;

                cmd.CommandText = "SELECT * FROM petshop.pessoa ORDER BY id DESC LIMIT 1;";

                cmd.ExecuteReader();
                return id;

            }
            finally
            {
                ConnMySql.Close();
            }

        }
    }
}
