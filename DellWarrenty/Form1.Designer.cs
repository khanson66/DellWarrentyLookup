namespace DellWarrenty
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.serviceTagInput = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.computerModelBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.warrantyEndDateBox = new System.Windows.Forms.TextBox();
            this.shipDateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serviceTagBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Tag:";
            // 
            // serviceTagInput
            // 
            this.serviceTagInput.Location = new System.Drawing.Point(84, 30);
            this.serviceTagInput.Name = "serviceTagInput";
            this.serviceTagInput.Size = new System.Drawing.Size(100, 20);
            this.serviceTagInput.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.submitButton.Location = new System.Drawing.Point(198, 30);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 20);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.computerModelBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.warrantyEndDateBox);
            this.groupBox1.Controls.Add(this.shipDateBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.serviceTagBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WarrantyInfo";
            // 
            // computerModelBox
            // 
            this.computerModelBox.Location = new System.Drawing.Point(120, 36);
            this.computerModelBox.Name = "computerModelBox";
            this.computerModelBox.ReadOnly = true;
            this.computerModelBox.Size = new System.Drawing.Size(100, 20);
            this.computerModelBox.TabIndex = 8;
            this.computerModelBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Computer Model:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // warrantyEndDateBox
            // 
            this.warrantyEndDateBox.Location = new System.Drawing.Point(120, 82);
            this.warrantyEndDateBox.Name = "warrantyEndDateBox";
            this.warrantyEndDateBox.ReadOnly = true;
            this.warrantyEndDateBox.Size = new System.Drawing.Size(100, 20);
            this.warrantyEndDateBox.TabIndex = 6;
            // 
            // shipDateBox
            // 
            this.shipDateBox.Location = new System.Drawing.Point(120, 59);
            this.shipDateBox.Name = "shipDateBox";
            this.shipDateBox.ReadOnly = true;
            this.shipDateBox.Size = new System.Drawing.Size(100, 20);
            this.shipDateBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Warranty End Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ship Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // serviceTagBox
            // 
            this.serviceTagBox.Location = new System.Drawing.Point(120, 13);
            this.serviceTagBox.Name = "serviceTagBox";
            this.serviceTagBox.ReadOnly = true;
            this.serviceTagBox.Size = new System.Drawing.Size(100, 20);
            this.serviceTagBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Service Tag:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(285, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 191);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.serviceTagInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DellWarrantyLookup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox shipDateBox;
        private System.Windows.Forms.TextBox warrantyEndDateBox;

        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox serviceTagBox;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.TextBox serviceTagInput;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TextBox computerModelBox;
        private System.Windows.Forms.Label label4;
    }
}