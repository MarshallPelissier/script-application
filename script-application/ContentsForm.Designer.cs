namespace script_application
{
    partial class ContentsForm
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
            this.tlp_Contents = new System.Windows.Forms.TableLayoutPanel();
            this.flp_Page_Cards = new System.Windows.Forms.FlowLayoutPanel();
            this.tlp_File_Info = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Summary = new System.Windows.Forms.Panel();
            this.txt_Summary = new System.Windows.Forms.TextBox();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_Card_Count = new System.Windows.Forms.Panel();
            this.lbl_Card_Count = new System.Windows.Forms.Label();
            this.pnl_Card_Controls = new System.Windows.Forms.Panel();
            this.btn_New_Card = new System.Windows.Forms.Button();
            this.btn_Edit_Card = new System.Windows.Forms.Button();
            this.btn_Delete_Card = new System.Windows.Forms.Button();
            this.btn_Duplicate_Card = new System.Windows.Forms.Button();
            this.tlp_Contents.SuspendLayout();
            this.tlp_File_Info.SuspendLayout();
            this.pnl_Summary.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.pnl_Card_Count.SuspendLayout();
            this.pnl_Card_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Contents
            // 
            this.tlp_Contents.ColumnCount = 1;
            this.tlp_Contents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Contents.Controls.Add(this.flp_Page_Cards, 0, 1);
            this.tlp_Contents.Controls.Add(this.tlp_File_Info, 0, 0);
            this.tlp_Contents.Controls.Add(this.pnl_Card_Controls, 0, 2);
            this.tlp_Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Contents.Location = new System.Drawing.Point(0, 0);
            this.tlp_Contents.Name = "tlp_Contents";
            this.tlp_Contents.RowCount = 3;
            this.tlp_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Contents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_Contents.Size = new System.Drawing.Size(884, 561);
            this.tlp_Contents.TabIndex = 0;
            // 
            // flp_Page_Cards
            // 
            this.flp_Page_Cards.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flp_Page_Cards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Page_Cards.Location = new System.Drawing.Point(3, 103);
            this.flp_Page_Cards.Name = "flp_Page_Cards";
            this.flp_Page_Cards.Size = new System.Drawing.Size(878, 395);
            this.flp_Page_Cards.TabIndex = 0;
            // 
            // tlp_File_Info
            // 
            this.tlp_File_Info.ColumnCount = 3;
            this.tlp_File_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_File_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_File_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tlp_File_Info.Controls.Add(this.pnl_Summary, 1, 0);
            this.tlp_File_Info.Controls.Add(this.pnl_Title, 0, 0);
            this.tlp_File_Info.Controls.Add(this.pnl_Card_Count, 2, 0);
            this.tlp_File_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_File_Info.Location = new System.Drawing.Point(3, 3);
            this.tlp_File_Info.Name = "tlp_File_Info";
            this.tlp_File_Info.RowCount = 1;
            this.tlp_File_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_File_Info.Size = new System.Drawing.Size(878, 94);
            this.tlp_File_Info.TabIndex = 1;
            // 
            // pnl_Summary
            // 
            this.pnl_Summary.Controls.Add(this.txt_Summary);
            this.pnl_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Summary.Location = new System.Drawing.Point(313, 3);
            this.pnl_Summary.Name = "pnl_Summary";
            this.pnl_Summary.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Summary.Size = new System.Drawing.Size(459, 88);
            this.pnl_Summary.TabIndex = 1;
            // 
            // txt_Summary
            // 
            this.txt_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Summary.Location = new System.Drawing.Point(10, 10);
            this.txt_Summary.Multiline = true;
            this.txt_Summary.Name = "txt_Summary";
            this.txt_Summary.Size = new System.Drawing.Size(439, 68);
            this.txt_Summary.TabIndex = 0;
            this.txt_Summary.Text = "Summary";
            // 
            // pnl_Title
            // 
            this.pnl_Title.Controls.Add(this.textBox1);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Title.Location = new System.Drawing.Point(3, 3);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Padding = new System.Windows.Forms.Padding(10, 21, 10, 10);
            this.pnl_Title.Size = new System.Drawing.Size(304, 88);
            this.pnl_Title.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Title";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_Card_Count
            // 
            this.pnl_Card_Count.Controls.Add(this.lbl_Card_Count);
            this.pnl_Card_Count.Location = new System.Drawing.Point(778, 3);
            this.pnl_Card_Count.Name = "pnl_Card_Count";
            this.pnl_Card_Count.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Card_Count.Size = new System.Drawing.Size(97, 88);
            this.pnl_Card_Count.TabIndex = 3;
            // 
            // lbl_Card_Count
            // 
            this.lbl_Card_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Card_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Card_Count.Location = new System.Drawing.Point(10, 10);
            this.lbl_Card_Count.Name = "lbl_Card_Count";
            this.lbl_Card_Count.Size = new System.Drawing.Size(77, 68);
            this.lbl_Card_Count.TabIndex = 0;
            this.lbl_Card_Count.Text = "0 : 0";
            this.lbl_Card_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Card_Controls
            // 
            this.pnl_Card_Controls.Controls.Add(this.btn_New_Card);
            this.pnl_Card_Controls.Controls.Add(this.btn_Edit_Card);
            this.pnl_Card_Controls.Controls.Add(this.btn_Duplicate_Card);
            this.pnl_Card_Controls.Controls.Add(this.btn_Delete_Card);
            this.pnl_Card_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Card_Controls.Location = new System.Drawing.Point(3, 504);
            this.pnl_Card_Controls.Name = "pnl_Card_Controls";
            this.pnl_Card_Controls.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Card_Controls.Size = new System.Drawing.Size(878, 54);
            this.pnl_Card_Controls.TabIndex = 2;
            // 
            // btn_New_Card
            // 
            this.btn_New_Card.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_New_Card.Location = new System.Drawing.Point(568, 10);
            this.btn_New_Card.Name = "btn_New_Card";
            this.btn_New_Card.Size = new System.Drawing.Size(75, 34);
            this.btn_New_Card.TabIndex = 2;
            this.btn_New_Card.Text = "New";
            this.btn_New_Card.UseVisualStyleBackColor = true;
            this.btn_New_Card.Click += new System.EventHandler(this.btn_New_Card_Click);
            // 
            // btn_Edit_Card
            // 
            this.btn_Edit_Card.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Edit_Card.Enabled = false;
            this.btn_Edit_Card.Location = new System.Drawing.Point(643, 10);
            this.btn_Edit_Card.Name = "btn_Edit_Card";
            this.btn_Edit_Card.Size = new System.Drawing.Size(75, 34);
            this.btn_Edit_Card.TabIndex = 1;
            this.btn_Edit_Card.Text = "Edit";
            this.btn_Edit_Card.UseVisualStyleBackColor = true;
            this.btn_Edit_Card.Click += new System.EventHandler(this.btn_Edit_Card_Click);
            // 
            // btn_Delete_Card
            // 
            this.btn_Delete_Card.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Delete_Card.Enabled = false;
            this.btn_Delete_Card.Location = new System.Drawing.Point(793, 10);
            this.btn_Delete_Card.Name = "btn_Delete_Card";
            this.btn_Delete_Card.Size = new System.Drawing.Size(75, 34);
            this.btn_Delete_Card.TabIndex = 0;
            this.btn_Delete_Card.Text = "Delete";
            this.btn_Delete_Card.UseVisualStyleBackColor = true;
            this.btn_Delete_Card.Click += new System.EventHandler(this.btn_Delete_Card_Click);
            // 
            // btn_Duplicate_Card
            // 
            this.btn_Duplicate_Card.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Duplicate_Card.Enabled = false;
            this.btn_Duplicate_Card.Location = new System.Drawing.Point(718, 10);
            this.btn_Duplicate_Card.Name = "btn_Duplicate_Card";
            this.btn_Duplicate_Card.Size = new System.Drawing.Size(75, 34);
            this.btn_Duplicate_Card.TabIndex = 3;
            this.btn_Duplicate_Card.Text = "Duplicate";
            this.btn_Duplicate_Card.UseVisualStyleBackColor = true;
            this.btn_Duplicate_Card.Click += new System.EventHandler(this.btn_Duplicate_Card_Click);
            // 
            // ContentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Contents);
            this.Name = "ContentsForm";
            this.Size = new System.Drawing.Size(884, 561);
            this.Load += new System.EventHandler(this.ContentsForm_Load);
            this.tlp_Contents.ResumeLayout(false);
            this.tlp_File_Info.ResumeLayout(false);
            this.pnl_Summary.ResumeLayout(false);
            this.pnl_Summary.PerformLayout();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.pnl_Card_Count.ResumeLayout(false);
            this.pnl_Card_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Contents;
        private System.Windows.Forms.FlowLayoutPanel flp_Page_Cards;
        private System.Windows.Forms.TableLayoutPanel tlp_File_Info;
        private System.Windows.Forms.Panel pnl_Summary;
        private System.Windows.Forms.TextBox txt_Summary;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnl_Card_Controls;
        private System.Windows.Forms.Button btn_New_Card;
        private System.Windows.Forms.Button btn_Edit_Card;
        private System.Windows.Forms.Button btn_Delete_Card;
        private System.Windows.Forms.Panel pnl_Card_Count;
        private System.Windows.Forms.Label lbl_Card_Count;
        private System.Windows.Forms.Button btn_Duplicate_Card;
    }
}