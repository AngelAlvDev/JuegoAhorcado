
namespace JuegoAhorcado
{
    partial class ahorcadoView
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.backBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1051, 538);
            this.panel.TabIndex = 5;
            // 
            // backBox
            // 
            this.backBox.Image = global::JuegoAhorcado.Properties.Resources.back_arrow_100px;
            this.backBox.Location = new System.Drawing.Point(42, 544);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(90, 82);
            this.backBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBox.TabIndex = 1;
            this.backBox.TabStop = false;
            this.backBox.Click += new System.EventHandler(this.backBox_Click);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = global::JuegoAhorcado.Properties.Resources.exit_100px;
            this.exitPictureBox.Location = new System.Drawing.Point(919, 544);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(90, 82);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPictureBox.TabIndex = 0;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // ahorcadoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 656);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.exitPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ahorcadoView";
            this.Text = "Ahorcado V 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox backBox;
        private System.Windows.Forms.Panel panel;
    }
}

