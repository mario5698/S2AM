
namespace PCBCripto
{
    partial class servidor_tcp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lbl_messageText = new System.Windows.Forms.Label();
            this.lst_data = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_messageText
            // 
            this.lbl_messageText.AutoSize = true;
            this.lbl_messageText.Location = new System.Drawing.Point(81, 79);
            this.lbl_messageText.Name = "lbl_messageText";
            this.lbl_messageText.Size = new System.Drawing.Size(50, 13);
            this.lbl_messageText.TabIndex = 0;
            this.lbl_messageText.Text = "Message";
            // 
            // lst_data
            // 
            this.lst_data.FormattingEnabled = true;
            this.lst_data.Location = new System.Drawing.Point(84, 131);
            this.lst_data.Name = "lst_data";
            this.lst_data.Size = new System.Drawing.Size(255, 251);
            this.lst_data.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // servidor_tcp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_data);
            this.Controls.Add(this.lbl_messageText);
            this.Name = "servidor_tcp";
            this.Text = "servidor_tcp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_messageText;
        private System.Windows.Forms.ListBox lst_data;
        private System.Windows.Forms.Button button1;
    }
}