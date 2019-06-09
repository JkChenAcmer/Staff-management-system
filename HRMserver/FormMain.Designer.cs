namespace HRMserver
{
    partial class FormMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDraft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeOperator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccountManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOperatorManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBaseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDictionaryManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewSalarySheet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalaryReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystemLock = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssInfo
            // 
            this.tssInfo.Name = "tssInfo";
            this.tssInfo.Size = new System.Drawing.Size(131, 17);
            this.tssInfo.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiBaseInfo,
            this.tsmiEmp,
            this.tsmiSalary,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCalculator,
            this.tsmiDraft,
            this.tsmiChangeOperator,
            this.tsmiAccountManagement,
            this.tsmiOperatorManagement,
            this.tsmiSystemLock,
            this.tsmiExit});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(83, 21);
            this.tsmiSystem.Text = "系统功能(S)";
            // 
            // tsmiCalculator
            // 
            this.tsmiCalculator.Name = "tsmiCalculator";
            this.tsmiCalculator.Size = new System.Drawing.Size(180, 22);
            this.tsmiCalculator.Text = "计算器(C)";
            this.tsmiCalculator.Click += new System.EventHandler(this.tsmiCalculator_Click);
            // 
            // tsmiDraft
            // 
            this.tsmiDraft.Name = "tsmiDraft";
            this.tsmiDraft.Size = new System.Drawing.Size(180, 22);
            this.tsmiDraft.Text = "草稿(D)";
            this.tsmiDraft.Click += new System.EventHandler(this.tsmiDraft_Click);
            // 
            // tsmiChangeOperator
            // 
            this.tsmiChangeOperator.Name = "tsmiChangeOperator";
            this.tsmiChangeOperator.Size = new System.Drawing.Size(180, 22);
            this.tsmiChangeOperator.Text = "切换用户(C)";
            this.tsmiChangeOperator.Click += new System.EventHandler(this.tsmiChangeOperator_Click);
            // 
            // tsmiAccountManagement
            // 
            this.tsmiAccountManagement.Name = "tsmiAccountManagement";
            this.tsmiAccountManagement.Size = new System.Drawing.Size(180, 22);
            this.tsmiAccountManagement.Text = "账户管理(A)";
            this.tsmiAccountManagement.Click += new System.EventHandler(this.tsmiAccountManagement_Click);
            // 
            // tsmiOperatorManagement
            // 
            this.tsmiOperatorManagement.Name = "tsmiOperatorManagement";
            this.tsmiOperatorManagement.Size = new System.Drawing.Size(180, 22);
            this.tsmiOperatorManagement.Text = "操作员管理(O)";
            this.tsmiOperatorManagement.Click += new System.EventHandler(this.tsmiOperatorManagement_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "退出(X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiBaseInfo
            // 
            this.tsmiBaseInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogQuery,
            this.tsmDepartment,
            this.tsmiDictionaryManagement});
            this.tsmiBaseInfo.Name = "tsmiBaseInfo";
            this.tsmiBaseInfo.Size = new System.Drawing.Size(108, 21);
            this.tsmiBaseInfo.Text = "基础数据维护(B)";
            // 
            // tsmiLogQuery
            // 
            this.tsmiLogQuery.Name = "tsmiLogQuery";
            this.tsmiLogQuery.Size = new System.Drawing.Size(180, 22);
            this.tsmiLogQuery.Text = "日志查看(L)";
            this.tsmiLogQuery.Click += new System.EventHandler(this.tsmiLogQuery_Click);
            // 
            // tsmDepartment
            // 
            this.tsmDepartment.Name = "tsmDepartment";
            this.tsmDepartment.Size = new System.Drawing.Size(180, 22);
            this.tsmDepartment.Text = "部门管理(D)";
            this.tsmDepartment.Click += new System.EventHandler(this.tsmDepartment_Click);
            // 
            // tsmiDictionaryManagement
            // 
            this.tsmiDictionaryManagement.Name = "tsmiDictionaryManagement";
            this.tsmiDictionaryManagement.Size = new System.Drawing.Size(180, 22);
            this.tsmiDictionaryManagement.Text = "字典管理(D)";
            this.tsmiDictionaryManagement.Click += new System.EventHandler(this.tsmiDictionaryManagement_Click);
            // 
            // tsmiEmp
            // 
            this.tsmiEmp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEmployee});
            this.tsmiEmp.Name = "tsmiEmp";
            this.tsmiEmp.Size = new System.Drawing.Size(83, 21);
            this.tsmiEmp.Text = "员工管理(E)";
            // 
            // tsmEmployee
            // 
            this.tsmEmployee.Name = "tsmEmployee";
            this.tsmEmployee.Size = new System.Drawing.Size(180, 22);
            this.tsmEmployee.Text = "员工管理(E)";
            this.tsmEmployee.Click += new System.EventHandler(this.tsmEmployee_Click);
            // 
            // tsmiSalary
            // 
            this.tsmiSalary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewSalarySheet,
            this.tsmiSalaryReport});
            this.tsmiSalary.Name = "tsmiSalary";
            this.tsmiSalary.Size = new System.Drawing.Size(83, 21);
            this.tsmiSalary.Text = "薪资管理(S)";
            // 
            // tsmiNewSalarySheet
            // 
            this.tsmiNewSalarySheet.Name = "tsmiNewSalarySheet";
            this.tsmiNewSalarySheet.Size = new System.Drawing.Size(180, 22);
            this.tsmiNewSalarySheet.Text = "生成薪资单(S)";
            this.tsmiNewSalarySheet.Click += new System.EventHandler(this.tsmiNewSalarySheet_Click);
            // 
            // tsmiSalaryReport
            // 
            this.tsmiSalaryReport.Name = "tsmiSalaryReport";
            this.tsmiSalaryReport.Size = new System.Drawing.Size(180, 22);
            this.tsmiSalaryReport.Text = "薪资报表(R)";
            this.tsmiSalaryReport.Click += new System.EventHandler(this.tsmiSalaryReport_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbout.Text = "关于";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiSystemLock
            // 
            this.tsmiSystemLock.Name = "tsmiSystemLock";
            this.tsmiSystemLock.Size = new System.Drawing.Size(180, 22);
            this.tsmiSystemLock.Text = "锁定系统(L)";
            this.tsmiSystemLock.Click += new System.EventHandler(this.tsmiSystemLock_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 514);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "操作界面";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBaseInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmp;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalary;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmDepartment;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewSalarySheet;
        private System.Windows.Forms.ToolStripMenuItem tsmiDictionaryManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalaryReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiOperatorManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeOperator;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalculator;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiDraft;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemLock;
    }
}