namespace ComponentUserControl.DataGridViews
{
    partial class DataGridViewCustom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewCustom));
            this.tblLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPagination = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTrangHienTai = new System.Windows.Forms.Label();
            this.cbbSelectPageSize = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblLayoutMain.SuspendLayout();
            this.tblLayoutControls.SuspendLayout();
            this.tblLayoutPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutMain
            // 
            this.tblLayoutMain.ColumnCount = 1;
            this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutMain.Controls.Add(this.tblLayoutControls, 0, 1);
            this.tblLayoutMain.Controls.Add(this.dgv, 0, 0);
            this.tblLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutMain.Name = "tblLayoutMain";
            this.tblLayoutMain.RowCount = 2;
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblLayoutMain.Size = new System.Drawing.Size(1272, 609);
            this.tblLayoutMain.TabIndex = 0;
            // 
            // tblLayoutControls
            // 
            this.tblLayoutControls.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblLayoutControls.ColumnCount = 5;
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tblLayoutControls.Controls.Add(this.tblLayoutPagination, 2, 0);
            this.tblLayoutControls.Controls.Add(this.lblTrangHienTai, 0, 0);
            this.tblLayoutControls.Controls.Add(this.cbbSelectPageSize, 4, 0);
            this.tblLayoutControls.Controls.Add(this.btnBack, 1, 0);
            this.tblLayoutControls.Controls.Add(this.btnNext, 3, 0);
            this.tblLayoutControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLayoutControls.ForeColor = System.Drawing.Color.White;
            this.tblLayoutControls.Location = new System.Drawing.Point(0, 540);
            this.tblLayoutControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutControls.Name = "tblLayoutControls";
            this.tblLayoutControls.RowCount = 1;
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutControls.Size = new System.Drawing.Size(1272, 69);
            this.tblLayoutControls.TabIndex = 1;
            // 
            // tblLayoutPagination
            // 
            this.tblLayoutPagination.AutoScroll = true;
            this.tblLayoutPagination.BackColor = System.Drawing.Color.Transparent;
            this.tblLayoutPagination.ColumnCount = 3;
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPagination.Controls.Add(this.flowLayoutPagination, 1, 0);
            this.tblLayoutPagination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPagination.Location = new System.Drawing.Point(306, 0);
            this.tblLayoutPagination.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutPagination.Name = "tblLayoutPagination";
            this.tblLayoutPagination.RowCount = 1;
            this.tblLayoutPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.Size = new System.Drawing.Size(635, 69);
            this.tblLayoutPagination.TabIndex = 2;
            // 
            // flowLayoutPagination
            // 
            this.flowLayoutPagination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPagination.Location = new System.Drawing.Point(24, 5);
            this.flowLayoutPagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPagination.Name = "flowLayoutPagination";
            this.flowLayoutPagination.Size = new System.Drawing.Size(587, 59);
            this.flowLayoutPagination.TabIndex = 0;
            // 
            // lblTrangHienTai
            // 
            this.lblTrangHienTai.AutoSize = true;
            this.lblTrangHienTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrangHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangHienTai.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTrangHienTai.Location = new System.Drawing.Point(4, 0);
            this.lblTrangHienTai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangHienTai.Name = "lblTrangHienTai";
            this.lblTrangHienTai.Size = new System.Drawing.Size(172, 69);
            this.lblTrangHienTai.TabIndex = 0;
            this.lblTrangHienTai.Text = "Trang";
            this.lblTrangHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbSelectPageSize
            // 
            this.cbbSelectPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbbSelectPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectPageSize.FormattingEnabled = true;
            this.cbbSelectPageSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbSelectPageSize.Location = new System.Drawing.Point(1083, 12);
            this.cbbSelectPageSize.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.cbbSelectPageSize.Name = "cbbSelectPageSize";
            this.cbbSelectPageSize.Size = new System.Drawing.Size(172, 37);
            this.cbbSelectPageSize.TabIndex = 5;
            this.cbbSelectPageSize.SelectedValueChanged += new System.EventHandler(this.cbbSelectPageSize_SelectedValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(228, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 63);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(944, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 63);
            this.btnNext.TabIndex = 7;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(4, 5);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1264, 530);
            this.dgv.TabIndex = 2;
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(129, 42);
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(128, 38);
            this.xoáToolStripMenuItem.Text = "Xoá";
            // 
            // DataGridViewCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataGridViewCustom";
            this.Size = new System.Drawing.Size(1272, 609);
            this.tblLayoutMain.ResumeLayout(false);
            this.tblLayoutControls.ResumeLayout(false);
            this.tblLayoutControls.PerformLayout();
            this.tblLayoutPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tblLayoutControls;
        private System.Windows.Forms.Label lblTrangHienTai;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPagination;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbbSelectPageSize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPagination;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
    }
}
