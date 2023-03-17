using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) textBox7.UseSystemPasswordChar = false;
            else textBox7.UseSystemPasswordChar = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) textBox6.UseSystemPasswordChar = false;
            else textBox6.UseSystemPasswordChar = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLogin().Show();
        }
    }
}
