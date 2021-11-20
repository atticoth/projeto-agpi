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
    public partial class frm_Consulta : Form
    {
        public frm_Consulta()
        {
            InitializeComponent();
            this.ugConsulta.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ugConsulta_ClickCellButton);
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

                ugConsulta.DataSource = DtUser;
                ConfigGrid();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar o banco!", "Erro");
            }
        }

        private void frm_Consulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AGPIDataSet.tbl_ConsultaAgendada' table. You can move, or remove it, as needed.
            //this.tbl_ConsultaAgendadaTableAdapter.Fill(this.dB_AGPIDataSet.tbl_ConsultaAgendada);
            LoadConsultas();
            ConfigGrid();
        }

        private void ConfigGrid()
        {
            if (!ugConsulta.DisplayLayout.Bands[0].Columns.Exists("AbrePopup"))
            {
                ugConsulta.DisplayLayout.Bands[0].Columns.Add("AbrePopup", "Triagem");
            }

            ugConsulta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].Header.VisiblePosition = 8;
            ugConsulta.DisplayLayout.Override.CellButtonAppearance.Image = Properties.Resources.grayicons__45_;
            ugConsulta.DisplayLayout.Override.CellButtonAppearance.ImageHAlign = Infragistics.Win.HAlign.Center;
            ugConsulta.DisplayLayout.Override.CellButtonAppearance.ImageVAlign = Infragistics.Win.VAlign.Middle;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
        }

        private void bnNovoItem_Click(object sender, EventArgs e)
        {
            //frm_Agendar_Consulta agendarConsulta = new frm_Agendar_Consulta();
            //agendarConsulta.StartPosition = FormStartPosition.CenterScreen;
            //agendarConsulta.ShowDialog();
            //LoadConsultas();
        }

        private void ugConsulta_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            var NovoDetalhe = new frm_Atendimento((int)ugConsulta.ActiveRow.Cells["CodigoPaciente"].Value);
            NovoDetalhe.ShowDialog();

            LoadConsultas();
        }
    }
}
