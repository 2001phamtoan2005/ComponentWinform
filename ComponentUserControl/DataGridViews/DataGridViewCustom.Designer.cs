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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewCustom));
            this.tblLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPagination = new System.Windows.Forms.TableLayoutPanel();
            this.lblTrangHienTai = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbbSelectPageSize = new System.Windows.Forms.ComboBox();
            this.btnBack = new Components.Buttons.ButtonCustom();
            this.btnNext = new Components.Buttons.ButtonCustom();
            this.flowLayoutPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.tblLayoutMain.SuspendLayout();
            this.tblLayoutControls.SuspendLayout();
            this.tblLayoutPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.tblLayoutMain.Name = "tblLayoutMain";
            this.tblLayoutMain.RowCount = 2;
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblLayoutMain.Size = new System.Drawing.Size(848, 390);
            this.tblLayoutMain.TabIndex = 0;
            // 
            // tblLayoutControls
            // 
            this.tblLayoutControls.BackColor = System.Drawing.Color.Silver;
            this.tblLayoutControls.ColumnCount = 5;
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblLayoutControls.Controls.Add(this.tblLayoutPagination, 2, 0);
            this.tblLayoutControls.Controls.Add(this.lblTrangHienTai, 0, 0);
            this.tblLayoutControls.Controls.Add(this.btnBack, 1, 0);
            this.tblLayoutControls.Controls.Add(this.btnNext, 3, 0);
            this.tblLayoutControls.Controls.Add(this.cbbSelectPageSize, 4, 0);
            this.tblLayoutControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutControls.ForeColor = System.Drawing.Color.White;
            this.tblLayoutControls.Location = new System.Drawing.Point(3, 349);
            this.tblLayoutControls.Name = "tblLayoutControls";
            this.tblLayoutControls.RowCount = 1;
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutControls.Size = new System.Drawing.Size(842, 38);
            this.tblLayoutControls.TabIndex = 1;
            // 
            // tblLayoutPagination
            // 
            this.tblLayoutPagination.ColumnCount = 3;
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPagination.Controls.Add(this.flowLayoutPagination, 1, 0);
            this.tblLayoutPagination.Location = new System.Drawing.Point(213, 0);
            this.tblLayoutPagination.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutPagination.Name = "tblLayoutPagination";
            this.tblLayoutPagination.Padding = new System.Windows.Forms.Padding(3);
            this.tblLayoutPagination.RowCount = 1;
            this.tblLayoutPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.Size = new System.Drawing.Size(414, 37);
            this.tblLayoutPagination.TabIndex = 2;
            // 
            // lblTrangHienTai
            // 
            this.lblTrangHienTai.AutoSize = true;
            this.lblTrangHienTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrangHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangHienTai.Location = new System.Drawing.Point(3, 0);
            this.lblTrangHienTai.Name = "lblTrangHienTai";
            this.lblTrangHienTai.Size = new System.Drawing.Size(159, 38);
            this.lblTrangHienTai.TabIndex = 0;
            this.lblTrangHienTai.Text = "Trang";
            this.lblTrangHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(842, 340);
            this.dgv.TabIndex = 2;
            // 
            // cbbSelectPageSize
            // 
            this.cbbSelectPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbbSelectPageSize.FormattingEnabled = true;
            this.cbbSelectPageSize.Location = new System.Drawing.Point(698, 3);
            this.cbbSelectPageSize.Name = "cbbSelectPageSize";
            this.cbbSelectPageSize.Size = new System.Drawing.Size(121, 24);
            this.cbbSelectPageSize.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnBack.BorderRadius = 8;
            this.btnBack.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(181, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnBack.Size = new System.Drawing.Size(29, 32);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnNext.BorderRadius = 8;
            this.btnNext.BorderSize = 0;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(630, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnNext.Size = new System.Drawing.Size(29, 32);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // flowLayoutPagination
            // 
            this.flowLayoutPagination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPagination.Location = new System.Drawing.Point(46, 6);
            this.flowLayoutPagination.Name = "flowLayoutPagination";
            this.flowLayoutPagination.Size = new System.Drawing.Size(322, 25);
            this.flowLayoutPagination.TabIndex = 0;
            // 
            // DataGridViewCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutMain);
            this.Name = "DataGridViewCustom";
            this.Size = new System.Drawing.Size(848, 390);
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
        private System.Windows.Forms.DataGridView dgv;
        private Components.Buttons.ButtonCustom btnBack;
        private Components.Buttons.ButtonCustom btnNext;
        private System.Windows.Forms.ComboBox cbbSelectPageSize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPagination;
    }
}
