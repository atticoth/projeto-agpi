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
    partial class frm_Consulta : Forms_Default.frm_Consulta_Mod
    {
        public frm_Consulta() : base ("DEFAULT_SELECT_CONSULTA_AGENDADA", true, Forms_Default.GridMode.Infragistics)
        {
            InitializeComponent();
            this.ugConsulta.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ugConsulta_ClickCellButton);
        }

        protected override void ConfigGrid()
        {
            if (!ugConsulta.DisplayLayout.Bands[0].Columns.Exists("AbrePopup"))
            {
                ugConsulta.DisplayLayout.Bands[0].Columns.Add("AbrePopup", "Detalhes");
            }

            ugConsulta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].Header.VisiblePosition = 7;
            ugConsulta.DisplayLayout.Override.CellButtonAppearance.Image = Properties.Resources.grayicons__45_;
            ugConsulta.DisplayLayout.Override.CellButtonAppearance.ImageHAlign = Infragistics.Win.HAlign.Center;
            ugConsulta.DisplayLayout.Override.CellButtonAppearance.ImageVAlign = Infragistics.Win.VAlign.Middle;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
        }

        protected override List<SqlParameter> Filtros()
        {
            return base.Filtros();
        }

        private void ugConsulta_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {

        }
    }
}
