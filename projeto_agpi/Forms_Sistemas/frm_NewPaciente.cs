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

        public void CadastrarPaciente(string nomePaciente, string sexo, DateTime dataNascimento, string cpf, string rg, string numConvenio, string telefone, string celular, string email, string endereco)
        {
            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = "DEFAULT_INSERT_NEW_PACIENTE";
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@Nome", nomePaciente));
                        sqlComando.Parameters.Add(new SqlParameter("@Sexo", sexo));
                        sqlComando.Parameters.Add(new SqlParameter("@DataNascimento", dataNascimento));
                        sqlComando.Parameters.Add(new SqlParameter("@CPF", cpf));
                        sqlComando.Parameters.Add(new SqlParameter("@RG", rg));
                        sqlComando.Parameters.Add(new SqlParameter("@Convenio", numConvenio));
                        sqlComando.Parameters.Add(new SqlParameter("@Telefone", telefone));
                        sqlComando.Parameters.Add(new SqlParameter("@Celular", celular));
                        sqlComando.Parameters.Add(new SqlParameter("@Email", email));
                        sqlComando.Parameters.Add(new SqlParameter("@Endereco", endereco));
                        sqlComando.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                MessageBox.Show("Paciente cadastrado com sucesso", "Aviso!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Salvar_Click_1(object sender, EventArgs e)
        {
            string nomePaciente = txt_NomePaciente.Text;
            string sexo = cbo_Sexo.Text;
            DateTime dataNascimento = dtDataNasc.Value;
            string cpf = txt_CPF.Text;
            string rg = txt_RG.Text;
            string numConvenio = txt_NumConve.Text;
            string telefone = txt_Telefone.Text;
            string celular = txt_Celular.Text;
            string email = txt_Email.Text;
            string endereco = txt_Endereco.Text;

            CadastrarPaciente(nomePaciente, sexo, dataNascimento, cpf, rg, numConvenio, telefone, celular, email, endereco);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_NomePaciente.Text = " ";
            cbo_Sexo.SelectedIndex = -1;
            dtDataNasc.Value = DateTime.Now;
            txt_CPF.Text = " ";
            txt_RG.Text = " ";
            txt_NumConve.Text = " ";
            txt_Telefone.Text = " ";
            txt_Celular.Text = " ";
            txt_Email.Text = " ";
            txt_Endereco.Text = " ";
        }
    }
}
