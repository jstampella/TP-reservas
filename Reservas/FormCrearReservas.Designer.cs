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
            this.cbAlojamientos = new System.Windows.Forms.ComboBox();
            this.numericHuesped = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHuesped)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(12, 12);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 23);
            this.dtFecha.TabIndex = 0;
            // 
            // numericDay
            // 
            this.numericDay.Location = new System.Drawing.Point(237, 12);
            this.numericDay.Name = "numericDay";
            this.numericDay.Size = new System.Drawing.Size(120, 23);
            this.numericDay.TabIndex = 1;
            // 
            // cbAlojamientos
            // 
            this.cbAlojamientos.FormattingEnabled = true;
            this.cbAlojamientos.Location = new System.Drawing.Point(387, 11);
            this.cbAlojamientos.Name = "cbAlojamientos";
            this.cbAlojamientos.Size = new System.Drawing.Size(121, 23);
            this.cbAlojamientos.TabIndex = 2;
            // 
            // numericHuesped
            // 
            this.numericHuesped.Location = new System.Drawing.Point(12, 51);
            this.numericHuesped.Name = "numericHuesped";
            this.numericHuesped.Size = new System.Drawing.Size(75, 23);
            this.numericHuesped.TabIndex = 3;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(433, 176);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Reservar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FormCrearReservas
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 211);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.numericHuesped);
            this.Controls.Add(this.cbAlojamientos);
            this.Controls.Add(this.numericDay);
            this.Controls.Add(this.dtFecha);
            this.Name = "FormCrearReservas";
            this.Text = "FormCrearReservas";
            this.Load += new System.EventHandler(this.FormCrearReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHuesped)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtFecha;
        private NumericUpDown numericDay;
        private ComboBox cbAlojamientos;
        private NumericUpDown numericHuesped;
        private Button btnCrear;
    }
}