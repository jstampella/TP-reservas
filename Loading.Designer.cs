namespace TPreservas
{
    partial class Loading
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
            this.pxLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pxLoading
            // 
            this.pxLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pxLoading.BackColor = System.Drawing.Color.Transparent;
            this.pxLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pxLoading.Image = global::TPreservas.Properties.Resources.loading;
            this.pxLoading.Location = new System.Drawing.Point(41, 37);
            this.pxLoading.Name = "pxLoading";
            this.pxLoading.Size = new System.Drawing.Size(293, 262);
            this.pxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxLoading.TabIndex = 0;
            this.pxLoading.TabStop = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(380, 349);
            this.Controls.Add(this.pxLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Loading";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loading_FormClosing);
            this.Load += new System.EventHandler(this.Loading_Load);
            this.Shown += new System.EventHandler(this.Loading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pxLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pxLoading;
    }
}