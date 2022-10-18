namespace TPreservas
{
    partial class FrmListarClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbfiltro);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(560, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(338, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // cbfiltro
            // 
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Location = new System.Drawing.Point(7, 31);
            this.cbfiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(106, 28);
            this.cbfiltro.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(120, 31);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(145, 27);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(272, 31);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 31);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 13);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 79);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
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
            this.dni,
            this.nombre,
            this.apellido,
            this.email,
            this.ver,
            this.editar});
            this.dgLista.Location = new System.Drawing.Point(12, 95);
            this.dgLista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgLista.RowHeadersVisible = false;
            this.dgLista.RowHeadersWidth = 25;
            this.dgLista.RowTemplate.Height = 25;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLista.Size = new System.Drawing.Size(887, 508);
            this.dgLista.TabIndex = 7;
            // 
            // dni
            // 
            this.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dni.FillWeight = 64.04803F;
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 120;
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 120;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.FillWeight = 64.04803F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellido.FillWeight = 64.04803F;
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 95;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.FillWeight = 64.04803F;
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 75;
            // 
            // ver
            // 
            this.ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ver.FillWeight = 151.2945F;
            this.ver.HeaderText = "Ver";
            this.ver.MinimumWidth = 50;
            this.ver.Name = "ver";
            this.ver.ReadOnly = true;
            this.ver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ver.Width = 50;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar.FillWeight = 192.5134F;
            this.editar.HeaderText = "Editar";
            this.editar.MinimumWidth = 50;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editar.Width = 50;
            // 
            // FrmListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgLista);
            this.Name = "FrmListarClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.FrmListarClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbfiltro;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnActualizar;
        private DataGridView dgLista;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn ver;
        private DataGridViewTextBoxColumn editar;
    }
}