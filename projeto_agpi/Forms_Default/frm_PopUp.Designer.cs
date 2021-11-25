namespace projeto_agpi.Forms_Default
{
    partial class frm_PopUp
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
            this.PnForm = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Pn = new System.Windows.Forms.Panel();
            this.btClose = new FontAwesome.Sharp.IconButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnForm
            // 
            this.PnForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnForm.BackColor = System.Drawing.Color.White;
            this.PnForm.ForeColor = System.Drawing.Color.Black;
            this.PnForm.Location = new System.Drawing.Point(1, 26);
            this.PnForm.Name = "PnForm";
            this.PnForm.Size = new System.Drawing.Size(498, 232);
            this.PnForm.TabIndex = 4;
            this.PnForm.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PnForm_ControlRemoved);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(30)))), ((int)(((byte)(74)))));
            this.Panel1.Controls.Add(this.Pn);
            this.Panel1.Controls.Add(this.lbTitle);
            this.Panel1.ForeColor = System.Drawing.Color.White;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(500, 26);
            this.Panel1.TabIndex = 3;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // Pn
            // 
            this.Pn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(30)))), ((int)(((byte)(74)))));
            this.Pn.Controls.Add(this.btClose);
            this.Pn.Location = new System.Drawing.Point(472, 0);
            this.Pn.Name = "Pn";
            this.Pn.Size = new System.Drawing.Size(28, 31);
            this.Pn.TabIndex = 20;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btClose.IconSize = 20;
            this.btClose.Location = new System.Drawing.Point(2, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 20);
            this.btClose.TabIndex = 5;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click_1);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(30)))), ((int)(((byte)(74)))));
            this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(24, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(86, 15);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Tela de Default";
            // 
            // frm_PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(30)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.PnForm);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PopUp";
            this.Text = "frm_PopUp";
            this.Load += new System.EventHandler(this.frm_PopUp_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Pn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PnForm;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Pn;
        internal System.Windows.Forms.Label lbTitle;
        private FontAwesome.Sharp.IconButton btClose;
    }
}