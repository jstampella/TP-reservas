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
    }
}