
namespace projeto_agpi
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btn_Historico = new FontAwesome.Sharp.IconButton();
            this.btn_NovoUsuario = new FontAwesome.Sharp.IconButton();
            this.btn_Atendimento = new FontAwesome.Sharp.IconButton();
            this.btn_Consultas = new FontAwesome.Sharp.IconButton();
            this.btn_Paciente = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.ptbx_Home = new System.Windows.Forms.PictureBox();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.btn_Historico);
            this.pnlMenu.Controls.Add(this.btn_NovoUsuario);
            this.pnlMenu.Controls.Add(this.btn_Atendimento);
            this.pnlMenu.Controls.Add(this.btn_Consultas);
            this.pnlMenu.Controls.Add(this.btn_Paciente);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(198, 547);
            this.pnlMenu.TabIndex = 0;
            // 
            // btn_Historico
            // 
            this.btn_Historico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Historico.FlatAppearance.BorderSize = 0;
            this.btn_Historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Historico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Historico.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Historico.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btn_Historico.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Historico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Historico.IconSize = 38;
            this.btn_Historico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Historico.Location = new System.Drawing.Point(0, 280);
            this.btn_Historico.Name = "btn_Historico";
            this.btn_Historico.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Historico.Size = new System.Drawing.Size(198, 60);
            this.btn_Historico.TabIndex = 7;
            this.btn_Historico.Text = " Histórico";
            this.btn_Historico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Historico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Historico.UseVisualStyleBackColor = true;
            this.btn_Historico.Click += new System.EventHandler(this.btn_Historico_Click);
            // 
            // btn_NovoUsuario
            // 
            this.btn_NovoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NovoUsuario.FlatAppearance.BorderSize = 0;
            this.btn_NovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_NovoUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_NovoUsuario.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_NovoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NovoUsuario.IconSize = 38;
            this.btn_NovoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NovoUsuario.Location = new System.Drawing.Point(-3, 487);
            this.btn_NovoUsuario.Name = "btn_NovoUsuario";
            this.btn_NovoUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_NovoUsuario.Size = new System.Drawing.Size(201, 60);
            this.btn_NovoUsuario.TabIndex = 6;
            this.btn_NovoUsuario.Text = " Novo Usuário";
            this.btn_NovoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NovoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NovoUsuario.UseVisualStyleBackColor = true;
            this.btn_NovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btn_Atendimento
            // 
            this.btn_Atendimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Atendimento.FlatAppearance.BorderSize = 0;
            this.btn_Atendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atendimento.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Atendimento.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.btn_Atendimento.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Atendimento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Atendimento.IconSize = 38;
            this.btn_Atendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Atendimento.Location = new System.Drawing.Point(0, 220);
            this.btn_Atendimento.Name = "btn_Atendimento";
            this.btn_Atendimento.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Atendimento.Size = new System.Drawing.Size(198, 60);
            this.btn_Atendimento.TabIndex = 5;
            this.btn_Atendimento.Text = " Atendimento";
            this.btn_Atendimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Atendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Atendimento.UseVisualStyleBackColor = true;
            this.btn_Atendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
            // 
            // btn_Consultas
            // 
            this.btn_Consultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Consultas.FlatAppearance.BorderSize = 0;
            this.btn_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Consultas.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btn_Consultas.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Consultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Consultas.IconSize = 38;
            this.btn_Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consultas.Location = new System.Drawing.Point(0, 160);
            this.btn_Consultas.Name = "btn_Consultas";
            this.btn_Consultas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Consultas.Size = new System.Drawing.Size(198, 60);
            this.btn_Consultas.TabIndex = 3;
            this.btn_Consultas.Text = " Consultas";
            this.btn_Consultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Consultas.UseVisualStyleBackColor = true;
            this.btn_Consultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btn_Paciente
            // 
            this.btn_Paciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Paciente.FlatAppearance.BorderSize = 0;
            this.btn_Paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Paciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Paciente.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.btn_Paciente.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Paciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Paciente.IconSize = 38;
            this.btn_Paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Paciente.Location = new System.Drawing.Point(0, 100);
            this.btn_Paciente.Name = "btn_Paciente";
            this.btn_Paciente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Paciente.Size = new System.Drawing.Size(198, 60);
            this.btn_Paciente.TabIndex = 1;
            this.btn_Paciente.Text = " Paciente";
            this.btn_Paciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Paciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Paciente.UseVisualStyleBackColor = true;
            this.btn_Paciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.lbl_Logo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(198, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Logo.AutoSize = true;
            this.lbl_Logo.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logo.ForeColor = System.Drawing.Color.White;
            this.lbl_Logo.Location = new System.Drawing.Point(22, 21);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(150, 57);
            this.lbl_Logo.TabIndex = 0;
            this.lbl_Logo.Text = "AGPI";
            this.lbl_Logo.Click += new System.EventHandler(this.lbl_Logo_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.lblUserName);
            this.pnlTitleBar.Controls.Add(this.btn_Minimize);
            this.pnlTitleBar.Controls.Add(this.btn_Maximize);
            this.pnlTitleBar.Controls.Add(this.btn_Close);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(198, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1022, 69);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(772, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(54, 24);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = " User";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 25;
            this.btn_Minimize.Location = new System.Drawing.Point(930, -2);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(32, 31);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_Maximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximize.IconSize = 25;
            this.btn_Maximize.Location = new System.Drawing.Point(958, -2);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(32, 31);
            this.btn_Maximize.TabIndex = 3;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Close.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 25;
            this.btn_Close.Location = new System.Drawing.Point(987, -2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(32, 31);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(63, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = " Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 50;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 13);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(51, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Controls.Add(this.ptbx_Home);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(198, 69);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1022, 478);
            this.pnlDesktop.TabIndex = 2;
            // 
            // ptbx_Home
            // 
            this.ptbx_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbx_Home.Image = ((System.Drawing.Image)(resources.GetObject("ptbx_Home.Image")));
            this.ptbx_Home.Location = new System.Drawing.Point(221, 82);
            this.ptbx_Home.Name = "ptbx_Home";
            this.ptbx_Home.Size = new System.Drawing.Size(588, 309);
            this.ptbx_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbx_Home.TabIndex = 1;
            this.ptbx_Home.TabStop = false;
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(198, 69);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(1022, 9);
            this.pnlShadow.TabIndex = 3;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 547);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlDesktop;
        private FontAwesome.Sharp.IconButton btn_Consultas;
        private FontAwesome.Sharp.IconButton btn_Paciente;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlShadow;
        private FontAwesome.Sharp.IconButton btn_Close;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconButton btn_Atendimento;
        private System.Windows.Forms.PictureBox ptbx_Home;
        private System.Windows.Forms.Label lbl_Logo;
        private FontAwesome.Sharp.IconButton btn_NovoUsuario;
        private FontAwesome.Sharp.IconButton btn_Historico;
    }
}

