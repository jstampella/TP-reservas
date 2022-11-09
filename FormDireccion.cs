using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas
{
    internal partial class FormDireccion : Form
    {
        Direccion direccion = new Direccion();
        public FormDireccion()
        {
            InitializeComponent();
            this.Size = new Size(404, 266);
        }

        public Direccion Valor { 
            get { return direccion; } 
            set { direccion = value; txtCalle.Text = direccion.Calle; txtDireccion.Text = direccion.Ciudad; txtProvincia.Text = direccion.Provincia; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtCalle.Text.Length<1 || txtDireccion.Text.Length<1 || txtProvincia.Text.Length < 1)
            {
                MessageBox.Show("Complete los campos");
                return;
            }
            else
            {
                direccion.Calle = txtCalle.Text;
                direccion.Ciudad = txtDireccion.Text;
                direccion.Provincia = txtProvincia.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
