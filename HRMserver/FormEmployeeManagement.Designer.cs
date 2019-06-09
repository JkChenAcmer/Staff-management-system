namespace HRMserver
{
    partial class FormEmployeeManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeManagement));
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.ckbTime = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ckbName = new System.Windows.Forms.CheckBox();
            this.ckbDepartment = new System.Windows.Forms.CheckBox();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsbEraseEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsbExpert = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 230);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 23;
            this.dgvEmployee.Size = new System.Drawing.Size(735, 224);
            this.dgvEmployee.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.ckbTime);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.ckbName);
            this.groupBox1.Controls.Add(this.ckbDepartment);
            this.groupBox1.Controls.Add(this.cbbDepartment);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(609, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 33);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(373, 102);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(193, 30);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.Value = new System.DateTime(2000, 3, 25, 9, 15, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "到";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(123, 102);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(209, 30);
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.Value = new System.DateTime(1900, 3, 25, 9, 15, 0, 0);
            // 
            // ckbTime
            // 
            this.ckbTime.AutoSize = true;
            this.ckbTime.Location = new System.Drawing.Point(9, 104);
            this.ckbTime.Name = "ckbTime";
            this.ckbTime.Size = new System.Drawing.Size(108, 24);
            this.ckbTime.TabIndex = 4;
            this.ckbTime.Text = "入职时间";
            this.ckbTime.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 30);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "张";
            // 
            // ckbName
            // 
            this.ckbName.AutoSize = true;
            this.ckbName.Location = new System.Drawing.Point(20, 45);
            this.ckbName.Name = "ckbName";
            this.ckbName.Size = new System.Drawing.Size(68, 24);
            this.ckbName.TabIndex = 2;
            this.ckbName.Text = "姓名";
            this.ckbName.UseVisualStyleBackColor = true;
            // 
            // ckbDepartment
            // 
            this.ckbDepartment.AutoSize = true;
            this.ckbDepartment.Location = new System.Drawing.Point(364, 43);
            this.ckbDepartment.Name = "ckbDepartment";
            this.ckbDepartment.Size = new System.Drawing.Size(68, 24);
            this.ckbDepartment.TabIndex = 1;
            this.ckbDepartment.Text = "部门";
            this.ckbDepartment.UseVisualStyleBackColor = true;
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(438, 41);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(226, 28);
            this.cbbDepartment.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddEmployee,
            this.tsbUpdateEmployee,
            this.tsbEraseEmployee,
            this.tsbExpert});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(759, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddEmployee
            // 
            this.tsbAddEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddEmployee.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbAddEmployee.Image = global::HRMserver.Properties.Resources.add;
            this.tsbAddEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddEmployee.Name = "tsbAddEmployee";
            this.tsbAddEmployee.Size = new System.Drawing.Size(23, 22);
            this.tsbAddEmployee.Text = "toolStripButton1";
            this.tsbAddEmployee.Click += new System.EventHandler(this.tsbAddEmployee_Click);
            // 
            // tsbUpdateEmployee
            // 
            this.tsbUpdateEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdateEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateEmployee.Image")));
            this.tsbUpdateEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateEmployee.Name = "tsbUpdateEmployee";
            this.tsbUpdateEmployee.Size = new System.Drawing.Size(23, 22);
            this.tsbUpdateEmployee.Text = "toolStripButton1";
            this.tsbUpdateEmployee.Click += new System.EventHandler(this.tsbUpdateEmployee_Click);
            // 
            // tsbEraseEmployee
            // 
            this.tsbEraseEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEraseEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbEraseEmployee.Image")));
            this.tsbEraseEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEraseEmployee.Name = "tsbEraseEmployee";
            this.tsbEraseEmployee.Size = new System.Drawing.Size(23, 22);
            this.tsbEraseEmployee.Text = "toolStripButton1";
            this.tsbEraseEmployee.Click += new System.EventHandler(this.tsbEraseEmployee_Click);
            // 
            // tsbExpert
            // 
            this.tsbExpert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExpert.Image = ((System.Drawing.Image)(resources.GetObject("tsbExpert.Image")));
            this.tsbExpert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExpert.Name = "tsbExpert";
            this.tsbExpert.Size = new System.Drawing.Size(23, 22);
            this.tsbExpert.Text = "toolStripButton1";
            this.tsbExpert.Click += new System.EventHandler(this.tsbExpert_Click);
            // 
            // FormEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 466);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEmployeeManagement";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.FormEmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.CheckBox ckbDepartment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox ckbName;
        private System.Windows.Forms.CheckBox ckbTime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddEmployee;
        private System.Windows.Forms.ToolStripButton tsbUpdateEmployee;
        private System.Windows.Forms.ToolStripButton tsbEraseEmployee;
        private System.Windows.Forms.ToolStripButton tsbExpert;
    }
}