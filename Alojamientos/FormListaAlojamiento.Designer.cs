namespace TPreservas
{
    partial class FormListaAlojamiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huesped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            this.dgLista.AllowUserToOrderColumns = true;
            this.dgLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLista.ColumnHeadersHeight = 40;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.direccion,
            this.huesped,
            this.precio,
            this.estado,
            this.tipo,
            this.editar,
            this.ver});
            this.dgLista.Location = new System.Drawing.Point(12, 77);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgLista.RowHeadersVisible = false;
            this.dgLista.RowHeadersWidth = 25;
            this.dgLista.RowTemplate.Height = 25;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLista.Size = new System.Drawing.Size(776, 361);
            this.dgLista.TabIndex = 0;
            this.dgLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellDoubleClick);
            this.dgLista.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellMouseLeave);
            this.dgLista.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgLista_CellMouseMove);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.FillWeight = 8.678338F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 50;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.FillWeight = 78.42543F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 80;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.direccion.FillWeight = 8.678338F;
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 80;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 82;
            // 
            // huesped
            // 
            this.huesped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.huesped.FillWeight = 8.678338F;
            this.huesped.HeaderText = "Can. Personas";
            this.huesped.MinimumWidth = 20;
            this.huesped.Name = "huesped";
            this.huesped.ReadOnly = true;
            this.huesped.Width = 97;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio.FillWeight = 8.678338F;
            this.precio.HeaderText = "Precio x Dia";
            this.precio.MinimumWidth = 20;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 71;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estado.FillWeight = 8.678338F;
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 20;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 67;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipo.FillWeight = 8.678338F;
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 80;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 80;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            this.editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.editar.FillWeight = 62.62717F;
            this.editar.HeaderText = "Editar";
            this.editar.MinimumWidth = 60;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editar.Width = 62;
            // 
            // ver
            // 
            this.ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.ver.DefaultCellStyle = dataGridViewCellStyle3;
            this.ver.FillWeight = 60F;
            this.ver.HeaderText = "Ver";
            this.ver.Name = "ver";
            this.ver.ReadOnly = true;
            this.ver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ver.Width = 60;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(238, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(105, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(127, 23);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 16);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 59);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbfiltro);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(492, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 59);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // cbfiltro
            // 
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Location = new System.Drawing.Point(6, 23);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(93, 23);
            this.cbfiltro.TabIndex = 0;
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Location = new System.Drawing.Point(6, 25);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(54, 19);
            this.rbHotel.TabIndex = 7;
            this.rbHotel.Text = "Hotel";
            this.rbHotel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Controls.Add(this.rbCasa);
            this.groupBox2.Controls.Add(this.rbHotel);
            this.groupBox2.Location = new System.Drawing.Point(295, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 59);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(129, 25);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 19);
            this.rbAll.TabIndex = 9;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Todos";
            this.rbAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Location = new System.Drawing.Point(66, 25);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(50, 19);
            this.rbCasa.TabIndex = 8;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = true;
            // 
            // FormListaAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgLista);
            this.Name = "FormListaAlojamiento";
            this.Text = "FormLista";
            this.Load += new System.EventHandler(this.FormLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgLista;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnActualizar;
        private GroupBox groupBox1;
        private ComboBox cbfiltro;
        private RadioButton rbHotel;
        private GroupBox groupBox2;
        private RadioButton rbCasa;
        private RadioButton rbAll;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn huesped;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn editar;
        private DataGridViewTextBoxColumn ver;
    }
}