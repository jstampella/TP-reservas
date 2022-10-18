namespace TPreservas.controles
{
    partial class CalendarCustom
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
            this.TableCalendar = new System.Windows.Forms.TableLayoutPanel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAnio = new System.Windows.Forms.ComboBox();
            this.paneltitle = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableCalendar
            // 
            this.TableCalendar.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableCalendar.ColumnCount = 7;
            this.TableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableCalendar.Location = new System.Drawing.Point(4, 78);
            this.TableCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableCalendar.Name = "TableCalendar";
            this.TableCalendar.RowCount = 6;
            this.TableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableCalendar.Size = new System.Drawing.Size(338, 245);
            this.TableCalendar.TabIndex = 5;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(126, 6);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(43, 28);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = "<<";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(175, 7);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 27);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbMes.Location = new System.Drawing.Point(6, 6);
            this.cbMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(114, 28);
            this.cbMes.TabIndex = 8;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbAnio_SelectedIndexChanged);
            // 
            // cbAnio
            // 
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Location = new System.Drawing.Point(219, 6);
            this.cbAnio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(118, 28);
            this.cbAnio.TabIndex = 9;
            this.cbAnio.SelectedIndexChanged += new System.EventHandler(this.cbAnio_SelectedIndexChanged);
            // 
            // paneltitle
            // 
            this.paneltitle.ColumnCount = 7;
            this.paneltitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.paneltitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.paneltitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.paneltitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.paneltitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.paneltitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.paneltitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.paneltitle.Controls.Add(this.label7, 5, 0);
            this.paneltitle.Controls.Add(this.label6, 4, 0);
            this.paneltitle.Controls.Add(this.label5, 3, 0);
            this.paneltitle.Controls.Add(this.label4, 2, 0);
            this.paneltitle.Controls.Add(this.label3, 1, 0);
            this.paneltitle.Controls.Add(this.label2, 0, 0);
            this.paneltitle.Controls.Add(this.label1, 6, 0);
            this.paneltitle.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.paneltitle.Location = new System.Drawing.Point(4, 37);
            this.paneltitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.RowCount = 1;
            this.paneltitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paneltitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.paneltitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.paneltitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.paneltitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.paneltitle.Size = new System.Drawing.Size(338, 40);
            this.paneltitle.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(243, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "V";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(195, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "J";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(147, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "M";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(99, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "M";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "L";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "D";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(291, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarCustom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.cbAnio);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.TableCalendar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(350, 329);
            this.MinimumSize = new System.Drawing.Size(350, 329);
            this.Name = "CalendarCustom";
            this.Size = new System.Drawing.Size(350, 329);
            this.Load += new System.EventHandler(this.CalendarCustom_Load);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableCalendar;
        private Button btnLast;
        private Button btnNext;
        private ComboBox cbMes;
        private ComboBox cbAnio;
        private TableLayoutPanel paneltitle;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
