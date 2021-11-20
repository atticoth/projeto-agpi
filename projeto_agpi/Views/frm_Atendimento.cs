using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projeto_agpi.Views
{
    public partial class frm_Atendimento : Form
    {
        public string Nome;
        public int CodPacien;
        public int CodAgendamento;

        int meuID;
        public frm_Atendimento(int Id)
        {
            meuID = Id;
            InitializeComponent();
            

        }

        public static SqlConnection Connection()
        {
            return new SqlConnection(@"Data Source = ITLNB064A\SQL2017; Initial Catalog = DB_AGPI; Integrated Security = True");
        }

        public void SelectPaciente(string Comando)
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
                        var reader = sqlComando.ExecuteReader();

                        dataTable.Load(reader);
                    }
                }

                CodPacien = int.Parse(dataTable.Rows[0].ItemArray[0].ToString());
                Nome = dataTable.Rows[0].ItemArray[1].ToString();
                txt_NomePaciente.Text = Nome;
                CodAgendamento = int.Parse(dataTable.Rows[0].ItemArray[2].ToString());

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Paciente não cadastrado!", "Erro");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string cpfPesquisar = txt_PesquisaCPF.Text;

            string Comando = String.Format("SELECT P.[CodPacien], P.[Nome], CA.CodAgendamento FROM tbl_Paciente P LEFT JOIN tbl_ConsultaAgendada CA ON P.CodPacien = CA.Cod_Pacien_FK WHERE P.[CPF] = '{0}'", cpfPesquisar);

            SelectPaciente(Comando);

        }

        public void SalvarTriagem(string Comando)
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
                MessageBox.Show("Salvo com sucesso!", "Aviso!", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK);

            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string pressao = txt_Pressao.Text;
            string temperatura = txt_Temperatura.Text;
            string saturacao = txt_Saturacao.Text;
            string observacoes = txt_Observacoes.Text;

            string comando = String.Format("insert into tbl_Triagem([CodAgendamento_FK], [Pressao], [Temperatura], [Saturacao], [Observacao], [Data_Insert]) " +
               "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", CodAgendamento, pressao, temperatura, saturacao, observacoes, DateTime.Now);

            SalvarTriagem(comando);
        }
    }
}
