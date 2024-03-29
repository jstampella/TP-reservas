﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPreservas
{
    public partial class FormPrincipal : Form,ITrasladarInfo
    {
        private Empresa empresa = new Empresa();
        string file = Application.StartupPath + "/data.dat";

        public FormPrincipal()
        {
            InitializeComponent();

        }

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Ventana " + childFormNumber++;
        //    childForm.Show();
        //}

        //private void OpenFile(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = openFileDialog.FileName;
        //    }
        //}

        //private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        //    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = saveFileDialog.FileName;
        //    }
        //}

        #region metodos propios del mdi

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        #endregion

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarStage();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FormCliente childForm = new FormCliente();
            childForm.MdiParent = this;
            childForm.Text = "Crear Usuario";
            childForm.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAlojamiento formAl = new FormAlojamiento();
            formAl.MdiParent = this;
            formAl.Show();
        }

        List<Alojamiento> ITrasladarInfo.ListarAlojamiento(ETipo tipo, EBuscar buscar,string valor)
        {
            return empresa.ListarAlojamientos(tipo,buscar, valor);
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListaAlojamiento frmLista = new FormListaAlojamiento();
            frmLista.MdiParent = this;
            frmLista.Show();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas.FormCrearReservas frmLista = new Reservas.FormCrearReservas();
            frmLista.MdiParent = this;
            frmLista.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reservas.FrmListarReservas frmLista = new Reservas.FrmListarReservas();
            frmLista.MdiParent = this;
            frmLista.Show();
        }

        List<Reserva> ITrasladarInfo.ListarReservas()
        {
            return empresa.ListarReservas();
        }

        void ITrasladarInfo.CrearReserva(Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, int huesped)
        {
            empresa.CrearReserva(alojamiento, cliente, checkin, checkout, huesped);
        }

        List<Alojamiento> ITrasladarInfo.AlojamientosDisponibles(DateTime checkIn, DateTime checkOut,ETipo tipo)
        {
            return empresa.AlojamientosDisponibles(checkIn, checkOut,tipo);
        }

        List<Alojamiento> ITrasladarInfo.AlojamientosDisponibles(DateTime checkIn, DateTime checkOut, ETipo tipo, int huesped)
        {
            return empresa.AlojamientosDisponibles(checkIn, checkOut,tipo, huesped);
        }

        List<Alojamiento> ITrasladarInfo.AlojamientosDisponibles(DateTime checkIn, DateTime checkOut, ETipo tipo, int huesped, EBuscar buscar, string valor)
        {
            return empresa.AlojamientosDisponibles(checkIn, checkOut,tipo, huesped, buscar,valor);
        }

        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alojamientos.FrmDisponiAlojamiento frmDisp = new Alojamientos.FrmDisponiAlojamiento();
            frmDisp.MdiParent = this;
            frmDisp.Show();
        }

        List<DateTime> ITrasladarInfo.FechaOcupadas(Alojamiento alojamiento)
        {
            return empresa.FechaOcupadas(alojamiento);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarStage();
        }

        private void CargarStage()
        {
            if (File.Exists(file))
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream fs = new FileStream(file, FileMode.Open);
                try
                {
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                    empresa = (Empresa)format.Deserialize(fs);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                }
                catch (SerializationException e)
                {
                    MessageBox.Show("Fallo al cargar los datos de la aplicacion: " + e.Message);
                    fs.Close();
                    File.Delete(file);
                }
                finally
                {
                    fs.Close();
                }
            }
        }
        private void GuardarStage()
        {
            
            FileStream fs = new FileStream(file, FileMode.Create);
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                binaryFormatter.Serialize(fs, empresa);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Fallo al guardar la aplicacion: " + e.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea finalizar la aplicación?",
                                "-Confirmación-",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                GuardarStage();
            }
            else
                e.Cancel = true;
        }


        #region SECTOR CLIENTE
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarClientes fmcliente = new FrmListarClientes();
            fmcliente.MdiParent = this;
            fmcliente.Show();
        }

        bool ITrasladarInfo.CrearCliente(string nombre, string apellido, float dni, string mail, string codArea, string celular)
        {
            return empresa.CrearCliente(nombre, apellido, dni, mail, codArea, celular);
        }

        IEnumerable<Cliente> ITrasladarInfo.ListarClientes()
        {
            return empresa.ListarClientes();
        }

        public bool ModificarCliente(string nombre, string apellido, float dni, string mail, string codArea, string celular)
        {
            return empresa.ModificarCliente(nombre, apellido,dni, mail, codArea, celular);
        }

        #endregion


        public void ModificarReserva(int alojamiento,int reserva, DateTime Checkin, DateTime CheckOut, EEstadoReserva estado, int huesped)
        {
            empresa.ModificarReserva(alojamiento,reserva, Checkin, CheckOut,estado, huesped);
        }

        public string CrearAlojamiento(string nombre, Direccion direccion, int huesped, double costo, int minD)
        {
            return empresa.CrearAlojamiento(nombre, direccion, huesped, costo, minD);
        }

        public string CrearAlojamiento(string nombre, Direccion direccion, int huesped, double costo, int estrellas, int nHab)
        {
            return empresa.CrearAlojamiento(nombre, direccion, huesped, costo, estrellas, nHab);
        }

        public bool ModificarAlojamiento(string ID, string nombre, Direccion direccion, int huesped, double costo, int estrellas, int nHab)
        {
            return empresa.ModificarAlojamiento(ID, nombre, direccion, huesped, costo, estrellas,nHab);
        }

        public bool ModificarAlojamiento(string ID, string nombre, Direccion direccion, int huesped, double costo, int minD)
        {
            return empresa.ModificarAlojamiento(ID, nombre, direccion, huesped, costo, minD);
        }

        public bool ModificarEstadoAlojamiento(string ID, EEstado estado)
        {
            return empresa.ModificarEstadoAlojamiento(ID, estado);
        }

        public bool AgregarCaracteristicas(string ID, string[] caracteristicas)
        {
            return empresa.AgregarCaracteristicas(ID, caracteristicas);
        }

        public bool AgregarImagenes(string ID, string[] imagenes)
        {
            return empresa.AgregarImagenes(ID, imagenes);
        }

        public void ModificarAlojamiento(string ID, TimeSpan checkin, TimeSpan checkout)
        {
            empresa.ModificarAlojamiento(ID, checkin, checkout);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "dato | *.dat";
            if(saveFile.ShowDialog()== DialogResult.OK)
            {
                FileStream fl = new FileStream(saveFile.FileName,FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                formatter.Serialize(fl, empresa);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                fl.Close();
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                SaveFileDialog fileSave = new SaveFileDialog();
                fileSave.Filter = "Archivo csv | *.csv";
                fileSave.FileName = "Clientes";
                if (fileSave.ShowDialog() == DialogResult.OK)
                {
                    empresa.Exportar<Cliente>(fileSave.FileName);
                //    FileStream fileStream = new FileStream(fileSave.FileName, FileMode.OpenOrCreate,FileAccess.ReadWrite);
                //    StreamWriter streamWriter = new StreamWriter(fileStream);
                //    IEnumerable<Cliente> clientes = empresa.ListarClientes();
                //    streamWriter.WriteLine("Nombre;Apellido;Email;CodArea;Telefono");
                //    foreach (Cliente cliente in clientes)
                //    {
                //        string line = cliente.Nombre + ";" + cliente.Apellido + ";" + cliente.Mail+";"+cliente.CodigoA+";"+cliente.Celular;
                //        streamWriter.WriteLine(line);
                //    }
                //    streamWriter.Close();
                //    fileStream.Close();
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
        }


        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "archivo csv |*.csv";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string errores =empresa.ImportarAlojamiento(ETipo.CASA, openFileDialog.FileName);
                if (errores != "")
                {
                    MessageBox.Show("Errores en la lineas:" + errores);
                }
            }
        }

        private void precioBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alojamientos.FormPrecio frmPrecio = new Alojamientos.FormPrecio();
            frmPrecio.MdiParent = this;
            frmPrecio.Show();
        }

        public void ActualizarPrecioHoteles(double precio)
        {
            empresa.ActualizarPrecioHoteles(precio);
        }

        public void ActualizarPrecioCasas(double porcentaje)
        {
            empresa.ActualizarPrecioCasas(porcentaje);
        }

        public Double PrecioHotel
        {
            get { return empresa.PrecioHotel; }
        }

        private void penalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExtra frmPrecio = new FormExtra();
            frmPrecio.MdiParent = this;
            frmPrecio.Show();
        }

        public void CargarPenalidad(int dias, double porcentaje)
        {
            empresa.CargarPenalidad(dias, porcentaje);
        }

        public int DiasPenalidad { get { return empresa.DiasPenalidad; } }
        public double PorcentajePenalidad { get { return empresa.PorcentajePenalidad; } }

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        public PageSetupDialog PagesSetup()
        {
            return pageSetupDialog1;
        }

        public void exportarCalendario(string id, string namefile)
        {
            empresa.exportarCal(id, namefile);
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileSave = new SaveFileDialog();
                fileSave.Filter = "Archivo csv | *.csv";
                fileSave.FileName = "alojamiento";
                if (fileSave.ShowDialog() == DialogResult.OK)
                {
                    empresa.Exportar<Alojamiento>(fileSave.FileName);
                    //    FileStream fileStream = new FileStream(fileSave.FileName, FileMode.OpenOrCreate,FileAccess.ReadWrite);
                    //    StreamWriter streamWriter = new StreamWriter(fileStream);
                    //    IEnumerable<Cliente> clientes = empresa.ListarClientes();
                    //    streamWriter.WriteLine("Nombre;Apellido;Email;CodArea;Telefono");
                    //    foreach (Cliente cliente in clientes)
                    //    {
                    //        string line = cliente.Nombre + ";" + cliente.Apellido + ";" + cliente.Mail+";"+cliente.CodigoA+";"+cliente.Celular;
                    //        streamWriter.WriteLine(line);
                    //    }
                    //    streamWriter.Close();
                    //    fileStream.Close();
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileSave = new SaveFileDialog();
                fileSave.Filter = "Archivo csv | *.csv";
                fileSave.FileName = "Reservas";
                if (fileSave.ShowDialog() == DialogResult.OK)
                {
                    empresa.Exportar<Reserva>(fileSave.FileName);
                    //    FileStream fileStream = new FileStream(fileSave.FileName, FileMode.OpenOrCreate,FileAccess.ReadWrite);
                    //    StreamWriter streamWriter = new StreamWriter(fileStream);
                    //    IEnumerable<Cliente> clientes = empresa.ListarClientes();
                    //    streamWriter.WriteLine("Nombre;Apellido;Email;CodArea;Telefono");
                    //    foreach (Cliente cliente in clientes)
                    //    {
                    //        string line = cliente.Nombre + ";" + cliente.Apellido + ";" + cliente.Mail+";"+cliente.CodigoA+";"+cliente.Celular;
                    //        streamWriter.WriteLine(line);
                    //    }
                    //    streamWriter.Close();
                    //    fileStream.Close();
                }



            }
            catch (Exception es)
            {
                MessageBox.Show("Error al guardar"+es.Message);
            }
        }
    }
}
