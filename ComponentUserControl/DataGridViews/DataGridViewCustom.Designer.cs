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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnBack = new Components.Buttons.ButtonCustom();
            this.btnNext = new Components.Buttons.ButtonCustom();
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
            this.tblLayoutMain.Name = "tblLayoutMain";
            this.tblLayoutMain.RowCount = 2;
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tblLayoutMain.Size = new System.Drawing.Size(1045, 617);
            this.tblLayoutMain.TabIndex = 0;
            // 
            // tblLayoutControls
            // 
            this.tblLayoutControls.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tblLayoutControls.ColumnCount = 4;
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.31746F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.68254F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 610F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tblLayoutControls.Controls.Add(this.tblLayoutPagination, 2, 0);
            this.tblLayoutControls.Controls.Add(this.label1, 0, 0);
            this.tblLayoutControls.Controls.Add(this.btnBack, 1, 0);
            this.tblLayoutControls.Controls.Add(this.btnNext, 3, 0);
            this.tblLayoutControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutControls.ForeColor = System.Drawing.Color.White;
            this.tblLayoutControls.Location = new System.Drawing.Point(3, 562);
            this.tblLayoutControls.Name = "tblLayoutControls";
            this.tblLayoutControls.RowCount = 1;
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutControls.Size = new System.Drawing.Size(1039, 52);
            this.tblLayoutControls.TabIndex = 1;
            this.tblLayoutControls.Paint += new System.Windows.Forms.PaintEventHandler(this.tblLayoutControls_Paint);
            // 
            // tblLayoutPagination
            // 
            this.tblLayoutPagination.ColumnCount = 3;
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPagination.Controls.Add(this.flowLayoutPages, 1, 0);
            this.tblLayoutPagination.Location = new System.Drawing.Point(284, 3);
            this.tblLayoutPagination.Name = "tblLayoutPagination";
            this.tblLayoutPagination.Padding = new System.Windows.Forms.Padding(4);
            this.tblLayoutPagination.RowCount = 1;
            this.tblLayoutPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.Size = new System.Drawing.Size(495, 46);
            this.tblLayoutPagination.TabIndex = 2;
            // 
            // flowLayoutPages
            // 
            this.flowLayoutPages.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPages.Location = new System.Drawing.Point(47, 7);
            this.flowLayoutPages.Name = "flowLayoutPages";
            this.flowLayoutPages.Size = new System.Drawing.Size(401, 32);
            this.flowLayoutPages.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1039, 553);
            this.dgv.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnBack.BorderRadius = 8;
            this.btnBack.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(173, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnBack.Size = new System.Drawing.Size(75, 38);
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
            this.btnNext.Location = new System.Drawing.Point(894, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnNext.Size = new System.Drawing.Size(75, 38);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // DataGridViewCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutMain);
            this.Name = "DataGridViewCustom";
            this.Size = new System.Drawing.Size(1045, 617);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPagination;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPages;
        private System.Windows.Forms.DataGridView dgv;
        private Components.Buttons.ButtonCustom btnBack;
        private Components.Buttons.ButtonCustom btnNext;
    }
}
