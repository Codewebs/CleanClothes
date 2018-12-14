using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            
            Register Check = new Register();
            Check.Show();
            Hide();
        }


    }
}
