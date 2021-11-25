using System;
using System.Drawing;
using System.Windows.Forms;

namespace projeto_agpi.Forms_Default
{
    public partial class frm_PopUp : Form
    {
        private bool MouseDw;
        private Point LstLocation;
        public bool PossibleToMaximize = true;
        private Point LastSizeLocation;
        private bool MouseSize;
        public bool PossibleToResize = true;

         public frm_PopUp(Form frmToSetInto)
        {
            InitializeComponent();
            SetingsParentScreen(frmToSetInto.Text, frmToSetInto.Size);
            SetingsChildScreen(frmToSetInto);
        }

        public frm_PopUp(Form frmToSetInto, string WindowName, bool IsPossibleToMaximize)
        {
            InitializeComponent();
            PossibleToMaximize = IsPossibleToMaximize;
            SetingsParentScreen(WindowName, frmToSetInto.Size);
            SetingsChildScreen(frmToSetInto);
        }

        public frm_PopUp(Form frmToSetInto, string WindowName, bool IsPossibleToMaximize, bool IsPossibleToResize)
        {
            InitializeComponent();
            PossibleToMaximize = IsPossibleToMaximize;
            PossibleToResize = IsPossibleToResize;
            SetingsParentScreen(WindowName, frmToSetInto.Size);
            SetingsChildScreen(frmToSetInto);
        }

        private void SetingsParentScreen(string MyName, Size MySize)
        {
            this.Text = MyName;
            lbTitle.Text = MyName;
            this.Size = MySize;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetingsChildScreen(Form frmToSetInto)
        {
            frmToSetInto.AutoScroll = true;
            frmToSetInto.TopLevel = false;
            PnForm.Controls.Add(frmToSetInto);
            frmToSetInto.FormBorderStyle = FormBorderStyle.None;
            frmToSetInto.Dock = DockStyle.Fill;
            frmToSetInto.Show();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDw = true;
            LstLocation = e.Location;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDw)
                this.Location = new Point((this.Location.X - LstLocation.X) + e.X, (this.Location.Y - LstLocation.Y) + e.Y);
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDw = false;
        }

        private void Panel2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.SizeNWSE;
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseSize = true;
            LastSizeLocation = this.Location;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseSize)
            {
                var Ver = (LastSizeLocation.X - e.X);
                var ver2 = (LastSizeLocation.Y - e.Y);

                this.Size = new Size(this.Width + e.X, this.Height + e.Y);
            }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            MouseSize = false;
        }


        private void frm_PopUp_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void PnForm_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.Close();
        }

        private void btClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
