using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_agpi.Views
{
    public partial class frm_Login : Form
    {
        int Id = 0;

        public frm_Login()
        {
            InitializeComponent();
        }

        public bool SelectLogin(string username, string password)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = "DEFAULT_SELECT_LOGIN";
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@Username", username));
                        sqlComando.Parameters.Add(new SqlParameter("@Password", password));
                        SqlDataReader reader = sqlComando.ExecuteReader();

                        dataTable.Load(reader);
                    }
                }

                if (dataTable.Rows.Count > 0)
                {
                    Id = int.Parse(dataTable.Rows[0].ItemArray[0].ToString());
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não foi possível conectar à base de dados, contacte o administrador do sistema!", "Erro");
                return false;
            }
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool Login = SelectLogin(username, password);

            if (Login)
            {
                frm_Main main = new frm_Main(Id);
                main.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválido!", "Acesso negado");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
