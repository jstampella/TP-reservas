namespace TPreservas
{
    partial class FormExtra
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
            this.panelDireccion = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numdias = new System.Windows.Forms.NumericUpDown();
            this.lb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelDireccion.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdias)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDireccion
            // 
            this.panelDireccion.Controls.Add(this.panel1);
            this.panelDireccion.Controls.Add(this.panel2);
            this.panelDireccion.Location = new System.Drawing.Point(6, 30);
            this.panelDireccion.Name = "panelDireccion";
            this.panelDireccion.Size = new System.Drawing.Size(358, 116);
            this.panelDireccion.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numdias);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 50);
            this.panel1.TabIndex = 0;
            // 
            // numdias
            // 
            this.numdias.Location = new System.Drawing.Point(172, 12);
            this.numdias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numdias.Name = "numdias";
            this.numdias.Size = new System.Drawing.Size(161, 27);
            this.numdias.TabIndex = 2;
            this.numdias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(13, 14);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(131, 20);
            this.lb.TabIndex = 0;
            this.lb.Text = "Dias de Penalidad:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numPorcentaje);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 50);
            this.panel2.TabIndex = 2;
            // 
            // numPorcentaje
            // 
            this.numPorcentaje.DecimalPlaces = 2;
            this.numPorcentaje.Location = new System.Drawing.Point(172, 12);
            this.numPorcentaje.Name = "numPorcentaje";
            this.numPorcentaje.Size = new System.Drawing.Size(161, 27);
            this.numPorcentaje.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "% de Penalidad:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(6, 178);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(358, 29);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormExtra
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 216);
            this.Controls.Add(this.panelDireccion);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuracion Penalidad";
            this.Load += new System.EventHandler(this.FormExtra_Load);
            this.panelDireccion.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDireccion;
        private Panel panel1;
        private NumericUpDown numdias;
        private Label lb;
        private Panel panel2;
        private NumericUpDown numPorcentaje;
        private Label label1;
        private Button btnAceptar;
    }
}