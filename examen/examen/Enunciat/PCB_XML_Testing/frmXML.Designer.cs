namespace PCB_XML_Testing
{
    partial class frmXML
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPremis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFidelitat = new System.Windows.Forms.TextBox();
            this.btnGrava = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPremis = new System.Windows.Forms.Button();
            this.btnFidelitat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(157, 67);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Total";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(81, 30);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(34, 20);
            this.txtClient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Premis:";
            // 
            // txtPremis
            // 
            this.txtPremis.Location = new System.Drawing.Point(79, 104);
            this.txtPremis.Name = "txtPremis";
            this.txtPremis.Size = new System.Drawing.Size(58, 20);
            this.txtPremis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fidelitat:";
            // 
            // txtFidelitat
            // 
            this.txtFidelitat.Location = new System.Drawing.Point(79, 140);
            this.txtFidelitat.Name = "txtFidelitat";
            this.txtFidelitat.Size = new System.Drawing.Size(58, 20);
            this.txtFidelitat.TabIndex = 5;
            // 
            // btnGrava
            // 
            this.btnGrava.Location = new System.Drawing.Point(48, 174);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(89, 23);
            this.btnGrava.TabIndex = 7;
            this.btnGrava.Text = "Grava dades";
            this.btnGrava.UseVisualStyleBackColor = true;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(81, 69);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(58, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // btnPremis
            // 
            this.btnPremis.Location = new System.Drawing.Point(157, 107);
            this.btnPremis.Name = "btnPremis";
            this.btnPremis.Size = new System.Drawing.Size(75, 23);
            this.btnPremis.TabIndex = 10;
            this.btnPremis.Text = "Premis";
            this.btnPremis.UseVisualStyleBackColor = true;
            this.btnPremis.Click += new System.EventHandler(this.btnPremis_Click);
            // 
            // btnFidelitat
            // 
            this.btnFidelitat.Location = new System.Drawing.Point(157, 140);
            this.btnFidelitat.Name = "btnFidelitat";
            this.btnFidelitat.Size = new System.Drawing.Size(75, 23);
            this.btnFidelitat.TabIndex = 11;
            this.btnFidelitat.Text = "Fidelitat";
            this.btnFidelitat.UseVisualStyleBackColor = true;
            this.btnFidelitat.Click += new System.EventHandler(this.btnFidelitat_Click);
            // 
            // frmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 234);
            this.Controls.Add(this.btnFidelitat);
            this.Controls.Add(this.btnPremis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnGrava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFidelitat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPremis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.btnLoad);
            this.Name = "frmXML";
            this.Text = "Promocions clients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPremis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFidelitat;
        private System.Windows.Forms.Button btnGrava;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPremis;
        private System.Windows.Forms.Button btnFidelitat;
    }
}

