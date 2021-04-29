
namespace XMLPRJ4
{
    partial class XmlDocumentForm
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
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.cbb_Category = new System.Windows.Forms.ComboBox();
            this.cbb_search = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsb_routes = new System.Windows.Forms.ListBox();
            this.lbl_long = new System.Windows.Forms.Label();
            this.lbl_longText = new System.Windows.Forms.Label();
            this.lbl_routesText = new System.Windows.Forms.Label();
            this.lbl_lat = new System.Windows.Forms.Label();
            this.lbl_LatText = new System.Windows.Forms.Label();
            this.lbl_filiation = new System.Windows.Forms.Label();
            this.lbl_filationText = new System.Windows.Forms.Label();
            this.lbl_natives = new System.Windows.Forms.Label();
            this.lbl_nativesText = new System.Windows.Forms.Label();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.lbl_SectorText = new System.Windows.Forms.Label();
            this.lbl_planet = new System.Windows.Forms.Label();
            this.lbl_planetText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Data
            // 
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(67, 130);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(488, 150);
            this.dgv_Data.TabIndex = 0;
            this.dgv_Data.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Data_RowHeaderMouseClick);
            // 
            // cbb_Category
            // 
            this.cbb_Category.FormattingEnabled = true;
            this.cbb_Category.Location = new System.Drawing.Point(67, 44);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(121, 21);
            this.cbb_Category.TabIndex = 1;
            this.cbb_Category.SelectedIndexChanged += new System.EventHandler(this.cbb_Category_SelectedIndexChanged);
            // 
            // cbb_search
            // 
            this.cbb_search.FormattingEnabled = true;
            this.cbb_search.Location = new System.Drawing.Point(238, 44);
            this.cbb_search.Name = "cbb_search";
            this.cbb_search.Size = new System.Drawing.Size(121, 21);
            this.cbb_search.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(443, 44);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsb_routes);
            this.panel1.Controls.Add(this.lbl_long);
            this.panel1.Controls.Add(this.lbl_longText);
            this.panel1.Controls.Add(this.lbl_routesText);
            this.panel1.Controls.Add(this.lbl_lat);
            this.panel1.Controls.Add(this.lbl_LatText);
            this.panel1.Controls.Add(this.lbl_filiation);
            this.panel1.Controls.Add(this.lbl_filationText);
            this.panel1.Controls.Add(this.lbl_natives);
            this.panel1.Controls.Add(this.lbl_nativesText);
            this.panel1.Controls.Add(this.lbl_sector);
            this.panel1.Controls.Add(this.lbl_SectorText);
            this.panel1.Controls.Add(this.lbl_planet);
            this.panel1.Controls.Add(this.lbl_planetText);
            this.panel1.Location = new System.Drawing.Point(67, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 454);
            this.panel1.TabIndex = 4;
            // 
            // lsb_routes
            // 
            this.lsb_routes.FormattingEnabled = true;
            this.lsb_routes.Location = new System.Drawing.Point(53, 273);
            this.lsb_routes.Name = "lsb_routes";
            this.lsb_routes.Size = new System.Drawing.Size(172, 160);
            this.lsb_routes.TabIndex = 14;
            // 
            // lbl_long
            // 
            this.lbl_long.AutoSize = true;
            this.lbl_long.Location = new System.Drawing.Point(50, 200);
            this.lbl_long.Name = "lbl_long";
            this.lbl_long.Size = new System.Drawing.Size(70, 13);
            this.lbl_long.TabIndex = 13;
            this.lbl_long.Text = "lbl_Longitude";
            // 
            // lbl_longText
            // 
            this.lbl_longText.AutoSize = true;
            this.lbl_longText.Location = new System.Drawing.Point(50, 180);
            this.lbl_longText.Name = "lbl_longText";
            this.lbl_longText.Size = new System.Drawing.Size(54, 13);
            this.lbl_longText.TabIndex = 12;
            this.lbl_longText.Text = "Longitude";
            // 
            // lbl_routesText
            // 
            this.lbl_routesText.AutoSize = true;
            this.lbl_routesText.Location = new System.Drawing.Point(50, 233);
            this.lbl_routesText.Name = "lbl_routesText";
            this.lbl_routesText.Size = new System.Drawing.Size(41, 13);
            this.lbl_routesText.TabIndex = 11;
            this.lbl_routesText.Text = "Routes";
            // 
            // lbl_lat
            // 
            this.lbl_lat.AutoSize = true;
            this.lbl_lat.Location = new System.Drawing.Point(350, 200);
            this.lbl_lat.Name = "lbl_lat";
            this.lbl_lat.Size = new System.Drawing.Size(61, 13);
            this.lbl_lat.TabIndex = 10;
            this.lbl_lat.Text = "lbl_Latitude";
            // 
            // lbl_LatText
            // 
            this.lbl_LatText.AutoSize = true;
            this.lbl_LatText.Location = new System.Drawing.Point(350, 180);
            this.lbl_LatText.Name = "lbl_LatText";
            this.lbl_LatText.Size = new System.Drawing.Size(45, 13);
            this.lbl_LatText.TabIndex = 9;
            this.lbl_LatText.Text = "Latitude";
            // 
            // lbl_filiation
            // 
            this.lbl_filiation.AutoSize = true;
            this.lbl_filiation.Location = new System.Drawing.Point(350, 150);
            this.lbl_filiation.Name = "lbl_filiation";
            this.lbl_filiation.Size = new System.Drawing.Size(56, 13);
            this.lbl_filiation.TabIndex = 8;
            this.lbl_filiation.Text = "lbl_Filation";
            // 
            // lbl_filationText
            // 
            this.lbl_filationText.AutoSize = true;
            this.lbl_filationText.Location = new System.Drawing.Point(350, 130);
            this.lbl_filationText.Name = "lbl_filationText";
            this.lbl_filationText.Size = new System.Drawing.Size(40, 13);
            this.lbl_filationText.TabIndex = 7;
            this.lbl_filationText.Text = "Filation";
            // 
            // lbl_natives
            // 
            this.lbl_natives.AutoSize = true;
            this.lbl_natives.Location = new System.Drawing.Point(50, 150);
            this.lbl_natives.Name = "lbl_natives";
            this.lbl_natives.Size = new System.Drawing.Size(59, 13);
            this.lbl_natives.TabIndex = 6;
            this.lbl_natives.Text = "lbl_Natives";
            // 
            // lbl_nativesText
            // 
            this.lbl_nativesText.AutoSize = true;
            this.lbl_nativesText.Location = new System.Drawing.Point(50, 130);
            this.lbl_nativesText.Name = "lbl_nativesText";
            this.lbl_nativesText.Size = new System.Drawing.Size(43, 13);
            this.lbl_nativesText.TabIndex = 5;
            this.lbl_nativesText.Text = "Natives";
            // 
            // lbl_sector
            // 
            this.lbl_sector.AutoSize = true;
            this.lbl_sector.Location = new System.Drawing.Point(50, 100);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(54, 13);
            this.lbl_sector.TabIndex = 4;
            this.lbl_sector.Text = "lbl_Sector";
            // 
            // lbl_SectorText
            // 
            this.lbl_SectorText.AutoSize = true;
            this.lbl_SectorText.Location = new System.Drawing.Point(50, 80);
            this.lbl_SectorText.Name = "lbl_SectorText";
            this.lbl_SectorText.Size = new System.Drawing.Size(38, 13);
            this.lbl_SectorText.TabIndex = 3;
            this.lbl_SectorText.Text = "Sector";
            // 
            // lbl_planet
            // 
            this.lbl_planet.AutoSize = true;
            this.lbl_planet.Location = new System.Drawing.Point(50, 50);
            this.lbl_planet.Name = "lbl_planet";
            this.lbl_planet.Size = new System.Drawing.Size(53, 13);
            this.lbl_planet.TabIndex = 2;
            this.lbl_planet.Text = "lbl_Planet";
            // 
            // lbl_planetText
            // 
            this.lbl_planetText.AutoSize = true;
            this.lbl_planetText.Location = new System.Drawing.Point(50, 30);
            this.lbl_planetText.Name = "lbl_planetText";
            this.lbl_planetText.Size = new System.Drawing.Size(36, 13);
            this.lbl_planetText.TabIndex = 1;
            this.lbl_planetText.Text = "planet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(888, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // XmlDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 844);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cbb_search);
            this.Controls.Add(this.cbb_Category);
            this.Controls.Add(this.dgv_Data);
            this.Name = "XmlDocumentForm";
            this.Text = "XmlDocument";
            this.Load += new System.EventHandler(this.XmlDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.ComboBox cbb_Category;
        private System.Windows.Forms.ComboBox cbb_search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_long;
        private System.Windows.Forms.Label lbl_longText;
        private System.Windows.Forms.Label lbl_routesText;
        private System.Windows.Forms.Label lbl_lat;
        private System.Windows.Forms.Label lbl_LatText;
        private System.Windows.Forms.Label lbl_filiation;
        private System.Windows.Forms.Label lbl_filationText;
        private System.Windows.Forms.Label lbl_natives;
        private System.Windows.Forms.Label lbl_nativesText;
        private System.Windows.Forms.Label lbl_sector;
        private System.Windows.Forms.Label lbl_SectorText;
        private System.Windows.Forms.Label lbl_planet;
        private System.Windows.Forms.Label lbl_planetText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lsb_routes;
    }
}