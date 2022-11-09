using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TPreservas
{
    public partial class Loading : Form
    {
        Timer t1 = new Timer();
        int pause = 0;
        public Action Worker { get; set; }
        public Loading(Form padre, Action worker)
        {
            InitializeComponent();
            CentrarForm(padre);
            this.TransparencyKey = Color.DarkGray;
            this.BackColor = Color.Gray;
            if (worker == null) throw new ArgumentNullException();
            Worker = worker;
            t1.Interval = 10;  //we'll increase the opacity every 10ms
        }

        public Loading(Form padre, Action worker,string texto): this(padre, worker)
        {
            pxLoading.Visible = false;
            Label lb = new Label();
            lb.Text = texto.ToUpper();
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            Font font = new Font("Times New Roman", 12.0f, FontStyle.Bold);
            lb.Font = font;
            lb.ForeColor = Color.White;
            this.Controls.Add(lb);
            lb.Dock = DockStyle.Fill;
            t1.Interval = 2;  //we'll increase the opacity every 10ms
            pause = 300;
            CentrarForm(padre,50);
        }

        private void CentrarForm(Form padre,int alto=0)
        {
            this.Width = padre.Width - 10;
            if (alto == 0)
                this.Height = padre.Height - 10;
            else this.Height = alto;
            Point p = padre.Parent.PointToScreen(padre.Location);
            p.Offset((padre.Width - this.Width) / 2, (padre.Height - this.Height) / 2);
            this.StartPosition = FormStartPosition.Manual;
            this.DesktopLocation = p;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            pxLoading.Location = new Point(this.Width/2-pxLoading.Width/2,this.Height/2-pxLoading.Height/2);
            Opacity = 0;      //first the opacity is 0
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        private void Loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    //cancel the event so the form won't be closed

            t1.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            t1.Start();

            if (Opacity == 0)  //if the form is completly transparent
                e.Cancel = false;   //resume the event - the program can be closed
        }

        void fadeIn(object? sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();   //this stops the timer if the form is completely displayed
                Task.Factory.StartNew(Worker).ContinueWith(t => { extendes(); }, TaskScheduler.FromCurrentSynchronizationContext());

            }
            else
                Opacity += 0.05;
        }

        void extendes()
        {
            t1.Tick += new EventHandler(paused);  //this calls the fade out function
            t1.Start();
        }

        void fadeOut(object? sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }

        void paused(object? sender, EventArgs e)
        {
            if (pause <= 100)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                this.Close();
            }
            else
                pause--;
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
