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
    public partial class Set_Schedule : Form
    {
        public Set_Schedule()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Agent_Panel_Login().Show();
        }

        private void Set_Schedule_Load(object sender, EventArgs e)
        {

        }
    }
}
