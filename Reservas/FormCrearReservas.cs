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
    public partial class FormCrearReservas : Form
    {
        private ITrasladarInfo? interfaz = null;
        List<Alojamiento> nAlojamiento = new List<Alojamiento>();
        public FormCrearReservas()
        {
            InitializeComponent();
        }

        private void FormCrearReservas_Load(object sender, EventArgs e)
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

        private void CargarAlojamiento(List<Alojamiento> alojamientos)
        {
            cbAlojamientos.Items.Clear();
            foreach (Alojamiento item in alojamientos)
            {
                cbAlojamientos.Items.Add(item.Nombre);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cliente nCliente = new Cliente("Carlos");
            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(nCliente);

            int indAlojamiento = cbAlojamientos.SelectedIndex;
            Alojamiento alojamiento = nAlojamiento[indAlojamiento];
            DateTime checkIn = dtFecha.Value.Date;
            DateTime checkOut = checkIn.AddDays(Convert.ToInt32(numericDay.Value));
            int huesped = Convert.ToInt32(numericHuesped.Value);
            if(interfaz!=null)
                interfaz.CrearReserva(alojamiento, listaClientes, checkIn, checkOut, alojamiento.Costo,DateTime.Now,huesped);
            this.Close();
        }
    }
}
