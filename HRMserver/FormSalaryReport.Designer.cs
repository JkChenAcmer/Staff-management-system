namespace HRMserver
{
    partial class FormSalaryReport
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
            this.gbOne = new System.Windows.Forms.GroupBox();
            this.crvSalaryReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbDept = new System.Windows.Forms.ComboBox();
            this.btnInsure = new System.Windows.Forms.Button();
            this.gbOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOne
            // 
            this.gbOne.Controls.Add(this.crvSalaryReport);
            this.gbOne.Location = new System.Drawing.Point(12, 61);
            this.gbOne.Name = "gbOne";
            this.gbOne.Size = new System.Drawing.Size(914, 535);
            this.gbOne.TabIndex = 0;
            this.gbOne.TabStop = false;
            // 
            // crvSalaryReport
            // 
            this.crvSalaryReport.ActiveViewIndex = -1;
            this.crvSalaryReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalaryReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalaryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalaryReport.Location = new System.Drawing.Point(3, 17);
            this.crvSalaryReport.Name = "crvSalaryReport";
            this.crvSalaryReport.Size = new System.Drawing.Size(908, 515);
            this.crvSalaryReport.TabIndex = 0;
            // 
            // cbbYear
            // 
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(31, 24);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(121, 28);
            this.cbbYear.TabIndex = 1;
            // 
            // cbbMonth
            // 
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Location = new System.Drawing.Point(202, 24);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(121, 28);
            this.cbbMonth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(158, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(329, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(511, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "部门";
            // 
            // cbbDept
            // 
            this.cbbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDept.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbDept.FormattingEnabled = true;
            this.cbbDept.Location = new System.Drawing.Point(384, 24);
            this.cbbDept.Name = "cbbDept";
            this.cbbDept.Size = new System.Drawing.Size(121, 28);
            this.cbbDept.TabIndex = 6;
            // 
            // btnInsure
            // 
            this.btnInsure.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsure.Location = new System.Drawing.Point(831, 23);
            this.btnInsure.Name = "btnInsure";
            this.btnInsure.Size = new System.Drawing.Size(92, 29);
            this.btnInsure.TabIndex = 7;
            this.btnInsure.Text = "生成";
            this.btnInsure.UseVisualStyleBackColor = true;
            this.btnInsure.Click += new System.EventHandler(this.btnInsure_Click);
            // 
            // FormSalaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 608);
            this.Controls.Add(this.btnInsure);
            this.Controls.Add(this.cbbDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.gbOne);
            this.Name = "FormSalaryReport";
            this.Text = "工资报表";
            this.Load += new System.EventHandler(this.FormSalaryReport_Load);
            this.Resize += new System.EventHandler(this.FormSalaryReport_Resize);
            this.gbOne.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOne;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalaryReport;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbDept;
        private System.Windows.Forms.Button btnInsure;
    }
}