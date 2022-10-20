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
