using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas.Alojamientos
{
    public partial class FrmDisponiAlojamiento : Form
    {
        private ITrasladarInfo? interfaz = null;
        List<Alojamiento> nAlojamiento = new List<Alojamiento>();

        public FrmDisponiAlojamiento()
        {
            InitializeComponent();
        }



        private void CargarAlojamiento(List<Alojamiento> alojamientos)
        {
            cbAlojamiento2.Items.Clear();
            foreach (Alojamiento item in alojamientos)
            {
                cbAlojamiento2.Items.Add(item.Nombre);
            }
            cbAlojamiento2.SelectedIndex = 0;
        }

        private void FrmDisponiAlojamiento_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                nAlojamiento = interfaz.ListarAlojamiento();
                CargarAlojamiento(nAlojamiento);
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtCheckin.Value.Date;
            DateTime checkOut = dtCheckout.Value.Date;
            List<Alojamiento> listadoAlojamiento = new List<Alojamiento>();
            if (interfaz!=null)
                listadoAlojamiento = interfaz.AlojamientosDisponibles(checkIn, checkOut);
            cbAlojamiento2.Items.Clear();
            foreach (Alojamiento item in listadoAlojamiento)
            {
                cbAlojamiento2.Items.Add(item.Nombre);
            }
            cbAlojamiento2.SelectedIndex = 0;
        }

        private void cbAlojamiento2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbAlojamiento2.SelectedIndex;
            Alojamiento alojamientoSelec = nAlojamiento[index];
            List<DateTime> fechas = new List<DateTime>();
            if (interfaz != null)
                fechas = interfaz.FechaOcupadas(alojamientoSelec);

            listBox1.DataSource = null;
            listBox1.DataSource = fechas;
            calendarCustom1.AgregarOcupado(fechas);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                nAlojamiento = interfaz.ListarAlojamiento();
                CargarAlojamiento(nAlojamiento);
            }
        }
    }
}
