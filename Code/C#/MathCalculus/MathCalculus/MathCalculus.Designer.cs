
namespace MathCalculus
{
    partial class MathCalculus
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
            this.btn_Number = new System.Windows.Forms.Button();
            this.btn_CMD = new System.Windows.Forms.Button();
            this.btn_MCM = new System.Windows.Forms.Button();
            this.btn_Calculs = new System.Windows.Forms.Button();
            this.lbl_Num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_CMD = new System.Windows.Forms.Label();
            this.lbl_MCM = new System.Windows.Forms.Label();
            this.lbl_ResultCMD = new System.Windows.Forms.Label();
            this.LBL_Result_MCM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_Results = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Number
            // 
            this.btn_Number.Location = new System.Drawing.Point(94, 40);
            this.btn_Number.Name = "btn_Number";
            this.btn_Number.Size = new System.Drawing.Size(75, 23);
            this.btn_Number.TabIndex = 0;
            this.btn_Number.Text = "Numbers";
            this.btn_Number.UseVisualStyleBackColor = true;
            this.btn_Number.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_CMD
            // 
            this.btn_CMD.Location = new System.Drawing.Point(94, 129);
            this.btn_CMD.Name = "btn_CMD";
            this.btn_CMD.Size = new System.Drawing.Size(75, 23);
            this.btn_CMD.TabIndex = 1;
            this.btn_CMD.Text = "C.M.D";
            this.btn_CMD.UseVisualStyleBackColor = true;
            this.btn_CMD.Click += new System.EventHandler(this.btn_CMD_Click);
            // 
            // btn_MCM
            // 
            this.btn_MCM.Location = new System.Drawing.Point(94, 174);
            this.btn_MCM.Name = "btn_MCM";
            this.btn_MCM.Size = new System.Drawing.Size(75, 23);
            this.btn_MCM.TabIndex = 2;
            this.btn_MCM.Text = "M.C.M";
            this.btn_MCM.UseVisualStyleBackColor = true;
            this.btn_MCM.Click += new System.EventHandler(this.btn_MCM_Click);
            // 
            // btn_Calculs
            // 
            this.btn_Calculs.Location = new System.Drawing.Point(56, 227);
            this.btn_Calculs.Name = "btn_Calculs";
            this.btn_Calculs.Size = new System.Drawing.Size(113, 23);
            this.btn_Calculs.TabIndex = 3;
            this.btn_Calculs.Text = "Set de Calculs";
            this.btn_Calculs.UseVisualStyleBackColor = true;
            this.btn_Calculs.Click += new System.EventHandler(this.btn_Calculs_Click);
            // 
            // lbl_Num1
            // 
            this.lbl_Num1.AutoSize = true;
            this.lbl_Num1.Location = new System.Drawing.Point(213, 45);
            this.lbl_Num1.Name = "lbl_Num1";
            this.lbl_Num1.Size = new System.Drawing.Size(13, 13);
            this.lbl_Num1.TabIndex = 4;
            this.lbl_Num1.Text = "0";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(257, 45);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(13, 13);
            this.lbl_num2.TabIndex = 5;
            this.lbl_num2.Text = "0";
            // 
            // lbl_CMD
            // 
            this.lbl_CMD.AutoSize = true;
            this.lbl_CMD.Location = new System.Drawing.Point(213, 134);
            this.lbl_CMD.Name = "lbl_CMD";
            this.lbl_CMD.Size = new System.Drawing.Size(67, 13);
            this.lbl_CMD.TabIndex = 6;
            this.lbl_CMD.Text = "Result CMD:";
            // 
            // lbl_MCM
            // 
            this.lbl_MCM.AutoSize = true;
            this.lbl_MCM.Location = new System.Drawing.Point(213, 184);
            this.lbl_MCM.Name = "lbl_MCM";
            this.lbl_MCM.Size = new System.Drawing.Size(68, 13);
            this.lbl_MCM.TabIndex = 7;
            this.lbl_MCM.Text = "Result MCM:";
            // 
            // lbl_ResultCMD
            // 
            this.lbl_ResultCMD.AutoSize = true;
            this.lbl_ResultCMD.Location = new System.Drawing.Point(298, 134);
            this.lbl_ResultCMD.Name = "lbl_ResultCMD";
            this.lbl_ResultCMD.Size = new System.Drawing.Size(13, 13);
            this.lbl_ResultCMD.TabIndex = 8;
            this.lbl_ResultCMD.Text = "0";
            // 
            // LBL_Result_MCM
            // 
            this.LBL_Result_MCM.AutoSize = true;
            this.LBL_Result_MCM.Location = new System.Drawing.Point(298, 179);
            this.LBL_Result_MCM.Name = "LBL_Result_MCM";
            this.LBL_Result_MCM.Size = new System.Drawing.Size(13, 13);
            this.LBL_Result_MCM.TabIndex = 9;
            this.LBL_Result_MCM.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result: ";
            // 
            // lst_Results
            // 
            this.lst_Results.FormattingEnabled = true;
            this.lst_Results.Location = new System.Drawing.Point(216, 263);
            this.lst_Results.Name = "lst_Results";
            this.lst_Results.Size = new System.Drawing.Size(120, 160);
            this.lst_Results.TabIndex = 11;
            // 
            // MathCalculus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_Results);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBL_Result_MCM);
            this.Controls.Add(this.lbl_ResultCMD);
            this.Controls.Add(this.lbl_MCM);
            this.Controls.Add(this.lbl_CMD);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_Num1);
            this.Controls.Add(this.btn_Calculs);
            this.Controls.Add(this.btn_MCM);
            this.Controls.Add(this.btn_CMD);
            this.Controls.Add(this.btn_Number);
            this.Name = "MathCalculus";
            this.Text = "MathCalculus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Number;
        private System.Windows.Forms.Button btn_CMD;
        private System.Windows.Forms.Button btn_MCM;
        private System.Windows.Forms.Button btn_Calculs;
        private System.Windows.Forms.Label lbl_Num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_CMD;
        private System.Windows.Forms.Label lbl_MCM;
        private System.Windows.Forms.Label lbl_ResultCMD;
        private System.Windows.Forms.Label LBL_Result_MCM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_Results;
    }
}