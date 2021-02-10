
namespace Estructura_de_dades
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Gen = new System.Windows.Forms.Button();
            this.bnt_Mos = new System.Windows.Forms.Button();
            this.bnt_Esb = new System.Windows.Forms.Button();
            this.bnt_inv = new System.Windows.Forms.Button();
            this.ltb_lletres = new System.Windows.Forms.ListBox();
            this.lst_num = new System.Windows.Forms.ListBox();
            this.txb_seq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Gen
            // 
            this.btn_Gen.Location = new System.Drawing.Point(41, 37);
            this.btn_Gen.Name = "btn_Gen";
            this.btn_Gen.Size = new System.Drawing.Size(180, 30);
            this.btn_Gen.TabIndex = 0;
            this.btn_Gen.Text = "Generar Diccionari";
            this.btn_Gen.UseVisualStyleBackColor = true;
            this.btn_Gen.Click += new System.EventHandler(this.btn_Gen_Click);
            // 
            // bnt_Mos
            // 
            this.bnt_Mos.Location = new System.Drawing.Point(251, 37);
            this.bnt_Mos.Name = "bnt_Mos";
            this.bnt_Mos.Size = new System.Drawing.Size(180, 30);
            this.bnt_Mos.TabIndex = 1;
            this.bnt_Mos.Text = "Mostrar Diccionari";
            this.bnt_Mos.UseVisualStyleBackColor = true;
            this.bnt_Mos.Click += new System.EventHandler(this.bnt_Mos_Click);
            // 
            // bnt_Esb
            // 
            this.bnt_Esb.Location = new System.Drawing.Point(456, 37);
            this.bnt_Esb.Name = "bnt_Esb";
            this.bnt_Esb.Size = new System.Drawing.Size(180, 30);
            this.bnt_Esb.TabIndex = 2;
            this.bnt_Esb.Text = "Esborrar Vocals";
            this.bnt_Esb.UseVisualStyleBackColor = true;
            this.bnt_Esb.Click += new System.EventHandler(this.bnt_Esb_Click);
            // 
            // bnt_inv
            // 
            this.bnt_inv.Location = new System.Drawing.Point(445, 362);
            this.bnt_inv.Name = "bnt_inv";
            this.bnt_inv.Size = new System.Drawing.Size(180, 30);
            this.bnt_inv.TabIndex = 3;
            this.bnt_inv.Text = "Invertir Codificacio";
            this.bnt_inv.UseVisualStyleBackColor = true;
            this.bnt_inv.Click += new System.EventHandler(this.bnt_inv_Click);
            // 
            // ltb_lletres
            // 
            this.ltb_lletres.FormattingEnabled = true;
            this.ltb_lletres.ItemHeight = 16;
            this.ltb_lletres.Location = new System.Drawing.Point(41, 88);
            this.ltb_lletres.Name = "ltb_lletres";
            this.ltb_lletres.Size = new System.Drawing.Size(180, 660);
            this.ltb_lletres.TabIndex = 4;
            // 
            // lst_num
            // 
            this.lst_num.FormattingEnabled = true;
            this.lst_num.ItemHeight = 16;
            this.lst_num.Location = new System.Drawing.Point(251, 88);
            this.lst_num.Name = "lst_num";
            this.lst_num.Size = new System.Drawing.Size(180, 660);
            this.lst_num.TabIndex = 5;
            // 
            // txb_seq
            // 
            this.txb_seq.Location = new System.Drawing.Point(635, 139);
            this.txb_seq.Name = "txb_seq";
            this.txb_seq.Size = new System.Drawing.Size(271, 22);
            this.txb_seq.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sequencia de lletres";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(635, 366);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 22);
            this.textBox3.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(635, 204);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 132);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 946);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_seq);
            this.Controls.Add(this.lst_num);
            this.Controls.Add(this.ltb_lletres);
            this.Controls.Add(this.bnt_inv);
            this.Controls.Add(this.bnt_Esb);
            this.Controls.Add(this.bnt_Mos);
            this.Controls.Add(this.btn_Gen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gen;
        private System.Windows.Forms.Button bnt_Mos;
        private System.Windows.Forms.Button bnt_Esb;
        private System.Windows.Forms.Button bnt_inv;
        private System.Windows.Forms.ListBox ltb_lletres;
        private System.Windows.Forms.ListBox lst_num;
        private System.Windows.Forms.TextBox txb_seq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

