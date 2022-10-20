using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas.Reservas
{
    public partial class FormCrearReservas : Form
    {
        private ITrasladarInfo? interfaz = null;
        List<Alojamiento> nAlojamiento = new List<Alojamiento>();
        List<Cliente> usuarios = new List<Cliente>();
        public FormCrearReservas()
        {
            InitializeComponent();
            btnCrear.Enabled = false;
            btnPrecio.Enabled = false;
        }


        private void HabilitarBtnCrear()
        {
            if (cbUsuario.SelectedIndex > -1 && lbAlojamiento.SelectedIndex > -1)
            {
                btnCrear.Enabled = true;
                btnPrecio.Enabled = true;
            }
            else
            {
                btnCrear.Enabled = false;
                btnPrecio.Enabled = false;
            }
        }

        private void FormCrearReservas_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                nAlojamiento = interfaz.ListarAlojamiento();
                usuarios = interfaz.ListarClientes();
                CargarAlojamiento();
                CargarUsuario();
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
        }

        private void CargarUsuario()
        {
            cbUsuario.Items.Clear();
            foreach (Cliente item in usuarios)
            {
                cbUsuario.Items.Add(item.Nombre);
            }
        }

        private void CargarAlojamiento()
        {
            cbUsuario.Items.Clear();
            foreach (Alojamiento item in nAlojamiento)
            {
                cbUsuario.Items.Add(item.Nombre);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();
                listaClientes.Add(usuarios[cbUsuario.SelectedIndex]);

                int indAlojamiento = lbAlojamiento.SelectedIndex;
                Alojamiento alojamiento = nAlojamiento[indAlojamiento];
                DateTime checkIn = dtFecha.Value.Date;
                DateTime checkOut = checkIn.AddDays(Convert.ToInt32(numericDay.Value));
                int huesped = Convert.ToInt32(numericHuesped.Value);
                if (interfaz != null)
                    interfaz.CrearReserva(alojamiento, listaClientes, checkIn, checkOut, alojamiento.Costo, DateTime.Now, huesped);
                this.Close();
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null)
                    MessageBox.Show(ex.Message);
                else
                    MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtFecha.Value.Date;
            DateTime checkOut = checkIn.AddDays(Convert.ToInt32(numericDay.Value));
            int huesped = Convert.ToInt32(numericHuesped.Value);
            List<Alojamiento> listadoAlojamiento = new List<Alojamiento>();
            if (interfaz != null)
                listadoAlojamiento = interfaz.AlojamientosDisponibles(checkIn, checkOut,huesped);
            lbAlojamiento.Items.Clear();
            foreach (Alojamiento item in listadoAlojamiento)
            {
                lbAlojamiento.Items.Add(item.ToString());
            }
        }

        private void lbAlojamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBtnCrear();
            Alojamiento alojamientoSelec = nAlojamiento[lbAlojamiento.SelectedIndex];
            List<DateTime> fechas = new List<DateTime>();
            if (interfaz != null)
                fechas = interfaz.FechaOcupadas(alojamientoSelec);
            calendarCustom1.AgregarOcupado(fechas);
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBtnCrear();
        }

        private void btnCrearU_Click(object sender, EventArgs e)
        {
            if(this.MdiParent is ITrasladarInfo it)
            {
                FormCliente ncliente = new FormCliente();
                ncliente.Interfaz = it;
                if (ncliente.ShowDialog() == DialogResult.OK)
                {
                    CargarUsuario();
                }
            }

        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            Alojamiento alojamientoSelec = nAlojamiento[lbAlojamiento.SelectedIndex];
            DateTime checkIn = dtFecha.Value.Date;
            DateTime checkOut = checkIn.AddDays(Convert.ToInt32(numericDay.Value));
            int huesped = Convert.ToInt32(numericHuesped.Value);
            Cliente nn = usuarios[cbUsuario.SelectedIndex];
            ComprobanteReserva comprobante = new ComprobanteReserva(alojamientoSelec, checkIn, checkOut,nn);
            comprobante.Text = "Comprobante no valido como factura";
            comprobante.ShowDialog();
        }
    }
}
