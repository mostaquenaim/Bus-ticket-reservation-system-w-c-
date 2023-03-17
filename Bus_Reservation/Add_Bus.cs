using Contents.Define;
using Contents.Operation;
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
    public partial class Add_Bus : Form
    {
        public Add_Bus()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Agent_Panel_Login().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBname.Text != "" && comboBusType.Text != "" && comboRoute.Text != "" && txtTotalBus.Text != "" && txtPrice.Text !="")
            {
                 DBus bus = new DBus();
                bus.bname = txtBname.Text;
                bus.btype = comboBusType.Text;
                bus.route = comboRoute.Text;
                bus.totalbus = txtTotalBus.Text;
                bus.price = txtPrice.Text;
                bus.cname = txtCname.Text;

                 OBus ob = new OBus();
                 int number = ob.addbus(bus);
                 if (number > 0)
                     {
                         MessageBox.Show("Bus Added~!");
                         new Agent_Panel_Login().Show();
                         this.Hide();
                     }
                 else
                     {
                         MessageBox.Show("Error!");
                     }
            }
        }
    }
}
