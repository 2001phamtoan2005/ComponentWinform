namespace ComponentUserControl.NumberBox
{
    partial class NumberBoxCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberBoxCustom));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.lblhHelper = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblhHelper, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.numberBox, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(250, 70);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label.Location = new System.Drawing.Point(4, 0);
            this.label.Margin = new System.Windows.Forms.Padding(0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(30, 15);
            this.label.TabIndex = 0;
            this.label.Text = "Title";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblhHelper
            // 
            this.lblhHelper.AutoSize = true;
            this.lblhHelper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblhHelper.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhHelper.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblhHelper.Location = new System.Drawing.Point(8, 48);
            this.lblhHelper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhHelper.Name = "lblhHelper";
            this.lblhHelper.Size = new System.Drawing.Size(38, 22);
            this.lblhHelper.TabIndex = 1;
            this.lblhHelper.Text = "label2";
            // 
            // numberBox
            // 
            this.numberBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberBox.Location = new System.Drawing.Point(4, 20);
            this.numberBox.Margin = new System.Windows.Forms.Padding(0);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(242, 20);
            this.numberBox.TabIndex = 2;
            this.numberBox.ThousandsSeparator = true;
            this.numberBox.ValueChanged += new System.EventHandler(this.numberBox_ValueChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // NumberBoxCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "NumberBoxCustom";
            this.Size = new System.Drawing.Size(250, 70);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblhHelper;
        private System.Windows.Forms.NumericUpDown numberBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
