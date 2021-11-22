
using System.Windows.Forms;

namespace projeto_agpi.Forms_Default
{
    partial class frm_Consulta_Mod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Consulta_Mod));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.bdNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnNovoItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.ugConsulta = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PesquisaCPF = new System.Windows.Forms.TextBox();
            this.bdSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdNavigator)).BeginInit();
            this.bdNavigator.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugConsulta)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdNavigator
            // 
            this.bdNavigator.AddNewItem = this.bnNovoItem;
            this.bdNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bdNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bdNavigator.DeleteItem = null;
            this.bdNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bdNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bnNovoItem});
            this.bdNavigator.Location = new System.Drawing.Point(0, 487);
            this.bdNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdNavigator.Name = "bdNavigator";
            this.bdNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bdNavigator.Size = new System.Drawing.Size(232, 25);
            this.bdNavigator.TabIndex = 64;
            this.bdNavigator.Text = "bindingNavigator1";
            // 
            // bnNovoItem
            // 
            this.bnNovoItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("bnNovoItem.Image")));
            this.bnNovoItem.Name = "bnNovoItem";
            this.bnNovoItem.RightToLeftAutoMirrorImage = true;
            this.bnNovoItem.Size = new System.Drawing.Size(23, 22);
            this.bnNovoItem.Text = "Novo Item";
            this.bnNovoItem.Click += new System.EventHandler(this.bnNovoItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Controls.Add(this.ugConsulta);
            this.pnlGrid.Location = new System.Drawing.Point(0, 77);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1074, 407);
            this.pnlGrid.TabIndex = 63;
            // 
            // ugConsulta
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ugConsulta.DisplayLayout.Appearance = appearance1;
            this.ugConsulta.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ugConsulta.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ugConsulta.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ugConsulta.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ugConsulta.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ugConsulta.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ugConsulta.DisplayLayout.MaxColScrollRegions = 1;
            this.ugConsulta.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ugConsulta.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ugConsulta.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ugConsulta.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ugConsulta.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ugConsulta.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ugConsulta.DisplayLayout.Override.CellAppearance = appearance8;
            this.ugConsulta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ugConsulta.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ugConsulta.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ugConsulta.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ugConsulta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugConsulta.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ugConsulta.DisplayLayout.Override.RowAppearance = appearance11;
            this.ugConsulta.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ugConsulta.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ugConsulta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugConsulta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugConsulta.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ugConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugConsulta.Location = new System.Drawing.Point(0, 0);
            this.ugConsulta.Name = "ugConsulta";
            this.ugConsulta.Size = new System.Drawing.Size(1074, 407);
            this.ugConsulta.TabIndex = 0;
            this.ugConsulta.Text = "ultraGrid1";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.btnPesquisar);
            this.pnlTitle.Controls.Add(this.label4);
            this.pnlTitle.Controls.Add(this.txt_PesquisaCPF);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1074, 78);
            this.pnlTitle.TabIndex = 62;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(412, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 34);
            this.btnPesquisar.TabIndex = 58;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "CPF Paciente:";
            // 
            // txt_PesquisaCPF
            // 
            this.txt_PesquisaCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PesquisaCPF.Location = new System.Drawing.Point(203, 24);
            this.txt_PesquisaCPF.Name = "txt_PesquisaCPF";
            this.txt_PesquisaCPF.Size = new System.Drawing.Size(188, 26);
            this.txt_PesquisaCPF.TabIndex = 46;
            // 
            // frm_Consulta_Mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 512);
            this.Controls.Add(this.bdNavigator);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frm_Consulta_Mod";
            this.Text = "frm_Consulta_Mod";
            this.Load += new System.EventHandler(this.frm_Consulta_Mod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdNavigator)).EndInit();
            this.bdNavigator.ResumeLayout(false);
            this.bdNavigator.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ugConsulta)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStripButton bnNovoItem;
        protected System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        protected System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        protected System.Windows.Forms.Panel pnlGrid;
        protected Infragistics.Win.UltraWinGrid.UltraGrid ugConsulta;
        protected System.Windows.Forms.Panel pnlTitle;
        protected System.Windows.Forms.Button btnPesquisar;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txt_PesquisaCPF;
        public GridMode ViewMode { get; set; }
        protected BindingSource bdSource;
        protected BindingNavigator bdNavigator;
    }
}