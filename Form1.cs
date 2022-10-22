using System.Runtime.CompilerServices;

namespace TPreservas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label tx = new Label();
            tx.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevo;
            CargarCliente carga = new CargarCliente();
            bool vent= true;
            do
            {
                if (carga.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string nombre = carga.textBox1.Text;
                        string apellido = carga.textBox2.Text;
                        float dni = float.Parse(carga.textBox3.Text);

                        string mail = carga.textBox4.Text;
                        string codArea = carga.textBox5.Text;
                        string celular = carga.textBox6.Text;
                        if (nombre == "" || apellido == "" || codArea == "" || celular == "")
                        {
                            throw new otraException("Debe Completar los Campos");

                        }

                        nuevo = new Cliente(nombre, apellido, dni, mail, codArea, celular);
                        vent = false;
                    }catch(FormatException ex)
                    {
                        carga.textBox2.BackColor = Color.IndianRed;
                        MessageBox.Show("debe ingresar n° DNI ");
                    }
                    catch (Exception ee)
                    {
                        carga.textBox1.BackColor = Color.IndianRed;
                        carga.textBox2.BackColor = Color.IndianRed;
                        carga.textBox3.BackColor = Color.IndianRed;
                        carga.textBox5.BackColor = Color.IndianRed;
                        carga.textBox6.BackColor = Color.IndianRed;
                        MessageBox.Show(ee.Message);
                        vent = true;
                    }


                }
                else
                {
                    vent= false;
                }


            } while (vent);
        }
    }
}