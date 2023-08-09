namespace ComponentUserControl
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.numberBoxCustom1 = new ComponentUserControl.NumberBox.NumberBoxCustom();
            this.buttonPrimary1 = new Components.Buttons.ButtonPrimary();
            this.inputCustom1 = new ComponentUserControl.TextBoxs.InputCustom();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.numberBoxCustom1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputCustom1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 270);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numberBoxCustom1
            // 
            this.numberBoxCustom1.Label = "Title";
            this.numberBoxCustom1.Location = new System.Drawing.Point(3, 3);
            this.numberBoxCustom1.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberBoxCustom1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numberBoxCustom1.Name = "numberBoxCustom1";
            this.numberBoxCustom1.Size = new System.Drawing.Size(194, 65);
            this.numberBoxCustom1.TabIndex = 2;
            this.numberBoxCustom1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // buttonPrimary1
            // 
            this.buttonPrimary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.buttonPrimary1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.buttonPrimary1.BorderRadius = 8;
            this.buttonPrimary1.BorderSize = 0;
            this.buttonPrimary1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrimary1.FlatAppearance.BorderSize = 0;
            this.buttonPrimary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimary1.ForeColor = System.Drawing.Color.White;
            this.buttonPrimary1.Location = new System.Drawing.Point(263, 178);
            this.buttonPrimary1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrimary1.Name = "buttonPrimary1";
            this.buttonPrimary1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buttonPrimary1.Size = new System.Drawing.Size(110, 30);
            this.buttonPrimary1.TabIndex = 0;
            this.buttonPrimary1.Text = "buttonPrimary1";
            this.buttonPrimary1.UseVisualStyleBackColor = false;
            this.buttonPrimary1.Click += new System.EventHandler(this.buttonPrimary1_Click);
            // 
            // inputCustom1
            // 
            this.inputCustom1.AllowWhiteSpace = true;
            this.inputCustom1.BackColor = System.Drawing.Color.White;
            this.inputCustom1.Error = "";
            this.inputCustom1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCustom1.Label = "Title";
            this.inputCustom1.Location = new System.Drawing.Point(2, 91);
            this.inputCustom1.Margin = new System.Windows.Forms.Padding(2);
            this.inputCustom1.MaximumSize = new System.Drawing.Size(250, 70);
            this.inputCustom1.MaxLenght = 12;
            this.inputCustom1.MinLenght = 14;
            this.inputCustom1.Multiline = false;
            this.inputCustom1.Name = "inputCustom1";
            this.inputCustom1.NotNull = true;
            this.inputCustom1.Size = new System.Drawing.Size(196, 70);
            this.inputCustom1.TabIndex = 3;
            this.inputCustom1.ValidationType = ComponentUserControl.TextBoxs.InputCustom.eValidationType.NumberAndLetter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonPrimary1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Buttons.ButtonPrimary buttonPrimary1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private NumberBox.NumberBoxCustom numberBoxCustom1;
        private TextBoxs.InputCustom inputCustom1;
    }
}