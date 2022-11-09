using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TPreservas.Reservas
{
    internal partial class ComprobanteReserva : Form
    {
        Font printFont;
        Brush relleno;
        Pen borde;
        SizeF tamañoLinea;
        int linea = 0;

        int numeroPagina = 1;

        public ComprobanteReserva()
        {
            InitializeComponent();
        }

        public ComprobanteReserva(Alojamiento alojamiento,DateTime Checkin,DateTime CheckOut,Cliente cliente) : this()
        {
            TimeSpan difFechas = CheckOut - Checkin;
            double PrecioFinal =  alojamiento.Precio * difFechas.Days;

            labelDireccion.Text = alojamiento.Direccion.ToString();
            labelExtraDirec.Text = alojamiento.ToString();
            labelTitulo.Text = alojamiento.Nombre;
            lblcheckout.Text = CheckOut.ToString();
            lbcheckin.Text = Checkin.ToString();
            lbCantidadPer.Text = alojamiento.Huesped.ToString();
            lblDni.Text = cliente.Dni.ToString();
            lblCliente.Text = cliente.Nombre.ToString();
            lblTotal.Text = PrecioFinal.ToString("C2");
            lblXdia.Text = alojamiento.Precio.ToString("C2");
            lblDiasReserv.Text = difFechas.Days.ToString();
            lblReservaF.Text = DateTime.Now.ToString();
        }

        public ComprobanteReserva(Reserva reserva):this()
        {
            labelDireccion.Text = reserva.Alojamiento.Direccion.ToString();
            labelExtraDirec.Text = reserva.Alojamiento.ToString();
            labelTitulo.Text = reserva.Alojamiento.Nombre;
            lblcheckout.Text = reserva.CheckOut.ToString();
            lbcheckin.Text = reserva.Checkin.ToString();
            lbCantidadPer.Text = reserva.Huesped.ToString();
            lblDni.Text = reserva.Cliente.Dni.ToString();
            lblCliente.Text = reserva.Cliente.Nombre.ToString();
            lblTotal.Text = reserva.PrecioFinal.ToString("C2");
            lblXdia.Text = reserva.CostoXdia.ToString("C2");
            lblDiasReserv.Text = reserva.Dias.ToString();
            lblReservaF.Text = reserva.FechaReserva.ToString();
        }

        private void imprimir_campos(PrintPageEventArgs e)
        {
            if(e.Graphics != null)
            {
                Font fontTitulo = new Font("Arial", 22,FontStyle.Bold);
                Brush brushTitulo = new SolidBrush(Color.Brown);
                Image LOGO = Properties.Resources.logo;
                int widthLogo = 200;
                int heightLogo = widthLogo*LOGO.Height / LOGO.Width;
                e.Graphics.DrawImage(LOGO, e.MarginBounds.Width - widthLogo, 10, widthLogo, heightLogo);

                float leftMargin = e.MarginBounds.Left;
                float topMargin = e.MarginBounds.Top;
                float medidaText = fontTitulo.GetHeight(e.Graphics);
                e.Graphics.DrawString(labelTitulo.Text, fontTitulo, brushTitulo, new PointF(0, medidaText));

                e.Graphics.DrawString(labelTitulo.Text, fontTitulo, relleno, new PointF(0, medidaText*2));
                e.Graphics.DrawString(labelTitulo.Text, fontTitulo, relleno, new PointF(0, medidaText*3));
                e.Graphics.DrawString(labelTitulo.Text, fontTitulo, relleno, new PointF(0, medidaText*4));

                //labelDireccion.Text = "";
                //labelExtraDirec.Text = "";
                //labelTitulo.Text = "";
                //lblcheckout.Text = 
                //lbcheckin.Text = 
                //lbCantidadPer.Text =
                //lblDni.Text =
                //lblCliente.Text = 
                //lblTotal.Text = 
                //lblXdia.Text = 
                //lblDiasReserv.Text =
                //lblReservaF.Text = 
            }


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Margins margenes = new Margins(25, 25, 25, 30);
            printDocument1.DefaultPageSettings.Margins = margenes;
            //printDialog1.Document = printDocument1;
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    Margins margenes = new Margins(20, 15, 15, 30);
            //    printDocument1.DefaultPageSettings.Margins = margenes;
            //    printDocument1.Print();
            //}
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (e.Graphics != null)
            {
                e.Graphics.DrawRectangle(borde, new Rectangle(0, 0, e.MarginBounds.Width, e.MarginBounds.Height));
                imprimir_campos(e);
                e.Graphics.DrawString("Página " + numeroPagina.ToString(),
printFont, relleno, 0, 0);
                linea++;
                if (linea < 3)
                {
                    e.HasMorePages = true;
                    numeroPagina++;
                }
                else e.HasMorePages = false;

            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printFont = new Font("Arial", 12);
            relleno = new SolidBrush(Color.Black);
            borde = new Pen(Color.Black);
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printFont.Dispose();
            borde.Dispose();
            relleno.Dispose();
        }
    }
}
