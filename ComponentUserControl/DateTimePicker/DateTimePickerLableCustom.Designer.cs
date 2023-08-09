namespace GUI.Components.Textboxs
{
    partial class DateTimePickerLableCustom
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel = new TableLayoutPanel();
            label = new Label();
            lblError = new Label();
            dtp = new DateTimePickers.DateTimePickerCustom();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(label, 0, 0);
            tableLayoutPanel.Controls.Add(lblError, 0, 2);
            tableLayoutPanel.Controls.Add(dtp, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(250, 70);
            tableLayoutPanel.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.FlatStyle = FlatStyle.Flat;
            label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label.ImageAlign = ContentAlignment.MiddleRight;
            label.Location = new Point(7, 5);
            label.Margin = new Padding(2, 0, 2, 0);
            label.Name = "label";
            label.Size = new Size(38, 20);
            label.TabIndex = 0;
            label.Text = "Title";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(9, 53);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(51, 20);
            lblError.TabIndex = 1;
            lblError.Text = "label2";
            // 
            // dtp
            // 
            dtp.BorderColor = Color.FromArgb(99, 101, 105);
            dtp.BorderSize = 1;
            dtp.CustomFormat = "dd/MM/yyyy";
            dtp.Dock = DockStyle.Fill;
            dtp.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Location = new Point(8, 28);
            dtp.MinimumSize = new Size(0, 24);
            dtp.Name = "dtp";
            dtp.Size = new Size(234, 29);
            dtp.SkinColor = Color.White;
            dtp.TabIndex = 2;
            dtp.TextColor = Color.FromArgb(99, 101, 105);
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // DateTimePickerLableCustom
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(2);
            MinimumSize = new Size(250, 70);
            Name = "DateTimePickerLableCustom";
            Size = new Size(250, 70);
            Load += Custom_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel;
        private Label lblError;
        private Label label;
        private ErrorProvider errorProvider;
        private DateTimePickers.DateTimePickerCustom dtp;
    }
}
