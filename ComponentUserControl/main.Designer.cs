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
            this.loading1 = new ComponentUserControl.Loading.Loading();
            this.dataGridViewCustom1 = new ComponentUserControl.DataGridViews.DataGridViewCustom();
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
            // loading1
            // 
            this.loading1.angle = 290F;
            this.loading1.Borderradius = 20;
            this.loading1.Color = System.Drawing.Color.Blue;
            this.loading1.Color1 = System.Drawing.Color.Orange;
            this.loading1.ForeColor = System.Drawing.Color.White;
            this.loading1.Location = new System.Drawing.Point(24, 164);
            this.loading1.Name = "loading1";
            this.loading1.Size = new System.Drawing.Size(150, 150);
            this.loading1.TabIndex = 6;
            // 
            // dataGridViewCustom1
            // 
            this.dataGridViewCustom1.Location = new System.Drawing.Point(254, 75);
            this.dataGridViewCustom1.Name = "dataGridViewCustom1";
            this.dataGridViewCustom1.Size = new System.Drawing.Size(925, 427);
            this.dataGridViewCustom1.TabIndex = 7;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 728);
            this.Controls.Add(this.dataGridViewCustom1);
            this.Controls.Add(this.loading1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTabs);
            this.Controls.Add(this.btnButtons);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnButtons;
        private System.Windows.Forms.Button btnTabs;
        private System.Windows.Forms.Button button1;
        private Loading.Loading loading1;
        private DataGridViews.DataGridViewCustom dataGridViewCustom1;
    }
}