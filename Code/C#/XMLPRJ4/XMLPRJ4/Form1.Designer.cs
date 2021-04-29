
namespace XMLPRJ4
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
            this.btn_ltx = new System.Windows.Forms.Button();
            this.btn_xmlD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ltx
            // 
            this.btn_ltx.Location = new System.Drawing.Point(191, 127);
            this.btn_ltx.Name = "btn_ltx";
            this.btn_ltx.Size = new System.Drawing.Size(118, 53);
            this.btn_ltx.TabIndex = 0;
            this.btn_ltx.Text = "LINQ To XML";
            this.btn_ltx.UseVisualStyleBackColor = true;
            this.btn_ltx.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_xmlD
            // 
            this.btn_xmlD.Location = new System.Drawing.Point(330, 127);
            this.btn_xmlD.Name = "btn_xmlD";
            this.btn_xmlD.Size = new System.Drawing.Size(118, 53);
            this.btn_xmlD.TabIndex = 1;
            this.btn_xmlD.Text = "XMLDocument";
            this.btn_xmlD.UseVisualStyleBackColor = true;
            this.btn_xmlD.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xmlD);
            this.Controls.Add(this.btn_ltx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ltx;
        private System.Windows.Forms.Button btn_xmlD;
    }
}

