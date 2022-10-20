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

        #region Load form
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
        #endregion


        #region Cargar lista en DataGrid
        private void CargarLista()
        {
            dgLista.AutoGenerateColumns = false;
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listacliente;
            dgLista.DataSource = bindingSource1;
            foreach (DataGridViewColumn column in dgLista.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        #endregion


        #region Cell mouse Click
        private void dgLista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string arg = dgLista.Columns[e.ColumnIndex].Name;
                if (arg == "editar" || arg == "ver")
                {
                    string? nro = dgLista.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (nro != null)
                    {
                        Cliente? al1 = listacliente.Find(x => x.Dni == Convert.ToDouble(nro));

                        if (al1 != null)
                        {
                            FormCliente frmCliente = new FormCliente(al1);
                            if (arg == "ver") frmCliente.Modifier = false;
                            frmCliente.MdiParent = this.MdiParent;
                            frmCliente.Show();
                        }
                    }

                }
            }
        }
        #endregion

        #region btn actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(interfaz != null)
            {
                listacliente = interfaz.ListarClientes();
                CargarLista();
            }
        }
        #endregion
    }
}
