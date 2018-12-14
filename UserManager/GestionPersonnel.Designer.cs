namespace UserManager
{
    partial class GestionPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPersonnel));
            this.textBoxCaretUsers = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.pictureBoxLogoApp = new System.Windows.Forms.PictureBox();
            this.labelTitleUsrmanager = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCaretUsers
            // 
            this.textBoxCaretUsers.Location = new System.Drawing.Point(228, 142);
            this.textBoxCaretUsers.Name = "textBoxCaretUsers";
            this.textBoxCaretUsers.Size = new System.Drawing.Size(618, 20);
            this.textBoxCaretUsers.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Controls.Add(this.dataGridViewUsers);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Controls.Add(this.textBoxCaretUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 634);
            this.panel1.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.labelTitleUsrmanager);
            this.panelHeader.Controls.Add(this.pictureBoxLogoApp);
            this.panelHeader.Location = new System.Drawing.Point(3, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(940, 114);
            this.panelHeader.TabIndex = 1;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(75, 187);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(771, 417);
            this.dataGridViewUsers.TabIndex = 2;
            // 
            // pictureBoxLogoApp
            // 
            this.pictureBoxLogoApp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoApp.Image")));
            this.pictureBoxLogoApp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogoApp.Name = "pictureBoxLogoApp";
            this.pictureBoxLogoApp.Size = new System.Drawing.Size(120, 111);
            this.pictureBoxLogoApp.TabIndex = 0;
            this.pictureBoxLogoApp.TabStop = false;
            // 
            // labelTitleUsrmanager
            // 
            this.labelTitleUsrmanager.AutoSize = true;
            this.labelTitleUsrmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleUsrmanager.Location = new System.Drawing.Point(300, 42);
            this.labelTitleUsrmanager.Name = "labelTitleUsrmanager";
            this.labelTitleUsrmanager.Size = new System.Drawing.Size(285, 33);
            this.labelTitleUsrmanager.TabIndex = 1;
            this.labelTitleUsrmanager.Text = "Personnal Manager";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(71, 140);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(151, 20);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Search For User :";
            // 
            // GestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 634);
            this.Controls.Add(this.panel1);
            this.Name = "GestionPersonnel";
            this.Text = "GestionPersonnel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCaretUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitleUsrmanager;
        private System.Windows.Forms.PictureBox pictureBoxLogoApp;
    }
}