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
    public partial class ahorcadoView : Form
    {
        
        public ahorcadoView()
        {
            InitializeComponent();
            panel.Controls.Add(new MainControl());
            
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea salir de la aplicación ?","Cerrando el juego",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backBox_Click(object sender, EventArgs e)
        {
            MainControl mainControl = new MainControl();
            showControl(mainControl);
        }

        public void showControl(Control control) {
            this.panel.Controls.Clear();

            control.Dock = DockStyle.Top;
            control.BringToFront();
            control.Focus();

            this.panel.Controls.Add(control);
        }

        private void retryPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
