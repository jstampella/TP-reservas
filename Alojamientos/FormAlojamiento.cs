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
        private double precioHotel;
        FormDireccion direccion = new FormDireccion();
        private List<string> caracteristicas_list = new List<string>();
        private Alojamiento? alojamiento;
        private ITrasladarInfo? interfaz;
        List<string> filesImagenes = new List<string>();

        #region Constructores
        public FormAlojamiento()
        {
            InitializeComponent();
            btnCrear.Text = "Crear";
            //cmbEstrellas.SelectedIndex = 0;
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

        #region Cargar Alojamiento
        private void CargarAlojamiento(Alojamiento alojamiento)
        {
            if (alojamiento is Hotel hs)
            {
                gbCasa.Visible = false;
                rbCasa.Checked = false;
                rbHotel.Checked = true;
                gbHotel.Visible = true;
                ItemHotel itemH = (ItemHotel)flowHotel.Controls[0];
                itemH.Estrella = hs.Estrella;
                itemH.Habitacion = hs.NHabitacion;
                itemH.Huesped = hs.Huesped;
            }
            if (alojamiento is Casa cs)
            {
                gbCasa.Visible = true;
                rbHotel.Checked = false;
                rbCasa.Checked = true;
                gbHotel.Visible = false;
                txtMinDias.Text = cs.Mindias.ToString();
                txtCanPersona.Text = cs.Huesped.ToString();
            }
            txtNombre.Text = alojamiento.Nombre;
            direccion.Valor = alojamiento.Direccion;
            txtDireccion.Text = alojamiento.Direccion.ToString();
            txtPrecioXdia.Text = alojamiento.Costo.ToString();
            cbEstado.SelectedItem = alojamiento.Estado.ToString();
            checkHourMin1.TiempoCompleto = alojamiento.CheckIn;
            checkHourMin2.TiempoCompleto = alojamiento.CheckOut;
            btnCrear.Text = "Modificar";
            gbTipos.Enabled = false;
        }
        #endregion


        #region boton crear/modificar
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (interfaz != null)
            {
                try
                {
                    string nombre = txtNombre.Text;
                    double precio = Convert.ToDouble(txtPrecioXdia.Text);
                    string id_alojamiento;

                    if (btnCrear.Text == "Crear")
                    {
                        if (rbCasa.Checked)
                        {
                            int huesped = Convert.ToInt32(txtCanPersona.Text);
                            int minDias = Convert.ToInt32(txtMinDias.Text);
                            id_alojamiento = interfaz.CrearAlojamiento(nombre, direccion.Valor, huesped, precio, minDias);
                            interfaz.ModificarEstadoAlojamiento(id_alojamiento, (EEstado)cbEstado.SelectedIndex);
                            interfaz.AgregarCaracteristicas(id_alojamiento, ObtenerCaracteristicas());
                            interfaz.AgregarImagenes(id_alojamiento, filesImagenes.ToArray());
                        }
                        else
                        {
                            foreach (ItemHotel item in flowHotel.Controls)
                            {
                                int estrella = item.Estrella;
                                int numeroHab = item.Habitacion;
                                int huesped = item.Huesped;
                                id_alojamiento = interfaz.CrearAlojamiento(nombre, direccion.Valor, huesped, precio, estrella, numeroHab);
                                interfaz.ModificarEstadoAlojamiento(id_alojamiento, (EEstado)cbEstado.SelectedIndex);
                                interfaz.AgregarCaracteristicas(id_alojamiento, ObtenerCaracteristicas());
                                interfaz.AgregarImagenes(id_alojamiento, filesImagenes.ToArray());
                            }
                        }
                        
                    }
                    else
                    {
                        if (alojamiento != null)
                        {
                            if (alojamiento is Casa cs)
                            {
                                int huesped = Convert.ToInt32(txtCanPersona.Text);
                                int minDias = Convert.ToInt32(txtMinDias.Text);
                                interfaz.ModificarAlojamiento(alojamiento.IDs, nombre, direccion.Valor, huesped, precio, minDias);
                            }
                            if (alojamiento is Hotel hs)
                            {
                                ItemHotel item = (ItemHotel)flowHotel.Controls[0];
                                int estrella = item.Estrella;
                                int numeroHab = item.Habitacion;
                                int huesped = item.Huesped;
                                interfaz.ModificarAlojamiento(alojamiento.IDs, nombre, direccion.Valor, huesped, precio, estrella, numeroHab);
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

        #endregion


        #region Guardar Copia de imagenes [] en el directorio
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
                        if (!Directory.Exists(path + "Resource"))
                        {
                            Directory.CreateDirectory(path + "Resource");
                        }
                        string nuevoDest = path + "Resource" + separador + id + "-" + i + "." + extension;
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
        #endregion

        #region Checked Changed Casa
        private void rbCasa_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) {
                
                gbCasa.Visible = true;
                gbHotel.Visible = false;
                txtPrecioXdia.Enabled = true;
                txtPrecioXdia.Text = "";
            }
            else
            {
                gbCasa.Visible = false;
                gbHotel.Visible = true;
                txtPrecioXdia.Enabled = false;
                txtPrecioXdia.Text = precioHotel.ToString();
            }
        }
        #endregion


        #region click Cargar imagnes
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
        #endregion

        #region Ver imagenes
        private void btnVerImagenes_Click(object sender, EventArgs e)
        {
            FormImagenes formImagenes = new FormImagenes();
            formImagenes.CargarImagenes(filesImagenes.ToArray());
            if(formImagenes.ShowDialog() == DialogResult.OK){
                filesImagenes = formImagenes.imagenes;
            }
        }
        #endregion

        #region Load Form
        private void FormAlojamiento_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is ITrasladarInfo md)
            {
                interfaz = md;
                precioHotel = interfaz.PrecioHotel;
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
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Cargar Caracteristicas
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
        #endregion

        #region Obtener caracteristicas
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
        #endregion

        #region Agregar Habitacion
        private void btnAgregarHab_Click(object sender, EventArgs e)
        {
            Padding pad = new Padding(3, 6, 6, 3);
            int cant = flowHotel.Controls.Count;
            if (cant == 1)
            {
                Control cc = flowHotel.Controls[0];
                cc.Margin = pad;
            }
            ItemHotel item = new ItemHotel();
            item.Name = "itemHotel" + cant;
            item.Margin = pad;
            item.BorderStyle = BorderStyle.FixedSingle;
            item.Size = new Size(472, 51);
            flowHotel.Controls.Add(item);
        }
        #endregion


        #region Boton crear direccion
        private void btnDireccion_Click(object sender, EventArgs e)
        {
            if(direccion.ShowDialog() == DialogResult.OK)
            {
                txtDireccion.Text = direccion.Valor.ToString();
            }
        }
        #endregion
    }
}
