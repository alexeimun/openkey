using System;
using System.Windows.Forms;

namespace OpenKey
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void timerlogin_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
                         
        private void txtkey_TextChanged(object sender, EventArgs e)
        {
            if(txtkey.Text==Global.Password)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
