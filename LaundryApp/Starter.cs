using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryApp
{
    public partial class Starter : Form
    {
        int progress = 0;
        public Starter()
        {
            InitializeComponent();
            labelLoading.Visible = true;
            progress = 0;
            timer1.Enabled = true;
            timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //INCREMENT OUR PROGRESS VALUE
            progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();

                //On demarre note MDI principal
                Main Check = new Main();
                Check.Show();
                Hide(); 
                //---------------------------
            }
            if(progress >= 40 && progress <41){

            System.Threading.Thread.Sleep(
                (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
            labelLoading.Text = "Check for Connexion";
            }
            if (progress >= 70 && progress < 71)
            {

                System.Threading.Thread.Sleep(
                    (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
                labelLoading.Text = "Configuring Environement";
            }

            //OTHERWISE
            progressBar1.Value = progress;
            progressBar1.Value = progress;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
          
            
    
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
