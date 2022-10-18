namespace TPreservas
{
    partial class FormAlojamiento
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCanPersona = new System.Windows.Forms.TextBox();
            this.txtPrecioXdia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbHotel = new System.Windows.Forms.GroupBox();
            this.cmbEstrellas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroHab = new System.Windows.Forms.TextBox();
            this.gbCasa = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinDias = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbTipos = new System.Windows.Forms.GroupBox();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbCaracteristicas = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerImagenes = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.gbHotel.SuspendLayout();
            this.gbCasa.SuspendLayout();
            this.gbTipos.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Location = new System.Drawing.Point(312, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "C. Persona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio x Dia (base):";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(269, 25);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtCanPersona
            // 
            this.txtCanPersona.Location = new System.Drawing.Point(82, 58);
            this.txtCanPersona.MaxLength = 3;
            this.txtCanPersona.Name = "txtCanPersona";
            this.txtCanPersona.Size = new System.Drawing.Size(92, 23);
            this.txtCanPersona.TabIndex = 2;
            // 
            // txtPrecioXdia
            // 
            this.txtPrecioXdia.Location = new System.Drawing.Point(301, 58);
            this.txtPrecioXdia.Name = "txtPrecioXdia";
            this.txtPrecioXdia.Size = new System.Drawing.Size(67, 23);
            this.txtPrecioXdia.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCanPersona);
            this.groupBox1.Controls.Add(this.txtPrecioXdia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // gbHotel
            // 
            this.gbHotel.Controls.Add(this.cmbEstrellas);
            this.gbHotel.Controls.Add(this.label5);
            this.gbHotel.Controls.Add(this.label7);
            this.gbHotel.Controls.Add(this.txtNroHab);
            this.gbHotel.Location = new System.Drawing.Point(3, 159);
            this.gbHotel.Name = "gbHotel";
            this.gbHotel.Size = new System.Drawing.Size(384, 59);
            this.gbHotel.TabIndex = 3;
            this.gbHotel.TabStop = false;
            this.gbHotel.Text = "Hotel";
            // 
            // cmbEstrellas
            // 
            this.cmbEstrellas.FormattingEnabled = true;
            this.cmbEstrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbEstrellas.Location = new System.Drawing.Point(74, 25);
            this.cmbEstrellas.Name = "cmbEstrellas";
            this.cmbEstrellas.Size = new System.Drawing.Size(55, 23);
            this.cmbEstrellas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Estrella";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nro: Habitacion";
            // 
            // txtNroHab
            // 
            this.txtNroHab.Location = new System.Drawing.Point(312, 25);
            this.txtNroHab.Name = "txtNroHab";
            this.txtNroHab.Size = new System.Drawing.Size(57, 23);
            this.txtNroHab.TabIndex = 6;
            // 
            // gbCasa
            // 
            this.gbCasa.Controls.Add(this.label8);
            this.gbCasa.Controls.Add(this.txtMinDias);
            this.gbCasa.Location = new System.Drawing.Point(3, 94);
            this.gbCasa.Name = "gbCasa";
            this.gbCasa.Size = new System.Drawing.Size(384, 59);
            this.gbCasa.TabIndex = 2;
            this.gbCasa.TabStop = false;
            this.gbCasa.Text = "Casa";
            this.gbCasa.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cantidad minima de Dias:";
            // 
            // txtMinDias
            // 
            this.txtMinDias.Location = new System.Drawing.Point(226, 24);
            this.txtMinDias.Name = "txtMinDias";
            this.txtMinDias.Size = new System.Drawing.Size(73, 23);
            this.txtMinDias.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(231, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbTipos
            // 
            this.gbTipos.Controls.Add(this.rbCasa);
            this.gbTipos.Controls.Add(this.rbHotel);
            this.gbTipos.Location = new System.Drawing.Point(12, 156);
            this.gbTipos.Name = "gbTipos";
            this.gbTipos.Size = new System.Drawing.Size(174, 49);
            this.gbTipos.TabIndex = 4;
            this.gbTipos.TabStop = false;
            this.gbTipos.Text = "TIPO";
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Location = new System.Drawing.Point(107, 18);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(55, 19);
            this.rbCasa.TabIndex = 1;
            this.rbCasa.Text = "CASA";
            this.rbCasa.UseVisualStyleBackColor = true;
            this.rbCasa.CheckedChanged += new System.EventHandler(this.rbCasa_CheckedChanged);
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Checked = true;
            this.rbHotel.Location = new System.Drawing.Point(10, 18);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(60, 19);
            this.rbHotel.TabIndex = 0;
            this.rbHotel.TabStop = true;
            this.rbHotel.Text = "HOTEL";
            this.rbHotel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.gbCasa);
            this.flowLayoutPanel1.Controls.Add(this.gbHotel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 216);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(390, 171);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.gbCaracteristicas);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 85);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Caracteristicas";
            // 
            // gbCaracteristicas
            // 
            this.gbCaracteristicas.AutoScroll = true;
            this.gbCaracteristicas.Location = new System.Drawing.Point(6, 22);
            this.gbCaracteristicas.Name = "gbCaracteristicas";
            this.gbCaracteristicas.Size = new System.Drawing.Size(372, 41);
            this.gbCaracteristicas.TabIndex = 0;
            this.gbCaracteristicas.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btnCrear);
            this.flowLayoutPanel2.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel2.Controls.Add(this.cbEstado);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(9, 393);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(390, 31);
            this.flowLayoutPanel2.TabIndex = 7;
            this.flowLayoutPanel2.TabStop = true;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(104, 3);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 23);
            this.cbEstado.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerImagenes);
            this.groupBox3.Controls.Add(this.btnCargarImagen);
            this.groupBox3.Location = new System.Drawing.Point(293, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 49);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // btnVerImagenes
            // 
            this.btnVerImagenes.Location = new System.Drawing.Point(6, 18);
            this.btnVerImagenes.Name = "btnVerImagenes";
            this.btnVerImagenes.Size = new System.Drawing.Size(48, 23);
            this.btnVerImagenes.TabIndex = 1;
            this.btnVerImagenes.Text = "ver";
            this.btnVerImagenes.UseVisualStyleBackColor = true;
            this.btnVerImagenes.Click += new System.EventHandler(this.btnVerImagenes_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(60, 18);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(40, 23);
            this.btnCargarImagen.TabIndex = 0;
            this.btnCargarImagen.Text = "+";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // FormAlojamiento
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(411, 426);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gbTipos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAlojamiento";
            this.Text = "Alojamiento";
            this.Load += new System.EventHandler(this.FormAlojamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbHotel.ResumeLayout(false);
            this.gbHotel.PerformLayout();
            this.gbCasa.ResumeLayout(false);
            this.gbCasa.PerformLayout();
            this.gbTipos.ResumeLayout(false);
            this.gbTipos.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCrear;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDireccion;
        private TextBox txtCanPersona;
        private TextBox txtPrecioXdia;
        private GroupBox groupBox1;
        private GroupBox gbHotel;
        private Label label5;
        private Label label7;
        private TextBox txtNroHab;
        private ComboBox cmbEstrellas;
        private GroupBox gbCasa;
        private Label label8;
        private TextBox txtMinDias;
        private Button btnCancelar;
        private GroupBox gbTipos;
        private RadioButton rbCasa;
        private RadioButton rbHotel;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox3;
        private Button btnVerImagenes;
        private Button btnCargarImagen;
        private FlowLayoutPanel gbCaracteristicas;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel2;
        private ComboBox cbEstado;
        private DateTimePicker dateTimePicker1;
    }
}