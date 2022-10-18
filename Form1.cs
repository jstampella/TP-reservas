namespace TPreservas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label tx = new Label();
            tx.Text = "1";
            calendarCustom1.AgregarElemento(tx, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevo;
            CargarCliente carga = new CargarCliente();
            
            if(carga.ShowDialog() == DialogResult.OK)
            {
               try
                {
                    string nombre = carga.textBox1.Text;
                    string apellido = carga.textBox2.Text;
                    float dni = float.Parse(carga.textBox3.Text);
                    string mail = carga.textBox4.Text;
                    string codArea = carga.textBox5.Text;
                    string celular = carga.textBox6.Text;
                    nuevo = new Cliente(nombre, apellido, dni, mail, codArea, celular);
                }
                catch(FormatException ee)
                {
                    MessageBox.Show(ee.Message);
                }
                
                
            }
        }
    }
}