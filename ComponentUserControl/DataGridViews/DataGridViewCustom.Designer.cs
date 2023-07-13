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
            this.btnIncrease = new Components.Buttons.ButtonCustom();
            this.btnDecrease = new Components.Buttons.ButtonCustom();
            this.flowLayoutPages = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tblLayoutControls.ColumnCount = 3;
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.31746F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.68254F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 724F));
            this.tblLayoutControls.Controls.Add(this.tblLayoutPagination, 2, 0);
            this.tblLayoutControls.Controls.Add(this.label1, 0, 0);
            this.tblLayoutControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutControls.ForeColor = System.Drawing.Color.White;
            this.tblLayoutControls.Location = new System.Drawing.Point(3, 562);
            this.tblLayoutControls.Name = "tblLayoutControls";
            this.tblLayoutControls.RowCount = 1;
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutControls.Size = new System.Drawing.Size(1039, 52);
            this.tblLayoutControls.TabIndex = 1;
            // 
            // tblLayoutPagination
            // 
            this.tblLayoutPagination.ColumnCount = 3;
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPagination.Controls.Add(this.btnIncrease, 2, 0);
            this.tblLayoutPagination.Controls.Add(this.btnDecrease, 0, 0);
            this.tblLayoutPagination.Controls.Add(this.flowLayoutPages, 1, 0);
            this.tblLayoutPagination.Location = new System.Drawing.Point(318, 3);
            this.tblLayoutPagination.Name = "tblLayoutPagination";
            this.tblLayoutPagination.Padding = new System.Windows.Forms.Padding(4);
            this.tblLayoutPagination.RowCount = 1;
            this.tblLayoutPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPagination.Size = new System.Drawing.Size(495, 46);
            this.tblLayoutPagination.TabIndex = 2;
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.Silver;
            this.btnIncrease.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnIncrease.BorderRadius = 8;
            this.btnIncrease.BorderSize = 0;
            this.btnIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncrease.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnIncrease.Image = ((System.Drawing.Image)(resources.GetObject("btnIncrease.Image")));
            this.btnIncrease.Location = new System.Drawing.Point(454, 7);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnIncrease.Size = new System.Drawing.Size(34, 32);
            this.btnIncrease.TabIndex = 4;
            this.btnIncrease.UseVisualStyleBackColor = false;
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.Color.Silver;
            this.btnDecrease.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnDecrease.BorderRadius = 8;
            this.btnDecrease.BorderSize = 0;
            this.btnDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrease.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDecrease.FlatAppearance.BorderSize = 0;
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnDecrease.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrease.Image")));
            this.btnDecrease.Location = new System.Drawing.Point(7, 7);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnDecrease.Size = new System.Drawing.Size(34, 32);
            this.btnDecrease.TabIndex = 4;
            this.btnDecrease.UseVisualStyleBackColor = false;
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
            this.label1.Size = new System.Drawing.Size(184, 52);
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
            // DataGridViewCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutMain);
            this.Name = "DataGridViewCustom";
            this.Size = new System.Drawing.Size(1045, 617);
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
        private Components.Buttons.ButtonCustom btnIncrease;
        private Components.Buttons.ButtonCustom btnDecrease;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPages;
        private System.Windows.Forms.DataGridView dgv;
    }
}
