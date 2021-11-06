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
    public partial class frm_Agendamento : Form
    {
        public frm_Agendamento()
        {
            InitializeComponent();
        }

        private string _strConn = @"Data Source = ITLNB064A\SQL2017; Initial Catalog = DB_AGPI; Integrated Security = True";

        SqlConnection objConect = null;
        SqlCommand objCommand = null;

        private void LoadConsultas()
        {
            string Comando = @"DEFAULT_SELECT_CONSULTA_AGENDADA";

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

        private void frm_Consultas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AGPIDataSet.tbl_ConsultaAgendada' table. You can move, or remove it, as needed.
            this.tbl_ConsultaAgendadaTableAdapter.Fill(this.dB_AGPIDataSet.tbl_ConsultaAgendada);
            LoadConsultas();
        }

        private void bnNovoItem_Click(object sender, EventArgs e)
        {
            frm_Agendar_Consulta agendarConsulta = new frm_Agendar_Consulta();
            agendarConsulta.StartPosition = FormStartPosition.CenterScreen;
            agendarConsulta.ShowDialog();
            LoadConsultas();
        }
    }
}
