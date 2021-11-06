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
    public partial class frm_NewPaciente : Form
    {
        public frm_NewPaciente()
        {
            InitializeComponent();
        }

        public static SqlConnection Connection()
        {
            return new SqlConnection(@"Data Source = ITLNB064A\SQL2017; Initial Catalog = DB_AGPI; Integrated Security = True");
        }

        public void CadastrarPaciente(string Comando)
        {
            try
            {
                using (SqlConnection sqlConnection = Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = Comando;
                        sqlComando.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                MessageBox.Show("Usuário cadastrado com sucesso", "Aviso!", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show("Usuário não cadastrado", "Erro");

            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string nomePaciente = txt_NomePaciente.Text;
            string dataNascimento = dtDataNasc.Value.ToString();
            string cpf = txt_CPF.Text;
            string rg = txt_RG.Text;
            string numConvenio = txt_NumConve.Text;
            string telefone = txt_Telefone.Text;
            string celular = txt_Celular.Text;
            string email = txt_Email.Text;
            string endereco = txt_Endereco.Text;


            string comando = String.Format("insert into tbl_Paciente([Nome], [DataNascimento], [CPF], [RG], [Convenio], [Telefone], [Celular], [Email], [Endereco], Cod_Perfil_Fk) " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', 4)", nomePaciente, dataNascimento, cpf, rg, numConvenio, telefone, celular, email, endereco);

            CadastrarPaciente(comando);
        }
    }
}
