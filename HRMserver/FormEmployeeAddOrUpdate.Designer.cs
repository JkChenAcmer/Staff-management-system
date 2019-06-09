namespace HRMserver
{
    partial class FormEmployeeAddOrUpdate
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.cbbDepartmentId = new System.Windows.Forms.ComboBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.dtpInDay = new System.Windows.Forms.DateTimePicker();
            this.cbbMarriageId = new System.Windows.Forms.ComboBox();
            this.cbbGenderId = new System.Windows.Forms.ComboBox();
            this.cbbPartyId = new System.Windows.Forms.ComboBox();
            this.cbbEducationId = new System.Windows.Forms.ComboBox();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNativePlace = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResume = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChoosePhoto);
            this.tabPage1.Controls.Add(this.picPhoto);
            this.tabPage1.Controls.Add(this.txtRemarks);
            this.tabPage1.Controls.Add(this.cbbDepartmentId);
            this.tabPage1.Controls.Add(this.dtpBirthDay);
            this.tabPage1.Controls.Add(this.dtpInDay);
            this.tabPage1.Controls.Add(this.cbbMarriageId);
            this.tabPage1.Controls.Add(this.cbbGenderId);
            this.tabPage1.Controls.Add(this.cbbPartyId);
            this.tabPage1.Controls.Add(this.cbbEducationId);
            this.tabPage1.Controls.Add(this.txtNation);
            this.tabPage1.Controls.Add(this.txtTelephone);
            this.tabPage1.Controls.Add(this.txtNumber);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtNativePlace);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoosePhoto.Location = new System.Drawing.Point(723, 312);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(85, 31);
            this.btnChoosePhoto.TabIndex = 70;
            this.btnChoosePhoto.Text = "选择照片";
            this.btnChoosePhoto.UseVisualStyleBackColor = true;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(680, 57);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(165, 236);
            this.picPhoto.TabIndex = 69;
            this.picPhoto.TabStop = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(110, 327);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(501, 117);
            this.txtRemarks.TabIndex = 68;
            this.txtRemarks.Text = "111";
            // 
            // cbbDepartmentId
            // 
            this.cbbDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartmentId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbDepartmentId.FormattingEnabled = true;
            this.cbbDepartmentId.Location = new System.Drawing.Point(457, 270);
            this.cbbDepartmentId.Name = "cbbDepartmentId";
            this.cbbDepartmentId.Size = new System.Drawing.Size(121, 24);
            this.cbbDepartmentId.TabIndex = 67;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(528, 19);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(123, 21);
            this.dtpBirthDay.TabIndex = 66;
            // 
            // dtpInDay
            // 
            this.dtpInDay.Location = new System.Drawing.Point(105, 70);
            this.dtpInDay.Name = "dtpInDay";
            this.dtpInDay.Size = new System.Drawing.Size(154, 21);
            this.dtpInDay.TabIndex = 65;
            // 
            // cbbMarriageId
            // 
            this.cbbMarriageId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMarriageId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbMarriageId.FormattingEnabled = true;
            this.cbbMarriageId.Location = new System.Drawing.Point(350, 73);
            this.cbbMarriageId.Name = "cbbMarriageId";
            this.cbbMarriageId.Size = new System.Drawing.Size(80, 24);
            this.cbbMarriageId.TabIndex = 64;
            // 
            // cbbGenderId
            // 
            this.cbbGenderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenderId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGenderId.FormattingEnabled = true;
            this.cbbGenderId.Location = new System.Drawing.Point(350, 20);
            this.cbbGenderId.Name = "cbbGenderId";
            this.cbbGenderId.Size = new System.Drawing.Size(80, 24);
            this.cbbGenderId.TabIndex = 63;
            // 
            // cbbPartyId
            // 
            this.cbbPartyId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPartyId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPartyId.FormattingEnabled = true;
            this.cbbPartyId.Location = new System.Drawing.Point(530, 70);
            this.cbbPartyId.Name = "cbbPartyId";
            this.cbbPartyId.Size = new System.Drawing.Size(121, 24);
            this.cbbPartyId.TabIndex = 62;
            // 
            // cbbEducationId
            // 
            this.cbbEducationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEducationId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbEducationId.FormattingEnabled = true;
            this.cbbEducationId.Location = new System.Drawing.Point(528, 115);
            this.cbbEducationId.Name = "cbbEducationId";
            this.cbbEducationId.Size = new System.Drawing.Size(121, 24);
            this.cbbEducationId.TabIndex = 61;
            // 
            // txtNation
            // 
            this.txtNation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNation.Location = new System.Drawing.Point(350, 112);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(80, 26);
            this.txtNation.TabIndex = 60;
            this.txtNation.Text = "蓝精灵";
            this.txtNation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTelephone.Location = new System.Drawing.Point(457, 227);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(154, 26);
            this.txtTelephone.TabIndex = 59;
            this.txtTelephone.Text = "111";
            this.txtTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumber.Location = new System.Drawing.Point(110, 267);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(154, 26);
            this.txtNumber.TabIndex = 58;
            this.txtNumber.Text = "111";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.Location = new System.Drawing.Point(110, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 26);
            this.txtEmail.TabIndex = 57;
            this.txtEmail.Text = "111@lanjingling";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(105, 177);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(506, 26);
            this.txtAddress.TabIndex = 56;
            this.txtAddress.Text = "山的那边海的那边";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNativePlace
            // 
            this.txtNativePlace.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNativePlace.Location = new System.Drawing.Point(105, 109);
            this.txtNativePlace.Name = "txtNativePlace";
            this.txtNativePlace.Size = new System.Drawing.Size(154, 26);
            this.txtNativePlace.TabIndex = 55;
            this.txtNativePlace.Text = "银河";
            this.txtNativePlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(105, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 26);
            this.txtName.TabIndex = 54;
            this.txtName.Text = "王三";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(43, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 53;
            this.label16.Text = "籍贯：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(11, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 52;
            this.label15.Text = "联系地址：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(11, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 51;
            this.label14.Text = "电子邮件：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(43, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "工号：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(43, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "备注：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(286, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "性别：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(265, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "婚姻状况：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(286, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "民族：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(436, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "政治面貌：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(468, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "学历：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(395, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "部门：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(436, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "出生年月：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(677, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "照片：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(363, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "联系电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "入职日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "姓名：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResume);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "简历";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(7, 7);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(862, 462);
            this.txtResume.TabIndex = 0;
            this.txtResume.Text = "111";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(777, 521);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 31);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddEmployee.Location = new System.Drawing.Point(642, 520);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(85, 31);
            this.btnAddEmployee.TabIndex = 71;
            this.btnAddEmployee.Text = "保存";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // FormEmployeeAddOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 564);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEmployeeAddOrUpdate";
            this.Text = "添加/编辑员工";
            this.Load += new System.EventHandler(this.FromEmployeeAddOrUpdate_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.ComboBox cbbDepartmentId;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.DateTimePicker dtpInDay;
        private System.Windows.Forms.ComboBox cbbMarriageId;
        private System.Windows.Forms.ComboBox cbbGenderId;
        private System.Windows.Forms.ComboBox cbbPartyId;
        private System.Windows.Forms.ComboBox cbbEducationId;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNativePlace;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtResume;
    }
}