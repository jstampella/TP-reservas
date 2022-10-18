namespace TPreservas.Reservas
{
    partial class FrmListarReservas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Controls.Add(this.rbCasa);
            this.groupBox2.Controls.Add(this.rbHotel);
            this.groupBox2.Location = new System.Drawing.Point(414, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 59);
            this.groupBox2.TabIndex = 12;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbfiltro);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(621, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 59);
            this.groupBox1.TabIndex = 11;
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
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(105, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(127, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(238, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 59);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToOrderColumns = true;
            this.dgLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Location = new System.Drawing.Point(12, 81);
            this.dgLista.Name = "dgLista";
            this.dgLista.RowTemplate.Height = 25;
            this.dgLista.Size = new System.Drawing.Size(905, 361);
            this.dgLista.TabIndex = 9;
            // 
            // FrmListarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgLista);
            this.Name = "FrmListarReservas";
            this.Text = "Lista Reservas";
            this.Load += new System.EventHandler(this.FrmListarReservas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton rbAll;
        private RadioButton rbCasa;
        private RadioButton rbHotel;
        private GroupBox groupBox1;
        private ComboBox cbfiltro;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnActualizar;
        private DataGridView dgLista;
    }
}