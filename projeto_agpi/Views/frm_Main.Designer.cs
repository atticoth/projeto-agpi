
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMédico = new FontAwesome.Sharp.IconButton();
            this.btnTriagem = new FontAwesome.Sharp.IconButton();
            this.btnConsultas = new FontAwesome.Sharp.IconButton();
            this.btnPaciente = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.btnMédico);
            this.pnlMenu.Controls.Add(this.btnTriagem);
            this.pnlMenu.Controls.Add(this.btnConsultas);
            this.pnlMenu.Controls.Add(this.btnPaciente);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 661);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnMédico
            // 
            this.btnMédico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMédico.FlatAppearance.BorderSize = 0;
            this.btnMédico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMédico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMédico.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMédico.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.btnMédico.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMédico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMédico.IconSize = 38;
            this.btnMédico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMédico.Location = new System.Drawing.Point(0, 280);
            this.btnMédico.Name = "btnMédico";
            this.btnMédico.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMédico.Size = new System.Drawing.Size(250, 60);
            this.btnMédico.TabIndex = 5;
            this.btnMédico.Text = " Médico";
            this.btnMédico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMédico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMédico.UseVisualStyleBackColor = true;
            this.btnMédico.Click += new System.EventHandler(this.btnMédico_Click);
            // 
            // btnTriagem
            // 
            this.btnTriagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTriagem.FlatAppearance.BorderSize = 0;
            this.btnTriagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriagem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTriagem.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            this.btnTriagem.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTriagem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTriagem.IconSize = 38;
            this.btnTriagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTriagem.Location = new System.Drawing.Point(0, 220);
            this.btnTriagem.Name = "btnTriagem";
            this.btnTriagem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTriagem.Size = new System.Drawing.Size(250, 60);
            this.btnTriagem.TabIndex = 4;
            this.btnTriagem.Text = " Triagem";
            this.btnTriagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTriagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTriagem.UseVisualStyleBackColor = true;
            this.btnTriagem.Click += new System.EventHandler(this.btnTriagem_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsultas.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnConsultas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultas.IconSize = 38;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(0, 160);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsultas.Size = new System.Drawing.Size(250, 60);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = " Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPaciente.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.btnPaciente.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaciente.IconSize = 38;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 100);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPaciente.Size = new System.Drawing.Size(250, 60);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = " Paciente";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.btnHome);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.LightGray;
            this.btnHome.Location = new System.Drawing.Point(56, 33);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(86, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "AGPI";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.lblUserName);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(250, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1084, 75);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(941, 43);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(54, 24);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = " User";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(992, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 31);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 25;
            this.btnMaximize.Location = new System.Drawing.Point(1020, -2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 31);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(1049, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(63, 33);
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
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 19);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(51, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.LightGray;
            this.pnlDesktop.Controls.Add(this.label1);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(250, 75);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1084, 586);
            this.pnlDesktop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(441, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "AGPI";
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(250, 75);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(1084, 9);
            this.pnlShadow.TabIndex = 3;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 661);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label btnHome;
        private System.Windows.Forms.Panel pnlDesktop;
        private FontAwesome.Sharp.IconButton btnConsultas;
        private FontAwesome.Sharp.IconButton btnPaciente;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlShadow;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconButton btnTriagem;
        private FontAwesome.Sharp.IconButton btnMédico;
    }
}

