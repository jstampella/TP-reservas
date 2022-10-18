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
                dgLista.DataSource= reservas;
                //CargarEnDataGrid(nAlojamiento);
                //CargarfiltrosSelect();
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
            dgLista.DataSource = null;
            dgLista.DataSource = reservas;
        }
    }
}
