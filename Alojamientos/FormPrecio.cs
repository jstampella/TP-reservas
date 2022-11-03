using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas.Alojamientos
{
    public partial class FormPrecio : Form
    {
        ITrasladarInfo? interfaz;
        decimal hotelesP;
        public FormPrecio()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           DialogResult dl = MessageBox.Show("Seguro que quieres actualizar los Hoteles y Casas?", "Aplicar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
           if(dl == DialogResult.Yes)
            {
                using(Loading lg = new Loading(this, ActualizarPrecios))
                {
                    lg.ShowDialog();
                }
            }

        }

        public void ActualizarPrecios()
        {
            try
            {
                if (interfaz != null)
                {
                    if (numCasa.Value != 0)
                    {
                        interfaz.ActualizarPrecioCasas(Convert.ToDouble(numCasa.Value));
                    }
                    if (hotelesP != numHotel.Value)
                    {
                        interfaz.ActualizarPrecioHoteles(Convert.ToDouble(numHotel.Value));
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPrecio_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                hotelesP = Convert.ToDecimal(interfaz.PrecioHotel);
                if(hotelesP>0)
                    numHotel.Value = hotelesP;
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
        }
    }
}
