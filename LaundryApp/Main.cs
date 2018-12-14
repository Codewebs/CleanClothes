using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace LaundryApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            string s = now.DayOfWeek.ToString();
            string today = DateTime.Now.ToString("MM'/'dd' : ' HH':'mm");
            labelDate.Text = s+" "+today;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab_userConnect_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_Param_Click(object sender, EventArgs e)
        {
            Parametres Check = new Parametres();            
            Check.Show();
            /* Hide(); */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Starter Check = new Starter();
            Check.Show();
        }

        private void buttonG_Personnel_Click(object sender, EventArgs e)
        {
            GestionPersonnel gest = new GestionPersonnel();
            gest.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

  
    }
}
