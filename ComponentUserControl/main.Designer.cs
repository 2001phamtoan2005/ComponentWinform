namespace ComponentUserControl
{
    partial class main
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
            this.btnButtons = new System.Windows.Forms.Button();
            this.btnTabs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputCustom1 = new ComponentUserControl.TextBoxs.InputCustom();
            this.SuspendLayout();
            // 
            // btnButtons
            // 
            this.btnButtons.FlatAppearance.BorderSize = 0;
            this.btnButtons.Location = new System.Drawing.Point(481, 82);
            this.btnButtons.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnButtons.Name = "btnButtons";
            this.btnButtons.Size = new System.Drawing.Size(56, 19);
            this.btnButtons.TabIndex = 1;
            this.btnButtons.Text = "Buttons";
            this.btnButtons.UseVisualStyleBackColor = true;
            this.btnButtons.Click += new System.EventHandler(this.btnButtons_Click);
            // 
            // btnTabs
            // 
            this.btnTabs.Location = new System.Drawing.Point(18, 43);
            this.btnTabs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTabs.Name = "btnTabs";
            this.btnTabs.Size = new System.Drawing.Size(56, 19);
            this.btnTabs.TabIndex = 2;
            this.btnTabs.Text = "Tabs";
            this.btnTabs.UseVisualStyleBackColor = true;
            this.btnTabs.Click += new System.EventHandler(this.btnTabs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "DateTimePicker";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // inputCustom1
            // 
            this.inputCustom1.BackColor = System.Drawing.Color.White;
            this.inputCustom1.BorderColor = System.Drawing.Color.Empty;
            this.inputCustom1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.inputCustom1.BorderSize = 2;
            this.inputCustom1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCustom1.Location = new System.Drawing.Point(113, 184);
            this.inputCustom1.Margin = new System.Windows.Forms.Padding(2);
            this.inputCustom1.MaximumSize = new System.Drawing.Size(250, 78);
            this.inputCustom1.Multiline = false;
            this.inputCustom1.Name = "inputCustom1";
            this.inputCustom1.SetErrorText = "";
            this.inputCustom1.SetImageForLabel = null;
            this.inputCustom1.SetLabel = "Title";
            this.inputCustom1.SetText = "";
            this.inputCustom1.Size = new System.Drawing.Size(250, 70);
            this.inputCustom1.TabIndex = 8;
            this.inputCustom1.UnderlinedStyle = false;
            this.inputCustom1.UCKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCustom1_UCKeyPress);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 505);
            this.Controls.Add(this.inputCustom1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTabs);
            this.Controls.Add(this.btnButtons);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnButtons;
        private System.Windows.Forms.Button btnTabs;
        private System.Windows.Forms.Button button1;
        private Components.Buttons.ButtonPrimary btnThem;
        private System.Windows.Forms.TextBox textBox1;
        private TextBoxs.InputCustom inputCustom1;
    }
}