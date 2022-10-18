using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas
{
    internal partial class FormAlojamiento : Form
    {
        private bool modifier = true;
        private List<string> caracteristicas_list = new List<string>();
        private Alojamiento? alojamiento;
        private readonly ITrasladarInfo interfaz;
        List<string> filesImagenes = new List<string>();
        public FormAlojamiento(ITrasladarInfo padre)
        {
            InitializeComponent();
            interfaz = padre;
            btnCrear.Text = "Crear";
            cmbEstrellas.SelectedIndex = 0;
            caracteristicas_list.AddRange(new string[6] { "Cochera", "Pileta", "WI FI", "Servicio de limpieza", "Desayuno", "Posibilidad de mascotas" });

            cbEstado.Items.AddRange(ListaEstado().ToArray());
            cbEstado.SelectedIndex = 0;
        }

        private List<string> ListaEstado()
        {
            List<string> list = new List<string>();
            foreach (string item in Enum.GetNames(typeof(EEstado)))
            {
                list.Add(item);
            }
            return list;
        }

        public FormAlojamiento(ITrasladarInfo padre, string codigo):this(padre)
        {
            alojamiento = interfaz.ListarAlojamiento(ETipo.TODOS, EBuscar.ID, codigo)[0];
            filesImagenes.AddRange(alojamiento.Imagenes);
            CargarAlojamiento(alojamiento);
        }
        public FormAlojamiento(ITrasladarInfo padre, Alojamiento alojamiento) : this(padre)
        {
            this.alojamiento = alojamiento;
            filesImagenes.AddRange(alojamiento.Imagenes);
            CargarAlojamiento(alojamiento);
        }

        public bool Modifier
        {
            get { return modifier; }
            set { modifier = value; }
        }

        private void CargarAlojamiento(Alojamiento alojamiento)
        {
            if (alojamiento is Hotel hs)
            {
                gbCasa.Visible = false;
                rbCasa.Checked = false;
                rbHotel.Checked = true;
                gbHotel.Visible = true;
                cmbEstrellas.SelectedItem = hs.Estrella.ToString();
                txtNroHab.Text = hs.NHabitacion.ToString();
            }
            if (alojamiento is Casa cs)
            {
                gbCasa.Visible = true;
                rbHotel.Checked = false;
                rbCasa.Checked = true;
                gbHotel.Visible = false;
                txtMinDias.Text = cs.Mindias.ToString();
            }
            txtNombre.Text = alojamiento.Nombre;
            txtDireccion.Text = alojamiento.Direccion;
            txtCanPersona.Text = alojamiento.Huesped.ToString();
            txtPrecioXdia.Text = alojamiento.Costo.ToString();
            cbEstado.SelectedItem = alojamiento.Estado.ToString();
            btnCrear.Text = "Modificar";
            gbTipos.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int huesped = Convert.ToInt32(txtCanPersona.Text);
            double precio = Convert.ToDouble(txtPrecioXdia.Text);


            if(btnCrear.Text == "Crear")
            {
                if (rbCasa.Checked)
                {
                    int minDias = Convert.ToInt32(txtMinDias.Text);
                    alojamiento = new Casa(nombre, direccion, huesped, precio, minDias);
                }
                else
                {
                    int estrella = Convert.ToInt32(cmbEstrellas.SelectedItem);
                    int numeroHab = Convert.ToInt32(txtNroHab.Text);
                    alojamiento = new Hotel(nombre, direccion, huesped, precio, estrella, numeroHab);
                }
                alojamiento.Estado = (EEstado)cbEstado.SelectedIndex;
                alojamiento.AgregarCaracteristicas(ObtenerCaracteristicas());
                alojamiento.AgregarImagenes(filesImagenes.ToArray());
                interfaz.Alojamiento(alojamiento);
            }
            else
            {
                if (alojamiento != null)
                {
                    alojamiento.Nombre = nombre;
                    alojamiento.Direccion = direccion;
                    alojamiento.Huesped = huesped;
                    alojamiento.Costo = precio;
                    if (alojamiento is Casa cs)
                    {
                        int minDias = Convert.ToInt32(txtMinDias.Text);
                        cs.Mindias = minDias;
                    }
                    if(alojamiento is Hotel hs)
                    {
                        int estrella = Convert.ToInt32(cmbEstrellas.SelectedItem);
                        int numeroHab = Convert.ToInt32(txtNroHab.Text);
                        hs.Estrella = estrella;
                        hs.NHabitacion = numeroHab;
                    }
                    alojamiento.Estado = (EEstado)cbEstado.SelectedIndex;
                    alojamiento.AgregarImagenes(filesImagenes.ToArray());
                    interfaz.ModificarAlojamiento(alojamiento);
                }
            }
            this.Close();
        }

        private void rbCasa_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) {
                
                gbCasa.Visible = true;
                gbHotel.Visible = false;
            }
            else
            {
                gbCasa.Visible = false;
                gbHotel.Visible = true;
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if(openFileDialog.ShowDialog()== DialogResult.OK)
            {
                filesImagenes.AddRange(openFileDialog.FileNames);
            }
        }

        private void btnVerImagenes_Click(object sender, EventArgs e)
        {
            FormImagenes formImagenes = new FormImagenes();
            formImagenes.CargarImagenes(filesImagenes.ToArray());
            formImagenes.ShowDialog();
        }

        private void FormAlojamiento_Load(object sender, EventArgs e)
        {
            btnCrear.Enabled = Modifier;
            CargarCaracteristicas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCaracteristicas()
        {
            List<string> lsit = new List<string>();
            if (alojamiento != null)
            {
                lsit = alojamiento.Caracteristicas;
            }
            for (int i = 0; i < caracteristicas_list.Count; i++)
            {
                CheckBox cb = new CheckBox();
                    cb.Name = i.ToString();
                
                cb.Text = caracteristicas_list[i].ToString();
                cb.Checked = lsit.Exists(x => x == cb.Text);
                gbCaracteristicas.Controls.Add(cb);
            }
        }

        private string[] ObtenerCaracteristicas()
        {
            List<string> caract = new List<string>();
            foreach (CheckBox item in gbCaracteristicas.Controls)
            {
                if (item.Checked)
                {
                    caract.Add(item.Text);
                }
            }
            return caract.ToArray();
            

        }
    }
}
