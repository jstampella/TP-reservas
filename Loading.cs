using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas
{
    public partial class Loading : Form
    {
        public Action Worker { get; set; }
        public Loading(Form padre, Action worker)
        {
            InitializeComponent();
            CentrarForm(padre);
            this.TransparencyKey = Color.DarkGray;
            this.BackColor = Color.Gray;
            if (worker == null) throw new ArgumentNullException();
            Worker = worker;
        }

        private void CentrarForm(Form padre)
        {
            this.Width = padre.Width - 10;
            this.Height = padre.Height - 10;
            Point p = padre.Parent.PointToScreen(padre.Location);
            p.Offset((padre.Width - this.Width) / 2, (padre.Height - this.Height) / 2);
            this.StartPosition = FormStartPosition.Manual;
            this.DesktopLocation = p;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            pxLoading.Location = new Point(this.Width/2-pxLoading.Width/2,this.Height/2-pxLoading.Height/2);

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
