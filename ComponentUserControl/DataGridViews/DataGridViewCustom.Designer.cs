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
            this.tblLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPagination = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPages = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTrangHienTai = new System.Windows.Forms.Label();
            this.btnBack = new Components.Buttons.ButtonCustom();
            this.btnNext = new Components.Buttons.ButtonCustom();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tblLayoutMain.SuspendLayout();
            this.tblLayoutControls.SuspendLayout();
            this.tblLayoutPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutMain
            // 
            this.tblLayoutMain.ColumnCount = 1;
            this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMain.Controls.Add(this.tblLayoutControls, 0, 1);
            this.tblLayoutMain.Controls.Add(this.dgv, 0, 0);
            this.tblLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblLayoutMain.Name = "tblLayoutMain";
            this.tblLayoutMain.RowCount = 2;
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblLayoutMain.Size = new System.Drawing.Size(1568, 964);
            this.tblLayoutMain.TabIndex = 0;
            // 
            // tblLayoutControls
            // 
            this.tblLayoutControls.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tblLayoutControls.ColumnCount = 4;
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.31746F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.68254F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 915F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tblLayoutControls.Controls.Add(this.tblLayoutPagination, 2, 0);
            this.tblLayoutControls.Controls.Add(this.lblTrangHienTai, 0, 0);
            this.tblLayoutControls.Controls.Add(this.btnBack, 1, 0);
            this.tblLayoutControls.Controls.Add(this.btnNext, 3, 0);
            this.tblLayoutControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutControls.ForeColor = System.Drawing.Color.White;
            this.tblLayoutControls.Location = new System.Drawing.Point(4, 878);
            this.tblLayoutControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblLayoutControls.Name = "tblLayoutControls";
            this.tblLayoutControls.RowCount = 1;
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutControls.Size = new System.Drawing.Size(1560, 81);
            this.tblLayoutControls.TabIndex = 1;
            this.tblLayoutControls.Paint += new System.Windows.Forms.PaintEventHandler(this.tblLayoutControls_Paint);
            // 
            // tblLayoutPagination
            // 
            this.tblLayoutPagination.ColumnCount = 3;
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLayoutPagination.Controls.Add(this.flowLayoutPages, 1, 0);
            this.tblLayoutPagination.Location = new System.Drawing.Point(423, 5);
            this.tblLayoutPagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblLayoutPagination.Name = "tblLayoutPagination";
            this.tblLayoutPagination.Padding = new System.Windows.Forms.Padding(6);
            this.tblLayoutPagination.RowCount = 1;
            this.tblLayoutPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.Size = new System.Drawing.Size(742, 71);
            this.tblLayoutPagination.TabIndex = 2;
            // 
            // flowLayoutPages
            // 
            this.flowLayoutPages.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPages.Location = new System.Drawing.Point(70, 11);
            this.flowLayoutPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPages.Name = "flowLayoutPages";
            this.flowLayoutPages.Size = new System.Drawing.Size(602, 49);
            this.flowLayoutPages.TabIndex = 5;
            // 
            // lblTrangHienTai
            // 
            this.lblTrangHienTai.AutoSize = true;
            this.lblTrangHienTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrangHienTai.Location = new System.Drawing.Point(4, 0);
            this.lblTrangHienTai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangHienTai.Name = "lblTrangHienTai";
            this.lblTrangHienTai.Size = new System.Drawing.Size(245, 81);
            this.lblTrangHienTai.TabIndex = 0;
            this.lblTrangHienTai.Text = "Trang";
            this.lblTrangHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnBack.BorderRadius = 8;
            this.btnBack.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(257, 5);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.btnBack.Size = new System.Drawing.Size(112, 59);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnNext.BorderRadius = 8;
            this.btnNext.BorderSize = 0;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(1338, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.btnNext.Size = new System.Drawing.Size(112, 59);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(4, 5);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1560, 863);
            this.dgv.TabIndex = 2;
            // 
            // DataGridViewCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataGridViewCustom";
            this.Size = new System.Drawing.Size(1568, 964);
            this.Load += new System.EventHandler(this.DataGridViewCustom_Load);
            this.tblLayoutMain.ResumeLayout(false);
            this.tblLayoutControls.ResumeLayout(false);
            this.tblLayoutControls.PerformLayout();
            this.tblLayoutPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tblLayoutControls;
        private System.Windows.Forms.Label lblTrangHienTai;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPagination;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPages;
        private System.Windows.Forms.DataGridView dgv;
        private Components.Buttons.ButtonCustom btnBack;
        private Components.Buttons.ButtonCustom btnNext;
    }
}
