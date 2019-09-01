using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horastrabajadas = double.Parse(txthoras.Text);
            double valorhora = double.Parse(txtvalor.Text);
            double total = horastrabajadas * valorhora;

            if (total>750000) {
                MessageBox.Show("Tú salario es mayor al mínimo");
                
            }

            else {
                total = (total * 0.20)+ total;
                


            }
            lbltotal.Text = "$"+ Convert.ToDecimal(total).ToString("N0");
            lbltotal.Visible = true;
        }
    }
}
