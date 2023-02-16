namespace TCERP
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.TCERPLogo = new System.Windows.Forms.PictureBox();
            this.tcerp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TCERPLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcerp)).BeginInit();
            this.SuspendLayout();
            // 
            // TCERPLogo
            // 
            this.TCERPLogo.BackColor = System.Drawing.Color.White;
            this.TCERPLogo.Image = global::TCERP.Properties.Resources.TCERP_Logo_definitiva;
            this.TCERPLogo.Location = new System.Drawing.Point(232, 104);
            this.TCERPLogo.Name = "TCERPLogo";
            this.TCERPLogo.Size = new System.Drawing.Size(326, 116);
            this.TCERPLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TCERPLogo.TabIndex = 5;
            this.TCERPLogo.TabStop = false;
            // 
            // tcerp
            // 
            this.tcerp.BackColor = System.Drawing.Color.White;
            this.tcerp.Image = ((System.Drawing.Image)(resources.GetObject("tcerp.Image")));
            this.tcerp.Location = new System.Drawing.Point(232, 215);
            this.tcerp.Name = "tcerp";
            this.tcerp.Size = new System.Drawing.Size(326, 289);
            this.tcerp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tcerp.TabIndex = 6;
            this.tcerp.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 609);
            this.Controls.Add(this.TCERPLogo);
            this.Controls.Add(this.tcerp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TCERPLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcerp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TCERPLogo;
        private System.Windows.Forms.PictureBox tcerp;
    }
}