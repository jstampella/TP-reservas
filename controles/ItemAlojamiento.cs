using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas.controles
{
    public partial class ItemAlojamiento : UserControl
    {
        private bool bloqueado = false;
        public ItemAlojamiento()
        {
            InitializeComponent();
            Bloqueado = false; 
        }

        public bool Bloqueado
        {
            get { return bloqueado; }
            set { 
                bloqueado = value;
                if (bloqueado)
                {
                    seleccionar.BackColor = Color.Silver;
                    titulo.BackColor = Color.Silver;
                    titulo.ForeColor = Color.DimGray;
                }
                else
                {
                    seleccionar.BackColor = Color.IndianRed;
                    titulo.BackColor = Color.SeaGreen;
                    titulo.ForeColor = Color.White;
                }

            }
        }
        public double Precio
        {
            get { return Convert.ToDouble(precioXdia.Text); }
            set {  precioXdia.Text = value.ToString("C2"); }
        }

        private void seleccionar_MouseEnter(object sender, EventArgs e)
        {
            if(!bloqueado)
                seleccionar.BackColor = Color.Thistle;
        }

        private void seleccionar_MouseLeave(object sender, EventArgs e)
        {
            if(seleccionar.Enabled && !bloqueado)
                seleccionar.BackColor = Color.IndianRed;
        }

        private void seleccionar_MouseClick(object sender, MouseEventArgs e)
        {
            if(!bloqueado)
                seleccionar.BackColor = Color.Aquamarine;
        }

        private void seleccionar_EnabledChanged(object sender, EventArgs e)
        {
            if(!bloqueado)
                if(seleccionar.Enabled)
                    seleccionar.BackColor = Color.IndianRed;
                else
                    seleccionar.BackColor = Color.Aquamarine;
        }
    }
}
