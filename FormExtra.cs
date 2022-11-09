using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas
{
    public partial class FormExtra : Form
    {
        private ITrasladarInfo? interfaz;
        public FormExtra()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (numdias.Value < 1 || numPorcentaje.Value < 0)
            {
                MessageBox.Show("Complete los campos");
                return;
            }
            else
            {
                if(interfaz != null)
                {
                    int dias = Convert.ToInt16(numdias.Value);
                    double porce = Convert.ToDouble(numPorcentaje.Value);
                    Action a = () => interfaz.CargarPenalidad(dias, porce);
                    using (Loading lg = new Loading(this, a,"Se actualizo"))
                    {
                        lg.ShowDialog();
                    }
                    this.Close();
                }
            }
        }

        private void FormExtra_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                numdias.Value = interfaz.DiasPenalidad;
                numPorcentaje.Value = Convert.ToDecimal(interfaz.PorcentajePenalidad);
            }
            else if (interfaz == null)

            {
                MessageBox.Show("Error al cargar componente.");
            }
        }
    }
}
