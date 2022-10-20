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
            this.dtCheckout = new System.Windows.Forms.DateTimePicker();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAlojamiento2 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.calendarCustom1 = new TPreservas.controles.CalendarCustom();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(268, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(386, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alojamiento";
            // 
            // cbAlojamiento2
            // 
            this.cbAlojamiento2.FormattingEnabled = true;
            this.cbAlojamiento2.Location = new System.Drawing.Point(6, 27);
            this.cbAlojamiento2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAlojamiento2.Name = "cbAlojamiento2";
            this.cbAlojamiento2.Size = new System.Drawing.Size(184, 28);
            this.cbAlojamiento2.TabIndex = 7;
            this.cbAlojamiento2.SelectedIndexChanged += new System.EventHandler(this.cbAlojamiento2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 117);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 324);
            this.listBox1.TabIndex = 8;
            // 
            // calendarCustom1
            // 
            this.calendarCustom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calendarCustom1.Location = new System.Drawing.Point(279, 117);
            this.calendarCustom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarCustom1.MaximumSize = new System.Drawing.Size(350, 329);
            this.calendarCustom1.MinimumSize = new System.Drawing.Size(350, 329);
            this.calendarCustom1.Name = "calendarCustom1";
            this.calendarCustom1.Size = new System.Drawing.Size(350, 329);
            this.calendarCustom1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRecargar);
            this.groupBox2.Controls.Add(this.cbAlojamiento2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 72);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alojamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fechas Reservadas";
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(196, 26);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(48, 29);
            this.btnRecargar.TabIndex = 12;
            this.btnRecargar.Text = "#";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // FrmDisponiAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.calendarCustom1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDisponiAlojamiento";
            this.Text = "Disponibilidad Alojamientos";
            this.Load += new System.EventHandler(this.FrmDisponiAlojamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dtCheckout;
        private DateTimePicker dtCheckin;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private ComboBox cbAlojamiento2;
        private ListBox listBox1;
        private controles.CalendarCustom calendarCustom1;
        private GroupBox groupBox2;
        private Label label1;
        private Button btnRecargar;
    }
}