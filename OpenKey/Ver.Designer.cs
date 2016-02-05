using System.ComponentModel;
using System.Windows.Forms;

namespace OpenKey
{
    partial class Ver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver));
            this.texto = new System.Windows.Forms.TextBox();
            this.regs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(3, 2);
            this.texto.Multiline = true;
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            this.texto.Size = new System.Drawing.Size(779, 439);
            this.texto.TabIndex = 0;
            // 
            // regs
            // 
            this.regs.AutoSize = true;
            this.regs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regs.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regs.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.regs.Location = new System.Drawing.Point(261, 198);
            this.regs.Name = "regs";
            this.regs.Size = new System.Drawing.Size(241, 39);
            this.regs.TabIndex = 1;
            this.regs.Text = "Sin registros...";
            // 
            // Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.regs);
            this.Controls.Add(this.texto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ver";
            this.Text = "Ver";
            this.Load += new System.EventHandler(this.Ver_Load);
            this.Resize += new System.EventHandler(this.Ver_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox texto;
        private Label regs;

    }
}