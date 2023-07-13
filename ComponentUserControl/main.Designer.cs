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
            this.textBoxCustom1 = new ComponentUserControl.TextBoxs.TextBoxCustom();
            this.dataGridViewCustom1 = new ComponentUserControl.DataGridViews.DataGridViewCustom();
            this.loading1 = new ComponentUserControl.Loading.Loading();
            this.SuspendLayout();
            // 
            // btnButtons
            // 
            this.btnButtons.Location = new System.Drawing.Point(24, 12);
            this.btnButtons.Name = "btnButtons";
            this.btnButtons.Size = new System.Drawing.Size(75, 23);
            this.btnButtons.TabIndex = 1;
            this.btnButtons.Text = "Buttons";
            this.btnButtons.UseVisualStyleBackColor = true;
            this.btnButtons.Click += new System.EventHandler(this.btnButtons_Click);
            // 
            // btnTabs
            // 
            this.btnTabs.Location = new System.Drawing.Point(24, 53);
            this.btnTabs.Name = "btnTabs";
            this.btnTabs.Size = new System.Drawing.Size(75, 23);
            this.btnTabs.TabIndex = 2;
            this.btnTabs.Text = "Tabs";
            this.btnTabs.UseVisualStyleBackColor = true;
            this.btnTabs.Click += new System.EventHandler(this.btnTabs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "DateTimePicker";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.BackColor = System.Drawing.Color.White;
            this.textBoxCustom1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(101)))), ((int)(((byte)(105)))));
            this.textBoxCustom1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.textBoxCustom1.BorderSize = 2;
            this.textBoxCustom1.Location = new System.Drawing.Point(259, 20);
            this.textBoxCustom1.Multiline = false;
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.Padding = new System.Windows.Forms.Padding(8, 2, 8, 8);
            this.textBoxCustom1.PasswordChar = false;
            this.textBoxCustom1.SetLabel = "labeládasd á";
            this.textBoxCustom1.Size = new System.Drawing.Size(380, 56);
            this.textBoxCustom1.TabIndex = 8;
            this.textBoxCustom1.Texts = "tét";
            this.textBoxCustom1.UnderlinedStyle = false;
            // 
            // dataGridViewCustom1
            // 
            this.dataGridViewCustom1.Location = new System.Drawing.Point(250, 122);
            this.dataGridViewCustom1.Name = "dataGridViewCustom1";
            this.dataGridViewCustom1.Size = new System.Drawing.Size(891, 326);
            this.dataGridViewCustom1.TabIndex = 7;
            // 
            // loading1
            // 
            this.loading1.angle = 83F;
            this.loading1.Borderradius = 20;
            this.loading1.Color = System.Drawing.Color.Blue;
            this.loading1.Color1 = System.Drawing.Color.Orange;
            this.loading1.ForeColor = System.Drawing.Color.White;
            this.loading1.Location = new System.Drawing.Point(24, 164);
            this.loading1.Name = "loading1";
            this.loading1.Size = new System.Drawing.Size(150, 150);
            this.loading1.TabIndex = 6;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 728);
            this.Controls.Add(this.textBoxCustom1);
            this.Controls.Add(this.dataGridViewCustom1);
            this.Controls.Add(this.loading1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTabs);
            this.Controls.Add(this.btnButtons);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnButtons;
        private System.Windows.Forms.Button btnTabs;
        private System.Windows.Forms.Button button1;
        private Loading.Loading loading1;
        private DataGridViews.DataGridViewCustom dataGridViewCustom1;
        private TextBoxs.TextBoxCustom textBoxCustom1;
    }
}