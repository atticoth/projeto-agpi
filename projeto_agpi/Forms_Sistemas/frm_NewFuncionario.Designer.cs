
namespace projeto_agpi.Views
{
    partial class frm_NewFuncionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Atualizar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtn_Medico = new System.Windows.Forms.RadioButton();
            this.rdbtn_Administrativo = new System.Windows.Forms.RadioButton();
            this.rdbtn_Master = new System.Windows.Forms.RadioButton();
            this.txt_ConfirmSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Salvar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbx_Inativo = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.txt_Cargo = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_Telefone);
            this.panel1.Controls.Add(this.txt_Cargo);
            this.panel1.Controls.Add(this.txt_CPF);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Atualizar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdbtn_Medico);
            this.panel1.Controls.Add(this.rdbtn_Administrativo);
            this.panel1.Controls.Add(this.rdbtn_Master);
            this.panel1.Controls.Add(this.txt_ConfirmSenha);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_Senha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.Add(this.lbl_Nome);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 343);
            this.panel1.TabIndex = 95;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Atualizar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_Atualizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Atualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Atualizar.IconSize = 30;
            this.btn_Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Atualizar.Location = new System.Drawing.Point(349, 293);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(100, 33);
            this.btn_Atualizar.TabIndex = 117;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 115;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 113;
            this.label3.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 112;
            this.label1.Text = "Perfil:";
            // 
            // rdbtn_Medico
            // 
            this.rdbtn_Medico.AutoSize = true;
            this.rdbtn_Medico.Location = new System.Drawing.Point(349, 258);
            this.rdbtn_Medico.Name = "rdbtn_Medico";
            this.rdbtn_Medico.Size = new System.Drawing.Size(60, 17);
            this.rdbtn_Medico.TabIndex = 111;
            this.rdbtn_Medico.TabStop = true;
            this.rdbtn_Medico.Text = "Médico";
            this.rdbtn_Medico.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Administrativo
            // 
            this.rdbtn_Administrativo.AutoSize = true;
            this.rdbtn_Administrativo.Location = new System.Drawing.Point(253, 258);
            this.rdbtn_Administrativo.Name = "rdbtn_Administrativo";
            this.rdbtn_Administrativo.Size = new System.Drawing.Size(90, 17);
            this.rdbtn_Administrativo.TabIndex = 110;
            this.rdbtn_Administrativo.TabStop = true;
            this.rdbtn_Administrativo.Text = "Administrativo";
            this.rdbtn_Administrativo.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Master
            // 
            this.rdbtn_Master.AutoSize = true;
            this.rdbtn_Master.Location = new System.Drawing.Point(190, 258);
            this.rdbtn_Master.Name = "rdbtn_Master";
            this.rdbtn_Master.Size = new System.Drawing.Size(57, 17);
            this.rdbtn_Master.TabIndex = 109;
            this.rdbtn_Master.TabStop = true;
            this.rdbtn_Master.Text = "Master";
            this.rdbtn_Master.UseVisualStyleBackColor = true;
            // 
            // txt_ConfirmSenha
            // 
            this.txt_ConfirmSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmSenha.Location = new System.Drawing.Point(190, 94);
            this.txt_ConfirmSenha.Name = "txt_ConfirmSenha";
            this.txt_ConfirmSenha.Size = new System.Drawing.Size(275, 26);
            this.txt_ConfirmSenha.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 106;
            this.label6.Text = "Confirme a Senha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 105;
            this.label7.Text = "Cargo:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(190, 62);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(275, 26);
            this.txt_Senha.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 103;
            this.label2.Text = "Senha:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(190, 30);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(275, 26);
            this.txt_Nome.TabIndex = 97;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(31, 33);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(153, 18);
            this.lbl_Nome.TabIndex = 94;
            this.lbl_Nome.Text = "Nome e Sobrenome:";
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
            this.btn_Salvar.Location = new System.Drawing.Point(360, 293);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(89, 33);
            this.btn_Salvar.TabIndex = 68;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.cbx_Inativo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 31);
            this.panel3.TabIndex = 98;
            // 
            // cbx_Inativo
            // 
            this.cbx_Inativo.AutoSize = true;
            this.cbx_Inativo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Inativo.Location = new System.Drawing.Point(436, 6);
            this.cbx_Inativo.Name = "cbx_Inativo";
            this.cbx_Inativo.Size = new System.Drawing.Size(68, 21);
            this.cbx_Inativo.TabIndex = 9;
            this.cbx_Inativo.Text = "Inativo";
            this.cbx_Inativo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 58);
            this.panel2.TabIndex = 97;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(172, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 27);
            this.label15.TabIndex = 7;
            this.label15.Text = "FUNCIONÁRIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 118;
            this.label5.Text = "CPF:";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPF.Location = new System.Drawing.Point(190, 126);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(275, 26);
            this.txt_CPF.TabIndex = 119;
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cargo.Location = new System.Drawing.Point(190, 158);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(275, 26);
            this.txt_Cargo.TabIndex = 120;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.Location = new System.Drawing.Point(190, 188);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(275, 26);
            this.txt_Telefone.TabIndex = 121;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(190, 220);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(275, 26);
            this.txt_Email.TabIndex = 122;
            // 
            // frm_NewFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 434);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_NewFuncionario";
            this.Text = "frm_NewPaciente";
            this.Load += new System.EventHandler(this.frm_NewFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Salvar;
        private System.Windows.Forms.TextBox txt_ConfirmSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtn_Medico;
        private System.Windows.Forms.RadioButton rdbtn_Administrativo;
        private System.Windows.Forms.RadioButton rdbtn_Master;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_Atualizar;
        private System.Windows.Forms.CheckBox cbx_Inativo;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Cargo;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.Label label5;
    }
}