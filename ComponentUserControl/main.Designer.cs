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
            this.dataGridViewCustom1 = new ComponentUserControl.DataGridViews.DataGridViewCustom();
            this.SuspendLayout();
            // 
            // btnButtons
            // 
            this.btnButtons.FlatAppearance.BorderSize = 0;
            this.btnButtons.Location = new System.Drawing.Point(1133, 91);
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
            // dataGridViewCustom1
            // 
            this.dataGridViewCustom1.CurrentPage = 1;
            this.dataGridViewCustom1.delegateDataSource = null;
            this.dataGridViewCustom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCustom1.Location = new System.Drawing.Point(0, 358);
            this.dataGridViewCustom1.Name = "dataGridViewCustom1";
            this.dataGridViewCustom1.SetHeaderTexts = new string[] {
        "STT"};
            this.dataGridViewCustom1.SetPropertyNames = new string[] {
        "Index"};
            this.dataGridViewCustom1.Size = new System.Drawing.Size(1246, 370);
            this.dataGridViewCustom1.TabIndex = 5;
            this.dataGridViewCustom1.TotalItem = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 728);
            this.Controls.Add(this.dataGridViewCustom1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTabs);
            this.Controls.Add(this.btnButtons);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnButtons;
        private System.Windows.Forms.Button btnTabs;
        private System.Windows.Forms.Button button1;
        private DataGridViews.DataGridViewCustom dataGridViewCustom1;
    }
}