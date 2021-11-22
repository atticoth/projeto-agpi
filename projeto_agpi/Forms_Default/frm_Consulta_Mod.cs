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

namespace projeto_agpi.Forms_Default
{
    public enum GridMode
    {
        DatagridView = 1,
        Infragistics = 2
    }

    public partial class frm_Consulta_Mod : Form
    {
        //private DataSet myDataSet;
        protected string strProc;
        protected bool blnAutoExec;

        public frm_Consulta_Mod()
        {
            InitializeComponent();
        }

        public frm_Consulta_Mod(string strProcedure, bool execOnLoad = false, GridMode viewMode = GridMode.Infragistics)
        {
            InitializeComponent();
            this.strProc = strProcedure;
            this.blnAutoExec = execOnLoad;
            this.ViewMode = viewMode;
        }

        protected virtual void ConfigGrid()
        {
        }

        protected virtual List<SqlParameter>Filtros()
        {
            return null;
        }

        protected void LoadData(List<SqlParameter> param = null)
        {
            try
            {
                this.ugConsulta.DataSource = this.bdSource;

                SqlCommand objCommand = new SqlCommand(strProc, frm_Main.Connection());
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable DtUser = new DataTable();

                objAdp.Fill(DtUser);

                bdSource.DataSource = null;
                bdSource.DataSource = DtUser;
                bdNavigator.BindingSource = bdSource;

                ConfigGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void LerForm()
        {
            if(blnAutoExec)
                LoadData(Filtros());
        }

        protected void RecarregaGrid()
        {
            if (blnAutoExec)
                LoadData(Filtros());
            else
                ugConsulta.DataSource = null;
        }

        protected void AdicionarNovaLinha()
        {
            if (ViewMode == GridMode.Infragistics)
            {
                ugConsulta.DisplayLayout.Bands[0].AddNew();
            }
        }

        protected virtual void bnNovoItem_Click(object sender, EventArgs e)
        {
            AdicionarNovaLinha();
        }

        private void frm_Consulta_Mod_Load(object sender, EventArgs e)
        {
            LerForm();
        }
    }
}
