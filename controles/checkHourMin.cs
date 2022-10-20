using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas.controles
{
    public partial class checkHourMin : UserControl
    {
        public checkHourMin()
        {
            InitializeComponent();
        }

        public string Titulo{ set{ this.label6.Text = value; } get { return this.label6.Text; } }

        public string Hora { set { this.textBox1.Text = value; } get { return this.textBox1.Text; } }

        public string Minuto { set { this.textBox2.Text = value; } get { return this.textBox2.Text; } }

        public TimeSpan TiempoCompleto
        {
            get { return new TimeSpan(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),0); }
            set
            {
                if(value.Hours.ToString().Length==1)
                    textBox1.Text = "0"+value.Hours.ToString();
                else textBox1.Text = value.Hours.ToString();
                if (value.Minutes.ToString().Length == 1)
                    textBox2.Text = "0"+value.Minutes.ToString();
                else textBox2.Text = value.Minutes.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.textBox1.Text);
            this.textBox1.Text = (num + 1).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.textBox2.Text);
            this.textBox2.Text = (num + 1).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.textBox1.Text);
            this.textBox1.Text = (num - 1).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.textBox2.Text);
            this.textBox2.Text = (num - 1).ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
