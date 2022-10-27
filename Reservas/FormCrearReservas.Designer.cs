namespace TPreservas.Reservas
{
    partial class FormCrearReservas
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
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.numericDay = new System.Windows.Forms.NumericUpDown();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.numericHuesped = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCrearU = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calendarCustom1 = new TPreservas.controles.CalendarCustom();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.panelContenedorItem = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAlojamiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHuesped)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "dd/MM/yyyy";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(14, 17);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFecha.MinDate = new System.DateTime(2022, 10, 20, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(137, 27);
            this.dtFecha.TabIndex = 0;
            // 
            // numericDay
            // 
            this.numericDay.Location = new System.Drawing.Point(204, 18);
            this.numericDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDay.Name = "numericDay";
            this.numericDay.Size = new System.Drawing.Size(53, 27);
            this.numericDay.TabIndex = 1;
            this.numericDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(6, 27);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(261, 28);
            this.cbUsuario.TabIndex = 2;
            this.cbUsuario.SelectedIndexChanged += new System.EventHandler(this.cbUsuario_SelectedIndexChanged);
            // 
            // numericHuesped
            // 
            this.numericHuesped.Location = new System.Drawing.Point(359, 18);
            this.numericHuesped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericHuesped.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHuesped.Name = "numericHuesped";
            this.numericHuesped.Size = new System.Drawing.Size(56, 27);
            this.numericHuesped.TabIndex = 3;
            this.numericHuesped.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Location = new System.Drawing.Point(743, 468);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(354, 31);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Reservar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(952, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 29);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Huesped:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnCrearU);
            this.groupBox2.Controls.Add(this.cbUsuario);
            this.groupBox2.Location = new System.Drawing.Point(14, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // btnCrearU
            // 
            this.btnCrearU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearU.Location = new System.Drawing.Point(277, 26);
            this.btnCrearU.Name = "btnCrearU";
            this.btnCrearU.Size = new System.Drawing.Size(94, 29);
            this.btnCrearU.TabIndex = 3;
            this.btnCrearU.Text = "Crear";
            this.btnCrearU.UseVisualStyleBackColor = true;
            this.btnCrearU.Click += new System.EventHandler(this.btnCrearU_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.calendarCustom1);
            this.groupBox3.Location = new System.Drawing.Point(14, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 358);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Verificar Alojamiento";
            // 
            // calendarCustom1
            // 
            this.calendarCustom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calendarCustom1.Location = new System.Drawing.Point(22, 25);
            this.calendarCustom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarCustom1.MaximumSize = new System.Drawing.Size(350, 329);
            this.calendarCustom1.MinimumSize = new System.Drawing.Size(350, 329);
            this.calendarCustom1.Name = "calendarCustom1";
            this.calendarCustom1.Size = new System.Drawing.Size(350, 329);
            this.calendarCustom1.TabIndex = 13;
            // 
            // btnPrecio
            // 
            this.btnPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrecio.Location = new System.Drawing.Point(397, 468);
            this.btnPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(318, 31);
            this.btnPrecio.TabIndex = 13;
            this.btnPrecio.Text = "Comprobante";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // panelContenedorItem
            // 
            this.panelContenedorItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorItem.AutoScroll = true;
            this.panelContenedorItem.Location = new System.Drawing.Point(397, 84);
            this.panelContenedorItem.Name = "panelContenedorItem";
            this.panelContenedorItem.Size = new System.Drawing.Size(700, 338);
            this.panelContenedorItem.TabIndex = 14;
            // 
            // lblAlojamiento
            // 
            this.lblAlojamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlojamiento.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAlojamiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlojamiento.ForeColor = System.Drawing.Color.Red;
            this.lblAlojamiento.Location = new System.Drawing.Point(397, 428);
            this.lblAlojamiento.Name = "lblAlojamiento";
            this.lblAlojamiento.Size = new System.Drawing.Size(700, 36);
            this.lblAlojamiento.TabIndex = 15;
            this.lblAlojamiento.Text = "-";
            this.lblAlojamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCrearReservas
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 505);
            this.Controls.Add(this.lblAlojamiento);
            this.Controls.Add(this.panelContenedorItem);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.numericHuesped);
            this.Controls.Add(this.numericDay);
            this.Controls.Add(this.dtFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCrearReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Reserva";
            this.Load += new System.EventHandler(this.FormCrearReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHuesped)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtFecha;
        private NumericUpDown numericDay;
        private ComboBox cbUsuario;
        private NumericUpDown numericHuesped;
        private Button btnCrear;
        private Button btnBuscar;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnCrearU;
        private GroupBox groupBox3;
        private controles.CalendarCustom calendarCustom1;
        private Button btnPrecio;
        private FlowLayoutPanel panelContenedorItem;
        private Label lblAlojamiento;
    }
}