using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoAhorcado
{
    
    public partial class MainControl : UserControl
    {

        public MainControl()
        {
            InitializeComponent();
            dificultadComboBox.SelectedIndex = 0;
        }

        private void adminMaterialFlatButton_Click(object sender, EventArgs e)
        {
            LoginControl loginControl = new LoginControl();
            this.Controls.Clear();
            loginControl.Dock = DockStyle.Fill;
            loginControl.BringToFront();
            loginControl.Focus();
            this.Controls.Add(loginControl);
        }


        private void playPictureBox_Click(object sender, EventArgs e)
        {
            GameControl gameControl = new GameControl(dificultadComboBox.SelectedIndex);
            
            gameControl.Dock = DockStyle.Fill;
            gameControl.BringToFront();
            gameControl.Focus();
            
            
            this.Controls.Clear();
            this.Controls.Add(gameControl);
        }
    }
}
