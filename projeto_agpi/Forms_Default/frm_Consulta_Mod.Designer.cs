
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Consulta_Mod));
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ugConsulta = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btn_Pesquisar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PesquisaCPF = new System.Windows.Forms.TextBox();
            this.bdNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tsbn_NewRow = new System.Windows.Forms.ToolStripButton();
            this.bdSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugConsulta)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdNavigator)).BeginInit();
            this.bdNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Controls.Add(this.dataGridView1);
            this.pnlGrid.Controls.Add(this.ugConsulta);
            this.pnlGrid.Location = new System.Drawing.Point(0, 77);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1074, 411);
            this.pnlGrid.TabIndex = 63;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1074, 411);
            this.dataGridView1.TabIndex = 1;
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
            this.ugConsulta.Size = new System.Drawing.Size(1074, 411);
            this.ugConsulta.TabIndex = 0;
            this.ugConsulta.Text = "ultraGrid1";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.btn_Pesquisar);
            this.pnlTitle.Controls.Add(this.label4);
            this.pnlTitle.Controls.Add(this.txt_PesquisaCPF);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1074, 78);
            this.pnlTitle.TabIndex = 62;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Pesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Pesquisar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_Pesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Pesquisar.IconSize = 30;
            this.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pesquisar.Location = new System.Drawing.Point(840, 26);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(111, 33);
            this.btn_Pesquisar.TabIndex = 47;
            this.btn_Pesquisar.Text = " Pesquisar";
            this.btn_Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "CPF Paciente:";
            // 
            // txt_PesquisaCPF
            // 
            this.txt_PesquisaCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PesquisaCPF.Location = new System.Drawing.Point(149, 29);
            this.txt_PesquisaCPF.Name = "txt_PesquisaCPF";
            this.txt_PesquisaCPF.Size = new System.Drawing.Size(188, 26);
            this.txt_PesquisaCPF.TabIndex = 46;
            // 
            // bdNavigator
            // 
            this.bdNavigator.AddNewItem = null;
            this.bdNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bdNavigator.AutoSize = false;
            this.bdNavigator.CountItem = this.BindingNavigatorCountItem;
            this.bdNavigator.DeleteItem = null;
            this.bdNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bdNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.tsbn_NewRow});
            this.bdNavigator.Location = new System.Drawing.Point(0, 491);
            this.bdNavigator.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.bdNavigator.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.bdNavigator.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.bdNavigator.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.bdNavigator.Name = "bdNavigator";
            this.bdNavigator.PositionItem = this.BindingNavigatorPositionItem;
            this.bdNavigator.Size = new System.Drawing.Size(267, 30);
            this.bdNavigator.TabIndex = 2;
            this.bdNavigator.Text = "bdNavigator";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(35, 27);
            this.BindingNavigatorCountItem.Text = "of {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 27);
            this.BindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 27);
            this.BindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 27);
            this.BindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 27);
            this.BindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tsbn_NewRow
            // 
            this.tsbn_NewRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbn_NewRow.Image = global::projeto_agpi.Properties.Resources.redIcons__1_;
            this.tsbn_NewRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_NewRow.Name = "tsbn_NewRow";
            this.tsbn_NewRow.Size = new System.Drawing.Size(23, 27);
            this.tsbn_NewRow.Text = "toolStripButton2";
            this.tsbn_NewRow.Click += new System.EventHandler(this.tsbn_NewRow_Click);
            // 
            // frm_Consulta_Mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 520);
            this.Controls.Add(this.bdNavigator);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frm_Consulta_Mod";
            this.Text = "frm_Consulta_Mod";
            this.Load += new System.EventHandler(this.frm_Consulta_Mod_Load);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugConsulta)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdNavigator)).EndInit();
            this.bdNavigator.ResumeLayout(false);
            this.bdNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        protected System.Windows.Forms.Panel pnlTitle;
        protected System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        protected Infragistics.Win.UltraWinGrid.UltraGrid ugConsulta;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txt_PesquisaCPF;
        public GridMode ViewMode { get; set; }
        protected BindingSource bdSource;
        private DataGridView dataGridView1;
        protected BindingNavigator bdNavigator;
        protected internal ToolStripLabel BindingNavigatorCountItem;
        protected internal ToolStripButton BindingNavigatorMoveFirstItem;
        protected internal ToolStripButton BindingNavigatorMovePreviousItem;
        protected internal ToolStripSeparator BindingNavigatorSeparator;
        protected internal ToolStripTextBox BindingNavigatorPositionItem;
        protected internal ToolStripSeparator BindingNavigatorSeparator1;
        protected internal ToolStripButton BindingNavigatorMoveNextItem;
        protected internal ToolStripButton BindingNavigatorMoveLastItem;
        private ToolStripButton tsbn_NewRow;
        private FontAwesome.Sharp.IconButton btn_Pesquisar;
    }
}