using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenKey
{
    public partial class Ver : Form
    {
        public Ver(string texto)
        {
            InitializeComponent();
            this.texto.Text = texto;
            if (texto != "") regs.Visible = false;
        }

        private void Ver_Resize(object sender, EventArgs e)
        {
            texto.Size = Size;
            regs.Location = new Point(2*Size.Width / 5, 2*Size.Height / 5);

        }

        private void Ver_Load(object sender, EventArgs e)
        {

        }
    }
}
