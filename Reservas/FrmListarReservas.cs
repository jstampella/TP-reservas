using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas.Reservas
{
    public partial class FrmListarReservas : Form
    {
        private ITrasladarInfo? interfaz = null;
        List<Reserva> reservas = new List<Reserva>();
        public FrmListarReservas()
        {
            InitializeComponent();
        }

        private void FrmListarReservas_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                reservas = interfaz.ListarReservas();
                CargarDats();
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(interfaz!=null)
                reservas = interfaz.ListarReservas();
            CargarDats();
        }

        private void CargarDats()
        {
            dgLista.AutoGenerateColumns = false;
            dgLista.DataSource = null;
            dgLista.DataSource = new BindingList<Reserva>(reservas);
        }


        #region Cell mouse Click
        private void dgLista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string arg = dgLista.Columns[e.ColumnIndex].Name;
                if (arg == "editar" || arg == "ver")
                {
                    int? nro = Convert.ToInt32(dgLista.Rows[e.RowIndex].Cells[0].Value);
                    if (nro != null)
                    {
                        Reserva? al1 = reservas.Find(x => x.Id == nro);

                        if (al1 != null)
                        {
                            if (arg == "ver")
                            {
                                ComprobanteReserva comprobante = new ComprobanteReserva(al1);
                                comprobante.MdiParent = this.MdiParent;
                                comprobante.Show();
                            }
                            else
                            {
                                ModificarReserva mReser = new ModificarReserva(al1);
                                mReser.MdiParent = this.MdiParent;
                                mReser.Show();
                            }
                        }
                    }

                }
            }

        }

        #endregion
    }

}
