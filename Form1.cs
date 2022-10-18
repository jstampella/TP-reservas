namespace TPreservas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Label tx = new Label();
            //tx.Text = "1";
            //calendarCustom1.AgregarElemento(tx, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormPrincipal mdp = new FormPrincipal();
            this.Hide();
            if(mdp.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}