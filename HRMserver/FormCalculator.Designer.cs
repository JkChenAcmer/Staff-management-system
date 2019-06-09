namespace HRMserver
{
    partial class FormCalculator
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
            this.gbAll = new System.Windows.Forms.GroupBox();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.gbOne = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbTwo = new System.Windows.Forms.GroupBox();
            this.lblTmp = new System.Windows.Forms.Label();
            this.gbAll.SuspendLayout();
            this.gbButton.SuspendLayout();
            this.gbOne.SuspendLayout();
            this.gbTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAll
            // 
            this.gbAll.Controls.Add(this.gbButton);
            this.gbAll.Controls.Add(this.gbOne);
            this.gbAll.Controls.Add(this.gbTwo);
            this.gbAll.Location = new System.Drawing.Point(-1, -8);
            this.gbAll.Name = "gbAll";
            this.gbAll.Size = new System.Drawing.Size(463, 591);
            this.gbAll.TabIndex = 88;
            this.gbAll.TabStop = false;
            // 
            // gbButton
            // 
            this.gbButton.Controls.Add(this.btnSqrt);
            this.gbButton.Controls.Add(this.btnPow);
            this.gbButton.Controls.Add(this.btnClear);
            this.gbButton.Controls.Add(this.btnBack);
            this.gbButton.Controls.Add(this.btnDivide);
            this.gbButton.Controls.Add(this.btnMul);
            this.gbButton.Controls.Add(this.btnSub);
            this.gbButton.Controls.Add(this.btnAdd);
            this.gbButton.Controls.Add(this.btnEqual);
            this.gbButton.Controls.Add(this.btnDot);
            this.gbButton.Controls.Add(this.btn1);
            this.gbButton.Controls.Add(this.btn0);
            this.gbButton.Controls.Add(this.btn2);
            this.gbButton.Controls.Add(this.btn3);
            this.gbButton.Controls.Add(this.btn4);
            this.gbButton.Controls.Add(this.btn5);
            this.gbButton.Controls.Add(this.btn6);
            this.gbButton.Controls.Add(this.btn7);
            this.gbButton.Controls.Add(this.btn8);
            this.gbButton.Controls.Add(this.btn9);
            this.gbButton.Location = new System.Drawing.Point(26, 197);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(406, 367);
            this.gbButton.TabIndex = 90;
            this.gbButton.TabStop = false;
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.SystemColors.Control;
            this.btnSqrt.BackgroundImage = global::HRMserver.Properties.Resources.sqrt;
            this.btnSqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSqrt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSqrt.Location = new System.Drawing.Point(14, 285);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(90, 60);
            this.btnSqrt.TabIndex = 103;
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnPow
            // 
            this.btnPow.BackgroundImage = global::HRMserver.Properties.Resources.pow;
            this.btnPow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPow.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPow.Location = new System.Drawing.Point(14, 21);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(90, 60);
            this.btnPow.TabIndex = 102;
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::HRMserver.Properties.Resources.clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(110, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 60);
            this.btnClear.TabIndex = 101;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::HRMserver.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(206, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 60);
            this.btnBack.TabIndex = 100;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackgroundImage = global::HRMserver.Properties.Resources.dovode;
            this.btnDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDivide.Location = new System.Drawing.Point(301, 21);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(90, 60);
            this.btnDivide.TabIndex = 99;
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackgroundImage = global::HRMserver.Properties.Resources.mul;
            this.btnMul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMul.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMul.Location = new System.Drawing.Point(301, 87);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(90, 60);
            this.btnMul.TabIndex = 98;
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackgroundImage = global::HRMserver.Properties.Resources.sub;
            this.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSub.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSub.Location = new System.Drawing.Point(301, 153);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(90, 60);
            this.btnSub.TabIndex = 97;
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::HRMserver.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(301, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 60);
            this.btnAdd.TabIndex = 96;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackgroundImage = global::HRMserver.Properties.Resources.equal;
            this.btnEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEqual.Location = new System.Drawing.Point(302, 285);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(90, 60);
            this.btnEqual.TabIndex = 95;
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackgroundImage = global::HRMserver.Properties.Resources.dot;
            this.btnDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDot.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDot.Location = new System.Drawing.Point(206, 285);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(90, 60);
            this.btnDot.TabIndex = 94;
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::HRMserver.Properties.Resources._1;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(14, 87);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 60);
            this.btn1.TabIndex = 93;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Control;
            this.btn0.BackgroundImage = global::HRMserver.Properties.Resources._02;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn0.Location = new System.Drawing.Point(110, 285);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 60);
            this.btn0.TabIndex = 92;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.BackgroundImage = global::HRMserver.Properties.Resources._2;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.Location = new System.Drawing.Point(110, 87);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 60);
            this.btn2.TabIndex = 91;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = global::HRMserver.Properties.Resources._3;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.Location = new System.Drawing.Point(206, 87);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 60);
            this.btn3.TabIndex = 90;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = global::HRMserver.Properties.Resources._4;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4.Location = new System.Drawing.Point(14, 153);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 60);
            this.btn4.TabIndex = 89;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = global::HRMserver.Properties.Resources._5;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn5.Location = new System.Drawing.Point(110, 153);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 60);
            this.btn5.TabIndex = 88;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = global::HRMserver.Properties.Resources._6;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6.Location = new System.Drawing.Point(206, 153);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 60);
            this.btn6.TabIndex = 87;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = global::HRMserver.Properties.Resources._7;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn7.Location = new System.Drawing.Point(14, 219);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 60);
            this.btn7.TabIndex = 86;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImage = global::HRMserver.Properties.Resources._8;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn8.Location = new System.Drawing.Point(110, 219);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 60);
            this.btn8.TabIndex = 85;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = global::HRMserver.Properties.Resources._9;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9.Location = new System.Drawing.Point(206, 219);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 60);
            this.btn9.TabIndex = 84;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // gbOne
            // 
            this.gbOne.Controls.Add(this.lblResult);
            this.gbOne.Location = new System.Drawing.Point(26, 21);
            this.gbOne.Name = "gbOne";
            this.gbOne.Size = new System.Drawing.Size(406, 66);
            this.gbOne.TabIndex = 89;
            this.gbOne.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("宋体", 20F);
            this.lblResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResult.Location = new System.Drawing.Point(27, 18);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(360, 36);
            this.lblResult.TabIndex = 84;
            this.lblResult.Text = "label1";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbTwo
            // 
            this.gbTwo.Controls.Add(this.lblTmp);
            this.gbTwo.Location = new System.Drawing.Point(26, 101);
            this.gbTwo.Name = "gbTwo";
            this.gbTwo.Size = new System.Drawing.Size(406, 66);
            this.gbTwo.TabIndex = 88;
            this.gbTwo.TabStop = false;
            // 
            // lblTmp
            // 
            this.lblTmp.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTmp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTmp.Location = new System.Drawing.Point(24, 28);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(360, 21);
            this.lblTmp.TabIndex = 84;
            this.lblTmp.Text = "label1";
            this.lblTmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 578);
            this.Controls.Add(this.gbAll);
            this.Name = "FormCalculator";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.Resize += new System.EventHandler(this.FormCalculator_Resize);
            this.gbAll.ResumeLayout(false);
            this.gbButton.ResumeLayout(false);
            this.gbOne.ResumeLayout(false);
            this.gbTwo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAll;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.GroupBox gbOne;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox gbTwo;
        private System.Windows.Forms.Label lblTmp;
    }
}