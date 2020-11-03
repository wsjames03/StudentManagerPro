namespace StudentManagerPro
{
    partial class FrmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudent));
            this.lblAddStu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.btnStartPhoto = new System.Windows.Forms.Button();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.btnLocalUpd = new System.Windows.Forms.Button();
            this.groupStuInfo = new System.Windows.Forms.GroupBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.datBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblIDNum = new System.Windows.Forms.Label();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.lblConfirmAdd = new System.Windows.Forms.Button();
            this.lblCloseWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupStuInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddStu
            // 
            this.lblAddStu.AutoSize = true;
            this.lblAddStu.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddStu.Location = new System.Drawing.Point(26, 34);
            this.lblAddStu.Name = "lblAddStu";
            this.lblAddStu.Size = new System.Drawing.Size(162, 38);
            this.lblAddStu.TabIndex = 0;
            this.lblAddStu.Text = "添加新学员";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(33, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 207);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(465, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 207);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartCamera.Location = new System.Drawing.Point(318, 83);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(104, 32);
            this.btnStartCamera.TabIndex = 2;
            this.btnStartCamera.Text = "启动摄像头";
            this.btnStartCamera.UseVisualStyleBackColor = true;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // btnStartPhoto
            // 
            this.btnStartPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartPhoto.Location = new System.Drawing.Point(318, 131);
            this.btnStartPhoto.Name = "btnStartPhoto";
            this.btnStartPhoto.Size = new System.Drawing.Size(104, 32);
            this.btnStartPhoto.TabIndex = 2;
            this.btnStartPhoto.Text = "开始拍照";
            this.btnStartPhoto.UseVisualStyleBackColor = true;
            this.btnStartPhoto.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearPhoto.Location = new System.Drawing.Point(318, 179);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(104, 32);
            this.btnClearPhoto.TabIndex = 2;
            this.btnClearPhoto.Text = "清除照片";
            this.btnClearPhoto.UseVisualStyleBackColor = true;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // btnLocalUpd
            // 
            this.btnLocalUpd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLocalUpd.Location = new System.Drawing.Point(318, 258);
            this.btnLocalUpd.Name = "btnLocalUpd";
            this.btnLocalUpd.Size = new System.Drawing.Size(104, 32);
            this.btnLocalUpd.TabIndex = 2;
            this.btnLocalUpd.Text = "本地上传";
            this.btnLocalUpd.UseVisualStyleBackColor = true;
            this.btnLocalUpd.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // groupStuInfo
            // 
            this.groupStuInfo.Controls.Add(this.txtIDNum);
            this.groupStuInfo.Controls.Add(this.cmbClass);
            this.groupStuInfo.Controls.Add(this.datBirthday);
            this.groupStuInfo.Controls.Add(this.rdoFemale);
            this.groupStuInfo.Controls.Add(this.rdoMale);
            this.groupStuInfo.Controls.Add(this.txtPhoneNum);
            this.groupStuInfo.Controls.Add(this.txtAddr);
            this.groupStuInfo.Controls.Add(this.txtCardNum);
            this.groupStuInfo.Controls.Add(this.txtStuName);
            this.groupStuInfo.Controls.Add(this.lblGender);
            this.groupStuInfo.Controls.Add(this.lblBirthday);
            this.groupStuInfo.Controls.Add(this.lblIDNum);
            this.groupStuInfo.Controls.Add(this.lblPhoneNum);
            this.groupStuInfo.Controls.Add(this.lblAddr);
            this.groupStuInfo.Controls.Add(this.lblCardNum);
            this.groupStuInfo.Controls.Add(this.lblClass);
            this.groupStuInfo.Controls.Add(this.lblStuName);
            this.groupStuInfo.Location = new System.Drawing.Point(33, 317);
            this.groupStuInfo.Name = "groupStuInfo";
            this.groupStuInfo.Size = new System.Drawing.Size(675, 220);
            this.groupStuInfo.TabIndex = 3;
            this.groupStuInfo.TabStop = false;
            this.groupStuInfo.Text = "[学员基本信息]";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStuName.Location = new System.Drawing.Point(28, 33);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(59, 12);
            this.lblStuName.TabIndex = 0;
            this.lblStuName.Text = "学员姓名:";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(93, 29);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(150, 21);
            this.txtStuName.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(272, 33);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(35, 12);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "性别:";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.ForeColor = System.Drawing.Color.Black;
            this.rdoMale.Location = new System.Drawing.Point(313, 31);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 2;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.ForeColor = System.Drawing.Color.Black;
            this.rdoFemale.Location = new System.Drawing.Point(354, 31);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 3;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBirthday.Location = new System.Drawing.Point(411, 33);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(59, 12);
            this.lblBirthday.TabIndex = 0;
            this.lblBirthday.Text = "出生日期:";
            // 
            // datBirthday
            // 
            this.datBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datBirthday.Location = new System.Drawing.Point(487, 29);
            this.datBirthday.Name = "datBirthday";
            this.datBirthday.Size = new System.Drawing.Size(100, 21);
            this.datBirthday.TabIndex = 4;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClass.Location = new System.Drawing.Point(28, 76);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(59, 12);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "所在班级:";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(93, 72);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(149, 20);
            this.cmbClass.TabIndex = 5;
            // 
            // lblIDNum
            // 
            this.lblIDNum.AutoSize = true;
            this.lblIDNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIDNum.Location = new System.Drawing.Point(272, 76);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(59, 12);
            this.lblIDNum.TabIndex = 0;
            this.lblIDNum.Text = "身份证号:";
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(337, 71);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(250, 21);
            this.txtIDNum.TabIndex = 6;
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCardNum.Location = new System.Drawing.Point(28, 119);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(59, 12);
            this.lblCardNum.TabIndex = 0;
            this.lblCardNum.Text = "考勤卡号:";
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(93, 115);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(150, 21);
            this.txtCardNum.TabIndex = 1;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneNum.Location = new System.Drawing.Point(272, 119);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(59, 12);
            this.lblPhoneNum.TabIndex = 0;
            this.lblPhoneNum.Text = "联系电话:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(337, 115);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(250, 21);
            this.txtPhoneNum.TabIndex = 1;
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddr.Location = new System.Drawing.Point(28, 162);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(59, 12);
            this.lblAddr.TabIndex = 0;
            this.lblAddr.Text = "家庭地址:";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(93, 158);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(494, 21);
            this.txtAddr.TabIndex = 1;
            // 
            // lblConfirmAdd
            // 
            this.lblConfirmAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConfirmAdd.Image = ((System.Drawing.Image)(resources.GetObject("lblConfirmAdd.Image")));
            this.lblConfirmAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConfirmAdd.Location = new System.Drawing.Point(465, 37);
            this.lblConfirmAdd.Name = "lblConfirmAdd";
            this.lblConfirmAdd.Size = new System.Drawing.Size(104, 32);
            this.lblConfirmAdd.TabIndex = 2;
            this.lblConfirmAdd.Text = "确认添加  ";
            this.lblConfirmAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConfirmAdd.UseVisualStyleBackColor = true;
            this.lblConfirmAdd.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // lblCloseWindow
            // 
            this.lblCloseWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("lblCloseWindow.Image")));
            this.lblCloseWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCloseWindow.Location = new System.Drawing.Point(604, 37);
            this.lblCloseWindow.Name = "lblCloseWindow";
            this.lblCloseWindow.Size = new System.Drawing.Size(104, 32);
            this.lblCloseWindow.TabIndex = 2;
            this.lblCloseWindow.Text = "关闭窗口  ";
            this.lblCloseWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCloseWindow.UseVisualStyleBackColor = true;
            this.lblCloseWindow.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 567);
            this.Controls.Add(this.groupStuInfo);
            this.Controls.Add(this.btnLocalUpd);
            this.Controls.Add(this.btnClearPhoto);
            this.Controls.Add(this.btnStartPhoto);
            this.Controls.Add(this.lblCloseWindow);
            this.Controls.Add(this.lblConfirmAdd);
            this.Controls.Add(this.btnStartCamera);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddStu);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[添加新学员]";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupStuInfo.ResumeLayout(false);
            this.groupStuInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddStu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.Button btnStartPhoto;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.Button btnLocalUpd;
        private System.Windows.Forms.GroupBox groupStuInfo;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DateTimePicker datBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblIDNum;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Button lblConfirmAdd;
        private System.Windows.Forms.Button lblCloseWindow;
    }
}