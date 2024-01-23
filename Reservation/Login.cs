using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="ariz" && textBox2.Text=="123")
            {
                Admin next=new Admin();
                next.Show();
            }
            else
            {
                MessageBox.Show("Sifre yalnisdir");

            }
        }
    }
}
