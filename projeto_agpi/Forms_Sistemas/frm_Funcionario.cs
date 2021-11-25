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
    partial class frm_Funcionario : Forms_Default.frm_Consulta_Mod
    {
        int id = 0;
        public frm_Funcionario() : base("DEFAULT_SELECT_FUNCIONARIOS", true, Forms_Default.GridMode.Infragistics)
        {
            InitializeComponent();
        }

        protected override void ConfigGrid()
        {
            if (!ugConsulta.DisplayLayout.Bands[0].Columns.Exists("AbrePopup"))
            {
                ugConsulta.DisplayLayout.Bands[0].Columns.Add("AbrePopup", "Editar");
            }

            ugConsulta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].Header.VisiblePosition = 9;
            ugConsulta.DisplayLayout.Override.CellButtonAppearance.Image = Properties.Resources.grayicons__1_;
            ugConsulta.DisplayLayout.Override.CellButtonAppearance.ImageHAlign = Infragistics.Win.HAlign.Center;
            ugConsulta.DisplayLayout.Override.CellButtonAppearance.ImageVAlign = Infragistics.Win.VAlign.Middle;
            ugConsulta.DisplayLayout.Bands[0].Columns["AbrePopup"].CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ugConsulta.DisplayLayout.Bands[0].Columns["Inativo"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.FormattedText;

        }

        protected override List<SqlParameter> Filtros()
        {
            return base.Filtros();
        }

        protected override void tsbn_NewRow_Click(object sender, EventArgs e)
        {
            
            var NovoDetalhe = new frm_NewFuncionario(id);
            var NovoPopup = new Forms_Default.frm_PopUp(NovoDetalhe, "Novo Consulta", true);
            NovoPopup.ShowDialog();

            LoadData();
        }

        protected override void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string cpf = txt_PesquisaCPF.Text;

            PesquisarCPF("DEFAULT_SELECT_FUNCIONARIOS_CPF", cpf);
        }

        private void ugConsulta_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            var NovoDetalhe = new frm_NewFuncionario((int)ugConsulta.ActiveRow.Cells["CodFunc"].Value);
            var NovoPopup = new Forms_Default.frm_PopUp(NovoDetalhe, "Detalhes Atendimento", true);
            NovoPopup.ShowDialog();

            LoadData();
        }
    }
}
