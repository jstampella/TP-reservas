namespace TPreservas.Alojamientos
{
    partial class FrmDisponiAlojamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbAlojamientos = new System.Windows.Forms.ComboBox();
            this.dtCheckout = new System.Windows.Forms.DateTimePicker();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAlojamiento2 = new System.Windows.Forms.ComboBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.calendarCustom1 = new TPreservas.controles.CalendarCustom();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAlojamientos
            // 
            this.cbAlojamientos.FormattingEnabled = true;
            this.cbAlojamientos.Location = new System.Drawing.Point(646, 92);
            this.cbAlojamientos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAlojamientos.Name = "cbAlojamientos";
            this.cbAlojamientos.Size = new System.Drawing.Size(389, 28);
            this.cbAlojamientos.TabIndex = 3;
            // 
            // dtCheckout
            // 
            this.dtCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckout.Location = new System.Drawing.Point(151, 29);
            this.dtCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(129, 27);
            this.dtCheckout.TabIndex = 4;
            // 
            // dtCheckin
            // 
            this.dtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckin.Location = new System.Drawing.Point(11, 29);
            this.dtCheckin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(134, 27);
            this.dtCheckin.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(286, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 31);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtCheckin);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtCheckout);
            this.groupBox1.Location = new System.Drawing.Point(646, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(389, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alojamiento";
            // 
            // cbAlojamiento2
            // 
            this.cbAlojamiento2.FormattingEnabled = true;
            this.cbAlojamiento2.Location = new System.Drawing.Point(12, 163);
            this.cbAlojamiento2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAlojamiento2.Name = "cbAlojamiento2";
            this.cbAlojamiento2.Size = new System.Drawing.Size(250, 28);
            this.cbAlojamiento2.TabIndex = 7;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(11, 199);
            this.btnBuscar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(251, 31);
            this.btnBuscar2.TabIndex = 7;
            this.btnBuscar2.Text = "buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(11, 237);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 324);
            this.listBox1.TabIndex = 8;
            // 
            // calendarCustom1
            // 
            this.calendarCustom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calendarCustom1.Location = new System.Drawing.Point(637, 131);
            this.calendarCustom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarCustom1.MaximumSize = new System.Drawing.Size(398, 439);
            this.calendarCustom1.MinimumSize = new System.Drawing.Size(398, 439);
            this.calendarCustom1.Name = "calendarCustom1";
            this.calendarCustom1.Size = new System.Drawing.Size(398, 439);
            this.calendarCustom1.TabIndex = 9;
            // 
            // FrmDisponiAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 577);
            this.Controls.Add(this.calendarCustom1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbAlojamientos);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.cbAlojamiento2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDisponiAlojamiento";
            this.Text = "Disponibilidad Alojamientos";
            this.Load += new System.EventHandler(this.FrmDisponiAlojamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbAlojamientos;
        private DateTimePicker dtCheckout;
        private DateTimePicker dtCheckin;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private ComboBox cbAlojamiento2;
        private Button btnBuscar2;
        private ListBox listBox1;
        private controles.CalendarCustom calendarCustom1;
    }
}