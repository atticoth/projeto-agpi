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
                if (ViewMode == GridMode.DatagridView)
                {
                    this.dataGridView1.DataSource = this.bdSource;
                    ugConsulta.Visible = false;
                }
                else
                {
                    this.ugConsulta.DataSource = this.bdSource;
                    dataGridView1.Visible = false;
                }

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
                dataGridView1.DataSource = null;
        }

        private void frm_Consulta_Mod_Load(object sender, EventArgs e)
        {
            LerForm();
        }


        protected void PesquisarCPF(string strProc, string cpf)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (ViewMode == GridMode.DatagridView)
                {
                    this.dataGridView1.DataSource = this.bdSource;
                    ugConsulta.Visible = false;
                }
                else
                {
                    this.ugConsulta.DataSource = this.bdSource;
                    dataGridView1.Visible = false;
                }

                SqlCommand objCommand = new SqlCommand(strProc, frm_Main.Connection());
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.Add(new SqlParameter("@CPF", cpf));
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable DtUser = new DataTable();

                objAdp.Fill(DtUser);

                bdSource.DataSource = null;
                bdSource.DataSource = DtUser;
                bdNavigator.BindingSource = bdSource;

                ConfigGrid();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        protected void LimparFiltros()
        {
            txt_PesquisaCPF.Text = " ";
            RecarregaGrid();
        }

        protected virtual void btn_Pesquisar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tsbn_NewRow_Click(object sender, EventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }
    }
}
