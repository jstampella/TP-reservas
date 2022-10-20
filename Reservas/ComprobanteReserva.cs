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
    internal partial class ComprobanteReserva : Form
    {
        public ComprobanteReserva()
        {
            InitializeComponent();
        }

        public ComprobanteReserva(Alojamiento alojamiento,DateTime Checkin,DateTime CheckOut,Cliente cliente) : this()
        {
            TimeSpan difFechas = CheckOut - Checkin;
            double PrecioFinal =  alojamiento.Precio * difFechas.Days;

            labelDireccion.Text = alojamiento.Direccion;
            labelExtraDirec.Text = alojamiento.ToString();
            labelTitulo.Text = alojamiento.Nombre;
            lblcheckout.Text = CheckOut.ToString();
            lbcheckin.Text = Checkin.ToString();
            lblDni.Text = cliente.Dni.ToString();
            lblCliente.Text = cliente.Nombre.ToString();
            lblTotal.Text = PrecioFinal.ToString("C2");
            lblXdia.Text = alojamiento.Precio.ToString("C2");
            lblDiasReserv.Text = difFechas.ToString();
            lblReservaF.Text = DateTime.Now.ToString();
        }

        public ComprobanteReserva(Reserva reserva):this()
        {
            labelDireccion.Text = reserva.Alojamiento.Direccion;
            labelExtraDirec.Text = reserva.Alojamiento.ToString();
            labelTitulo.Text = reserva.Alojamiento.Nombre;
            lblcheckout.Text = reserva.CheckOut.ToString();
            lbcheckin.Text = reserva.Checkin.ToString();
            lblDni.Text = reserva.Cliente.Dni.ToString();
            lblCliente.Text = reserva.Cliente.Nombre.ToString();
            lblTotal.Text = reserva.PrecioFinal.ToString("C2");
            lblXdia.Text = reserva.CostoXdia.ToString("C2");
            lblDiasReserv.Text = reserva.Dias.ToString();
            lblReservaF.Text = reserva.FechaReserva.ToString();
        }
    }
}
