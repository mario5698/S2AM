
namespace Flis_i_fitxers
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
            this.lbl_num_fitxers = new System.Windows.Forms.Label();
            this.lbl_num_lletres = new System.Windows.Forms.Label();
            this.txb_num_fitxers = new System.Windows.Forms.TextBox();
            this.tbx_num_lletres = new System.Windows.Forms.TextBox();
            this.btn_gen_Codificacio = new System.Windows.Forms.Button();
            this.btn_gen_Fitxers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_num_fitxers
            // 
            this.lbl_num_fitxers.AutoSize = true;
            this.lbl_num_fitxers.Location = new System.Drawing.Point(88, 105);
            this.lbl_num_fitxers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_num_fitxers.Name = "lbl_num_fitxers";
            this.lbl_num_fitxers.Size = new System.Drawing.Size(123, 17);
            this.lbl_num_fitxers.TabIndex = 0;
            this.lbl_num_fitxers.Text = "Número de Fitxers";
            // 
            // lbl_num_lletres
            // 
            this.lbl_num_lletres.AutoSize = true;
            this.lbl_num_lletres.Location = new System.Drawing.Point(100, 160);
            this.lbl_num_lletres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_num_lletres.Name = "lbl_num_lletres";
            this.lbl_num_lletres.Size = new System.Drawing.Size(120, 17);
            this.lbl_num_lletres.TabIndex = 3;
            this.lbl_num_lletres.Text = "Número de lletres";
            // 
            // txb_num_fitxers
            // 
            this.txb_num_fitxers.Location = new System.Drawing.Point(301, 105);
            this.txb_num_fitxers.Margin = new System.Windows.Forms.Padding(4);
            this.txb_num_fitxers.Name = "txb_num_fitxers";
            this.txb_num_fitxers.Size = new System.Drawing.Size(132, 22);
            this.txb_num_fitxers.TabIndex = 4;
            // 
            // tbx_num_lletres
            // 
            this.tbx_num_lletres.Location = new System.Drawing.Point(301, 160);
            this.tbx_num_lletres.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_num_lletres.Name = "tbx_num_lletres";
            this.tbx_num_lletres.Size = new System.Drawing.Size(132, 22);
            this.tbx_num_lletres.TabIndex = 5;
            // 
            // btn_gen_Codificacio
            // 
            this.btn_gen_Codificacio.Location = new System.Drawing.Point(137, 270);
            this.btn_gen_Codificacio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gen_Codificacio.Name = "btn_gen_Codificacio";
            this.btn_gen_Codificacio.Size = new System.Drawing.Size(155, 78);
            this.btn_gen_Codificacio.TabIndex = 6;
            this.btn_gen_Codificacio.Text = "Generar Codificació";
            this.btn_gen_Codificacio.UseVisualStyleBackColor = true;
            this.btn_gen_Codificacio.Click += new System.EventHandler(this.btn_gen_Codificacio_Click);
            // 
            // btn_gen_Fitxers
            // 
            this.btn_gen_Fitxers.Location = new System.Drawing.Point(301, 270);
            this.btn_gen_Fitxers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gen_Fitxers.Name = "btn_gen_Fitxers";
            this.btn_gen_Fitxers.Size = new System.Drawing.Size(155, 78);
            this.btn_gen_Fitxers.TabIndex = 7;
            this.btn_gen_Fitxers.Text = "Generar Fitxer";
            this.btn_gen_Fitxers.UseVisualStyleBackColor = true;
            this.btn_gen_Fitxers.Click += new System.EventHandler(this.btn_gen_Fitxers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_gen_Fitxers);
            this.Controls.Add(this.btn_gen_Codificacio);
            this.Controls.Add(this.tbx_num_lletres);
            this.Controls.Add(this.txb_num_fitxers);
            this.Controls.Add(this.lbl_num_lletres);
            this.Controls.Add(this.lbl_num_fitxers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num_fitxers;
        private System.Windows.Forms.Label lbl_num_lletres;
        private System.Windows.Forms.TextBox txb_num_fitxers;
        private System.Windows.Forms.TextBox tbx_num_lletres;
        private System.Windows.Forms.Button btn_gen_Codificacio;
        private System.Windows.Forms.Button btn_gen_Fitxers;
    }
}

