﻿using System;
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
    partial class frm_Paciente : Forms_Default.frm_Consulta_Mod
    {
        public frm_Paciente() : base("DEFAULT_SELECT_PACIENTE", true, Forms_Default.GridMode.Infragistics)
        {
            InitializeComponent();
        }

        protected override void ConfigGrid()
        {
            this.ugConsulta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ugConsulta.DisplayLayout.Bands[0].Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ugConsulta.DisplayLayout.Bands[0].Columns[0].CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit;
            ugConsulta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
        }

        protected override List<SqlParameter> Filtros()
        {
            return base.Filtros();
        }

        protected override void tsbn_NewRow_Click(object sender, EventArgs e)
        {
            frm_NewPaciente newPaciente = new frm_NewPaciente();
            newPaciente.ShowDialog();
            LoadData();
        }
    }
}
