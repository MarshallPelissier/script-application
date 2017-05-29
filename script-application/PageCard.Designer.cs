namespace script_application
{
    partial class PageCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbl_Info = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Card_Desc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Page_Num = new System.Windows.Forms.Label();
            this.pnl_Arrows = new System.Windows.Forms.Panel();
            this.btn_Shift_Left = new System.Windows.Forms.Button();
            this.btn_Shift_Right = new System.Windows.Forms.Button();
            this.pnl_Card = new System.Windows.Forms.Panel();
            this.tbl_Info.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Arrows.SuspendLayout();
            this.pnl_Card.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Info
            // 
            this.tbl_Info.ColumnCount = 2;
            this.tbl_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbl_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Info.Controls.Add(this.txt_Card_Desc, 1, 0);
            this.tbl_Info.Controls.Add(this.panel1, 0, 0);
            this.tbl_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Info.Location = new System.Drawing.Point(5, 5);
            this.tbl_Info.Name = "tbl_Info";
            this.tbl_Info.RowCount = 1;
            this.tbl_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Info.Size = new System.Drawing.Size(234, 84);
            this.tbl_Info.TabIndex = 0;
            // 
            // txt_Card_Desc
            // 
            this.txt_Card_Desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Card_Desc.Location = new System.Drawing.Point(63, 3);
            this.txt_Card_Desc.Multiline = true;
            this.txt_Card_Desc.Name = "txt_Card_Desc";
            this.txt_Card_Desc.Size = new System.Drawing.Size(168, 78);
            this.txt_Card_Desc.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Page_Num);
            this.panel1.Controls.Add(this.pnl_Arrows);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 78);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Page_Num
            // 
            this.lbl_Page_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Page_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Page_Num.Location = new System.Drawing.Point(0, 0);
            this.lbl_Page_Num.Name = "lbl_Page_Num";
            this.lbl_Page_Num.Size = new System.Drawing.Size(54, 53);
            this.lbl_Page_Num.TabIndex = 4;
            this.lbl_Page_Num.Text = "12";
            this.lbl_Page_Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Arrows
            // 
            this.pnl_Arrows.Controls.Add(this.btn_Shift_Left);
            this.pnl_Arrows.Controls.Add(this.btn_Shift_Right);
            this.pnl_Arrows.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Arrows.Location = new System.Drawing.Point(0, 53);
            this.pnl_Arrows.Name = "pnl_Arrows";
            this.pnl_Arrows.Size = new System.Drawing.Size(54, 25);
            this.pnl_Arrows.TabIndex = 3;
            // 
            // btn_Shift_Left
            // 
            this.btn_Shift_Left.BackgroundImage = global::script_application.Properties.Resources.left;
            this.btn_Shift_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Shift_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Shift_Left.Location = new System.Drawing.Point(0, 0);
            this.btn_Shift_Left.Name = "btn_Shift_Left";
            this.btn_Shift_Left.Size = new System.Drawing.Size(24, 25);
            this.btn_Shift_Left.TabIndex = 1;
            this.btn_Shift_Left.UseVisualStyleBackColor = true;
            this.btn_Shift_Left.Click += new System.EventHandler(this.btn_Shift_Left_Click);
            // 
            // btn_Shift_Right
            // 
            this.btn_Shift_Right.BackgroundImage = global::script_application.Properties.Resources.right;
            this.btn_Shift_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Shift_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Shift_Right.Location = new System.Drawing.Point(30, 0);
            this.btn_Shift_Right.Name = "btn_Shift_Right";
            this.btn_Shift_Right.Size = new System.Drawing.Size(24, 25);
            this.btn_Shift_Right.TabIndex = 2;
            this.btn_Shift_Right.UseVisualStyleBackColor = true;
            this.btn_Shift_Right.Click += new System.EventHandler(this.btn_Shift_Right_Click);
            // 
            // pnl_Card
            // 
            this.pnl_Card.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Card.Controls.Add(this.tbl_Info);
            this.pnl_Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Card.Location = new System.Drawing.Point(3, 3);
            this.pnl_Card.Name = "pnl_Card";
            this.pnl_Card.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_Card.Size = new System.Drawing.Size(244, 94);
            this.pnl_Card.TabIndex = 3;
            // 
            // PageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Card);
            this.Name = "PageCard";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(250, 100);
            this.Load += new System.EventHandler(this.PageCard_Load);
            this.tbl_Info.ResumeLayout(false);
            this.tbl_Info.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl_Arrows.ResumeLayout(false);
            this.pnl_Card.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_Info;
        private System.Windows.Forms.Button btn_Shift_Left;
        private System.Windows.Forms.Button btn_Shift_Right;
        private System.Windows.Forms.TextBox txt_Card_Desc;
        private System.Windows.Forms.Panel pnl_Card;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Page_Num;
        private System.Windows.Forms.Panel pnl_Arrows;
    }
}
