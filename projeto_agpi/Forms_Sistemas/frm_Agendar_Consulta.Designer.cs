
namespace projeto_agpi.Views
{
    partial class frm_Agendar_Consulta
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PesquisaCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NomePaciente = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_HorarioConsulta = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new FontAwesome.Sharp.IconButton();
            this.btn_Limpar = new FontAwesome.Sharp.IconButton();
            this.btn_Salvar = new FontAwesome.Sharp.IconButton();
            this.cboDoutores = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Doutor(a):";
            // 
            // dtDataConsulta
            // 
            this.dtDataConsulta.Location = new System.Drawing.Point(174, 146);
            this.dtDataConsulta.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dtDataConsulta.Name = "dtDataConsulta";
            this.dtDataConsulta.Size = new System.Drawing.Size(230, 20);
            this.dtDataConsulta.TabIndex = 42;
            this.dtDataConsulta.Value = new System.DateTime(2021, 11, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Data da Consulta:";
            // 
            // txt_PesquisaCPF
            // 
            this.txt_PesquisaCPF.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PesquisaCPF.Location = new System.Drawing.Point(174, 48);
            this.txt_PesquisaCPF.Name = "txt_PesquisaCPF";
            this.txt_PesquisaCPF.Size = new System.Drawing.Size(144, 23);
            this.txt_PesquisaCPF.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "CPF Paciente:";
            // 
            // txt_NomePaciente
            // 
            this.txt_NomePaciente.Enabled = false;
            this.txt_NomePaciente.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomePaciente.Location = new System.Drawing.Point(174, 90);
            this.txt_NomePaciente.Name = "txt_NomePaciente";
            this.txt_NomePaciente.Size = new System.Drawing.Size(230, 23);
            this.txt_NomePaciente.TabIndex = 37;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(27, 90);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(141, 19);
            this.lbl_Nome.TabIndex = 36;
            this.lbl_Nome.Text = "Nome do Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "Horário:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 10);
            this.panel3.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 58);
            this.panel2.TabIndex = 100;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(123, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 27);
            this.label15.TabIndex = 7;
            this.label15.Text = "NOVA CONSULTA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_HorarioConsulta);
            this.panel1.Controls.Add(this.btn_Pesquisar);
            this.panel1.Controls.Add(this.btn_Limpar);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_Nome);
            this.panel1.Controls.Add(this.txt_NomePaciente);
            this.panel1.Controls.Add(this.txt_PesquisaCPF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtDataConsulta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboDoutores);
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 299);
            this.panel1.TabIndex = 99;
            // 
            // txt_HorarioConsulta
            // 
            this.txt_HorarioConsulta.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HorarioConsulta.Location = new System.Drawing.Point(174, 170);
            this.txt_HorarioConsulta.Name = "txt_HorarioConsulta";
            this.txt_HorarioConsulta.Size = new System.Drawing.Size(230, 23);
            this.txt_HorarioConsulta.TabIndex = 73;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Pesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Pesquisar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Pesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Pesquisar.IconSize = 30;
            this.btn_Pesquisar.Location = new System.Drawing.Point(324, 40);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(53, 35);
            this.btn_Pesquisar.TabIndex = 72;
            this.btn_Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Limpar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_Limpar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Limpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Limpar.IconSize = 30;
            this.btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpar.Location = new System.Drawing.Point(240, 236);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(89, 33);
            this.btn_Limpar.TabIndex = 71;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Salvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_Salvar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Salvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Salvar.IconSize = 30;
            this.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salvar.Location = new System.Drawing.Point(335, 236);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(89, 33);
            this.btn_Salvar.TabIndex = 68;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // cboDoutores
            // 
            this.cboDoutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoutores.FormattingEnabled = true;
            this.cboDoutores.Location = new System.Drawing.Point(174, 119);
            this.cboDoutores.Name = "cboDoutores";
            this.cboDoutores.Size = new System.Drawing.Size(230, 21);
            this.cboDoutores.TabIndex = 44;
            // 
            // frm_Agendar_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 360);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Agendar_Consulta";
            this.Text = "frm_Agendar_Consulta";
            this.Load += new System.EventHandler(this.frm_Agendar_Consulta_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDataConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PesquisaCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NomePaciente;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Limpar;
        private FontAwesome.Sharp.IconButton btn_Salvar;
        private FontAwesome.Sharp.IconButton btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_HorarioConsulta;
        private System.Windows.Forms.ComboBox cboDoutores;
    }
}