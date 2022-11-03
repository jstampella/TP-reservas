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
            this.checkHourMin2 = new TPreservas.controles.checkHourMin();
            this.checkHourMin1 = new TPreservas.controles.checkHourMin();
            this.gbHotel = new System.Windows.Forms.GroupBox();
            this.btnAgregarHab = new System.Windows.Forms.Button();
            this.flowHotel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemHotel1 = new TPreservas.controles.ItemHotel();
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
            this.groupBox1.SuspendLayout();
            this.gbHotel.SuspendLayout();
            this.flowHotel.SuspendLayout();
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
            this.btnCrear.Location = new System.Drawing.Point(439, 4);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(86, 31);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "C. Persona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio (base):";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(87, 57);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(253, 27);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtCanPersona
            // 
            this.txtCanPersona.Location = new System.Drawing.Point(102, 33);
            this.txtCanPersona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCanPersona.MaxLength = 3;
            this.txtCanPersona.Name = "txtCanPersona";
            this.txtCanPersona.Size = new System.Drawing.Size(66, 27);
            this.txtCanPersona.TabIndex = 2;
            // 
            // txtPrecioXdia
            // 
            this.txtPrecioXdia.Location = new System.Drawing.Point(253, 92);
            this.txtPrecioXdia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioXdia.Name = "txtPrecioXdia";
            this.txtPrecioXdia.PlaceholderText = "$100";
            this.txtPrecioXdia.Size = new System.Drawing.Size(86, 27);
            this.txtPrecioXdia.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrecioXdia);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Location = new System.Drawing.Point(192, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(346, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // checkHourMin2
            // 
            this.checkHourMin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkHourMin2.Hora = "10";
            this.checkHourMin2.Location = new System.Drawing.Point(289, 142);
            this.checkHourMin2.Minuto = "00";
            this.checkHourMin2.Name = "checkHourMin2";
            this.checkHourMin2.Size = new System.Drawing.Size(121, 100);
            this.checkHourMin2.TabIndex = 7;
            this.checkHourMin2.TiempoCompleto = System.TimeSpan.Parse("10:00:00");
            this.checkHourMin2.Titulo = "CheckOut";
            // 
            // checkHourMin1
            // 
            this.checkHourMin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkHourMin1.Hora = "12";
            this.checkHourMin1.Location = new System.Drawing.Point(134, 142);
            this.checkHourMin1.Minuto = "00";
            this.checkHourMin1.Name = "checkHourMin1";
            this.checkHourMin1.Size = new System.Drawing.Size(121, 100);
            this.checkHourMin1.TabIndex = 6;
            this.checkHourMin1.TiempoCompleto = System.TimeSpan.Parse("12:00:00");
            this.checkHourMin1.Titulo = "CheckIn";
            // 
            // gbHotel
            // 
            this.gbHotel.Controls.Add(this.btnAgregarHab);
            this.gbHotel.Controls.Add(this.flowHotel);
            this.gbHotel.Location = new System.Drawing.Point(3, 211);
            this.gbHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 12);
            this.gbHotel.MaximumSize = new System.Drawing.Size(516, 177);
            this.gbHotel.Name = "gbHotel";
            this.gbHotel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbHotel.Size = new System.Drawing.Size(516, 177);
            this.gbHotel.TabIndex = 3;
            this.gbHotel.TabStop = false;
            this.gbHotel.Text = "Hotel";
            this.gbHotel.Visible = false;
            // 
            // btnAgregarHab
            // 
            this.btnAgregarHab.Location = new System.Drawing.Point(7, 27);
            this.btnAgregarHab.Name = "btnAgregarHab";
            this.btnAgregarHab.Size = new System.Drawing.Size(503, 29);
            this.btnAgregarHab.TabIndex = 8;
            this.btnAgregarHab.Text = "Agregar Item";
            this.btnAgregarHab.UseVisualStyleBackColor = true;
            this.btnAgregarHab.Click += new System.EventHandler(this.btnAgregarHab_Click);
            // 
            // flowHotel
            // 
            this.flowHotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowHotel.AutoScroll = true;
            this.flowHotel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowHotel.Controls.Add(this.itemHotel1);
            this.flowHotel.Location = new System.Drawing.Point(7, 63);
            this.flowHotel.MaximumSize = new System.Drawing.Size(502, 106);
            this.flowHotel.Name = "flowHotel";
            this.flowHotel.Size = new System.Drawing.Size(502, 106);
            this.flowHotel.TabIndex = 0;
            // 
            // itemHotel1
            // 
            this.itemHotel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemHotel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemHotel1.Estrella = 0;
            this.itemHotel1.Huesped = 1;
            this.itemHotel1.IsDeleted = false;
            this.itemHotel1.Location = new System.Drawing.Point(16, 26);
            this.itemHotel1.Margin = new System.Windows.Forms.Padding(16, 26, 6, 6);
            this.itemHotel1.Name = "itemHotel1";
            this.itemHotel1.Size = new System.Drawing.Size(472, 51);
            this.itemHotel1.TabIndex = 0;
            // 
            // gbCasa
            // 
            this.gbCasa.Controls.Add(this.label8);
            this.gbCasa.Controls.Add(this.txtCanPersona);
            this.gbCasa.Controls.Add(this.txtMinDias);
            this.gbCasa.Controls.Add(this.label3);
            this.gbCasa.Location = new System.Drawing.Point(3, 124);
            this.gbCasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCasa.Name = "gbCasa";
            this.gbCasa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCasa.Size = new System.Drawing.Size(516, 79);
            this.gbCasa.TabIndex = 2;
            this.gbCasa.TabStop = false;
            this.gbCasa.Text = "Casa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cantidad min. de Dias:";
            // 
            // txtMinDias
            // 
            this.txtMinDias.Location = new System.Drawing.Point(338, 33);
            this.txtMinDias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinDias.Name = "txtMinDias";
            this.txtMinDias.Size = new System.Drawing.Size(83, 27);
            this.txtMinDias.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(347, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbTipos
            // 
            this.gbTipos.Controls.Add(this.rbCasa);
            this.gbTipos.Controls.Add(this.rbHotel);
            this.gbTipos.Location = new System.Drawing.Point(10, 5);
            this.gbTipos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTipos.Name = "gbTipos";
            this.gbTipos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTipos.Size = new System.Drawing.Size(173, 65);
            this.gbTipos.TabIndex = 4;
            this.gbTipos.TabStop = false;
            this.gbTipos.Text = "Tipo";
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Checked = true;
            this.rbCasa.Location = new System.Drawing.Point(13, 26);
            this.rbCasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(67, 24);
            this.rbCasa.TabIndex = 1;
            this.rbCasa.TabStop = true;
            this.rbCasa.Text = "CASA";
            this.rbCasa.UseVisualStyleBackColor = true;
            this.rbCasa.CheckedChanged += new System.EventHandler(this.rbCasa_CheckedChanged);
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Location = new System.Drawing.Point(87, 26);
            this.rbHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(74, 24);
            this.rbHotel.TabIndex = 0;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 267);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 314);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gbCaracteristicas);
            this.groupBox4.Location = new System.Drawing.Point(3, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(516, 112);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Caracteristicas";
            // 
            // gbCaracteristicas
            // 
            this.gbCaracteristicas.AutoScroll = true;
            this.gbCaracteristicas.Location = new System.Drawing.Point(7, 29);
            this.gbCaracteristicas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCaracteristicas.Name = "gbCaracteristicas";
            this.gbCaracteristicas.Size = new System.Drawing.Size(502, 55);
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
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 589);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(528, 41);
            this.flowLayoutPanel2.TabIndex = 7;
            this.flowLayoutPanel2.TabStop = true;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(87, 4);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(254, 28);
            this.cbEstado.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerImagenes);
            this.groupBox3.Controls.Add(this.btnCargarImagen);
            this.groupBox3.Location = new System.Drawing.Point(10, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(173, 61);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagenes";
            // 
            // btnVerImagenes
            // 
            this.btnVerImagenes.Location = new System.Drawing.Point(7, 24);
            this.btnVerImagenes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerImagenes.Name = "btnVerImagenes";
            this.btnVerImagenes.Size = new System.Drawing.Size(78, 31);
            this.btnVerImagenes.TabIndex = 1;
            this.btnVerImagenes.Text = "ver";
            this.btnVerImagenes.UseVisualStyleBackColor = true;
            this.btnVerImagenes.Click += new System.EventHandler(this.btnVerImagenes_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(87, 24);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(78, 31);
            this.btnCargarImagen.TabIndex = 0;
            this.btnCargarImagen.Text = "+";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // FormAlojamiento
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(550, 633);
            this.Controls.Add(this.checkHourMin2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.checkHourMin1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gbTipos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAlojamiento";
            this.Text = "Alojamiento";
            this.Load += new System.EventHandler(this.FormAlojamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbHotel.ResumeLayout(false);
            this.flowHotel.ResumeLayout(false);
            this.gbCasa.ResumeLayout(false);
            this.gbCasa.PerformLayout();
            this.gbTipos.ResumeLayout(false);
            this.gbTipos.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private controles.checkHourMin checkHourMin1;
        private controles.checkHourMin checkHourMin2;
        private FlowLayoutPanel flowHotel;
        private Button btnAgregarHab;
        private controles.ItemHotel itemHotel1;
    }
}