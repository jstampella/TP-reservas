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
using static System.Net.Mime.MediaTypeNames;

namespace TPreservas
{
    public partial class FormImagenes : Form
    {
        public List<string> imagenes = new List<string>();
        private bool modificado = false;
        public FormImagenes()
        {
            InitializeComponent();
        }

        public FormImagenes(Bitmap image) : this()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Text = "Imagen Ampliada";
            this.Controls.Remove(flowPanel);
            PictureBox px = new PictureBox();
            px.Image = image;
            px.Dock = DockStyle.Fill;
            px.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(px);
            

        }

        public void CargarImagenes(string[] imagenes)
        {
            this.imagenes = imagenes.ToList();
            int indice = 0;
            foreach (string imagen in imagenes)
            {
                if(imagen != null)
                {
                    if (File.Exists(imagen))
                    {
                        try
                        {
                            Button pd = new Button();
                            pd.Text = "Eliminar";
                            pd.Name = "imagen" + indice;
                            pd.Dock = DockStyle.Bottom;
                            pd.Click += (se, ev) => btn_Eliminar(se, ev);
                            Panel px = new Panel();
                            px.Name = "panel" + indice;
                            px.BackgroundImage = new Bitmap(imagen);
                            px.Height = flowPanel.Height - 20;
                            px.Width = 400;
                            px.Click += (se, ev) => button1_Click(se, ev);
                            px.Controls.Add(pd);
                            px.BackgroundImageLayout = ImageLayout.Zoom;
                            flowPanel.Controls.Add(px);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al cargar algunas imagenes");
                            this.imagenes.RemoveAt(indice);
                        }
                        
                    }
                    else
                        MessageBox.Show("Verificar las imagenes, algunas no se encontraron");
                }
                indice++;
            }
        }

        private void btn_Eliminar(object? sender, EventArgs e)
        {
            try
            {
                if (sender is Button ee)
                {
                    if (MessageBox.Show("Seguro que quieres eliminar esta imagen?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int id = Convert.ToInt32(ee.Name.Replace("imagen",""));
                        imagenes.RemoveAt(id);
                        Control px = flowPanel.Controls.Find("panel" + id, true)[0];
                        flowPanel.Controls.Remove(px);
                        modificado = true;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al eliminar");
            }
            
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if(sender is Panel ex)
            {
                if(ex.BackgroundImage != null)
                {
                    FormImagenes fr = new FormImagenes((Bitmap)ex.BackgroundImage);
                    fr.ShowDialog();
                }
            }
        }

        private void FormImagenes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!modificado)
            {
                this.DialogResult = DialogResult.Abort;
            }
            else
            {
                if (MessageBox.Show("Desea guardar los cambios?", "Finalizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
