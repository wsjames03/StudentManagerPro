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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_System = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_PassWdModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Management = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsim_BulkImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_StuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.tsmi_PassWdModify.Size = new System.Drawing.Size(180, 22);
            this.tsmi_PassWdModify.Text = "密码修改(&C)";
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Exit.Image")));
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Exit.Text = "退出系统";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
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
            this.tsmi_AddStudent.Size = new System.Drawing.Size(180, 22);
            this.tsmi_AddStudent.Text = "添加学员(&A)";
            // 
            // tsim_BulkImport
            // 
            this.tsim_BulkImport.Image = ((System.Drawing.Image)(resources.GetObject("tsim_BulkImport.Image")));
            this.tsim_BulkImport.Name = "tsim_BulkImport";
            this.tsim_BulkImport.Size = new System.Drawing.Size(180, 22);
            this.tsim_BulkImport.Text = "批量导入学员(&I)";
            // 
            // tsmi_StuManagement
            // 
            this.tsmi_StuManagement.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_StuManagement.Image")));
            this.tsmi_StuManagement.Name = "tsmi_StuManagement";
            this.tsmi_StuManagement.Size = new System.Drawing.Size(180, 22);
            this.tsmi_StuManagement.Text = "学员信息管理";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[学员管理系统]-最适合初学者实践的项目";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
    }
}

