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

        public static SqlConnection Connection()
        {
            return new SqlConnection(@"Data Source = ITLNB064A\SQL2017; Initial Catalog = DB_AGPI; Integrated Security = True");
        }

        public bool SelectLogin(string Comando)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = Comando;
                        SqlDataReader reader = sqlComando.ExecuteReader();

                        dataTable.Load(reader);
                    }
                }

                Id = int.Parse(dataTable.Rows[0].ItemArray[0].ToString());

                if (dataTable.Rows.Count > 0)
                {
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

            string ComandoSQL = String.Format("SELECT [CodID]  FROM [DB_AGPI].[dbo].[tbl_LoginUser] WHERE [User] = '{0}' AND [Senha] = '{1}'", username, password);

            bool Login = SelectLogin(ComandoSQL);

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

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPassword.PasswordChar = '*';
        }
    }
}
