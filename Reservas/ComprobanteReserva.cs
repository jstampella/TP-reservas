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
using TPreservas.Properties;
using static System.Windows.Forms.DataFormats;
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
        Image jpgAlojamiento;

        int numeroPagina = 1;

        public ComprobanteReserva()
        {
            InitializeComponent();
        }
        /*Imprimir un original y una copia de la reserva, donde quede el registro escrito de la misma,
agregando los datos personales (nombre, dni y fecha de nacimiento de cada huésped).
La impresión debe tener una imagen de la propiedad.*/

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
            jpgAlojamiento = Resources.images; //en esta parte va la imagen 

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
            jpgAlojamiento = Resources.images; //en esta parte va la imagen
        }
        //e.MarginBounds.Height   la parte baja de la hoja
        //e.MarginBounds.Right    la parte derecha
        //e.MarginBounds
        private void Imprimir_campos(PrintPageEventArgs e)
        {
            if (e.Graphics != null)
            {
                Brush solid = new SolidBrush(Color.FromArgb(240, 242, 239)); //Gris
                Brush solid2 = new SolidBrush(Color.FromArgb(178, 225, 235));//turqueza
                Brush solid3 = new SolidBrush(Color.FromArgb(31, 33, 89));//azul
                Font fontTitulo = new Font("Times New Roman", 22, FontStyle.Bold);
                Font textoId = new Font("Times New Roman", 12, FontStyle.Regular);
                Brush brushid = new SolidBrush(Color.Black);
                Brush brushTitulo = new SolidBrush(Color.White);
                Image LOGO = Resources.logo;
                int widthLogo = 150;
                float leftMargin = e.MarginBounds.Left;
                float topMargin = e.MarginBounds.Top;
                float medidaText = fontTitulo.GetHeight(e.Graphics);
                int heightLogo = widthLogo * LOGO.Height / LOGO.Width;
               
                int tem = (((e.MarginBounds.Width / 3) - 10) / 2) + 10;
                
                //diseño
                Rectangle rect2 = new Rectangle(e.MarginBounds.Left, 80, e.MarginBounds.Width / 2, 100);//  azul parte arriba
                e.Graphics.DrawLine(borde, (e.MarginBounds.Width / 2), 125, 30 + (e.MarginBounds.Width), 125);
                e.Graphics.FillRectangle(solid3, rect2);
                //linea superior
                Rectangle rect3 = new Rectangle( e.MarginBounds.Left, 200, 200, 600);
                e.Graphics.FillRectangle(solid2, rect3);  // Rectangulo celeste 
                Rectangle rect4 = new Rectangle(200, 200, e.MarginBounds.Width - 180, 600);
                e.Graphics.FillRectangle(solid, rect4);//Rectangulo gris 
                Rectangle rect5 = new Rectangle(e.MarginBounds.Left, e.MarginBounds.Height-100,e.MarginBounds.Width , 70); //rectangulo Precio 
               
               
                e.Graphics.FillRectangle(solid3, rect5);

                e.Graphics.DrawImage(LOGO, e.MarginBounds.Width - widthLogo, 50, widthLogo, heightLogo);//logo
                e.Graphics.DrawImage(jpgAlojamiento,e.MarginBounds.Left+30, e.MarginBounds.Height - jpgAlojamiento.Height+50,e.MarginBounds.Width/2, jpgAlojamiento.Height-50);//imagen alojamiento
                String text1 = String.Format("Id: {0} \nDireccion: {1} \n \nFecha de Reserva. \nCheckIn: {2}" +
                    " \nCheckOut: {3}\n \nPrecio por Dia: {4} \nDatos de cliente\n\nNombre:{5}\nApellido: {6}" +
                    "\nDni: {7}\n Fecha de Nacimiento: {8}\nTelefono: {9}\n\nCantidad de Huespedes:{10}", "nicolas",
                    "philbois","35235","23235","2352","235235","23523","23523","25235","2352","235235");
                e.Graphics.DrawString((text1), textoId, brushid, rect3);

                String o22 = "Hotel de los naranjos";

                string text2 = String.Format("Alojamiento: {0} ",o22);//nombre alojamiento 
                Font font2 = new Font("Sanseriffic", 22, FontStyle.Bold, GraphicsUnit.Point);                StringFormat stringFormat = new StringFormat();
                stringFormat.LineAlignment = StringAlignment.Center;
                stringFormat.Alignment = StringAlignment.Center;   
                e.Graphics.DrawString((text2), font2, brushTitulo , rect2,stringFormat);  // texto del alojamiento

                stringFormat.Alignment = StringAlignment.Far;

                e.Graphics.DrawString(lblTotal.Text, fontTitulo, brushTitulo, rect5, stringFormat); //texto del precio 
              

            }


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Margins margenes = new Margins(25, 40, 25, 30);
            printDocument1.DefaultPageSettings.Margins = margenes;

            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //   printDocument1.Print();


            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            if (e.Graphics != null)
            {
              
               e.Graphics.DrawRectangle(borde,e.MarginBounds.Top, e.MarginBounds.Left, e.MarginBounds.Width, e.MarginBounds.Height);
                Imprimir_campos(e);
                if (linea < 1)
                {
                    e.Graphics.DrawString("Original" , printFont, new SolidBrush(Color.Black), e.MarginBounds.Width/2, 5);
                }
                else
                {
                    e.Graphics.DrawString("Copia", printFont, new SolidBrush(Color.Black), e.MarginBounds.Width / 2, 5);
                }
                
                e.Graphics.DrawString("Página " + numeroPagina.ToString(), printFont, new SolidBrush (Color.Black ), e.MarginBounds.Right-100,e.MarginBounds.Height);
                linea++;
                if (linea < 2)
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
            relleno = new SolidBrush(Color.FromArgb(92, 198, 208));
            borde = new Pen(relleno,5);
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printFont.Dispose();
            borde.Dispose();
            relleno.Dispose();
        }
    }
}
