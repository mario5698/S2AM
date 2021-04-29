
namespace PCBCripto
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
            this.tbx_original = new System.Windows.Forms.TextBox();
            this.btn_genKey = new System.Windows.Forms.Button();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.lbl_exKey = new System.Windows.Forms.Button();
            this.btn_exEncrypt = new System.Windows.Forms.Button();
            this.btn_exDecrypt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbx_desencriptat = new System.Windows.Forms.TextBox();
            this.tbx_encriptat = new System.Windows.Forms.TextBox();
            this.tbx_exEncriptar = new System.Windows.Forms.TextBox();
            this.tbx_exOringinal = new System.Windows.Forms.TextBox();
            this.lbl_desencriptatText = new System.Windows.Forms.Label();
            this.lbl_encriptatText = new System.Windows.Forms.Label();
            this.lbl_originalText = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tbx_exDesencriptar = new System.Windows.Forms.TextBox();
            this.lbl_exOriginalText = new System.Windows.Forms.Label();
            this.lbl_exEncriptatKey = new System.Windows.Forms.Label();
            this.lbl_exDesencriptatKey = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_original
            // 
            this.tbx_original.Location = new System.Drawing.Point(85, 121);
            this.tbx_original.Name = "tbx_original";
            this.tbx_original.Size = new System.Drawing.Size(190, 20);
            this.tbx_original.TabIndex = 0;
            // 
            // btn_genKey
            // 
            this.btn_genKey.Location = new System.Drawing.Point(37, 35);
            this.btn_genKey.Name = "btn_genKey";
            this.btn_genKey.Size = new System.Drawing.Size(110, 48);
            this.btn_genKey.TabIndex = 1;
            this.btn_genKey.Text = "Generar Key";
            this.btn_genKey.UseVisualStyleBackColor = true;
            this.btn_genKey.Click += new System.EventHandler(this.btn_genKey_Click);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(333, 119);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 2;
            this.btn_encrypt.Text = "Encriptar";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(333, 165);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_decrypt.TabIndex = 3;
            this.btn_decrypt.Text = "Desencriptar";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // lbl_exKey
            // 
            this.lbl_exKey.Location = new System.Drawing.Point(478, 35);
            this.lbl_exKey.Name = "lbl_exKey";
            this.lbl_exKey.Size = new System.Drawing.Size(75, 23);
            this.lbl_exKey.TabIndex = 5;
            this.lbl_exKey.Text = "load External Key";
            this.lbl_exKey.UseVisualStyleBackColor = true;
            this.lbl_exKey.Click += new System.EventHandler(this.lbl_exKey_Click);
            // 
            // btn_exEncrypt
            // 
            this.btn_exEncrypt.Location = new System.Drawing.Point(757, 119);
            this.btn_exEncrypt.Name = "btn_exEncrypt";
            this.btn_exEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_exEncrypt.TabIndex = 6;
            this.btn_exEncrypt.Text = "Encriptar";
            this.btn_exEncrypt.UseVisualStyleBackColor = true;
            this.btn_exEncrypt.Click += new System.EventHandler(this.btn_exEncrypt_Click);
            // 
            // btn_exDecrypt
            // 
            this.btn_exDecrypt.Location = new System.Drawing.Point(757, 165);
            this.btn_exDecrypt.Name = "btn_exDecrypt";
            this.btn_exDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_exDecrypt.TabIndex = 7;
            this.btn_exDecrypt.Text = "Desencriptar";
            this.btn_exDecrypt.UseVisualStyleBackColor = true;
            this.btn_exDecrypt.Click += new System.EventHandler(this.btn_exDecrypt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(74, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 139);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "TCP unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Messatge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(271, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Send";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // tbx_desencriptat
            // 
            this.tbx_desencriptat.Location = new System.Drawing.Point(85, 218);
            this.tbx_desencriptat.Name = "tbx_desencriptat";
            this.tbx_desencriptat.Size = new System.Drawing.Size(190, 20);
            this.tbx_desencriptat.TabIndex = 10;
            // 
            // tbx_encriptat
            // 
            this.tbx_encriptat.Location = new System.Drawing.Point(85, 167);
            this.tbx_encriptat.Name = "tbx_encriptat";
            this.tbx_encriptat.Size = new System.Drawing.Size(190, 20);
            this.tbx_encriptat.TabIndex = 11;
            // 
            // tbx_exEncriptar
            // 
            this.tbx_exEncriptar.Location = new System.Drawing.Point(545, 165);
            this.tbx_exEncriptar.Name = "tbx_exEncriptar";
            this.tbx_exEncriptar.Size = new System.Drawing.Size(194, 20);
            this.tbx_exEncriptar.TabIndex = 14;
            // 
            // tbx_exOringinal
            // 
            this.tbx_exOringinal.Location = new System.Drawing.Point(545, 119);
            this.tbx_exOringinal.Name = "tbx_exOringinal";
            this.tbx_exOringinal.Size = new System.Drawing.Size(194, 20);
            this.tbx_exOringinal.TabIndex = 12;
            // 
            // lbl_desencriptatText
            // 
            this.lbl_desencriptatText.AutoSize = true;
            this.lbl_desencriptatText.Location = new System.Drawing.Point(12, 221);
            this.lbl_desencriptatText.Name = "lbl_desencriptatText";
            this.lbl_desencriptatText.Size = new System.Drawing.Size(67, 13);
            this.lbl_desencriptatText.TabIndex = 13;
            this.lbl_desencriptatText.Text = "Desencriptat";
            // 
            // lbl_encriptatText
            // 
            this.lbl_encriptatText.AutoSize = true;
            this.lbl_encriptatText.Location = new System.Drawing.Point(12, 170);
            this.lbl_encriptatText.Name = "lbl_encriptatText";
            this.lbl_encriptatText.Size = new System.Drawing.Size(49, 13);
            this.lbl_encriptatText.TabIndex = 15;
            this.lbl_encriptatText.Text = "Encriptat";
            // 
            // lbl_originalText
            // 
            this.lbl_originalText.AutoSize = true;
            this.lbl_originalText.Location = new System.Drawing.Point(12, 119);
            this.lbl_originalText.Name = "lbl_originalText";
            this.lbl_originalText.Size = new System.Drawing.Size(42, 13);
            this.lbl_originalText.TabIndex = 16;
            this.lbl_originalText.Text = "Original";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(15, 293);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(334, 190);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "xml private key";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(469, 293);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(334, 190);
            this.textBox8.TabIndex = 18;
            this.textBox8.Text = "xml public key";
            // 
            // tbx_exDesencriptar
            // 
            this.tbx_exDesencriptar.Location = new System.Drawing.Point(545, 214);
            this.tbx_exDesencriptar.Name = "tbx_exDesencriptar";
            this.tbx_exDesencriptar.Size = new System.Drawing.Size(194, 20);
            this.tbx_exDesencriptar.TabIndex = 19;
            // 
            // lbl_exOriginalText
            // 
            this.lbl_exOriginalText.AutoSize = true;
            this.lbl_exOriginalText.Location = new System.Drawing.Point(466, 124);
            this.lbl_exOriginalText.Name = "lbl_exOriginalText";
            this.lbl_exOriginalText.Size = new System.Drawing.Size(42, 13);
            this.lbl_exOriginalText.TabIndex = 22;
            this.lbl_exOriginalText.Text = "Original";
            // 
            // lbl_exEncriptatKey
            // 
            this.lbl_exEncriptatKey.AutoSize = true;
            this.lbl_exEncriptatKey.Location = new System.Drawing.Point(466, 175);
            this.lbl_exEncriptatKey.Name = "lbl_exEncriptatKey";
            this.lbl_exEncriptatKey.Size = new System.Drawing.Size(49, 13);
            this.lbl_exEncriptatKey.TabIndex = 21;
            this.lbl_exEncriptatKey.Text = "Encriptat";
            // 
            // lbl_exDesencriptatKey
            // 
            this.lbl_exDesencriptatKey.AutoSize = true;
            this.lbl_exDesencriptatKey.Location = new System.Drawing.Point(466, 226);
            this.lbl_exDesencriptatKey.Name = "lbl_exDesencriptatKey";
            this.lbl_exDesencriptatKey.Size = new System.Drawing.Size(67, 13);
            this.lbl_exDesencriptatKey.TabIndex = 20;
            this.lbl_exDesencriptatKey.Text = "Desencriptat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 708);
            this.Controls.Add(this.lbl_exOriginalText);
            this.Controls.Add(this.lbl_exEncriptatKey);
            this.Controls.Add(this.lbl_exDesencriptatKey);
            this.Controls.Add(this.tbx_exDesencriptar);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lbl_originalText);
            this.Controls.Add(this.lbl_encriptatText);
            this.Controls.Add(this.lbl_desencriptatText);
            this.Controls.Add(this.tbx_exEncriptar);
            this.Controls.Add(this.tbx_exOringinal);
            this.Controls.Add(this.tbx_encriptat);
            this.Controls.Add(this.tbx_desencriptat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exDecrypt);
            this.Controls.Add(this.btn_exEncrypt);
            this.Controls.Add(this.lbl_exKey);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.btn_genKey);
            this.Controls.Add(this.tbx_original);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_original;
        private System.Windows.Forms.Button btn_genKey;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button lbl_exKey;
        private System.Windows.Forms.Button btn_exEncrypt;
        private System.Windows.Forms.Button btn_exDecrypt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_desencriptat;
        private System.Windows.Forms.TextBox tbx_encriptat;
        private System.Windows.Forms.TextBox tbx_exEncriptar;
        private System.Windows.Forms.TextBox tbx_exOringinal;
        private System.Windows.Forms.Label lbl_desencriptatText;
        private System.Windows.Forms.Label lbl_encriptatText;
        private System.Windows.Forms.Label lbl_originalText;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tbx_exDesencriptar;
        private System.Windows.Forms.Label lbl_exOriginalText;
        private System.Windows.Forms.Label lbl_exEncriptatKey;
        private System.Windows.Forms.Label lbl_exDesencriptatKey;
    }
}

