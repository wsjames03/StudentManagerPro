namespace StudentManagerPro
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_System = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_PassWdModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Management = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsim_BulkImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_StuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.btnExit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_System,
            this.tsmi_Management});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_System
            // 
            this.tsmi_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_PassWdModify,
            this.toolStripSeparator1,
            this.tsmi_Exit});
            this.tsmi_System.Name = "tsmi_System";
            this.tsmi_System.Size = new System.Drawing.Size(59, 21);
            this.tsmi_System.Text = "系统(&S)";
            // 
            // tsmi_PassWdModify
            // 
            this.tsmi_PassWdModify.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_PassWdModify.Image")));
            this.tsmi_PassWdModify.Name = "tsmi_PassWdModify";
            this.tsmi_PassWdModify.Size = new System.Drawing.Size(140, 22);
            this.tsmi_PassWdModify.Text = "密码修改(&C)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Exit.Image")));
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(140, 22);
            this.tsmi_Exit.Text = "退出系统";
            // 
            // tsmi_Management
            // 
            this.tsmi_Management.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AddStudent,
            this.tsim_BulkImport,
            this.toolStripSeparator2,
            this.tsmi_StuManagement});
            this.tsmi_Management.Name = "tsmi_Management";
            this.tsmi_Management.Size = new System.Drawing.Size(88, 21);
            this.tsmi_Management.Text = "学员管理(&M)";
            // 
            // tsmi_AddStudent
            // 
            this.tsmi_AddStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_AddStudent.Image")));
            this.tsmi_AddStudent.Name = "tsmi_AddStudent";
            this.tsmi_AddStudent.Size = new System.Drawing.Size(160, 22);
            this.tsmi_AddStudent.Text = "添加学员(&A)";
            // 
            // tsim_BulkImport
            // 
            this.tsim_BulkImport.Image = ((System.Drawing.Image)(resources.GetObject("tsim_BulkImport.Image")));
            this.tsim_BulkImport.Name = "tsim_BulkImport";
            this.tsim_BulkImport.Size = new System.Drawing.Size(160, 22);
            this.tsim_BulkImport.Text = "批量导入学员(&I)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // tsmi_StuManagement
            // 
            this.tsmi_StuManagement.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_StuManagement.Image")));
            this.tsmi_StuManagement.Name = "tsmi_StuManagement";
            this.tsmi_StuManagement.Size = new System.Drawing.Size(160, 22);
            this.tsmi_StuManagement.Text = "学员信息管理";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "版本号V2.0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel2.Text = "当前用户：周启";
            // 
            // spContainer
            // 
            this.spContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 25);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.btnExit);
            this.spContainer.Panel1.Controls.Add(this.button6);
            this.spContainer.Panel1.Controls.Add(this.button4);
            this.spContainer.Panel1.Controls.Add(this.button2);
            this.spContainer.Panel1.Controls.Add(this.button7);
            this.spContainer.Panel1.Controls.Add(this.button5);
            this.spContainer.Panel1.Controls.Add(this.button3);
            this.spContainer.Panel1.Controls.Add(this.btnAddStudent);
            this.spContainer.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spContainer.Panel2.BackgroundImage")));
            this.spContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spContainer.Panel2.Controls.Add(this.label1);
            this.spContainer.Size = new System.Drawing.Size(1264, 682);
            this.spContainer.SplitterDistance = 286;
            this.spContainer.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageIndex = 9;
            this.btnExit.ImageList = this.imageList1;
            this.btnExit.Location = new System.Drawing.Point(159, 613);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出系统";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about.ico");
            this.imageList1.Images.SetKeyName(1, "CustomerOrder.ico");
            this.imageList1.Images.SetKeyName(2, "MngIncdown.bmp");
            this.imageList1.Images.SetKeyName(3, "MngUpover.bmp");
            this.imageList1.Images.SetKeyName(4, "people.ico");
            this.imageList1.Images.SetKeyName(5, "PROPS.ICO");
            this.imageList1.Images.SetKeyName(6, "Sells.ico");
            this.imageList1.Images.SetKeyName(7, "SysIco.ico");
            this.imageList1.Images.SetKeyName(8, "TABLE.ICO");
            this.imageList1.Images.SetKeyName(9, "关闭.bmp");
            this.imageList1.Images.SetKeyName(10, "修改.bmp");
            // 
            // button6
            // 
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 8;
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(159, 318);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 36);
            this.button6.TabIndex = 2;
            this.button6.Text = "成绩浏览";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 5;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(159, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "考勤打卡";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(159, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "批量导入";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageIndex = 10;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(33, 613);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 36);
            this.button7.TabIndex = 1;
            this.button7.Text = "密码修改";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 6;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(33, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 36);
            this.button5.TabIndex = 1;
            this.button5.Text = "成绩分析";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(33, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 36);
            this.button3.TabIndex = 1;
            this.button3.Text = "学员管理";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(33, 212);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(94, 36);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = " 添加学员";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(33, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("STCaiyun", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(150, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用学员信息管理系统";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[学员管理系统]-最适合初学者实践的项目";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            this.spContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_System;
        private System.Windows.Forms.ToolStripMenuItem tsmi_PassWdModify;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Management;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddStudent;
        private System.Windows.Forms.ToolStripMenuItem tsim_BulkImport;
        private System.Windows.Forms.ToolStripMenuItem tsmi_StuManagement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}

