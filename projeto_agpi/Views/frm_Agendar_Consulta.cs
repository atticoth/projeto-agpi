using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace projeto_agpi.Views
{
    public partial class frm_Agendar_Consulta : Form
    {
        public string Nome;
        public int CodPacien;
        public int CodFunc;

        public frm_Agendar_Consulta()
        {
            InitializeComponent();
        }

        public static SqlConnection Connection()
        {
            return new SqlConnection(@"Data Source = ITLNB064A\SQL2017; Initial Catalog = DB_AGPI; Integrated Security = True");
        }

        public void LoadCombo()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = @"DEFAULT_SELECT_FUNCIONARIOS_CBO";
                        var reader = sqlComando.ExecuteReader();

                        dataTable.Load(reader);
                    }
                }
                cboDoutores.DataSource = dataTable;
                cboDoutores.DisplayMember = "Nome";
                cboDoutores.ValueMember = "CodFunc";
                cboDoutores.Text = " ";

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não foi possivel conectar ao banco!", "Erro");
            }
        }

        private void frm_Agendar_Consulta_Load(object sender, EventArgs e)
        {
            LoadCombo();
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

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Paciente não cadastrado!", "Erro");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string cpfPesquisar = txt_PesquisaCPF.Text;

            string Comando = String.Format("SELECT [CodPacien], [Nome] FROM tbl_Paciente WHERE [CPF] = '{0}'", cpfPesquisar);

            SelectPaciente(Comando);

        }

        public void AgendarConsulta(string Comando)
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

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string data = dtDataConsulta.Value.ToString();
            string horario = dtHorario.Value.ToString();
            string motivoConsulta = txtMotivoConsulta.Text;
            

            if (cboDoutores.SelectedIndex >= 0)
            {
                CodFunc = Convert.ToInt32(cboDoutores.SelectedValue);
            }

            string comando = String.Format("insert into tbl_ConsultaAgendada([Cod_Pacien_FK], [Cod_Func_FK], [Data], [Horario], [MotivoConsulta], [Data_Insert]) " +
               "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", CodPacien, CodFunc, data, horario, motivoConsulta, DateTime.Now);

            AgendarConsulta(comando);
        }
    }
}
