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
using TPreservas.controles;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace TPreservas
{
    internal partial class FormAlojamiento : Form
    {
        private bool modifier = true;
        private string codigo="";
        private List<string> caracteristicas_list = new List<string>();
        private Alojamiento? alojamiento;
        private ITrasladarInfo? interfaz;
        List<string> filesImagenes = new List<string>();

        #region Constructores
        public FormAlojamiento()
        {
            InitializeComponent();
            btnCrear.Text = "Crear";
            cmbEstrellas.SelectedIndex = 0;
            caracteristicas_list.AddRange(new string[6] { "Cochera", "Pileta", "WI FI", "Servicio de limpieza", "Desayuno", "Posibilidad de mascotas" });

            cbEstado.Items.AddRange(ListaEstado().ToArray());
            cbEstado.SelectedIndex = 0;
        }
        public FormAlojamiento(string codigo) : this()
        {
            this.codigo = codigo;
        }
        public FormAlojamiento(Alojamiento alojamiento) : this()
        {
            this.alojamiento = alojamiento;
            filesImagenes.AddRange(alojamiento.Imagenes);
            CargarAlojamiento(alojamiento);
        }
        #endregion

        private List<string> ListaEstado()
        {
            List<string> list = new List<string>();
            foreach (string item in Enum.GetNames(typeof(EEstado)))
            {
                list.Add(item);
            }
            return list;
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
            checkHourMin1.TiempoCompleto = alojamiento.CheckIn;
            checkHourMin2.TiempoCompleto = alojamiento.CheckOut;
            btnCrear.Text = "Modificar";
            gbTipos.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (interfaz != null)
            {
                try
                {
                    string nombre = txtNombre.Text;
                    string direccion = txtDireccion.Text;
                    int huesped = Convert.ToInt32(txtCanPersona.Text);
                    double precio = Convert.ToDouble(txtPrecioXdia.Text);
                    string id_alojamiento;

                    if (btnCrear.Text == "Crear")
                    {
                        if (rbCasa.Checked)
                        {
                            int minDias = Convert.ToInt32(txtMinDias.Text);
                            id_alojamiento = interfaz.CrearAlojamiento(nombre, direccion, huesped, precio, minDias);
                        }
                        else
                        {
                            int estrella = Convert.ToInt32(cmbEstrellas.SelectedItem);
                            int numeroHab = Convert.ToInt32(txtNroHab.Text);
                            id_alojamiento = interfaz.CrearAlojamiento(nombre, direccion, huesped, precio, estrella, numeroHab);
                        }
                        interfaz.ModificarEstadoAlojamiento(id_alojamiento, (EEstado)cbEstado.SelectedIndex);
                        interfaz.AgregarCaracteristicas(id_alojamiento, ObtenerCaracteristicas());
                        interfaz.AgregarImagenes(id_alojamiento, filesImagenes.ToArray());
                    }
                    else
                    {
                        if (alojamiento != null)
                        {
                            if (alojamiento is Casa cs)
                            {
                                int minDias = Convert.ToInt32(txtMinDias.Text);
                                interfaz.ModificarAlojamiento(alojamiento.IDs, nombre, direccion, huesped, precio, minDias);
                            }
                            if (alojamiento is Hotel hs)
                            {
                                int estrella = Convert.ToInt32(cmbEstrellas.SelectedItem);
                                int numeroHab = Convert.ToInt32(txtNroHab.Text);
                                interfaz.ModificarAlojamiento(alojamiento.IDs, nombre, direccion, huesped, precio, estrella, numeroHab);
                            }
                            interfaz.ModificarEstadoAlojamiento(alojamiento.IDs, (EEstado)cbEstado.SelectedIndex);
                            interfaz.AgregarCaracteristicas(alojamiento.IDs, ObtenerCaracteristicas());
                            interfaz.AgregarImagenes(alojamiento.IDs, GuardarCopiaImagenes(alojamiento.IDs));
                            interfaz.ModificarAlojamiento(alojamiento.IDs, checkHourMin1.TiempoCompleto, checkHourMin2.TiempoCompleto);

                        }
                    }
                    this.Close();
                }
                catch (ArgumentException ee)
                {
                    MessageBox.Show("Error en la imagen cargada ("+ ee.Message+")");
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message);
                    else MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("error en el modulo");
        }

        private string[] GuardarCopiaImagenes(string id)
        {
            string[] filesnuevos = new string[filesImagenes.Count];
            int i = 0;
            char separador = Path.DirectorySeparatorChar;
            foreach (string item in filesImagenes)
            {
                if (item != null)
                {
                    string path = Application.StartupPath;
                    if (!item.Contains(path))
                    {
                        Bitmap myBitmap = new Bitmap(item);
                        string extension = item.Split(".")[1];
                        if (!Directory.Exists(path + "images"))
                        {
                            Directory.CreateDirectory(path + "images");
                        }
                        string nuevoDest = path + "images" + separador + id + "-" + i + "." + extension;
                        if (!File.Exists(nuevoDest))
                        {
                            File.Copy(item, nuevoDest);
                        }
                        filesnuevos[i] = nuevoDest;
                        i++;
                    }
                }
            }
            return filesnuevos;
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
            openFileDialog.Filter = "images files (*.jpg)|*.jpeg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                filesImagenes.AddRange(openFileDialog.FileNames);
            }
        }

        private void btnVerImagenes_Click(object sender, EventArgs e)
        {
            FormImagenes formImagenes = new FormImagenes();
            formImagenes.CargarImagenes(filesImagenes.ToArray());
            if(formImagenes.ShowDialog() == DialogResult.OK){
                filesImagenes = formImagenes.imagenes;
            }
        }

        private void FormAlojamiento_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                
            }
            else
            {
                MessageBox.Show("Error al cargar componente.");
            }
            btnCrear.Enabled = Modifier;
            CargarCaracteristicas();
            if (codigo != "" && interfaz!=null)
            {
                alojamiento = interfaz.ListarAlojamiento(ETipo.TODOS, EBuscar.ID, codigo)[0];
                filesImagenes.AddRange(alojamiento.Imagenes);
                CargarAlojamiento(alojamiento);
            }
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
                cb.AutoSize = true;
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
