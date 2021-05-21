namespace PCB_TPL_Fitxers
{
    partial class frmTPL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTOT = new System.Windows.Forms.Label();
            this.lblresultat = new System.Windows.Forms.Label();
            this.btnTPL = new System.Windows.Forms.Button();
            this.btnCompara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fitxer1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fitxer2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fitxer3";
            // 
            // labelTOT
            // 
            this.labelTOT.AutoSize = true;
            this.labelTOT.Location = new System.Drawing.Point(171, 199);
            this.labelTOT.Name = "labelTOT";
            this.labelTOT.Size = new System.Drawing.Size(54, 13);
            this.labelTOT.TabIndex = 4;
            this.labelTOT.Text = "FitxerFinal";
            // 
            // lblresultat
            // 
            this.lblresultat.AutoSize = true;
            this.lblresultat.Location = new System.Drawing.Point(438, 60);
            this.lblresultat.Name = "lblresultat";
            this.lblresultat.Size = new System.Drawing.Size(63, 13);
            this.lblresultat.TabIndex = 6;
            this.lblresultat.Text = "Comparació";
            // 
            // btnTPL
            // 
            this.btnTPL.Location = new System.Drawing.Point(68, 39);
            this.btnTPL.Name = "btnTPL";
            this.btnTPL.Size = new System.Drawing.Size(75, 42);
            this.btnTPL.TabIndex = 8;
            this.btnTPL.Text = "Executar proces";
            this.btnTPL.UseVisualStyleBackColor = true;
            this.btnTPL.Click += new System.EventHandler(this.btnTPL_Click);
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(334, 39);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(75, 42);
            this.btnCompara.TabIndex = 9;
            this.btnCompara.Text = "Comparar fitxers";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // frmTPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 234);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.btnTPL);
            this.Controls.Add(this.lblresultat);
            this.Controls.Add(this.labelTOT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTPL";
            this.Text = "TPL i Streams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTOT;
        private System.Windows.Forms.Label lblresultat;
        private System.Windows.Forms.Button btnTPL;
        private System.Windows.Forms.Button btnCompara;
    }
}

