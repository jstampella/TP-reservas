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
                CargarEnDataGrid(nAlojamiento);
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
                CargarEnDataGrid(nAlojamiento);
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
                CargarEnDataGrid(nAlojamiento);
                CargarfiltrosSelect();
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
        }

        private void CargarEnDataGrid(List<Alojamiento> lista)
        {
            dgLista.Rows.Clear();
            foreach (Alojamiento item in lista)
            {
                string[] rw = { item.ID.ToString(), item.Nombre, item.Direccion, item.Huesped.ToString(), item.Precio.ToString(), item.Estado.ToString(), item.Tipo.ToString(), "EDITAR", "VER" };
                dgLista.Rows.Add(rw);
            }
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

        private void dgLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string arg = dgLista.Columns[e.ColumnIndex].Name;
                if (arg == "editar")
                {
                    string? nro = dgLista.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (nro != null)
                    {
                        Alojamiento? al1 = nAlojamiento.Find(x => x.ID == nro);
                        if (al1 != null)
                        {
                            FormAlojamiento formAl = new FormAlojamiento((ITrasladarInfo)this.MdiParent, al1);
                            //FormAlojamiento formAl = new FormAlojamiento((ITrasladarInfo)this.MdiParent, nro);
                            formAl.MdiParent = this.MdiParent;
                            formAl.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }

                }
                else if (arg == "ver")
                {
                    string? nro = dgLista.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (nro != null)
                    {
                        Alojamiento? al1 = nAlojamiento.Find(x => x.ID == nro);
                        if (al1 != null)
                        {
                            FormAlojamiento formAl = new FormAlojamiento((ITrasladarInfo)this.MdiParent, al1);
                            //FormAlojamiento formAl = new FormAlojamiento((ITrasladarInfo)this.MdiParent, nro);
                            formAl.MdiParent = this.MdiParent;
                            formAl.Modifier = false;
                            formAl.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }

                }
            }

        }

        private void dgLista_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string arg = dgLista.Columns[e.ColumnIndex].Name;
            if (arg == "editar" || arg == "ver")
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void dgLista_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgLista.Cursor = Cursors.Default;
        }

        private void dgLista_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            //Check the condition as per the requirement casting the cell value to the appropriate type
            string arg = dgLista.Columns[e.ColumnIndex].Name;
            if (arg == "editar" || arg == "ver")
            
                dgLista.Cursor = Cursors.Hand;
            else
                dgLista.Cursor = Cursors.Default;
        }
    }
}
