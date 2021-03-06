using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using projeto_agpi.Forms_Sistemas;
using projeto_agpi.Views;

namespace projeto_agpi
{
    public partial class frm_Main : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public string userName;
        public int codID;
        public int codPerfil;

        public frm_Main(int Id)
        {
            codID = Id; 
            InitializeComponent();
            SelectUserName(codID);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            pnlMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public static SqlConnection Connection()
        {
            return new SqlConnection(@"Data Source = ITLNB064A\SQL2017; Initial Catalog = DB_AGPI; Integrated Security = True");
        }

        public void SelectUserName(int codID)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = String.Format("DEFAULT_SELECT_FUNCIONARIO_MAIN");
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@CodFunc", codID));
                        var reader = sqlComando.ExecuteReader();

                        dataTable.Load(reader);
                    }
                }

                userName = dataTable.Rows[0].ItemArray[0].ToString();
                codPerfil = int.Parse(dataTable.Rows[0].ItemArray[2].ToString());
                lblUserName.Text = userName;
            }
            catch (SqlException ex)
            {
                lblUserName.Text = "User";
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();

                //Botão
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                
                //Borda a esquerda
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icone Titulo
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

                //Titulo
                lblTitle.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //Formulário aberto apenas
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitle.Text = "Home";
        }



        private void frm_Main_Load(object sender, EventArgs e)
        {
            if(codPerfil == 3)
            {
                btn_Atendimento.Visible = false;
                btn_NovoUsuario.Visible = false;
            }

            if(codPerfil == 2)
            {
                btn_Consultas.Visible = false;
                btn_Paciente.Visible = false;
                btn_NovoUsuario.Visible = false;
            }

            if (codPerfil == 1)
            {
                btn_Consultas.Visible = true;
                btn_Paciente.Visible = true;
                btn_Atendimento.Visible = true;
                btn_NovoUsuario.Visible = true;
            }
        }

        private void lbl_Logo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frm_Paciente(codID));
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frm_Agendamento(codID));
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frm_Consulta(codID));
        }

        private void btn_Historico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new frm_Historico());
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frm_Funcionario());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
