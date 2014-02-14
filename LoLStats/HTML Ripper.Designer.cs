namespace LoLStats
{
    partial class HTML_Ripper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_StartAddress = new System.Windows.Forms.Label();
            this.lb_TeamXpath = new System.Windows.Forms.Label();
            this.lb_PlayerXPath = new System.Windows.Forms.Label();
            this.tb_StartAddress = new System.Windows.Forms.TextBox();
            this.tb_TeamXPath = new System.Windows.Forms.TextBox();
            this.tb_PlayerXPath = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.tv_Results = new System.Windows.Forms.TreeView();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lb_InGameNameXpath = new System.Windows.Forms.Label();
            this.tb_IgnXpath = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lb_StartAddress
            // 
            this.lb_StartAddress.AutoSize = true;
            this.lb_StartAddress.Location = new System.Drawing.Point(12, 15);
            this.lb_StartAddress.Name = "lb_StartAddress";
            this.lb_StartAddress.Size = new System.Drawing.Size(54, 13);
            this.lb_StartAddress.TabIndex = 1;
            this.lb_StartAddress.Text = "Start URL";
            // 
            // lb_TeamXpath
            // 
            this.lb_TeamXpath.AutoSize = true;
            this.lb_TeamXpath.Location = new System.Drawing.Point(12, 41);
            this.lb_TeamXpath.Name = "lb_TeamXpath";
            this.lb_TeamXpath.Size = new System.Drawing.Size(66, 13);
            this.lb_TeamXpath.TabIndex = 2;
            this.lb_TeamXpath.Text = "Team XPath";
            // 
            // lb_PlayerXPath
            // 
            this.lb_PlayerXPath.AutoSize = true;
            this.lb_PlayerXPath.Location = new System.Drawing.Point(12, 67);
            this.lb_PlayerXPath.Name = "lb_PlayerXPath";
            this.lb_PlayerXPath.Size = new System.Drawing.Size(68, 13);
            this.lb_PlayerXPath.TabIndex = 4;
            this.lb_PlayerXPath.Text = "Player XPath";
            // 
            // tb_StartAddress
            // 
            this.tb_StartAddress.Location = new System.Drawing.Point(107, 8);
            this.tb_StartAddress.Name = "tb_StartAddress";
            this.tb_StartAddress.Size = new System.Drawing.Size(407, 20);
            this.tb_StartAddress.TabIndex = 5;
            // 
            // tb_TeamXPath
            // 
            this.tb_TeamXPath.Location = new System.Drawing.Point(107, 34);
            this.tb_TeamXPath.Name = "tb_TeamXPath";
            this.tb_TeamXPath.Size = new System.Drawing.Size(407, 20);
            this.tb_TeamXPath.TabIndex = 6;
            // 
            // tb_PlayerXPath
            // 
            this.tb_PlayerXPath.Location = new System.Drawing.Point(107, 60);
            this.tb_PlayerXPath.Name = "tb_PlayerXPath";
            this.tb_PlayerXPath.Size = new System.Drawing.Size(407, 20);
            this.tb_PlayerXPath.TabIndex = 7;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(520, 8);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tv_Results
            // 
            this.tv_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_Results.Location = new System.Drawing.Point(0, 0);
            this.tv_Results.Name = "tv_Results";
            this.tv_Results.Size = new System.Drawing.Size(523, 287);
            this.tv_Results.TabIndex = 10;
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(3, 3);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 11;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(520, 37);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_IgnXpath);
            this.splitContainer1.Panel1.Controls.Add(this.lb_InGameNameXpath);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Start);
            this.splitContainer1.Panel1.Controls.Add(this.lb_StartAddress);
            this.splitContainer1.Panel1.Controls.Add(this.lb_TeamXpath);
            this.splitContainer1.Panel1.Controls.Add(this.lb_PlayerXPath);
            this.splitContainer1.Panel1.Controls.Add(this.tb_StartAddress);
            this.splitContainer1.Panel1.Controls.Add(this.tb_TeamXPath);
            this.splitContainer1.Panel1.Controls.Add(this.tb_PlayerXPath);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Exit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(607, 419);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 13;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tv_Results);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_Clear);
            this.splitContainer2.Panel2.Controls.Add(this.btn_Accept);
            this.splitContainer2.Size = new System.Drawing.Size(607, 287);
            this.splitContainer2.SplitterDistance = 523;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(2, 32);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // lb_InGameNameXpath
            // 
            this.lb_InGameNameXpath.AutoSize = true;
            this.lb_InGameNameXpath.Location = new System.Drawing.Point(12, 93);
            this.lb_InGameNameXpath.Name = "lb_InGameNameXpath";
            this.lb_InGameNameXpath.Size = new System.Drawing.Size(58, 13);
            this.lb_InGameNameXpath.TabIndex = 13;
            this.lb_InGameNameXpath.Text = "IGN XPath";
            // 
            // tb_IgnXpath
            // 
            this.tb_IgnXpath.Location = new System.Drawing.Point(107, 86);
            this.tb_IgnXpath.Name = "tb_IgnXpath";
            this.tb_IgnXpath.Size = new System.Drawing.Size(407, 20);
            this.tb_IgnXpath.TabIndex = 14;
            // 
            // HTML_Ripper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 443);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HTML_Ripper";
            this.Text = "HTML_Ripper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lb_StartAddress;
        private System.Windows.Forms.Label lb_TeamXpath;
        private System.Windows.Forms.Label lb_PlayerXPath;
        private System.Windows.Forms.TextBox tb_StartAddress;
        private System.Windows.Forms.TextBox tb_TeamXPath;
        private System.Windows.Forms.TextBox tb_PlayerXPath;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TreeView tv_Results;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox tb_IgnXpath;
        private System.Windows.Forms.Label lb_InGameNameXpath;
    }
}