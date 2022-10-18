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

namespace TPreservas.controles
{
    public partial class CalendarCustom : UserControl
    {
        bool bandera = false;
        DateTime fecha;
        List<Point> diasGris = new List<Point>();
        List<Point> diasMes = new List<Point>();
        List<DateTime> diasOcupados = new List<DateTime>();
        List<DateTime> calendario = new List<DateTime>();
        Color[] colores = new Color[3];
        public CalendarCustom()
        {
            InitializeComponent();
            colores[0] = Color.Red;
            colores[1] = Color.AliceBlue;
            colores[2] = Color.DarkGray;
        }

        private void CargarValores(int anio,int mes)
        {
            diasGris.Clear();
            diasMes.Clear();
            calendario.Clear();
            int diasTotales = DateTime.DaysInMonth(anio, mes);
            fecha = new DateTime(anio, mes, 1);
            int diasemana = (int)fecha.DayOfWeek;

            if (diasemana > 0)
            {
                int d = diasemana-1;
                while (d >= 0)
                {
                    fecha = new DateTime(anio, mes,1);
                    DateTime nuevaF = fecha.AddDays(d- diasemana);
                    Label lbl = new Label();
                    lbl.Text = nuevaF.Day.ToString();
                    diasGris.Add(new Point(d, 0));
                    calendario.Add(nuevaF);
                    AgregarElemento(lbl, d, 0, colores[2]);
                    d--;
                };
            }

            int ejeY = 0;
            for (int i = 1; i <= diasTotales; i++)
            {
                Label lbl = new Label();
                lbl.Text = i.ToString();
                diasMes.Add(new Point(diasemana, ejeY));
                calendario.Add(new DateTime(anio,mes, i));
                AgregarElemento(lbl, diasemana, ejeY, colores[1]);
                if (diasemana == 6)
                {
                    diasemana = 0;
                    ejeY++;
                }
                else
                {
                    diasemana++;
                }
            }
            fecha = new DateTime(anio, mes, diasTotales);
            diasemana = (int)fecha.DayOfWeek;
            if (calendario.Count < 42)
            {
                int d = diasemana + 1;
                int cont = 0;
                while (calendario.Count <= 42)
                {
                    cont++;
                    DateTime nuevaF = fecha.AddDays(cont);
                    Label lbl = new Label();
                    lbl.Text = nuevaF.Day.ToString();
                    diasGris.Add(new Point(d, ejeY));
                    calendario.Add(nuevaF);
                    AgregarElemento(lbl, d, ejeY, colores[2]);
                    if (d == 6)
                    {
                        d = 0;
                        ejeY++;
                    }
                    else
                    {
                        d++;
                    }
                };
            }
        }

        private void AgregarOcupado()
        {
            foreach (DateTime fe in diasOcupados)
            {
                DateTime nDate = new DateTime(fe.Year, fe.Month, fe.Day);
                int posicion = calendario.FindIndex(f => f == nDate);
                if (posicion != -1)
                {
                    int posX = posicion % 7;
                    int posY = posicion / 7;
                    Panel item = (Panel)TableCalendar.GetControlFromPosition(posX, posY);
                    if (item != null)
                    {
                        item.BackColor = colores[0];
                    }
                }
            }
                
        }

        public void AgregarOcupado(List<DateTime> fechas)
        {
            bandera = false;
            diasOcupados.Clear();
            diasOcupados = fechas;
            if (diasOcupados.Count > 0)
            {
                if (diasOcupados[0].Year.ToString() != cbAnio.SelectedItem.ToString() || diasOcupados[0].Month.ToString() != cbMes.SelectedItem.ToString())
                {
                    cbMes.SelectedIndex = diasOcupados[0].Month - 1;
                    cbAnio.SelectedItem = diasOcupados[0].Year.ToString();
                    CargarValores(diasOcupados[0].Year, diasOcupados[0].Month);
                }
            }
            foreach (Point item in diasGris)
            {
                CambiarColor(item.X, item.Y, colores[2]);
            }
            foreach (Point item in diasMes)
            {
                CambiarColor(item.X, item.Y, colores[1]);
            }
            AgregarOcupado();
            bandera = true;
        }


        private void CambiarColor(int posX, int posY, Color colors)
        {
            Panel item = (Panel)TableCalendar.GetControlFromPosition(posX, posY);
            if (item != null)
            {
                item.BackColor = colors;
            }
        }

        private void AgregarElemento(Control obj, int posX, int posY,Color colors)
        {
            Panel item = (Panel)TableCalendar.GetControlFromPosition(posX, posY);
            if (item != null)
            {
                item.Controls.Clear();
                item.Controls.Add(obj);
                item.BackColor = colors;
            }
        }

        private void cbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandera)
            {
                int mes = cbMes.SelectedIndex + 1;
                int anio = Convert.ToInt32(cbAnio.SelectedItem);
                if (mes != 0 && anio != 0)
                    CargarValores(anio, mes);
            }
        }

        private void CargarPanel()
        {
            for (int i = 0; i < TableCalendar.ColumnCount; i++)
            {
                for (int j = 0;  j < TableCalendar.RowCount; j++)
                {
                    Panel pn = new Panel();
                    pn.Name = i +"-"+ j;
                    pn.Margin = new Padding(0, 0, 0, 0);
                    pn.Dock = DockStyle.Fill;
                    TableCalendar.Controls.Add(pn, i, j);
                }
            }
            
        }

        private void CalendarCustom_Load(object sender, EventArgs e)
        {
            int anio = DateTime.Now.Year;
            int mes = DateTime.Now.Month;
            for (int a = anio - 1; a <= anio + 1; a++)
                cbAnio.Items.Add(a.ToString());
            cbMes.SelectedIndex = mes - 1;
            cbAnio.SelectedItem = anio.ToString();
            CargarPanel();
            CargarValores(anio, mes);
            bandera = true;


        }
    }
}
