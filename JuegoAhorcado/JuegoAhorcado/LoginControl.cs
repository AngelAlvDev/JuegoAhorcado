using System;
using System.Windows.Forms;

namespace JuegoAhorcado
{
    public partial class LoginControl : UserControl
    {
        private static LoginControl _instance;
        public static LoginControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginControl();
                return _instance;
            }
        }

        public LoginControl()
        {
            InitializeComponent();
        }

        private void accesButton_Click(object sender, EventArgs e)
        {
            if(usuarioTextBox.Text == "admin" && passwordTextBox.Text == "1234")
            {
                AdminControl adminControl = new AdminControl();
                this.Controls.Clear();
                adminControl.Dock = DockStyle.Fill;
                adminControl.BringToFront();
                adminControl.Focus();
                this.Controls.Add(adminControl);
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña no son correctos");
            }
        }
    }
}
