namespace LaundryApp
{
    partial class Parametres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametres));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlParametres = new System.Windows.Forms.TabControl();
            this.tabPageParamGeneral = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLangue = new System.Windows.Forms.ComboBox();
            this.labeLangue = new System.Windows.Forms.Label();
            this.tabPageParamAdvanced = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlParametres.SuspendLayout();
            this.tabPageParamGeneral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tabControlParametres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 551);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 135);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parametres";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlParametres
            // 
            this.tabControlParametres.Controls.Add(this.tabPageParamGeneral);
            this.tabControlParametres.Controls.Add(this.tabPageParamAdvanced);
            this.tabControlParametres.Location = new System.Drawing.Point(61, 162);
            this.tabControlParametres.Name = "tabControlParametres";
            this.tabControlParametres.SelectedIndex = 0;
            this.tabControlParametres.Size = new System.Drawing.Size(570, 351);
            this.tabControlParametres.TabIndex = 0;
            // 
            // tabPageParamGeneral
            // 
            this.tabPageParamGeneral.Controls.Add(this.panel2);
            this.tabPageParamGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageParamGeneral.Name = "tabPageParamGeneral";
            this.tabPageParamGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParamGeneral.Size = new System.Drawing.Size(562, 325);
            this.tabPageParamGeneral.TabIndex = 0;
            this.tabPageParamGeneral.Text = "General";
            this.tabPageParamGeneral.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxLangue);
            this.panel2.Controls.Add(this.labeLangue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 319);
            this.panel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Non",
            "Oui"});
            this.comboBox1.Location = new System.Drawing.Point(205, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tolerer les avances : ";
            // 
            // comboBoxLangue
            // 
            this.comboBoxLangue.FormattingEnabled = true;
            this.comboBoxLangue.Items.AddRange(new object[] {
            "Anglais",
            "Francais"});
            this.comboBoxLangue.Location = new System.Drawing.Point(205, 68);
            this.comboBoxLangue.Name = "comboBoxLangue";
            this.comboBoxLangue.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLangue.TabIndex = 1;
            this.comboBoxLangue.SelectedIndexChanged += new System.EventHandler(this.comboBoxLangue_SelectedIndexChanged);
            // 
            // labeLangue
            // 
            this.labeLangue.AutoSize = true;
            this.labeLangue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLangue.Location = new System.Drawing.Point(24, 73);
            this.labeLangue.Name = "labeLangue";
            this.labeLangue.Size = new System.Drawing.Size(141, 16);
            this.labeLangue.TabIndex = 0;
            this.labeLangue.Text = "langue par defaut : ";
            // 
            // tabPageParamAdvanced
            // 
            this.tabPageParamAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabPageParamAdvanced.Name = "tabPageParamAdvanced";
            this.tabPageParamAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParamAdvanced.Size = new System.Drawing.Size(599, 359);
            this.tabPageParamAdvanced.TabIndex = 1;
            this.tabPageParamAdvanced.Text = "Advanced";
            this.tabPageParamAdvanced.UseVisualStyleBackColor = true;
            // 
            // Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 551);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Parametres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametres";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlParametres.ResumeLayout(false);
            this.tabPageParamGeneral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlParametres;
        private System.Windows.Forms.TabPage tabPageParamGeneral;
        private System.Windows.Forms.TabPage tabPageParamAdvanced;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxLangue;
        private System.Windows.Forms.Label labeLangue;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}