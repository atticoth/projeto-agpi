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

        public void LoadCombo()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = @"DEFAULT_SELECT_FUNCIONARIOS_CBO";
                        var reader = sqlComando.ExecuteReader();

                        dataTable.Load(reader);
                    }
                }
                cboDoutores.Items.Insert(0, " ");
                cboDoutores.DataSource = dataTable;
                cboDoutores.DisplayMember = "Nome";
                cboDoutores.ValueMember = "CodFunc";

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não foi possivel conectar ao banco!", "Erro");
            }
        }        

        public void SelectPaciente(string strProc, string cpf)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = strProc;
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@CPF", cpf));
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
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AgendarConsulta(int CodFunc, DateTime DataConsulta, string HorarioConsulta)
        {
            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = "DEFAULT_INSERT_AGENDAR_CONSULTA";
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@CodPacien", CodPacien));
                        sqlComando.Parameters.Add(new SqlParameter("@CodFunc", CodFunc));
                        sqlComando.Parameters.Add(new SqlParameter("@DataConsulta", DataConsulta));
                        sqlComando.Parameters.Add(new SqlParameter("@HorarioConsulta", HorarioConsulta));
                        sqlComando.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                MessageBox.Show("Consulta Agendada!", "Aviso!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frm_Agendar_Consulta_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string cpf = txt_PesquisaCPF.Text;

            SelectPaciente("DEFAULT_SELECT_PACIENTE_CPF_AGENDAR_CONSULTA", cpf);
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            DateTime DataConsulta = dtDataConsulta.Value;
            string HorarioConsulta = txt_HorarioConsulta.Text;


            if (cboDoutores.SelectedIndex >= 0)
            {
                CodFunc = Convert.ToInt32(cboDoutores.SelectedValue);
            }

            AgendarConsulta(CodFunc, DataConsulta, HorarioConsulta);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_PesquisaCPF.Text = " ";
            txt_NomePaciente.Text = " ";
            cboDoutores.SelectedIndex = -1;
            dtDataConsulta.Value = DateTime.Now;
            txt_HorarioConsulta.Text = " ";
        }
    }
}
