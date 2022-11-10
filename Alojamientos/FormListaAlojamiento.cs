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

        #region Ordenamiento
        #endregion

        #region Btn Buscar
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
        #endregion


        #region btn Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (interfaz != null)
            {
                nAlojamiento = interfaz.ListarAlojamiento();
                CargarEnDataGrid();
            }
        }
        #endregion

        #region btn Buscar event key
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnBuscar.PerformClick();
            }
        }
        #endregion


        #region load
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
        #endregion

        private void CargarEnDataGrid()
        {
            dgLista.AutoGenerateColumns = false;
            dgLista.DataSource = null;
            dgLista.DataSource = new BindingList<Alojamiento>(nAlojamiento);

            
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



        private void dgLista_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            if (grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }
            //set SortGlyphDirection after databinding otherwise will always be none 
            Sort(grid.Columns[e.ColumnIndex].Name, so);
            foreach (DataGridViewColumn item in grid.Columns)
            {
                item.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;

        }
        private void Sort(string column, SortOrder sortOrder)
        {
            switch (column)
            {
                case "IDs":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            dgLista.DataSource = null;
                            dgLista.DataSource = nAlojamiento.OrderBy(x => x.ID).ToList();
                        }
                        else
                        {
                            dgLista.DataSource = nAlojamiento.OrderByDescending(x => x.ID).ToList();
                        }
                        break;
                    }
                case "nombre":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            dgLista.DataSource = nAlojamiento.OrderBy(x => x.Nombre).ToList();
                        }
                        else
                        {
                            dgLista.DataSource = nAlojamiento.OrderByDescending(x => x.Nombre).ToList();
                        }
                        break;
                    }
                case "direccion":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            dgLista.DataSource = nAlojamiento.OrderBy(x => x.Direccion).ToList();
                        }
                        else
                        {
                            dgLista.DataSource = nAlojamiento.OrderByDescending(x => x.Direccion).ToList();
                        }
                        break;
                    }
            }

        }

        #region Cell mouse Click
        private void dgLista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string arg = dgLista.Columns[e.ColumnIndex].Name;
                if (arg == "editar" || arg == "ver")
                {
                    string? nro = dgLista.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (nro != null)
                    {
                        Alojamiento? al1 = nAlojamiento.Find(x => x.IDs == nro);

                        if (al1 != null)
                        {
                            this.Cursor = Cursors.WaitCursor;
                            FormAlojamiento frmAloja = new FormAlojamiento(al1);
                            if (arg == "ver") frmAloja.Modifier = false;
                            frmAloja.MdiParent = this.MdiParent;
                            this.Cursor = Cursors.Default;
                            frmAloja.Show();
                        }
                    }

                }
                else if (arg == "exportar")
                {
                    if (interfaz != null)
                    {


                        string? nro = dgLista.Rows[e.RowIndex].Cells[0].Value.ToString();
                        if (nro != null)
                        {
                            Alojamiento? al1 = nAlojamiento.Find(x => x.IDs == nro);
                            if (al1 != null)
                            {
                                SaveFileDialog saveFileDialog = new SaveFileDialog();
                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    interfaz.exportarCalendario(al1.IDs, saveFileDialog.FileName);
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}
