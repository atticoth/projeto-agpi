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
    public partial class frm_Historico : Forms_Default.frm_Consulta_Mod
    {
        public frm_Historico() : base("DEFAULT_SELECT_HISTORICO_CONSULTA", true, Forms_Default.GridMode.Infragistics)
        {
            InitializeComponent();
        }

        protected override void ConfigGrid()
        {
            this.ugConsulta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ugConsulta.DisplayLayout.Bands[0].Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ugConsulta.DisplayLayout.Bands[0].Columns[0].CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit;
            ugConsulta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ugConsulta.DisplayLayout.Bands[0].Columns["Consulta_Finalizada"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.FormattedText;
        }

        protected override List<SqlParameter> Filtros()
        {
            return base.Filtros();
        }

        protected override void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string cpf = txt_PesquisaCPF.Text;

            PesquisarCPF("DEFAULT_SELECT_HISTORICO_CONSULTA_CPF", cpf);
        }
    }
}
