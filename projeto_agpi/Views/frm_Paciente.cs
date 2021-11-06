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
    public partial class frm_Paciente : Form
    {
        public string nomePaciente;

        public frm_Paciente()
        {
            InitializeComponent();
        }

        private string _strConn = @"Data Source = ITLNB064A\SQL2017; Initial Catalog = DB_AGPI; Integrated Security = True";

        SqlConnection objConect = null;
        SqlCommand objCommand = null;

        private void LoadConsultas()
        {
            string Comando = @"DEFAULT_SELECT_PACIENTE";

            objConect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(Comando, objConect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable DtUser = new DataTable();

                objAdp.Fill(DtUser);

                dgConsulta.DataSource = DtUser;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar o banco!", "Erro");
            }
        }

        private void SelectPaciente(string Comando)
        {

            objConect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(Comando, objConect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable DtUser = new DataTable();

                objAdp.Fill(DtUser);

                dgConsulta.DataSource = DtUser;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar o banco!", "Erro");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string cpfPesquisar = txt_PesquisaCPF.Text;

            string Comando = String.Format("SELECT [Nome], [DataNascimento], [CPF], [RG], [Convenio], [Telefone], [Celular], [Email], [Endereco] FROM tbl_Paciente WHERE [CPF] = '{0}'", cpfPesquisar);

            if (txt_PesquisaCPF.Text != " ")
            {
                SelectPaciente(Comando);

            }
            else
            {
                LoadConsultas();
            }
        }
        private void frm_Paciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AGPIDataSet.tbl_Paciente' table. You can move, or remove it, as needed.
            this.tbl_PacienteTableAdapter.Fill(this.dB_AGPIDataSet.tbl_Paciente);
            // TODO: This line of code loads data into the 'dB_AGPIDataSet.tbl_Paciente' table. You can move, or remove it, as needed.
            this.tbl_PacienteTableAdapter.Fill(this.dB_AGPIDataSet.tbl_Paciente);
            LoadConsultas();
        }

        private void bnNovoItem_Click(object sender, EventArgs e)
        {
            frm_NewPaciente newPaciente = new frm_NewPaciente();
            newPaciente.StartPosition = FormStartPosition.CenterScreen;
            newPaciente.ShowDialog();
            LoadConsultas();
        }
    }
}
