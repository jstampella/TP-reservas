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
    public partial class CalendarCustom : UserControl
    {
        public CalendarCustom()
        {
            InitializeComponent();
        }

        public void AgregarElemento(Control obj,int posX,int posY)
        {
            TableCalendar.Controls.Add(obj, posX, posY);
        }
    }
}
