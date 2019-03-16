namespace Calculator
{
    partial class Form1
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
            this.LblDisplay = new System.Windows.Forms.Label();
            this.LblHistory = new System.Windows.Forms.Label();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnNeg = new System.Windows.Forms.Button();
            this.BtnEq = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnSep = new System.Windows.Forms.Button();
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.BtnMplus = new System.Windows.Forms.Button();
            this.BtnMminus = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDisplay
            // 
            this.LblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplay.Location = new System.Drawing.Point(25, 39);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(438, 78);
            this.LblDisplay.TabIndex = 0;
            this.LblDisplay.Text = "0";
            this.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblHistory
            // 
            this.LblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHistory.Location = new System.Drawing.Point(45, 7);
            this.LblHistory.Name = "LblHistory";
            this.LblHistory.Size = new System.Drawing.Size(405, 30);
            this.LblHistory.TabIndex = 0;
            this.LblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.Location = new System.Drawing.Point(21, 188);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(99, 80);
            this.BtnCE.TabIndex = 1;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(364, 188);
            this.BtnDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(99, 80);
            this.BtnDiv.TabIndex = 1;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.Location = new System.Drawing.Point(136, 188);
            this.BtnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(99, 80);
            this.BtnC.TabIndex = 1;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Location = new System.Drawing.Point(251, 188);
            this.BtnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(99, 80);
            this.BtnDel.TabIndex = 1;
            this.BtnDel.Text = "Del";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(21, 286);
            this.Btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(99, 80);
            this.Btn7.TabIndex = 1;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMult.Location = new System.Drawing.Point(364, 286);
            this.BtnMult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(99, 80);
            this.BtnMult.TabIndex = 1;
            this.BtnMult.Text = "x";
            this.BtnMult.UseVisualStyleBackColor = false;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(136, 286);
            this.Btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(99, 80);
            this.Btn8.TabIndex = 1;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(251, 286);
            this.Btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(99, 80);
            this.Btn9.TabIndex = 1;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(21, 382);
            this.Btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(99, 80);
            this.Btn4.TabIndex = 1;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.Location = new System.Drawing.Point(364, 382);
            this.BtnSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(99, 80);
            this.BtnSub.TabIndex = 1;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = false;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(136, 382);
            this.Btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(99, 80);
            this.Btn5.TabIndex = 1;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(251, 382);
            this.Btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(99, 80);
            this.Btn6.TabIndex = 1;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(21, 478);
            this.Btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(99, 80);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(364, 478);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(99, 80);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(136, 478);
            this.Btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(99, 80);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(251, 478);
            this.Btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(99, 80);
            this.Btn3.TabIndex = 1;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // BtnNeg
            // 
            this.BtnNeg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNeg.Location = new System.Drawing.Point(21, 576);
            this.BtnNeg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNeg.Name = "BtnNeg";
            this.BtnNeg.Size = new System.Drawing.Size(99, 80);
            this.BtnNeg.TabIndex = 1;
            this.BtnNeg.Text = "+/-";
            this.BtnNeg.UseVisualStyleBackColor = false;
            // 
            // BtnEq
            // 
            this.BtnEq.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEq.Location = new System.Drawing.Point(364, 576);
            this.BtnEq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEq.Name = "BtnEq";
            this.BtnEq.Size = new System.Drawing.Size(99, 80);
            this.BtnEq.TabIndex = 1;
            this.BtnEq.Text = "=";
            this.BtnEq.UseVisualStyleBackColor = false;
            this.BtnEq.Click += new System.EventHandler(this.BtnEq_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(136, 576);
            this.Btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(99, 80);
            this.Btn0.TabIndex = 1;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnSep
            // 
            this.BtnSep.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSep.Location = new System.Drawing.Point(251, 576);
            this.BtnSep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSep.Name = "BtnSep";
            this.BtnSep.Size = new System.Drawing.Size(99, 80);
            this.BtnSep.TabIndex = 1;
            this.BtnSep.Text = ",";
            this.BtnSep.UseVisualStyleBackColor = false;
            // 
            // BtnMC
            // 
            this.BtnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMC.Location = new System.Drawing.Point(25, 139);
            this.BtnMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(75, 32);
            this.BtnMC.TabIndex = 2;
            this.BtnMC.Text = "MC";
            this.BtnMC.UseVisualStyleBackColor = true;
            // 
            // BtnMR
            // 
            this.BtnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMR.Location = new System.Drawing.Point(115, 139);
            this.BtnMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(75, 32);
            this.BtnMR.TabIndex = 2;
            this.BtnMR.Text = "MR";
            this.BtnMR.UseVisualStyleBackColor = true;
            // 
            // BtnMplus
            // 
            this.BtnMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMplus.Location = new System.Drawing.Point(205, 139);
            this.BtnMplus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMplus.Name = "BtnMplus";
            this.BtnMplus.Size = new System.Drawing.Size(75, 32);
            this.BtnMplus.TabIndex = 2;
            this.BtnMplus.Text = "M+";
            this.BtnMplus.UseVisualStyleBackColor = true;
            // 
            // BtnMminus
            // 
            this.BtnMminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMminus.Location = new System.Drawing.Point(295, 139);
            this.BtnMminus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMminus.Name = "BtnMminus";
            this.BtnMminus.Size = new System.Drawing.Size(75, 32);
            this.BtnMminus.TabIndex = 2;
            this.BtnMminus.Text = "M-";
            this.BtnMminus.UseVisualStyleBackColor = true;
            // 
            // BtnMS
            // 
            this.BtnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMS.Location = new System.Drawing.Point(386, 139);
            this.BtnMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(75, 32);
            this.BtnMS.TabIndex = 2;
            this.BtnMS.Text = "MS";
            this.BtnMS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(489, 682);
            this.Controls.Add(this.BtnMS);
            this.Controls.Add(this.BtnMminus);
            this.Controls.Add(this.BtnMplus);
            this.Controls.Add(this.BtnMR);
            this.Controls.Add(this.BtnMC);
            this.Controls.Add(this.BtnSep);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnEq);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnNeg);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.LblHistory);
            this.Controls.Add(this.LblDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblDisplay;
        private System.Windows.Forms.Label LblHistory;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnNeg;
        private System.Windows.Forms.Button BtnEq;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnSep;
        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnMR;
        private System.Windows.Forms.Button BtnMplus;
        private System.Windows.Forms.Button BtnMminus;
        private System.Windows.Forms.Button BtnMS;
    }
}

