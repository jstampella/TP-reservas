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
    internal partial class ModificarReserva : Form
    {
        private ITrasladarInfo? interfaz = null;
        public ModificarReserva()
        {
            InitializeComponent();
            cbEstado.Items.AddRange(ListaEstado().ToArray());
            cbEstado.SelectedIndex = 0;
        }

        public ModificarReserva(Reserva miReserva) : this()
        {
            lblIdAloja.Text = miReserva.Alojamiento.ID.ToString();
            dtcheckin.Value = miReserva.Checkin;
            dtCheckOut.Value = miReserva.CheckOut;
            numericHuesped.Value = miReserva.Huesped;
            cbEstado.SelectedItem = miReserva.Estado.ToString();
            lblId.Text = miReserva.Id.ToString();
        }

        private List<string> ListaEstado()
        {
            List<string> list = new List<string>();
            foreach (string item in Enum.GetNames(typeof(EEstadoReserva)))
            {
                list.Add(item);
            }
            return list;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (interfaz != null)
                {

                    EEstadoReserva ee = (EEstadoReserva)cbEstado.SelectedIndex;
                    if (ee != EEstadoReserva.Cancelada || ee != EEstadoReserva.Activa) ee = EEstadoReserva.Modificada;
                    int hue = Convert.ToInt32(numericHuesped.Value);
                    int idReserva = Convert.ToInt32(lblId.Text);
                    int idAlojamiento = Convert.ToInt32(lblIdAloja.Text);
                    interfaz.ModificarReserva(idAlojamiento, idReserva, dtcheckin.Value, dtCheckOut.Value, ee, hue);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void ModificarReserva_Load(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
                interfaz = (ITrasladarInfo)this.MdiParent;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
