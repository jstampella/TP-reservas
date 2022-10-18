using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas
{
    public partial class FormImagenes : Form
    {
        public FormImagenes()
        {
            InitializeComponent();
        }

        public void CargarImagenes(string[] imagenes)
        {
            foreach (string imagen in imagenes)
            {
                PictureBox px = new PictureBox();
                px.Image = new Bitmap(imagen);
                px.Width = 500;
                px.Height = 400;
                px.SizeMode = PictureBoxSizeMode.Zoom;
                flowPanel.Controls.Add(px);
            }
        }
    }
}
