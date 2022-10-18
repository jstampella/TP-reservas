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
    public partial class FrmListarClientes : Form
    {
        ITrasladarInfo? interfaz;
        List<Cliente> listacliente = new List<Cliente>();
        public FrmListarClientes()
        {
            InitializeComponent();
        }

        private void FrmListarClientes_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                listacliente = interfaz.ListarClientes();
                CargarLista();
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
        }

        private void CargarLista()
        {
            dgLista.AutoGenerateColumns = false;
            dgLista.DataSource = listacliente;
            
        }
    }
}
