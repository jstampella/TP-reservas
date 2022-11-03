namespace TPreservas.controles
{
    partial class ItemHotel
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHot = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.numHusped = new System.Windows.Forms.NumericUpDown();
            this.cmbEstrellas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroHab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelHot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHusped)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHot
            // 
            this.panelHot.Controls.Add(this.btnDelete);
            this.panelHot.Controls.Add(this.numHusped);
            this.panelHot.Controls.Add(this.cmbEstrellas);
            this.panelHot.Controls.Add(this.label6);
            this.panelHot.Controls.Add(this.label5);
            this.panelHot.Controls.Add(this.txtNroHab);
            this.panelHot.Controls.Add(this.label7);
            this.panelHot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHot.Location = new System.Drawing.Point(0, 0);
            this.panelHot.MaximumSize = new System.Drawing.Size(491, 51);
            this.panelHot.Name = "panelHot";
            this.panelHot.Size = new System.Drawing.Size(490, 50);
            this.panelHot.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImage = global::TPreservas.Properties.Resources.delte;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(445, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // numHusped
            // 
            this.numHusped.Location = new System.Drawing.Point(91, 11);
            this.numHusped.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHusped.Name = "numHusped";
            this.numHusped.Size = new System.Drawing.Size(64, 27);
            this.numHusped.TabIndex = 9;
            this.numHusped.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.cmbEstrellas.Location = new System.Drawing.Point(224, 11);
            this.cmbEstrellas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstrellas.Name = "cmbEstrellas";
            this.cmbEstrellas.Size = new System.Drawing.Size(62, 28);
            this.cmbEstrellas.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "C. Persona:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Estrella:";
            // 
            // txtNroHab
            // 
            this.txtNroHab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNroHab.Location = new System.Drawing.Point(370, 11);
            this.txtNroHab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNroHab.Name = "txtNroHab";
            this.txtNroHab.Size = new System.Drawing.Size(65, 27);
            this.txtNroHab.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nro Hab.:";
            // 
            // ItemHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHot);
            this.Name = "ItemHotel";
            this.Size = new System.Drawing.Size(490, 50);
            this.panelHot.ResumeLayout(false);
            this.panelHot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHusped)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHot;
        private Button btnDelete;
        private NumericUpDown numHusped;
        private ComboBox cmbEstrellas;
        private Label label6;
        private Label label5;
        private TextBox txtNroHab;
        private Label label7;
    }
}
