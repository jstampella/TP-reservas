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
    public partial class ItemHotel : UserControl
    {
        public ItemHotel()
        {
            InitializeComponent();
            cmbEstrellas.SelectedIndex = 0;
        }

        public bool IsDeleted { get { return btnDelete.Enabled; } set { btnDelete.Enabled = value; } }


        public int Estrella { get { return Convert.ToInt32(cmbEstrellas.SelectedItem); } 
            set { cmbEstrellas.SelectedItem = value.ToString(); } }

        public int Habitacion { get { return Convert.ToInt32(txtNroHab.Text); } set { txtNroHab.Text = value.ToString(); } }

        public int Huesped { get { return Convert.ToInt32(numHusped.Value); } set { numHusped.Value = value; } }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
