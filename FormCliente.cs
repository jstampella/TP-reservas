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
    internal partial class FormCliente : Form
    {
        private bool modifier = true;
        private Cliente? cliente;
        private ITrasladarInfo? interfaz = null;

        public ITrasladarInfo? Interfaz { get { return interfaz; } set { interfaz = value; } }

        #region Constructor
        public FormCliente()
        {
            InitializeComponent();
        }

        public FormCliente(Cliente cc):this()
        {
            cliente = cc;
            btnAceptar.Text = "Modificar";
            textBox3.Enabled = false;
        }
        #endregion

        public bool Modifier { get { return modifier; }set { modifier = value; } }

        #region KeyPress
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

        #endregion

        #region btn Aceptar
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
                if (btnAceptar.Text == "Modificar")
                    resultado = interfaz.ModificarCliente(nombre, apellido, dni, mail, codArea, celular);
                else
                    resultado = interfaz.CrearCliente(nombre, apellido, dni, mail, codArea, celular);

            if (resultado) this.Close();
            else
            {
                MessageBox.Show("Ocurrio un error al guardar el cliente");
            }
        }
        #endregion

        #region Form load

        private void FormCliente_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
            }
            else if(interfaz == null)
            
            {
                MessageBox.Show("Error al cargar componente.");
            }

            if (cliente != null)
            {
                textBox1.Text = cliente.Nombre;
                textBox2.Text = cliente.Apellido;
                textBox3.Text = cliente.Dni.ToString(); 
                textBox4.Text = cliente.Mail;
                textBox5.Text = cliente.CodigoA;
                textBox6.Text = cliente.Celular;
            }
            if (!modifier) btnAceptar.Enabled = false;
        }
        #endregion
    }
}
