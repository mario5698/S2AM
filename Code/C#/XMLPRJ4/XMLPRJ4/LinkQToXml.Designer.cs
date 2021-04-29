
namespace XMLPRJ4
{
    partial class LinkQToXml
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_CarregarDades = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Spaceship = new System.Windows.Forms.Label();
            this.lbl_Armamanet = new System.Windows.Forms.Label();
            this.lbl_HyperDrive = new System.Windows.Forms.Label();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Manufacturer = new System.Windows.Forms.Label();
            this.lbl_Shielding = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(69, 115);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 258);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.TabIndexChanged += new System.EventHandler(this.treeView1_TabIndexChanged);
            // 
            // btn_CarregarDades
            // 
            this.btn_CarregarDades.Location = new System.Drawing.Point(69, 45);
            this.btn_CarregarDades.Name = "btn_CarregarDades";
            this.btn_CarregarDades.Size = new System.Drawing.Size(121, 23);
            this.btn_CarregarDades.TabIndex = 1;
            this.btn_CarregarDades.Text = "Carregar Dades";
            this.btn_CarregarDades.UseVisualStyleBackColor = true;
            this.btn_CarregarDades.Click += new System.EventHandler(this.btn_CarregarDades_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.image);
            this.panel1.Controls.Add(this.lbl_Spaceship);
            this.panel1.Controls.Add(this.lbl_Armamanet);
            this.panel1.Controls.Add(this.lbl_HyperDrive);
            this.panel1.Controls.Add(this.lbl_Length);
            this.panel1.Controls.Add(this.lbl_Manufacturer);
            this.panel1.Controls.Add(this.lbl_Shielding);
            this.panel1.Controls.Add(this.lbl_speed);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(226, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 509);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lbl_Spaceship
            // 
            this.lbl_Spaceship.Location = new System.Drawing.Point(54, 72);
            this.lbl_Spaceship.Name = "lbl_Spaceship";
            this.lbl_Spaceship.Size = new System.Drawing.Size(492, 173);
            this.lbl_Spaceship.TabIndex = 13;
            this.lbl_Spaceship.Tag = "textInfoDetail";
            this.lbl_Spaceship.Text = "lbl_Spaceship";
            // 
            // lbl_Armamanet
            // 
            this.lbl_Armamanet.AutoSize = true;
            this.lbl_Armamanet.Location = new System.Drawing.Point(50, 460);
            this.lbl_Armamanet.Name = "lbl_Armamanet";
            this.lbl_Armamanet.Size = new System.Drawing.Size(76, 13);
            this.lbl_Armamanet.TabIndex = 12;
            this.lbl_Armamanet.Tag = "Armament";
            this.lbl_Armamanet.Text = "lbl_Armamanet";
            // 
            // lbl_HyperDrive
            // 
            this.lbl_HyperDrive.AutoSize = true;
            this.lbl_HyperDrive.Location = new System.Drawing.Point(50, 410);
            this.lbl_HyperDrive.Name = "lbl_HyperDrive";
            this.lbl_HyperDrive.Size = new System.Drawing.Size(76, 13);
            this.lbl_HyperDrive.TabIndex = 11;
            this.lbl_HyperDrive.Tag = "Hyperdrive";
            this.lbl_HyperDrive.Text = "lbl_HyperDrive";
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(50, 360);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(46, 13);
            this.lbl_Length.TabIndex = 10;
            this.lbl_Length.Tag = "Length";
            this.lbl_Length.Text = "lbl_lengt";
            // 
            // lbl_Manufacturer
            // 
            this.lbl_Manufacturer.AutoSize = true;
            this.lbl_Manufacturer.Location = new System.Drawing.Point(50, 310);
            this.lbl_Manufacturer.Name = "lbl_Manufacturer";
            this.lbl_Manufacturer.Size = new System.Drawing.Size(86, 13);
            this.lbl_Manufacturer.TabIndex = 9;
            this.lbl_Manufacturer.Tag = "Manufacturer";
            this.lbl_Manufacturer.Text = "lbl_Manufacturer";
            // 
            // lbl_Shielding
            // 
            this.lbl_Shielding.AutoSize = true;
            this.lbl_Shielding.Location = new System.Drawing.Point(309, 398);
            this.lbl_Shielding.Name = "lbl_Shielding";
            this.lbl_Shielding.Size = new System.Drawing.Size(66, 13);
            this.lbl_Shielding.TabIndex = 8;
            this.lbl_Shielding.Tag = "Shielding";
            this.lbl_Shielding.Text = "lbl_Shielding";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(309, 337);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(55, 13);
            this.lbl_speed.TabIndex = 7;
            this.lbl_speed.Tag = "Speed";
            this.lbl_speed.Text = " lbl_speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Tag = "hola";
            this.label7.Text = "Shielding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Tag = "hola";
            this.label6.Text = "Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Tag = "hola";
            this.label5.Text = "Armamanet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Tag = "hola";
            this.label4.Text = "HyperDrive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Tag = "hola";
            this.label3.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "hola";
            this.label2.Text = "Manufacturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "hola";
            this.label1.Text = "SpaceShip Description";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(660, 36);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(470, 399);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 3;
            this.image.TabStop = false;
            this.image.Tag = "image";
            // 
            // LinkQToXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_CarregarDades);
            this.Name = "LinkQToXml";
            this.Text = "LinkQToXml";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_CarregarDades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Spaceship;
        private System.Windows.Forms.Label lbl_Armamanet;
        private System.Windows.Forms.Label lbl_HyperDrive;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Manufacturer;
        private System.Windows.Forms.Label lbl_Shielding;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox image;
    }
}