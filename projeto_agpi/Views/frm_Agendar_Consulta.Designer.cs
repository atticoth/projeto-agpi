
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
            this.btnAgendar = new System.Windows.Forms.Button();
            this.cboDoutores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PesquisaCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NomePaciente = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtHorario = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendar.Location = new System.Drawing.Point(520, 225);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(83, 34);
            this.btnAgendar.TabIndex = 45;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // cboDoutores
            // 
            this.cboDoutores.FormattingEnabled = true;
            this.cboDoutores.Location = new System.Drawing.Point(520, 77);
            this.cboDoutores.Name = "cboDoutores";
            this.cboDoutores.Size = new System.Drawing.Size(203, 21);
            this.cboDoutores.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Doutor(a):";
            // 
            // dtDataConsulta
            // 
            this.dtDataConsulta.Location = new System.Drawing.Point(184, 119);
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
            this.label1.Location = new System.Drawing.Point(43, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Data da Consulta:";
            // 
            // txt_PesquisaCPF
            // 
            this.txt_PesquisaCPF.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PesquisaCPF.Location = new System.Drawing.Point(184, 34);
            this.txt_PesquisaCPF.Name = "txt_PesquisaCPF";
            this.txt_PesquisaCPF.Size = new System.Drawing.Size(144, 23);
            this.txt_PesquisaCPF.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "CPF Paciente:";
            // 
            // txt_NomePaciente
            // 
            this.txt_NomePaciente.Enabled = false;
            this.txt_NomePaciente.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomePaciente.Location = new System.Drawing.Point(184, 76);
            this.txt_NomePaciente.Name = "txt_NomePaciente";
            this.txt_NomePaciente.Size = new System.Drawing.Size(230, 23);
            this.txt_NomePaciente.TabIndex = 37;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(37, 76);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(141, 19);
            this.lbl_Nome.TabIndex = 36;
            this.lbl_Nome.Text = "Nome do Paciente:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(344, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 34);
            this.btnPesquisar.TabIndex = 59;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtHorario
            // 
            this.dtHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHorario.Location = new System.Drawing.Point(520, 118);
            this.dtHorario.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dtHorario.Name = "dtHorario";
            this.dtHorario.Size = new System.Drawing.Size(203, 20);
            this.dtHorario.TabIndex = 61;
            this.dtHorario.Value = new System.DateTime(2021, 11, 5, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "Horário:";
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoConsulta.Location = new System.Drawing.Point(184, 161);
            this.txtMotivoConsulta.Multiline = true;
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.Size = new System.Drawing.Size(230, 98);
            this.txtMotivoConsulta.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "Motivo da Consulta:";
            // 
            // frm_Agendar_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 294);
            this.Controls.Add(this.txtMotivoConsulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtHorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.cboDoutores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDataConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PesquisaCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NomePaciente);
            this.Controls.Add(this.lbl_Nome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Agendar_Consulta";
            this.Text = "frm_Agendar_Consulta";
            this.Load += new System.EventHandler(this.frm_Agendar_Consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.ComboBox cboDoutores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDataConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PesquisaCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NomePaciente;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.Label label5;
    }
}