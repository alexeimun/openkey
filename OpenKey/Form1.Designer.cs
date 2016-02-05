namespace OpenKey
{
    partial class Openkey
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Openkey));
            this.Logger = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturarM = new System.Windows.Forms.ToolStripMenuItem();
            this.pararM = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarT = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbiniciar = new System.Windows.Forms.Label();
            this.lbparar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbocultar = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.regs = new System.Windows.Forms.Label();
            this.Regger = new System.Windows.Forms.Timer(this.components);
            this.Snapper = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.pichide = new System.Windows.Forms.PictureBox();
            this.unhook = new System.Windows.Forms.PictureBox();
            this.hook = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Galeria = new System.Windows.Forms.TabPage();
            this.Snapperlocal = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unhook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logger
            // 
            this.Logger.Interval = 5000;
            this.Logger.Tick += new System.EventHandler(this.Logger_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturarM,
            this.pararM,
            this.ocultarT,
            this.verToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // capturarM
            // 
            this.capturarM.Image = global::OpenKey.Properties.Resources.start_icon;
            this.capturarM.Name = "capturarM";
            this.capturarM.Size = new System.Drawing.Size(145, 26);
            this.capturarM.Text = "&Capturar";
            this.capturarM.Click += new System.EventHandler(this.hook_Click_1);
            // 
            // pararM
            // 
            this.pararM.Enabled = false;
            this.pararM.Image = global::OpenKey.Properties.Resources.Record_Normal_icon;
            this.pararM.Name = "pararM";
            this.pararM.Size = new System.Drawing.Size(145, 26);
            this.pararM.Text = "&Parar";
            this.pararM.Click += new System.EventHandler(this.unhook_Click);
            // 
            // ocultarT
            // 
            this.ocultarT.Enabled = false;
            this.ocultarT.Image = global::OpenKey.Properties.Resources.hide_right_icon;
            this.ocultarT.Name = "ocultarT";
            this.ocultarT.Size = new System.Drawing.Size(145, 26);
            this.ocultarT.Text = "Oc&ultar";
            this.ocultarT.Click += new System.EventHandler(this.hide_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Image = global::OpenKey.Properties.Resources.Dj_View_icon;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.verToolStripMenuItem.Text = "&Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Image = global::OpenKey.Properties.Resources.pinion_settings_icon;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::OpenKey.Properties.Resources.Log_Out_icon;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // lbiniciar
            // 
            this.lbiniciar.AutoSize = true;
            this.lbiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbiniciar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbiniciar.Location = new System.Drawing.Point(98, 217);
            this.lbiniciar.Name = "lbiniciar";
            this.lbiniciar.Size = new System.Drawing.Size(87, 31);
            this.lbiniciar.TabIndex = 0;
            this.lbiniciar.Text = "Iniciar";
            this.lbiniciar.Click += new System.EventHandler(this.hook_Click_1);
            this.lbiniciar.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lbiniciar.MouseHover += new System.EventHandler(this.hook_MouseHover);
            // 
            // lbparar
            // 
            this.lbparar.AutoSize = true;
            this.lbparar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbparar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbparar.Location = new System.Drawing.Point(98, 306);
            this.lbparar.Name = "lbparar";
            this.lbparar.Size = new System.Drawing.Size(80, 31);
            this.lbparar.TabIndex = 1;
            this.lbparar.Text = "Parar";
            this.lbparar.Click += new System.EventHandler(this.unhook_Click);
            this.lbparar.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lbparar.MouseHover += new System.EventHandler(this.unhook_MouseHover);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(200, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 416);
            this.label3.TabIndex = 9;
            // 
            // lbocultar
            // 
            this.lbocultar.AutoSize = true;
            this.lbocultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbocultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbocultar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbocultar.Location = new System.Drawing.Point(98, 388);
            this.lbocultar.Name = "lbocultar";
            this.lbocultar.Size = new System.Drawing.Size(102, 31);
            this.lbocultar.TabIndex = 2;
            this.lbocultar.Text = "Ocultar";
            this.lbocultar.Click += new System.EventHandler(this.hide_Click);
            this.lbocultar.MouseLeave += new System.EventHandler(this.ocultar_MouseLeave);
            this.lbocultar.MouseHover += new System.EventHandler(this.ocultar_MouseHover);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Black;
            this.status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(-2, 527);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(908, 28);
            this.status.TabIndex = 12;
            this.status.Text = "Listo";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Window;
            this.log.Cursor = System.Windows.Forms.Cursors.Default;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(7, 26);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(666, 295);
            this.log.TabIndex = 20;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(759, 490);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(138, 34);
            this.exit.TabIndex = 14;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // regs
            // 
            this.regs.AutoSize = true;
            this.regs.Cursor = System.Windows.Forms.Cursors.Default;
            this.regs.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regs.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.regs.Location = new System.Drawing.Point(227, 140);
            this.regs.Name = "regs";
            this.regs.Size = new System.Drawing.Size(241, 39);
            this.regs.TabIndex = 0;
            this.regs.Text = "Sin registros...";
            // 
            // Regger
            // 
            this.Regger.Tick += new System.EventHandler(this.Regger_Tick);
            // 
            // Snapper
            // 
            this.Snapper.Tick += new System.EventHandler(this.Snapper_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Live Streaming...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(422, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ctrl + Shift +Alt +F10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Oprima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "para mostrar cuando se oculte";
            // 
            // Cronometro
            // 
            this.Cronometro.Interval = 1000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // pichide
            // 
            this.pichide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pichide.Image = global::OpenKey.Properties.Resources.hide_right_icon;
            this.pichide.Location = new System.Drawing.Point(12, 363);
            this.pichide.Name = "pichide";
            this.pichide.Size = new System.Drawing.Size(80, 80);
            this.pichide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichide.TabIndex = 10;
            this.pichide.TabStop = false;
            this.pichide.Click += new System.EventHandler(this.hide_Click);
            this.pichide.MouseLeave += new System.EventHandler(this.ocultar_MouseLeave);
            this.pichide.MouseHover += new System.EventHandler(this.ocultar_MouseHover);
            // 
            // unhook
            // 
            this.unhook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unhook.Image = global::OpenKey.Properties.Resources.Record_Normal_icon;
            this.unhook.Location = new System.Drawing.Point(12, 279);
            this.unhook.Name = "unhook";
            this.unhook.Size = new System.Drawing.Size(80, 80);
            this.unhook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unhook.TabIndex = 6;
            this.unhook.TabStop = false;
            this.unhook.Click += new System.EventHandler(this.unhook_Click);
            this.unhook.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.unhook.MouseHover += new System.EventHandler(this.unhook_MouseHover);
            // 
            // hook
            // 
            this.hook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hook.Image = global::OpenKey.Properties.Resources.start_icon;
            this.hook.Location = new System.Drawing.Point(12, 193);
            this.hook.Name = "hook";
            this.hook.Size = new System.Drawing.Size(80, 80);
            this.hook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hook.TabIndex = 5;
            this.hook.TabStop = false;
            this.hook.Click += new System.EventHandler(this.hook_Click_1);
            this.hook.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.hook.MouseHover += new System.EventHandler(this.hook_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenKey.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Galeria);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(208, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(691, 362);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.regs);
            this.tabPage1.Controls.Add(this.log);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(683, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Texto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Galeria
            // 
            this.Galeria.AutoScroll = true;
            this.Galeria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Galeria.Location = new System.Drawing.Point(4, 25);
            this.Galeria.Name = "Galeria";
            this.Galeria.Padding = new System.Windows.Forms.Padding(3);
            this.Galeria.Size = new System.Drawing.Size(683, 333);
            this.Galeria.TabIndex = 1;
            this.Galeria.Text = "Galería";
            this.Galeria.UseVisualStyleBackColor = true;
            // 
            // Snapperlocal
            // 
            this.Snapperlocal.Tick += new System.EventHandler(this.Snapperlocal_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(791, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Versión: 0.75.01";
            // 
            // Openkey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 554);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lbocultar);
            this.Controls.Add(this.pichide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbparar);
            this.Controls.Add(this.lbiniciar);
            this.Controls.Add(this.unhook);
            this.Controls.Add(this.hook);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Openkey";
            this.Text = "OpenKey";
            this.Activated += new System.EventHandler(this.openkey_Activated);
            this.Deactivate += new System.EventHandler(this.openkey_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.openkey_FormClosing);
            this.Load += new System.EventHandler(this.openkey_Load);
            this.Shown += new System.EventHandler(this.openkey_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unhook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Logger;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturarM;
        private System.Windows.Forms.ToolStripMenuItem pararM;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox hook;
        private System.Windows.Forms.PictureBox unhook;
        private System.Windows.Forms.Label lbiniciar;
        private System.Windows.Forms.Label lbparar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbocultar;
        private System.Windows.Forms.PictureBox pichide;
        private System.Windows.Forms.ToolStripMenuItem ocultarT;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label regs;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Timer Regger;
        private System.Windows.Forms.Timer Snapper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Galeria;
        private System.Windows.Forms.Timer Snapperlocal;
        private System.Windows.Forms.Label label7;
    }
}

