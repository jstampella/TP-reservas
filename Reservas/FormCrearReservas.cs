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
using TPreservas.controles;

namespace TPreservas.Reservas
{
    public partial class FormCrearReservas : Form
    {
        private ITrasladarInfo? interfaz = null;
        List<Alojamiento> nAlojamiento = new List<Alojamiento>();
        List<Alojamiento> listadoAlojamiento = new List<Alojamiento>();
        List<Cliente> usuarios = new List<Cliente>();
        public FormCrearReservas()
        {
            InitializeComponent();
            btnCrear.Enabled = false;
            btnPrecio.Enabled = false;
            this.MaximumSize = new Size(this.Width, int.MaxValue);
        }


        #region Habilitar region
        private void HabilitarBtnCrear()
        {
            if (cbUsuario.SelectedIndex > -1 && lblAlojamiento.Text !="-")
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
        #endregion

        #region Load Form
        private void FormCrearReservas_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                nAlojamiento = interfaz.ListarAlojamiento();
                usuarios = interfaz.ListarClientes().ToList();
                CargarUsuario();
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
        }
        #endregion


        #region Cargar Usuario
        private void CargarUsuario()
        {
            cbUsuario.Items.Clear();
            foreach (Cliente item in usuarios)
            {
                cbUsuario.Items.Add(item.Nombre);
            }
        }
        #endregion


        #region Boton Crear
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();
                listaClientes.Add(usuarios[cbUsuario.SelectedIndex]);

                Alojamiento? alojamientoSelec = nAlojamiento.Find(x => x.Nombre == lblAlojamiento.Text);
                if (alojamientoSelec != null)
                {
                    DateTime checkIn = dtFecha.Value.Date;
                    DateTime checkOut = checkIn.AddDays(Convert.ToInt32(numericDay.Value));
                    int huesped = Convert.ToInt32(numericHuesped.Value);
                    if (interfaz != null)
                        interfaz.CrearReserva(alojamientoSelec, listaClientes, checkIn, checkOut, DateTime.Now, huesped);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                if (ex.InnerException == null)
                    MessageBox.Show(ex.Message);
                else
                    MessageBox.Show(ex.InnerException.Message);
            }
        }
        #endregion

        #region Boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(interfaz!=null)
                nAlojamiento = interfaz.ListarAlojamiento();
            DateTime checkIn = dtFecha.Value.Date;
            DateTime checkOut = checkIn.AddDays(Convert.ToInt32(numericDay.Value));
            int huesped = Convert.ToInt32(numericHuesped.Value);
            listadoAlojamiento = new List<Alojamiento>();
            if (interfaz != null)
                listadoAlojamiento = interfaz.AlojamientosDisponibles(checkIn, checkOut,huesped);
            lblAlojamiento.Text = "-";
            panelContenedorItem.Controls.Clear();
            foreach (Alojamiento item in listadoAlojamiento)
            {
                AgregarItem(item);
            }
            AgregarNoDisponible();
        }
        #endregion

        private void AgregarNoDisponible()
        {
            List<Alojamiento> alojamientos = nAlojamiento;
            foreach (Alojamiento item in listadoAlojamiento)
            {
                alojamientos = alojamientos.FindAll(x => x.IDs != item.IDs);
            }

            foreach (Alojamiento item in alojamientos)
            {
                ItemAlojamiento  mm = AgregarItem(item);
                if(item.Estado == EEstado.Activo)
                    mm.seleccionar.Text = "Reservado";
                else mm.seleccionar.Text = item.Estado.ToString();
                mm.Bloqueado = true;
            }
        }

        private ItemAlojamiento AgregarItem(Alojamiento alojamiento)
        {
            ItemAlojamiento itemlAlo = new ItemAlojamiento();
            itemlAlo.Name = alojamiento.IDs;
            itemlAlo.seleccionar.Click += ItemlAlo_MouseClick;
            itemlAlo.Width = panelContenedorItem.Width-10;
            itemlAlo.titulo.Text = alojamiento.Nombre;
            if(alojamiento.Imagenes.Count>0)
                itemlAlo.pxImagen.BackgroundImage = new Bitmap(alojamiento.Imagenes[0]);
            itemlAlo.Precio = alojamiento.Precio;
            itemlAlo.lbHuesped.Text = alojamiento.Huesped.ToString();
            itemlAlo.lbTipo.Text = alojamiento.Tipo.ToString();
            if (alojamiento is Hotel hs)
                itemlAlo.lbExtra.Text = hs.Estrella + " Estrellas | " + hs.NHabitacion + " Nro";
            if (alojamiento is Casa cs)
                itemlAlo.lbExtra.Text = cs.Mindias + " dias min.";
            panelContenedorItem.Controls.Add(itemlAlo);
            return itemlAlo;
        }

        private void CambiarColoresPanel()
        {
            foreach (Control item in panelContenedorItem.Controls)
            {
                if (item is ItemAlojamiento cc)
                    cc.seleccionar.Enabled = true;
            }
        }

        public void ItemlAlo_MouseClick(object? sender, EventArgs e)
        {
            if(sender is Control cc)
            {
                Alojamiento? alojamientoSelec = nAlojamiento.Find(x => x.IDs == cc.Parent.Name);
                if(alojamientoSelec != null)
                {
                    lblAlojamiento.Text = alojamientoSelec.Nombre;
                    CambiarColoresPanel();
                    HabilitarBtnCrear();
                    List<DateTime> fechas = new List<DateTime>();
                    if (interfaz != null)
                        fechas = interfaz.FechaOcupadas(alojamientoSelec);
                    calendarCustom1.AgregarOcupado(fechas);
                    cc.Enabled = false;
                }
            }
            
        }

        #region Evento cuando se selecciona usuario
        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBtnCrear();
        }
        #endregion

        #region Botn crear usuario
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
        #endregion


        #region Ver precio
        private void btnPrecio_Click(object sender, EventArgs e)
        {
            Alojamiento? alojamientoSelec = nAlojamiento.Find(x => x.Nombre == lblAlojamiento.Text);
            if(alojamientoSelec != null)
            {
                DateTime checkIn = dtFecha.Value.Date;
                DateTime checkOut = checkIn.AddDays(Convert.ToInt32(numericDay.Value));
                int huesped = Convert.ToInt32(numericHuesped.Value);
                Cliente nn = usuarios[cbUsuario.SelectedIndex];
                ComprobanteReserva comprobante = new ComprobanteReserva(alojamientoSelec, checkIn, checkOut, nn);
                comprobante.Text = "Comprobante no valido como factura";
                comprobante.ShowDialog();
            }
        }
        #endregion
    }
}
