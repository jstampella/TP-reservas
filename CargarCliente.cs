using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TPreservas
{
    public partial class CargarCliente : Form
    {
        public CargarCliente()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {if (textBox3.BackColor == Color.IndianRed)
            {
                textBox3.BackColor = Color.White;
            }
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {if (textBox5.BackColor == Color.IndianRed)
            {
                textBox5.BackColor = Color.White;
            }
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
           
        }

       

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox6.BackColor == Color.IndianRed)
            {
                textBox6.BackColor = Color.White;
            }
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBox1.BackColor== Color.IndianRed)
            {
                textBox1.BackColor = Color.White;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void CargarCliente_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.BackColor == Color.IndianRed)
            {
                textBox2.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
