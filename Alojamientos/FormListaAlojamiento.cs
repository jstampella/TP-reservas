using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace TPreservas
{
    internal partial class FormListaAlojamiento : Form
    {
        private ITrasladarInfo? interfaz = null;
        List<Alojamiento> nAlojamiento = new List<Alojamiento>();
        public FormListaAlojamiento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (interfaz != null)
            {

                if (txtBuscar.Text == "")
                {
                    nAlojamiento = interfaz.ListarAlojamiento(checkTipo());
                }
                else
                {

                    switch (cbfiltro.SelectedItem)
                    {
                        case EBuscar.PERSONAS:
                            nAlojamiento = interfaz.ListarAlojamiento(checkTipo(), EBuscar.PERSONAS, txtBuscar.Text);
                            break;
                        case EBuscar.NOMBRE:
                            nAlojamiento = interfaz.ListarAlojamiento(checkTipo(), EBuscar.NOMBRE, txtBuscar.Text);
                            break;
                        case EBuscar.ID:
                            nAlojamiento = interfaz.ListarAlojamiento(checkTipo(), EBuscar.ID, txtBuscar.Text);
                            break;
                        default:
                            nAlojamiento = interfaz.ListarAlojamiento();
                            break;
                    }


                }
                CargarEnDataGrid();
                if (nAlojamiento.Count == 0)
                {
                    MessageBox.Show("No se encontro");
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (interfaz != null)
            {
                nAlojamiento = interfaz.ListarAlojamiento();
                CargarEnDataGrid();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnBuscar.PerformClick();
            }
        }

        private void FormLista_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                nAlojamiento = interfaz.ListarAlojamiento();
                CargarEnDataGrid();
                CargarfiltrosSelect();
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
        }

        private void CargarEnDataGrid()
        {
            dgLista.AutoGenerateColumns = false;
            dgLista.DataSource = null;
            dgLista.DataSource = nAlojamiento;
        }

        private ETipo checkTipo()
        {
            if (rbCasa.Checked) return ETipo.CASA;
            if (rbHotel.Checked) return ETipo.HOTEL;
            return ETipo.TODOS;
        }

        private void CargarfiltrosSelect()
        {
            cbfiltro.Items.Clear();
            cbfiltro.Items.Add(EBuscar.NOMBRE);
            cbfiltro.Items.Add(EBuscar.PERSONAS);
            cbfiltro.Items.Add(EBuscar.ID);
            cbfiltro.SelectedIndex = 0;
        }

        #region Cell mouse Click
        private void dgLista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string arg = dgLista.Columns[e.ColumnIndex].Name;
            if (arg == "editar" || arg == "ver")
            {
                string? nro = dgLista.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (nro != null)
                {
                    Alojamiento? al1 = nAlojamiento.Find(x => x.ID == nro);

                    if (al1 != null)
                    {
                        FormAlojamiento frmAloja = new FormAlojamiento(al1);
                        if (arg == "ver") frmAloja.Modifier = false;
                        frmAloja.MdiParent = this.MdiParent;
                        frmAloja.Show();
                    }
                }

            }
        }
        #endregion
    }
}
