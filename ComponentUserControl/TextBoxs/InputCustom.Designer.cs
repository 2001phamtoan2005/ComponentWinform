namespace ComponentUserControl.TextBoxs
{
    partial class InputCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputCustom));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblError, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txt, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(250, 70);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label.Location = new System.Drawing.Point(7, 5);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Title";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(9, 53);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(51, 20);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "label2";
            // 
            // txt
            // 
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Location = new System.Drawing.Point(8, 28);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(234, 27);
            this.txt.TabIndex = 2;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // InputCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(250, 70);
            this.Name = "InputCustom";
            this.Size = new System.Drawing.Size(250, 70);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txt;
    }
}
