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
            this.cbAlojamientos.Location = new System.Drawing.Point(20, 51);
            this.cbAlojamientos.Name = "cbAlojamientos";
            this.cbAlojamientos.Size = new System.Drawing.Size(537, 23);
            this.cbAlojamientos.TabIndex = 3;
            // 
            // dtCheckout
            // 
            this.dtCheckout.Location = new System.Drawing.Point(249, 22);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(200, 23);
            this.dtCheckout.TabIndex = 4;
            // 
            // dtCheckin
            // 
            this.dtCheckin.Location = new System.Drawing.Point(20, 22);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(200, 23);
            this.dtCheckin.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(482, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtCheckin);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cbAlojamientos);
            this.groupBox1.Controls.Add(this.dtCheckout);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbAlojamiento2
            // 
            this.cbAlojamiento2.FormattingEnabled = true;
            this.cbAlojamiento2.Location = new System.Drawing.Point(10, 104);
            this.cbAlojamiento2.Name = "cbAlojamiento2";
            this.cbAlojamiento2.Size = new System.Drawing.Size(220, 23);
            this.cbAlojamiento2.TabIndex = 7;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(10, 149);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(220, 23);
            this.btnBuscar2.TabIndex = 7;
            this.btnBuscar2.Text = "buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(10, 178);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 244);
            this.listBox1.TabIndex = 8;
            // 
            // calendarCustom1
            // 
            this.calendarCustom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calendarCustom1.Location = new System.Drawing.Point(236, 98);
            this.calendarCustom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarCustom1.MaximumSize = new System.Drawing.Size(348, 329);
            this.calendarCustom1.MinimumSize = new System.Drawing.Size(348, 329);
            this.calendarCustom1.Name = "calendarCustom1";
            this.calendarCustom1.Size = new System.Drawing.Size(348, 329);
            this.calendarCustom1.TabIndex = 9;
            // 
            // FrmDisponiAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 433);
            this.Controls.Add(this.calendarCustom1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.cbAlojamiento2);
            this.Controls.Add(this.groupBox1);
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