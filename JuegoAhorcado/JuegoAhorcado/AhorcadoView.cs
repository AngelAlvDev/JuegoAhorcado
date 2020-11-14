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
    public partial class AhorcadoView : Form
    {
        public AhorcadoView()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea salir de la aplicación ?","Cerrando el juego",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
