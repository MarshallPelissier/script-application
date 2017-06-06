namespace script_application
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.tsm_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Save_As = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Line = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ctf_Contents_Main = new script_application.ContentsForm();
            this.pgf_Page = new script_application.PageForm();
            this.mnu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Main
            // 
            this.mnu_Main.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_File,
            this.tsm_Line});
            this.mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.Size = new System.Drawing.Size(884, 24);
            this.mnu_Main.TabIndex = 0;
            this.mnu_Main.Text = "mnuMain";
            // 
            // tsm_File
            // 
            this.tsm_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_New,
            this.tsm_Open,
            this.tsm_Save,
            this.tsm_Save_As,
            this.toolStripSeparator1,
            this.tsm_Exit});
            this.tsm_File.Name = "tsm_File";
            this.tsm_File.Size = new System.Drawing.Size(37, 20);
            this.tsm_File.Text = "File";
            // 
            // tsm_New
            // 
            this.tsm_New.Name = "tsm_New";
            this.tsm_New.Size = new System.Drawing.Size(114, 22);
            this.tsm_New.Text = "New";
            this.tsm_New.Click += new System.EventHandler(this.tsm_New_Click);
            // 
            // tsm_Open
            // 
            this.tsm_Open.Name = "tsm_Open";
            this.tsm_Open.Size = new System.Drawing.Size(114, 22);
            this.tsm_Open.Text = "Open";
            this.tsm_Open.Click += new System.EventHandler(this.tsm_Open_Click);
            // 
            // tsm_Save
            // 
            this.tsm_Save.Name = "tsm_Save";
            this.tsm_Save.Size = new System.Drawing.Size(114, 22);
            this.tsm_Save.Text = "Save";
            this.tsm_Save.Click += new System.EventHandler(this.tsm_Save_Click);
            // 
            // tsm_Save_As
            // 
            this.tsm_Save_As.Name = "tsm_Save_As";
            this.tsm_Save_As.Size = new System.Drawing.Size(114, 22);
            this.tsm_Save_As.Text = "Save As";
            this.tsm_Save_As.Click += new System.EventHandler(this.tsm_Save_As_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // tsm_Exit
            // 
            this.tsm_Exit.Name = "tsm_Exit";
            this.tsm_Exit.Size = new System.Drawing.Size(114, 22);
            this.tsm_Exit.Text = "Exit";
            this.tsm_Exit.Click += new System.EventHandler(this.tsm_Exit_Click);
            // 
            // tsm_Line
            // 
            this.tsm_Line.Name = "tsm_Line";
            this.tsm_Line.Size = new System.Drawing.Size(74, 20);
            this.tsm_Line.Text = "Line Styles";
            this.tsm_Line.Click += new System.EventHandler(this.tsm_Line_Click);
            // 
            // ctf_Contents_Main
            // 
            this.ctf_Contents_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctf_Contents_Main.Location = new System.Drawing.Point(0, 24);
            this.ctf_Contents_Main.Name = "ctf_Contents_Main";
            this.ctf_Contents_Main.Size = new System.Drawing.Size(884, 537);
            this.ctf_Contents_Main.TabIndex = 2;
            // 
            // pgf_Page
            // 
            this.pgf_Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgf_Page.Location = new System.Drawing.Point(0, 24);
            this.pgf_Page.Margin = new System.Windows.Forms.Padding(0);
            this.pgf_Page.MinimumSize = new System.Drawing.Size(835, 400);
            this.pgf_Page.Name = "pgf_Page";
            this.pgf_Page.Size = new System.Drawing.Size(884, 537);
            this.pgf_Page.TabIndex = 1;
            this.pgf_Page.Visible = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ctf_Contents_Main);
            this.Controls.Add(this.pgf_Page);
            this.Controls.Add(this.mnu_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_Main;
            this.MinimumSize = new System.Drawing.Size(865, 463);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseForm_FormClosing);
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_Main;
        private System.Windows.Forms.ToolStripMenuItem tsm_File;
        private System.Windows.Forms.ToolStripMenuItem tsm_New;
        private System.Windows.Forms.ToolStripMenuItem tsm_Open;
        private System.Windows.Forms.ToolStripMenuItem tsm_Save;
        private System.Windows.Forms.ToolStripMenuItem tsm_Save_As;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PageForm pgf_Page;
        private ContentsForm ctf_Contents_Main;
        private System.Windows.Forms.ToolStripMenuItem tsm_Line;
    }
}