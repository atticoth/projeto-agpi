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

namespace projeto_agpi.Forms_Sistemas
{
    public partial class frm_Atendimento_Medico : Form
    {
        int CodAgendamento;
        public frm_Atendimento_Medico(int ID)
        {
            InitializeComponent();
            CodAgendamento = ID;
        }

        public void LoadPaciente()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = @"DEFAULT_SELECT_PACIENTE_ATENDIMENTO";
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@CodAgendamento", CodAgendamento));
                        var reader = sqlComando.ExecuteReader();

                        dataTable.Load(reader);

                    }
                }

                lbl_NomePaciente.Text = dataTable.Rows[0].ItemArray[0].ToString();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InserirAtendimento(string pressao, string saturacao, string temperatura, string anotacoes, string medicamento)
        {
            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = "DEFAULT_INSERT_ATENDIMENTO";
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@CodAgendamento", CodAgendamento));
                        sqlComando.Parameters.Add(new SqlParameter("@Pressao", pressao));
                        sqlComando.Parameters.Add(new SqlParameter("@Saturacao", saturacao));
                        sqlComando.Parameters.Add(new SqlParameter("@Temperatura", temperatura));
                        sqlComando.Parameters.Add(new SqlParameter("@Anotacoes", anotacoes));
                        sqlComando.Parameters.Add(new SqlParameter("@Medicamento", medicamento));
                        sqlComando.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void FinalizarConsulta()
        {
            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = "DEFAULT_UPDATE_CONSULTA_FINALIZADA";
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@CodAgendamento", CodAgendamento));
                        sqlComando.Parameters.Add(new SqlParameter("@ConsultaFinalizada", 1));
                        sqlComando.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void frm_Atendimento_Medico_Load(object sender, EventArgs e)
        {
            LoadPaciente();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(cbx_FinalizarConsulta.Checked == true)
            {
                string pressao = txt_Pressao.Text;
                string saturacao = txt_Saturacao.Text;
                string temperatura = txt_Temperatura.Text;
                string anotacoes = txt_Anotacao.Text;
                string medicamento = txt_Medicamento.Text;

                InserirAtendimento(pressao, saturacao, temperatura, anotacoes, medicamento);
                FinalizarConsulta();

                MessageBox.Show("Atendimento Finalizado!", "Aviso!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Precisa finalizar a Consulta!", "Aviso!", MessageBoxButtons.OK);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_Pressao.Text = " ";
            txt_Anotacao.Text = " ";
            txt_Medicamento.Text = " ";
            txt_Saturacao.Text = " ";
            txt_Temperatura.Text = " ";
            
        }
    }
}
