using System.ComponentModel;
using System.Windows.Forms;

namespace OpenKey
{
    partial class Opciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.glocal = new System.Windows.Forms.GroupBox();
            this.grbsnapshotlocal = new System.Windows.Forms.GroupBox();
            this.nudsnaplocal = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.chksnaplocal = new System.Windows.Forms.CheckBox();
            this.grbregistrolocal = new System.Windows.Forms.GroupBox();
            this.nudreglocal = new System.Windows.Forms.NumericUpDown();
            this.cmbregformat = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.namereglocal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkreglocal = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Examinar = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chksendmail = new System.Windows.Forms.CheckBox();
            this.gmail = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gorigen = new System.Windows.Forms.GroupBox();
            this.chk_usessl = new System.Windows.Forms.CheckBox();
            this.txt_smtp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_smtpport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opc_origen2 = new System.Windows.Forms.RadioButton();
            this.timelog = new System.Windows.Forms.NumericUpDown();
            this.opc_origen1 = new System.Windows.Forms.RadioButton();
            this.Destino = new System.Windows.Forms.Label();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chksnapshot = new System.Windows.Forms.CheckBox();
            this.gshot = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formatsnap = new System.Windows.Forms.ComboBox();
            this.timeSnap = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nameshot = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkkey = new System.Windows.Forms.CheckBox();
            this.zonekey = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtrkey = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.chkhide = new System.Windows.Forms.CheckBox();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Opcion = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.glocal.SuspendLayout();
            this.grbsnapshotlocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudsnaplocal)).BeginInit();
            this.grbregistrolocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudreglocal)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.gmail.SuspendLayout();
            this.gorigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timelog)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gshot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSnap)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.zonekey.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.glocal);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(511, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Local";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // glocal
            // 
            this.glocal.Controls.Add(this.grbsnapshotlocal);
            this.glocal.Controls.Add(this.chksnaplocal);
            this.glocal.Controls.Add(this.grbregistrolocal);
            this.glocal.Controls.Add(this.chkreglocal);
            this.glocal.Controls.Add(this.label16);
            this.glocal.Controls.Add(this.Examinar);
            this.glocal.Controls.Add(this.location);
            this.glocal.Location = new System.Drawing.Point(8, 14);
            this.glocal.Name = "glocal";
            this.glocal.Size = new System.Drawing.Size(483, 405);
            this.glocal.TabIndex = 41;
            this.glocal.TabStop = false;
            this.glocal.Text = "Local";
            // 
            // grbsnapshotlocal
            // 
            this.grbsnapshotlocal.Controls.Add(this.nudsnaplocal);
            this.grbsnapshotlocal.Controls.Add(this.label19);
            this.grbsnapshotlocal.Controls.Add(this.label20);
            this.grbsnapshotlocal.Location = new System.Drawing.Point(24, 270);
            this.grbsnapshotlocal.Name = "grbsnapshotlocal";
            this.grbsnapshotlocal.Size = new System.Drawing.Size(434, 82);
            this.grbsnapshotlocal.TabIndex = 43;
            this.grbsnapshotlocal.TabStop = false;
            // 
            // nudsnaplocal
            // 
            this.nudsnaplocal.Location = new System.Drawing.Point(193, 32);
            this.nudsnaplocal.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudsnaplocal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudsnaplocal.Name = "nudsnaplocal";
            this.nudsnaplocal.Size = new System.Drawing.Size(47, 26);
            this.nudsnaplocal.TabIndex = 33;
            this.Opcion.SetToolTip(this.nudsnaplocal, "Guardar cada n minutos");
            this.nudsnaplocal.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(81, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 20);
            this.label19.TabIndex = 32;
            this.label19.Text = "Guardar cada:";
            this.Opcion.SetToolTip(this.label19, "Guardar cada n minutos");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(244, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 20);
            this.label20.TabIndex = 34;
            this.label20.Text = "minutos ";
            this.Opcion.SetToolTip(this.label20, "Guardar cada n minutos");
            // 
            // chksnaplocal
            // 
            this.chksnaplocal.AutoSize = true;
            this.chksnaplocal.Location = new System.Drawing.Point(24, 249);
            this.chksnaplocal.Name = "chksnaplocal";
            this.chksnaplocal.Size = new System.Drawing.Size(105, 24);
            this.chksnaplocal.TabIndex = 42;
            this.chksnaplocal.Text = "Snapshots";
            this.Opcion.SetToolTip(this.chksnaplocal, "Activar la opcion de guardar en el pc");
            this.chksnaplocal.UseVisualStyleBackColor = true;
            this.chksnaplocal.CheckedChanged += new System.EventHandler(this.chksnaplocal_CheckedChanged);
            // 
            // grbregistrolocal
            // 
            this.grbregistrolocal.Controls.Add(this.nudreglocal);
            this.grbregistrolocal.Controls.Add(this.cmbregformat);
            this.grbregistrolocal.Controls.Add(this.label14);
            this.grbregistrolocal.Controls.Add(this.label15);
            this.grbregistrolocal.Controls.Add(this.label13);
            this.grbregistrolocal.Controls.Add(this.namereglocal);
            this.grbregistrolocal.Controls.Add(this.label12);
            this.grbregistrolocal.Location = new System.Drawing.Point(24, 134);
            this.grbregistrolocal.Name = "grbregistrolocal";
            this.grbregistrolocal.Size = new System.Drawing.Size(434, 88);
            this.grbregistrolocal.TabIndex = 41;
            this.grbregistrolocal.TabStop = false;
            // 
            // nudreglocal
            // 
            this.nudreglocal.Location = new System.Drawing.Point(300, 55);
            this.nudreglocal.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudreglocal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudreglocal.Name = "nudreglocal";
            this.nudreglocal.Size = new System.Drawing.Size(47, 26);
            this.nudreglocal.TabIndex = 33;
            this.Opcion.SetToolTip(this.nudreglocal, "Guardar cada n minutos");
            this.nudreglocal.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmbregformat
            // 
            this.cmbregformat.FormattingEnabled = true;
            this.cmbregformat.Items.AddRange(new object[] {
            "txt"});
            this.cmbregformat.Location = new System.Drawing.Point(85, 51);
            this.cmbregformat.Name = "cmbregformat";
            this.cmbregformat.Size = new System.Drawing.Size(80, 28);
            this.cmbregformat.TabIndex = 37;
            this.cmbregformat.Text = "txt";
            this.Opcion.SetToolTip(this.cmbregformat, "formato de los archivos");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(186, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Guardar cada:";
            this.Opcion.SetToolTip(this.label14, "Guardar cada n minutos");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "minutos ";
            this.Opcion.SetToolTip(this.label15, "Guardar cada n minutos");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Formato:";
            this.Opcion.SetToolTip(this.label13, "formato de los archivos");
            // 
            // namereglocal
            // 
            this.namereglocal.Location = new System.Drawing.Point(85, 15);
            this.namereglocal.Name = "namereglocal";
            this.namereglocal.Size = new System.Drawing.Size(262, 26);
            this.namereglocal.TabIndex = 35;
            this.namereglocal.Text = "Registro";
            this.Opcion.SetToolTip(this.namereglocal, "Nombre de los archivos");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 36;
            this.label12.Text = "Nombre:";
            this.Opcion.SetToolTip(this.label12, "Nombre de los archivos");
            // 
            // chkreglocal
            // 
            this.chkreglocal.AutoSize = true;
            this.chkreglocal.Location = new System.Drawing.Point(24, 113);
            this.chkreglocal.Name = "chkreglocal";
            this.chkreglocal.Size = new System.Drawing.Size(96, 24);
            this.chkreglocal.TabIndex = 39;
            this.chkreglocal.Text = "Registros";
            this.Opcion.SetToolTip(this.chkreglocal, "Activar la opcion de guardar en el pc");
            this.chkreglocal.UseVisualStyleBackColor = true;
            this.chkreglocal.CheckedChanged += new System.EventHandler(this.chkreglocal_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "Ubicación:";
            this.Opcion.SetToolTip(this.label16, "Ubicación de los archivos a guardar por defecto");
            // 
            // Examinar
            // 
            this.Examinar.Location = new System.Drawing.Point(427, 69);
            this.Examinar.Name = "Examinar";
            this.Examinar.Size = new System.Drawing.Size(33, 28);
            this.Examinar.TabIndex = 0;
            this.Examinar.Text = "...";
            this.Examinar.UseVisualStyleBackColor = true;
            this.Examinar.Click += new System.EventHandler(this.Examinar_Click);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(24, 70);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(399, 26);
            this.location.TabIndex = 1;
            this.Opcion.SetToolTip(this.location, "Ubicación de los archivos a guardar por defecto");
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chksendmail);
            this.tabPage1.Controls.Add(this.gmail);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(511, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Correo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chksendmail
            // 
            this.chksendmail.AutoSize = true;
            this.chksendmail.Location = new System.Drawing.Point(26, 30);
            this.chksendmail.Name = "chksendmail";
            this.chksendmail.Size = new System.Drawing.Size(148, 24);
            this.chksendmail.TabIndex = 0;
            this.chksendmail.Text = "Envíar por correo";
            this.Opcion.SetToolTip(this.chksendmail, "Activa la opción para envíar registros");
            this.chksendmail.UseVisualStyleBackColor = true;
            this.chksendmail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gmail
            // 
            this.gmail.Controls.Add(this.label6);
            this.gmail.Controls.Add(this.gorigen);
            this.gmail.Controls.Add(this.label1);
            this.gmail.Controls.Add(this.opc_origen2);
            this.gmail.Controls.Add(this.timelog);
            this.gmail.Controls.Add(this.opc_origen1);
            this.gmail.Controls.Add(this.Destino);
            this.gmail.Controls.Add(this.txtdestino);
            this.gmail.Controls.Add(this.label7);
            this.gmail.Location = new System.Drawing.Point(26, 60);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(462, 371);
            this.gmail.TabIndex = 0;
            this.gmail.TabStop = false;
            this.gmail.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "minutos ";
            this.Opcion.SetToolTip(this.label6, "Envíar correo cada n minutos");
            // 
            // gorigen
            // 
            this.gorigen.Controls.Add(this.chk_usessl);
            this.gorigen.Controls.Add(this.txt_smtp);
            this.gorigen.Controls.Add(this.label4);
            this.gorigen.Controls.Add(this.label9);
            this.gorigen.Controls.Add(this.txt_smtpport);
            this.gorigen.Controls.Add(this.label5);
            this.gorigen.Controls.Add(this.txt_clave);
            this.gorigen.Controls.Add(this.label8);
            this.gorigen.Controls.Add(this.txt_email);
            this.gorigen.Enabled = false;
            this.gorigen.Location = new System.Drawing.Point(104, 153);
            this.gorigen.Name = "gorigen";
            this.gorigen.Size = new System.Drawing.Size(335, 152);
            this.gorigen.TabIndex = 25;
            this.gorigen.TabStop = false;
            // 
            // chk_usessl
            // 
            this.chk_usessl.AutoSize = true;
            this.chk_usessl.Checked = true;
            this.chk_usessl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_usessl.Location = new System.Drawing.Point(165, 116);
            this.chk_usessl.Name = "chk_usessl";
            this.chk_usessl.Size = new System.Drawing.Size(59, 24);
            this.chk_usessl.TabIndex = 24;
            this.chk_usessl.Text = "SSL";
            this.Opcion.SetToolTip(this.chk_usessl, "Activar seguridad ssl");
            this.chk_usessl.UseVisualStyleBackColor = true;
            // 
            // txt_smtp
            // 
            this.txt_smtp.Location = new System.Drawing.Point(100, 80);
            this.txt_smtp.Name = "txt_smtp";
            this.txt_smtp.Size = new System.Drawing.Size(207, 26);
            this.txt_smtp.TabIndex = 19;
            this.txt_smtp.Text = "smtp.live.com";
            this.Opcion.SetToolTip(this.txt_smtp, "Servidor smtp");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Correo:";
            this.Opcion.SetToolTip(this.label4, "Correo o usuario");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Clave:";
            this.Opcion.SetToolTip(this.label9, "Contraseña del usuario");
            // 
            // txt_smtpport
            // 
            this.txt_smtpport.Location = new System.Drawing.Point(102, 115);
            this.txt_smtpport.Name = "txt_smtpport";
            this.txt_smtpport.Size = new System.Drawing.Size(57, 26);
            this.txt_smtpport.TabIndex = 20;
            this.txt_smtpport.Text = "587";
            this.Opcion.SetToolTip(this.txt_smtpport, "Puerto");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Puerto:";
            this.Opcion.SetToolTip(this.label5, "Puerto");
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(100, 49);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(207, 26);
            this.txt_clave.TabIndex = 18;
            this.Opcion.SetToolTip(this.txt_clave, "Contraseña del usuario");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "SMTP:";
            this.Opcion.SetToolTip(this.label8, "Servidor smtp");
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(100, 16);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(207, 26);
            this.txt_email.TabIndex = 17;
            this.Opcion.SetToolTip(this.txt_email, "Correo o usuario");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origen:";
            // 
            // opc_origen2
            // 
            this.opc_origen2.AutoSize = true;
            this.opc_origen2.Location = new System.Drawing.Point(80, 129);
            this.opc_origen2.Name = "opc_origen2";
            this.opc_origen2.Size = new System.Drawing.Size(226, 24);
            this.opc_origen2.TabIndex = 3;
            this.opc_origen2.Text = "No hay problema, yo lo hago";
            this.Opcion.SetToolTip(this.opc_origen2, "Configuración manual del servidor smtp");
            this.opc_origen2.UseVisualStyleBackColor = true;
            this.opc_origen2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // timelog
            // 
            this.timelog.Location = new System.Drawing.Point(221, 326);
            this.timelog.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.timelog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timelog.Name = "timelog";
            this.timelog.Size = new System.Drawing.Size(47, 26);
            this.timelog.TabIndex = 22;
            this.Opcion.SetToolTip(this.timelog, "Envíar correo cada n minutos");
            this.timelog.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // opc_origen1
            // 
            this.opc_origen1.AutoSize = true;
            this.opc_origen1.Checked = true;
            this.opc_origen1.Location = new System.Drawing.Point(80, 99);
            this.opc_origen1.Name = "opc_origen1";
            this.opc_origen1.Size = new System.Drawing.Size(298, 24);
            this.opc_origen1.TabIndex = 2;
            this.opc_origen1.TabStop = true;
            this.opc_origen1.Text = "Que OpenKey se encargue de enviarlo";
            this.Opcion.SetToolTip(this.opc_origen1, "OpenKey lo hará por tí");
            this.opc_origen1.UseVisualStyleBackColor = true;
            this.opc_origen1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Destino
            // 
            this.Destino.AutoSize = true;
            this.Destino.Location = new System.Drawing.Point(30, 32);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(68, 20);
            this.Destino.TabIndex = 1;
            this.Destino.Text = "Destino:";
            this.Opcion.SetToolTip(this.Destino, "La dirección de correo a donde llegaran los registros");
            // 
            // txtdestino
            // 
            this.txtdestino.Location = new System.Drawing.Point(104, 32);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(316, 26);
            this.txtdestino.TabIndex = 0;
            this.txtdestino.Text = "correo@example.com";
            this.Opcion.SetToolTip(this.txtdestino, "La dirección de correo a donde llegaran los registros");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Envíar cada:";
            this.Opcion.SetToolTip(this.label7, "Envíar correo cada n minutos");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chksnapshot);
            this.tabPage2.Controls.Add(this.gshot);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(511, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Snapshot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chksnapshot
            // 
            this.chksnapshot.AutoSize = true;
            this.chksnapshot.Enabled = false;
            this.chksnapshot.Location = new System.Drawing.Point(19, 46);
            this.chksnapshot.Name = "chksnapshot";
            this.chksnapshot.Size = new System.Drawing.Size(153, 24);
            this.chksnapshot.TabIndex = 33;
            this.chksnapshot.Text = "Envíar Snapshots";
            this.Opcion.SetToolTip(this.chksnapshot, "Activar envío de snapshots");
            this.chksnapshot.UseVisualStyleBackColor = true;
            this.chksnapshot.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // gshot
            // 
            this.gshot.Controls.Add(this.label10);
            this.gshot.Controls.Add(this.label11);
            this.gshot.Controls.Add(this.label3);
            this.gshot.Controls.Add(this.formatsnap);
            this.gshot.Controls.Add(this.timeSnap);
            this.gshot.Controls.Add(this.label2);
            this.gshot.Controls.Add(this.nameshot);
            this.gshot.Location = new System.Drawing.Point(19, 96);
            this.gshot.Name = "gshot";
            this.gshot.Size = new System.Drawing.Size(472, 257);
            this.gshot.TabIndex = 32;
            this.gshot.TabStop = false;
            this.gshot.Text = "Snapshot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Nombre de los Snapshots:";
            this.Opcion.SetToolTip(this.label10, "Nombre de la imagen");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Formato:";
            this.Opcion.SetToolTip(this.label11, "Formato de la imagen");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Envíar cada:";
            this.Opcion.SetToolTip(this.label3, "Envíar snapshot cada n minutos");
            // 
            // formatsnap
            // 
            this.formatsnap.FormattingEnabled = true;
            this.formatsnap.Items.AddRange(new object[] {
            "png",
            "jpg",
            "bmp"});
            this.formatsnap.Location = new System.Drawing.Point(212, 107);
            this.formatsnap.Name = "formatsnap";
            this.formatsnap.Size = new System.Drawing.Size(95, 28);
            this.formatsnap.TabIndex = 30;
            this.formatsnap.Text = "jpg";
            this.Opcion.SetToolTip(this.formatsnap, "Formato de la imagen");
            // 
            // timeSnap
            // 
            this.timeSnap.Location = new System.Drawing.Point(231, 169);
            this.timeSnap.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.timeSnap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeSnap.Name = "timeSnap";
            this.timeSnap.Size = new System.Drawing.Size(47, 26);
            this.timeSnap.TabIndex = 25;
            this.Opcion.SetToolTip(this.timeSnap, "Envíar snapshot cada n minutos");
            this.timeSnap.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "minutos ";
            this.Opcion.SetToolTip(this.label2, "Envíar snapshot cada n minutos");
            // 
            // nameshot
            // 
            this.nameshot.Location = new System.Drawing.Point(212, 50);
            this.nameshot.Name = "nameshot";
            this.nameshot.Size = new System.Drawing.Size(226, 26);
            this.nameshot.TabIndex = 28;
            this.nameshot.Text = "Snapshot";
            this.Opcion.SetToolTip(this.nameshot, "Nombre de la imagen");
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkkey);
            this.tabPage4.Controls.Add(this.zonekey);
            this.tabPage4.Controls.Add(this.chkhide);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(511, 439);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ajustes Generales";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chkkey
            // 
            this.chkkey.AutoSize = true;
            this.chkkey.Location = new System.Drawing.Point(38, 92);
            this.chkkey.Name = "chkkey";
            this.chkkey.Size = new System.Drawing.Size(132, 24);
            this.chkkey.TabIndex = 43;
            this.chkkey.Text = "Requerir Clave";
            this.chkkey.UseVisualStyleBackColor = true;
            this.chkkey.CheckedChanged += new System.EventHandler(this.chkkey_CheckedChanged);
            // 
            // zonekey
            // 
            this.zonekey.Controls.Add(this.label18);
            this.zonekey.Controls.Add(this.txtrkey);
            this.zonekey.Controls.Add(this.label17);
            this.zonekey.Controls.Add(this.txtkey);
            this.zonekey.Enabled = false;
            this.zonekey.Location = new System.Drawing.Point(38, 152);
            this.zonekey.Name = "zonekey";
            this.zonekey.Size = new System.Drawing.Size(452, 186);
            this.zonekey.TabIndex = 42;
            this.zonekey.TabStop = false;
            this.zonekey.Text = "Zona de clave";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 20);
            this.label18.TabIndex = 42;
            this.label18.Text = "Comfirmar Clave:";
            this.Opcion.SetToolTip(this.label18, "Ingrese nuevamente la clave");
            // 
            // txtrkey
            // 
            this.txtrkey.Location = new System.Drawing.Point(158, 109);
            this.txtrkey.Name = "txtrkey";
            this.txtrkey.PasswordChar = '*';
            this.txtrkey.Size = new System.Drawing.Size(245, 26);
            this.txtrkey.TabIndex = 41;
            this.Opcion.SetToolTip(this.txtrkey, "Ingrese nuevamente la clave");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(97, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 40;
            this.label17.Text = "Clave:";
            this.Opcion.SetToolTip(this.label17, "Ingrese una clave");
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(158, 66);
            this.txtkey.Name = "txtkey";
            this.txtkey.PasswordChar = '*';
            this.txtkey.Size = new System.Drawing.Size(245, 26);
            this.txtkey.TabIndex = 1;
            this.Opcion.SetToolTip(this.txtkey, "Ingrese una clave");
            // 
            // chkhide
            // 
            this.chkhide.AutoSize = true;
            this.chkhide.Location = new System.Drawing.Point(38, 56);
            this.chkhide.Name = "chkhide";
            this.chkhide.Size = new System.Drawing.Size(274, 24);
            this.chkhide.TabIndex = 1;
            this.chkhide.Text = "Ocultar ventana al iniciar la captura";
            this.chkhide.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(435, 481);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 32);
            this.exit.TabIndex = 26;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Location = new System.Drawing.Point(349, 481);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(80, 32);
            this.save.TabIndex = 27;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Opcion
            // 
            this.Opcion.ForeColor = System.Drawing.Color.DarkBlue;
            this.Opcion.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Opcion.ToolTipTitle = "Info";
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 518);
            this.ControlBox = false;
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Opciones_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.glocal.ResumeLayout(false);
            this.glocal.PerformLayout();
            this.grbsnapshotlocal.ResumeLayout(false);
            this.grbsnapshotlocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudsnaplocal)).EndInit();
            this.grbregistrolocal.ResumeLayout(false);
            this.grbregistrolocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudreglocal)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gmail.ResumeLayout(false);
            this.gmail.PerformLayout();
            this.gorigen.ResumeLayout(false);
            this.gorigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timelog)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gshot.ResumeLayout(false);
            this.gshot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSnap)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.zonekey.ResumeLayout(false);
            this.zonekey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CheckBox chksendmail;
        private GroupBox gmail;
        private GroupBox gorigen;
        private Label label6;
        internal CheckBox chk_usessl;
        internal TextBox txt_smtp;
        private Label label4;
        private Label label9;
        internal NumericUpDown timelog;
        internal TextBox txt_smtpport;
        private Label label5;
        internal TextBox txt_clave;
        private Label label8;
        internal TextBox txt_email;
        private Label label7;
        private Label label1;
        private RadioButton opc_origen2;
        private RadioButton opc_origen1;
        private Label Destino;
        private TextBox txtdestino;
        private Button exit;
        private Button save;
        private TabPage tabPage4;
        private CheckBox chkhide;
        private Label label2;
        internal NumericUpDown timeSnap;
        private Label label3;
        private TextBox location;
        private Button Examinar;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label11;
        private ComboBox formatsnap;
        private Label label10;
        private TextBox nameshot;
        private CheckBox chksnapshot;
        private GroupBox gshot;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox cmbregformat;
        internal NumericUpDown nudreglocal;
        private Label label15;
        private TextBox namereglocal;
        private GroupBox glocal;
        private Label label16;
        private CheckBox chkreglocal;
        private ToolTip Opcion;
        private CheckBox chkkey;
        private GroupBox zonekey;
        private Label label18;
        private TextBox txtrkey;
        private Label label17;
        private TextBox txtkey;
        private GroupBox grbsnapshotlocal;
        internal NumericUpDown nudsnaplocal;
        private Label label19;
        private Label label20;
        private CheckBox chksnaplocal;
        private GroupBox grbregistrolocal;
    }
}