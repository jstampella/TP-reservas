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
    public partial class FormCliente : Form
    {
        private ITrasladarInfo? interfaz = null;
        public FormCliente()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;

        }



        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool resultado= false;
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            float dni = float.Parse(textBox3.Text);
            string mail = textBox4.Text;
            string codArea = textBox5.Text;
            string celular = textBox6.Text;
            if (interfaz != null)
                resultado = interfaz.CrearCliente(nombre, apellido, dni, mail, codArea, celular);

            if (resultado) this.Close();
            else
            {
                MessageBox.Show("Ocurrio un error al guardar el cliente");
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
        }
    }
}
