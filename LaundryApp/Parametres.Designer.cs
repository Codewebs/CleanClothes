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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlParametres = new System.Windows.Forms.TabControl();
            this.tabPageParamGeneral = new System.Windows.Forms.TabPage();
            this.tabPageParamAdvanced = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControlParametres.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlParametres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 620);
            this.panel1.TabIndex = 0;
            // 
            // tabControlParametres
            // 
            this.tabControlParametres.Controls.Add(this.tabPageParamGeneral);
            this.tabControlParametres.Controls.Add(this.tabPageParamAdvanced);
            this.tabControlParametres.Location = new System.Drawing.Point(44, 79);
            this.tabControlParametres.Name = "tabControlParametres";
            this.tabControlParametres.SelectedIndex = 0;
            this.tabControlParametres.Size = new System.Drawing.Size(713, 456);
            this.tabControlParametres.TabIndex = 0;
            // 
            // tabPageParamGeneral
            // 
            this.tabPageParamGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageParamGeneral.Name = "tabPageParamGeneral";
            this.tabPageParamGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParamGeneral.Size = new System.Drawing.Size(705, 430);
            this.tabPageParamGeneral.TabIndex = 0;
            this.tabPageParamGeneral.Text = "General";
            this.tabPageParamGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPageParamAdvanced
            // 
            this.tabPageParamAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabPageParamAdvanced.Name = "tabPageParamAdvanced";
            this.tabPageParamAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParamAdvanced.Size = new System.Drawing.Size(705, 430);
            this.tabPageParamAdvanced.TabIndex = 1;
            this.tabPageParamAdvanced.Text = "Advanced";
            this.tabPageParamAdvanced.UseVisualStyleBackColor = true;
            // 
            // Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 620);
            this.Controls.Add(this.panel1);
            this.Name = "Parametres";
            this.Text = "Parametres";
            this.panel1.ResumeLayout(false);
            this.tabControlParametres.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlParametres;
        private System.Windows.Forms.TabPage tabPageParamGeneral;
        private System.Windows.Forms.TabPage tabPageParamAdvanced;
    }
}