
namespace JuegoAhorcado
{
    partial class MainControl
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
            this.dificultadComboBox = new System.Windows.Forms.ComboBox();
            this.adminMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dificultadComboBox
            // 
            this.dificultadComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.dificultadComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dificultadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dificultadComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dificultadComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dificultadComboBox.Items.AddRange(new object[] {
            "BÁSICO",
            "MEDIO",
            "AVANZADO"});
            this.dificultadComboBox.Location = new System.Drawing.Point(538, 399);
            this.dificultadComboBox.Name = "dificultadComboBox";
            this.dificultadComboBox.Size = new System.Drawing.Size(210, 32);
            this.dificultadComboBox.TabIndex = 0;
            // 
            // adminMaterialFlatButton
            // 
            this.adminMaterialFlatButton.AutoSize = true;
            this.adminMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminMaterialFlatButton.Depth = 0;
            this.adminMaterialFlatButton.Icon = null;
            this.adminMaterialFlatButton.Location = new System.Drawing.Point(45, 471);
            this.adminMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.adminMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminMaterialFlatButton.Name = "adminMaterialFlatButton";
            this.adminMaterialFlatButton.Primary = false;
            this.adminMaterialFlatButton.Size = new System.Drawing.Size(195, 36);
            this.adminMaterialFlatButton.TabIndex = 2;
            this.adminMaterialFlatButton.Text = "Agregar nueva palabra";
            this.adminMaterialFlatButton.UseVisualStyleBackColor = true;
            this.adminMaterialFlatButton.Click += new System.EventHandler(this.adminMaterialFlatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "EL AHORCADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escoja dificultad";
            // 
            // playPictureBox
            // 
            this.playPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPictureBox.Image = global::JuegoAhorcado.Properties.Resources.iconfinder_play_alt_118620;
            this.playPictureBox.Location = new System.Drawing.Point(431, 168);
            this.playPictureBox.Name = "playPictureBox";
            this.playPictureBox.Size = new System.Drawing.Size(208, 212);
            this.playPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playPictureBox.TabIndex = 0;
            this.playPictureBox.TabStop = false;
            this.playPictureBox.Click += new System.EventHandler(this.playPictureBox_Click);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminMaterialFlatButton);
            this.Controls.Add(this.dificultadComboBox);
            this.Controls.Add(this.playPictureBox);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1053, 537);
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dificultadComboBox;
        private MaterialSkin.Controls.MaterialFlatButton adminMaterialFlatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox playPictureBox;
    }
}
