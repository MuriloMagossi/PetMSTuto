using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using MySql.Data.MySqlClient;
using System.Collections;
using bdtest;
using Google.Protobuf.WellKnownTypes;

namespace PetMSTuto
{
    public partial class Employees : Form
    {
        string connect = "server=localhost;User Id=root;password='1234';database=petshop";
        string queryPes = "SELECT * FROM pessoa";
        string queryEmp = "SELECT * FROM Employees";

        MySql MS = new MySql();

        public Employees()
        {
            InitializeComponent();
            EmpNameLbl.Text = Login.Employee;
            DisplayEmployees();
        }

        private void DisplayEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                MySqlDataAdapter DataB = new MySqlDataAdapter(queryPes, conn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(DataB);
                var ds = new DataSet();
                DataB.Fill(ds);
                EmployeeDGV.DataSource = ds.Tables[0];

                conn.Close();
            }
        }
        private void Clear()
        {
            EmpNameTb.Text = "";
            EmpAddTb.Text = "";
            EmpPhoneTb.Text = "";
            PasswordTb.Text = "";
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {

        }
        int Key = 0;

        private void Savebtn_Click_1(object sender, EventArgs e)
        {
            int id = MS.geIdPessoa();
            string nome = EmpNameTb.Text.Trim();
            string endereco = EmpAddTb.Text.Trim();
            string telefone = EmpPhoneTb.Text.Trim();
            string senha = PasswordTb.Text.Trim();
            string nascimento = EmpDOB.Text.Trim();
            int id_pessoa = MS.getEmpIdPessoa();
            try
            {

               string idE = id.ToString();

                if (idE == "" || nascimento == "" || nome == "" || endereco == "" || telefone == "" || senha == "")
                {
                    MessageBox.Show("Preenchimento Inválido");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Erro Geral");
            }

            //cadastro

            try
            {
                DateTime dt_nasc = DateTime.Parse(nascimento);
                

                Employees_DB employees_DB = new Employees_DB(id, dt_nasc, senha, id_pessoa);
                Pessoa pessoa = new Pessoa(id_pessoa, nome, endereco, telefone);

                MS.insertEmployee(employees_DB, pessoa);

                Clear();

                MessageBox.Show("Sertin!");
            }
            catch
            {
                MessageBox.Show("Bugou!");

            }
        }

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddTb.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpDOB.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            PasswordTb.Text = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();
            if(EmpNameTb.Text == "")
            {
                Key = 0;
            }else
            {
                Key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            /*if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || PasswordTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Faltando Informação");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EmployeeTbl set EmpName=@EN,EmpAdd=@EA,EmpDOB=@ED,EmpPhone=@EP,EmpPass=@EPa where EmpNum=@EKey", Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EPa", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário adicionado");
                    Con.Close();
                    DisplayEmployees();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }*/
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
           /* if (Key == 0)
            {
                MessageBox.Show("Selecione um funcionário");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmployeeTbl where EmpNum = @EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EmpKey", Key);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionario excluido");
                    Con.Close();
                    DisplayEmployees();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void EmpNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void GetCustId()
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryEmp, conn);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    EmpId.Text = dr["CustName"].ToString();
                }
                conn.Close();
            }            
        }

        private void clearText()
        {

        }
        private void EmpId_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCustId();
        }
    }
}
