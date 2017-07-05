namespace script_application
{
    partial class PageForm
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
            this.tlp_base = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.pnl_Script = new System.Windows.Forms.Panel();
            this.dgv_Script = new System.Windows.Forms.DataGridView();
            this.lines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Preview = new System.Windows.Forms.Panel();
            this.lbl_Preview = new System.Windows.Forms.Label();
            this.pnl_Line = new System.Windows.Forms.Panel();
            this.txt_Line = new System.Windows.Forms.TextBox();
            this.pnl_Line_Info = new System.Windows.Forms.Panel();
            this.cbo_Character = new System.Windows.Forms.ComboBox();
            this.btn_Cancel_Line = new System.Windows.Forms.Button();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.btn_Save_Line = new System.Windows.Forms.Button();
            this.pnl_Script_Control = new System.Windows.Forms.Panel();
            this.btn_Edit_Styles = new System.Windows.Forms.Button();
            this.btn_Move_Up = new System.Windows.Forms.Button();
            this.btn_Move_Down = new System.Windows.Forms.Button();
            this.btn_Remove_Line = new System.Windows.Forms.Button();
            this.btn_Add_Line = new System.Windows.Forms.Button();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.tlp_Script_Info = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Images = new System.Windows.Forms.Panel();
            this.tbl_Images = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Image_Control = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Image_Right = new System.Windows.Forms.Button();
            this.pnl_Image_Control = new System.Windows.Forms.Panel();
            this.txt_Caption = new System.Windows.Forms.TextBox();
            this.btn_Remove_Image = new System.Windows.Forms.Button();
            this.btn_Add_Image = new System.Windows.Forms.Button();
            this.btn_Image_Left = new System.Windows.Forms.Button();
            this.pic_Image = new System.Windows.Forms.PictureBox();
            this.pnl_Description = new System.Windows.Forms.Panel();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.pnl_Page_Control = new System.Windows.Forms.Panel();
            this.tbl_Page_Number = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Overview = new System.Windows.Forms.Panel();
            this.btn_Overview = new System.Windows.Forms.Button();
            this.cbo_Page_Number = new System.Windows.Forms.ComboBox();
            this.btn_Page_Right = new System.Windows.Forms.Button();
            this.btn_Page_Left = new System.Windows.Forms.Button();
            this.tlp_base.SuspendLayout();
            this.pnl_Left.SuspendLayout();
            this.pnl_Script.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Script)).BeginInit();
            this.pnl_Preview.SuspendLayout();
            this.pnl_Line.SuspendLayout();
            this.pnl_Line_Info.SuspendLayout();
            this.pnl_Script_Control.SuspendLayout();
            this.pnl_Right.SuspendLayout();
            this.tlp_Script_Info.SuspendLayout();
            this.pnl_Images.SuspendLayout();
            this.tbl_Images.SuspendLayout();
            this.tbl_Image_Control.SuspendLayout();
            this.pnl_Image_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.pnl_Description.SuspendLayout();
            this.pnl_Page_Control.SuspendLayout();
            this.tbl_Page_Number.SuspendLayout();
            this.pnl_Overview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_base
            // 
            this.tlp_base.BackColor = System.Drawing.SystemColors.Control;
            this.tlp_base.ColumnCount = 2;
            this.tlp_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_base.Controls.Add(this.pnl_Left, 0, 0);
            this.tlp_base.Controls.Add(this.pnl_Right, 1, 0);
            this.tlp_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_base.Location = new System.Drawing.Point(0, 0);
            this.tlp_base.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_base.MinimumSize = new System.Drawing.Size(835, 400);
            this.tlp_base.Name = "tlp_base";
            this.tlp_base.RowCount = 1;
            this.tlp_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_base.Size = new System.Drawing.Size(944, 584);
            this.tlp_base.TabIndex = 0;
            // 
            // pnl_Left
            // 
            this.pnl_Left.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl_Left.Controls.Add(this.pnl_Script);
            this.pnl_Left.Controls.Add(this.pnl_Preview);
            this.pnl_Left.Controls.Add(this.pnl_Line);
            this.pnl_Left.Controls.Add(this.pnl_Script_Control);
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Left.Location = new System.Drawing.Point(15, 0);
            this.pnl_Left.Margin = new System.Windows.Forms.Padding(15, 0, 8, 15);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Left.Size = new System.Drawing.Size(543, 569);
            this.pnl_Left.TabIndex = 0;
            // 
            // pnl_Script
            // 
            this.pnl_Script.AutoScroll = true;
            this.pnl_Script.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Script.Controls.Add(this.dgv_Script);
            this.pnl_Script.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Script.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Script.Location = new System.Drawing.Point(10, 10);
            this.pnl_Script.Name = "pnl_Script";
            this.pnl_Script.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Script.Size = new System.Drawing.Size(523, 334);
            this.pnl_Script.TabIndex = 4;
            // 
            // dgv_Script
            // 
            this.dgv_Script.AllowUserToAddRows = false;
            this.dgv_Script.AllowUserToDeleteRows = false;
            this.dgv_Script.AllowUserToResizeColumns = false;
            this.dgv_Script.AllowUserToResizeRows = false;
            this.dgv_Script.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Script.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Script.ColumnHeadersVisible = false;
            this.dgv_Script.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lines,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Script.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Script.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Script.Location = new System.Drawing.Point(10, 10);
            this.dgv_Script.Name = "dgv_Script";
            this.dgv_Script.RowHeadersVisible = false;
            this.dgv_Script.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Script.Size = new System.Drawing.Size(503, 314);
            this.dgv_Script.TabIndex = 0;
            this.dgv_Script.SelectionChanged += new System.EventHandler(this.dgv_Script_SelectionChanged);
            // 
            // lines
            // 
            this.lines.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lines.HeaderText = "Lines";
            this.lines.Name = "lines";
            this.lines.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 1F;
            this.Column2.HeaderText = "Data";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // pnl_Preview
            // 
            this.pnl_Preview.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Preview.Controls.Add(this.lbl_Preview);
            this.pnl_Preview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Preview.Location = new System.Drawing.Point(10, 344);
            this.pnl_Preview.Name = "pnl_Preview";
            this.pnl_Preview.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Preview.Size = new System.Drawing.Size(523, 60);
            this.pnl_Preview.TabIndex = 2;
            this.pnl_Preview.Visible = false;
            // 
            // lbl_Preview
            // 
            this.lbl_Preview.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Preview.Location = new System.Drawing.Point(10, 10);
            this.lbl_Preview.Name = "lbl_Preview";
            this.lbl_Preview.Size = new System.Drawing.Size(503, 40);
            this.lbl_Preview.TabIndex = 0;
            this.lbl_Preview.Text = "Preview Text";
            // 
            // pnl_Line
            // 
            this.pnl_Line.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Line.Controls.Add(this.txt_Line);
            this.pnl_Line.Controls.Add(this.pnl_Line_Info);
            this.pnl_Line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Line.Location = new System.Drawing.Point(10, 404);
            this.pnl_Line.Name = "pnl_Line";
            this.pnl_Line.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Line.Size = new System.Drawing.Size(523, 100);
            this.pnl_Line.TabIndex = 3;
            this.pnl_Line.Visible = false;
            // 
            // txt_Line
            // 
            this.txt_Line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Line.Location = new System.Drawing.Point(10, 10);
            this.txt_Line.Multiline = true;
            this.txt_Line.Name = "txt_Line";
            this.txt_Line.Size = new System.Drawing.Size(354, 80);
            this.txt_Line.TabIndex = 0;
            this.txt_Line.TextChanged += new System.EventHandler(this.txt_Line_TextChanged);
            // 
            // pnl_Line_Info
            // 
            this.pnl_Line_Info.Controls.Add(this.cbo_Character);
            this.pnl_Line_Info.Controls.Add(this.btn_Cancel_Line);
            this.pnl_Line_Info.Controls.Add(this.cbo_Type);
            this.pnl_Line_Info.Controls.Add(this.btn_Save_Line);
            this.pnl_Line_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Line_Info.Location = new System.Drawing.Point(364, 10);
            this.pnl_Line_Info.Name = "pnl_Line_Info";
            this.pnl_Line_Info.Size = new System.Drawing.Size(149, 80);
            this.pnl_Line_Info.TabIndex = 5;
            // 
            // cbo_Character
            // 
            this.cbo_Character.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Character.FormattingEnabled = true;
            this.cbo_Character.Items.AddRange(new object[] {
            "Characters"});
            this.cbo_Character.Location = new System.Drawing.Point(27, 28);
            this.cbo_Character.Name = "cbo_Character";
            this.cbo_Character.Size = new System.Drawing.Size(121, 21);
            this.cbo_Character.TabIndex = 2;
            this.cbo_Character.Text = "Character";
            this.cbo_Character.SelectedIndexChanged += new System.EventHandler(this.cbo_Character_SelectedIndexChanged);
            // 
            // btn_Cancel_Line
            // 
            this.btn_Cancel_Line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel_Line.Location = new System.Drawing.Point(84, 55);
            this.btn_Cancel_Line.Name = "btn_Cancel_Line";
            this.btn_Cancel_Line.Size = new System.Drawing.Size(65, 23);
            this.btn_Cancel_Line.TabIndex = 4;
            this.btn_Cancel_Line.Text = "Cancel";
            this.btn_Cancel_Line.UseVisualStyleBackColor = true;
            this.btn_Cancel_Line.Click += new System.EventHandler(this.btn_Cancel_Line_Click);
            // 
            // cbo_Type
            // 
            this.cbo_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(27, 1);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(121, 21);
            this.cbo_Type.TabIndex = 1;
            this.cbo_Type.Text = "Type";
            this.cbo_Type.SelectedIndexChanged += new System.EventHandler(this.cbo_Type_SelectedIndexChanged);
            // 
            // btn_Save_Line
            // 
            this.btn_Save_Line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save_Line.Location = new System.Drawing.Point(26, 55);
            this.btn_Save_Line.Name = "btn_Save_Line";
            this.btn_Save_Line.Size = new System.Drawing.Size(52, 23);
            this.btn_Save_Line.TabIndex = 3;
            this.btn_Save_Line.Text = "Save";
            this.btn_Save_Line.UseVisualStyleBackColor = true;
            this.btn_Save_Line.Click += new System.EventHandler(this.btn_Save_Line_Click);
            // 
            // pnl_Script_Control
            // 
            this.pnl_Script_Control.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Script_Control.Controls.Add(this.btn_Edit_Styles);
            this.pnl_Script_Control.Controls.Add(this.btn_Move_Up);
            this.pnl_Script_Control.Controls.Add(this.btn_Move_Down);
            this.pnl_Script_Control.Controls.Add(this.btn_Remove_Line);
            this.pnl_Script_Control.Controls.Add(this.btn_Add_Line);
            this.pnl_Script_Control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Script_Control.Location = new System.Drawing.Point(10, 504);
            this.pnl_Script_Control.Name = "pnl_Script_Control";
            this.pnl_Script_Control.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Script_Control.Size = new System.Drawing.Size(523, 55);
            this.pnl_Script_Control.TabIndex = 1;
            // 
            // btn_Edit_Styles
            // 
            this.btn_Edit_Styles.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Edit_Styles.Location = new System.Drawing.Point(190, 10);
            this.btn_Edit_Styles.Name = "btn_Edit_Styles";
            this.btn_Edit_Styles.Size = new System.Drawing.Size(90, 35);
            this.btn_Edit_Styles.TabIndex = 4;
            this.btn_Edit_Styles.Text = "Edit Styles";
            this.btn_Edit_Styles.UseVisualStyleBackColor = true;
            this.btn_Edit_Styles.Click += new System.EventHandler(this.btn_Edit_Styles_Click);
            // 
            // btn_Move_Up
            // 
            this.btn_Move_Up.BackgroundImage = global::script_application.Properties.Resources.triangle1;
            this.btn_Move_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Move_Up.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Move_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move_Up.Location = new System.Drawing.Point(431, 10);
            this.btn_Move_Up.Name = "btn_Move_Up";
            this.btn_Move_Up.Size = new System.Drawing.Size(41, 35);
            this.btn_Move_Up.TabIndex = 3;
            this.btn_Move_Up.UseVisualStyleBackColor = true;
            this.btn_Move_Up.Click += new System.EventHandler(this.btn_Move_Up_Click);
            // 
            // btn_Move_Down
            // 
            this.btn_Move_Down.BackgroundImage = global::script_application.Properties.Resources.down;
            this.btn_Move_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Move_Down.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Move_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move_Down.Location = new System.Drawing.Point(472, 10);
            this.btn_Move_Down.Name = "btn_Move_Down";
            this.btn_Move_Down.Size = new System.Drawing.Size(41, 35);
            this.btn_Move_Down.TabIndex = 2;
            this.btn_Move_Down.Text = "V";
            this.btn_Move_Down.UseVisualStyleBackColor = true;
            this.btn_Move_Down.Click += new System.EventHandler(this.btn_Move_Down_Click);
            // 
            // btn_Remove_Line
            // 
            this.btn_Remove_Line.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Remove_Line.Enabled = false;
            this.btn_Remove_Line.Location = new System.Drawing.Point(100, 10);
            this.btn_Remove_Line.Name = "btn_Remove_Line";
            this.btn_Remove_Line.Size = new System.Drawing.Size(90, 35);
            this.btn_Remove_Line.TabIndex = 1;
            this.btn_Remove_Line.Text = "Remove Line";
            this.btn_Remove_Line.UseVisualStyleBackColor = true;
            this.btn_Remove_Line.Click += new System.EventHandler(this.btn_Remove_Line_Click);
            // 
            // btn_Add_Line
            // 
            this.btn_Add_Line.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Add_Line.Location = new System.Drawing.Point(10, 10);
            this.btn_Add_Line.Name = "btn_Add_Line";
            this.btn_Add_Line.Size = new System.Drawing.Size(90, 35);
            this.btn_Add_Line.TabIndex = 0;
            this.btn_Add_Line.Text = "Add Line";
            this.btn_Add_Line.UseVisualStyleBackColor = true;
            this.btn_Add_Line.Click += new System.EventHandler(this.btn_Add_Line_Click);
            // 
            // pnl_Right
            // 
            this.pnl_Right.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl_Right.Controls.Add(this.tlp_Script_Info);
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Right.Location = new System.Drawing.Point(573, 0);
            this.pnl_Right.Margin = new System.Windows.Forms.Padding(7, 0, 15, 15);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Right.Size = new System.Drawing.Size(356, 569);
            this.pnl_Right.TabIndex = 2;
            // 
            // tlp_Script_Info
            // 
            this.tlp_Script_Info.ColumnCount = 1;
            this.tlp_Script_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Script_Info.Controls.Add(this.pnl_Images, 0, 2);
            this.tlp_Script_Info.Controls.Add(this.pnl_Description, 0, 1);
            this.tlp_Script_Info.Controls.Add(this.pnl_Page_Control, 0, 0);
            this.tlp_Script_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Script_Info.Location = new System.Drawing.Point(10, 10);
            this.tlp_Script_Info.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Script_Info.Name = "tlp_Script_Info";
            this.tlp_Script_Info.RowCount = 3;
            this.tlp_Script_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_Script_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Script_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_Script_Info.Size = new System.Drawing.Size(336, 549);
            this.tlp_Script_Info.TabIndex = 0;
            // 
            // pnl_Images
            // 
            this.pnl_Images.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Images.Controls.Add(this.tbl_Images);
            this.pnl_Images.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Images.Location = new System.Drawing.Point(0, 260);
            this.pnl_Images.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnl_Images.Name = "pnl_Images";
            this.pnl_Images.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_Images.Size = new System.Drawing.Size(336, 289);
            this.pnl_Images.TabIndex = 2;
            // 
            // tbl_Images
            // 
            this.tbl_Images.ColumnCount = 1;
            this.tbl_Images.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Images.Controls.Add(this.tbl_Image_Control, 0, 1);
            this.tbl_Images.Controls.Add(this.pic_Image, 0, 0);
            this.tbl_Images.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Images.Location = new System.Drawing.Point(3, 3);
            this.tbl_Images.Name = "tbl_Images";
            this.tbl_Images.RowCount = 2;
            this.tbl_Images.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Images.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Images.Size = new System.Drawing.Size(330, 283);
            this.tbl_Images.TabIndex = 0;
            // 
            // tbl_Image_Control
            // 
            this.tbl_Image_Control.ColumnCount = 3;
            this.tbl_Image_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_Image_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Image_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_Image_Control.Controls.Add(this.btn_Image_Right, 2, 0);
            this.tbl_Image_Control.Controls.Add(this.pnl_Image_Control, 1, 0);
            this.tbl_Image_Control.Controls.Add(this.btn_Image_Left, 0, 0);
            this.tbl_Image_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Image_Control.Location = new System.Drawing.Point(0, 243);
            this.tbl_Image_Control.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_Image_Control.Name = "tbl_Image_Control";
            this.tbl_Image_Control.RowCount = 1;
            this.tbl_Image_Control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Image_Control.Size = new System.Drawing.Size(330, 40);
            this.tbl_Image_Control.TabIndex = 0;
            // 
            // btn_Image_Right
            // 
            this.btn_Image_Right.BackgroundImage = global::script_application.Properties.Resources.right;
            this.btn_Image_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Image_Right.Location = new System.Drawing.Point(303, 3);
            this.btn_Image_Right.Name = "btn_Image_Right";
            this.btn_Image_Right.Size = new System.Drawing.Size(24, 34);
            this.btn_Image_Right.TabIndex = 2;
            this.btn_Image_Right.UseVisualStyleBackColor = true;
            this.btn_Image_Right.Click += new System.EventHandler(this.btn_Image_Right_Click);
            // 
            // pnl_Image_Control
            // 
            this.pnl_Image_Control.Controls.Add(this.txt_Caption);
            this.pnl_Image_Control.Controls.Add(this.btn_Remove_Image);
            this.pnl_Image_Control.Controls.Add(this.btn_Add_Image);
            this.pnl_Image_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Image_Control.Location = new System.Drawing.Point(33, 3);
            this.pnl_Image_Control.Name = "pnl_Image_Control";
            this.pnl_Image_Control.Size = new System.Drawing.Size(264, 34);
            this.pnl_Image_Control.TabIndex = 1;
            // 
            // txt_Caption
            // 
            this.txt_Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Caption.Location = new System.Drawing.Point(75, 0);
            this.txt_Caption.Multiline = true;
            this.txt_Caption.Name = "txt_Caption";
            this.txt_Caption.Size = new System.Drawing.Size(114, 34);
            this.txt_Caption.TabIndex = 2;
            this.txt_Caption.Text = "Caption";
            this.txt_Caption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Caption.Visible = false;
            // 
            // btn_Remove_Image
            // 
            this.btn_Remove_Image.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Remove_Image.Location = new System.Drawing.Point(189, 0);
            this.btn_Remove_Image.Name = "btn_Remove_Image";
            this.btn_Remove_Image.Size = new System.Drawing.Size(75, 34);
            this.btn_Remove_Image.TabIndex = 1;
            this.btn_Remove_Image.Text = "Remove Image";
            this.btn_Remove_Image.UseVisualStyleBackColor = true;
            this.btn_Remove_Image.Click += new System.EventHandler(this.btn_Remove_Image_Click);
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Add_Image.Location = new System.Drawing.Point(0, 0);
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.Size = new System.Drawing.Size(75, 34);
            this.btn_Add_Image.TabIndex = 0;
            this.btn_Add_Image.Text = "Add Image";
            this.btn_Add_Image.UseVisualStyleBackColor = true;
            this.btn_Add_Image.Click += new System.EventHandler(this.btn_Add_Image_Click);
            // 
            // btn_Image_Left
            // 
            this.btn_Image_Left.BackgroundImage = global::script_application.Properties.Resources.left;
            this.btn_Image_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Image_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Image_Left.Location = new System.Drawing.Point(3, 3);
            this.btn_Image_Left.Name = "btn_Image_Left";
            this.btn_Image_Left.Size = new System.Drawing.Size(24, 34);
            this.btn_Image_Left.TabIndex = 1;
            this.btn_Image_Left.UseVisualStyleBackColor = true;
            this.btn_Image_Left.Click += new System.EventHandler(this.btn_Image_Left_Click);
            // 
            // pic_Image
            // 
            this.pic_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Image.Location = new System.Drawing.Point(3, 3);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(324, 237);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Image.TabIndex = 3;
            this.pic_Image.TabStop = false;
            // 
            // pnl_Description
            // 
            this.pnl_Description.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Description.Controls.Add(this.txt_Description);
            this.pnl_Description.Controls.Add(this.lbl_Description);
            this.pnl_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Description.Location = new System.Drawing.Point(0, 65);
            this.pnl_Description.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnl_Description.Name = "pnl_Description";
            this.pnl_Description.Padding = new System.Windows.Forms.Padding(5, 35, 5, 5);
            this.pnl_Description.Size = new System.Drawing.Size(336, 185);
            this.pnl_Description.TabIndex = 1;
            // 
            // txt_Description
            // 
            this.txt_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Description.Location = new System.Drawing.Point(5, 35);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(326, 145);
            this.txt_Description.TabIndex = 1;
            this.txt_Description.TextChanged += new System.EventHandler(this.txt_Description_TextChanged);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(3, 5);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(192, 25);
            this.lbl_Description.TabIndex = 0;
            this.lbl_Description.Text = "Page Description";
            this.lbl_Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_Page_Control
            // 
            this.pnl_Page_Control.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Page_Control.Controls.Add(this.tbl_Page_Number);
            this.pnl_Page_Control.Controls.Add(this.btn_Page_Right);
            this.pnl_Page_Control.Controls.Add(this.btn_Page_Left);
            this.pnl_Page_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Page_Control.Location = new System.Drawing.Point(0, 0);
            this.pnl_Page_Control.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_Page_Control.Name = "pnl_Page_Control";
            this.pnl_Page_Control.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Page_Control.Size = new System.Drawing.Size(336, 55);
            this.pnl_Page_Control.TabIndex = 0;
            // 
            // tbl_Page_Number
            // 
            this.tbl_Page_Number.ColumnCount = 2;
            this.tbl_Page_Number.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Page_Number.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Page_Number.Controls.Add(this.pnl_Overview, 0, 0);
            this.tbl_Page_Number.Controls.Add(this.cbo_Page_Number, 1, 0);
            this.tbl_Page_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Page_Number.Location = new System.Drawing.Point(40, 10);
            this.tbl_Page_Number.Name = "tbl_Page_Number";
            this.tbl_Page_Number.RowCount = 1;
            this.tbl_Page_Number.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Page_Number.Size = new System.Drawing.Size(256, 35);
            this.tbl_Page_Number.TabIndex = 3;
            // 
            // pnl_Overview
            // 
            this.pnl_Overview.Controls.Add(this.btn_Overview);
            this.pnl_Overview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Overview.Location = new System.Drawing.Point(3, 3);
            this.pnl_Overview.Name = "pnl_Overview";
            this.pnl_Overview.Size = new System.Drawing.Size(122, 29);
            this.pnl_Overview.TabIndex = 1;
            // 
            // btn_Overview
            // 
            this.btn_Overview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Overview.Location = new System.Drawing.Point(0, 0);
            this.btn_Overview.Name = "btn_Overview";
            this.btn_Overview.Size = new System.Drawing.Size(122, 29);
            this.btn_Overview.TabIndex = 0;
            this.btn_Overview.Text = "Overview";
            this.btn_Overview.UseVisualStyleBackColor = true;
            this.btn_Overview.Click += new System.EventHandler(this.btn_Overview_Click);
            // 
            // cbo_Page_Number
            // 
            this.cbo_Page_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Page_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Page_Number.FormattingEnabled = true;
            this.cbo_Page_Number.Location = new System.Drawing.Point(131, 3);
            this.cbo_Page_Number.Name = "cbo_Page_Number";
            this.cbo_Page_Number.Size = new System.Drawing.Size(122, 28);
            this.cbo_Page_Number.TabIndex = 0;
            this.cbo_Page_Number.Text = "Page #";
            this.cbo_Page_Number.SelectedIndexChanged += new System.EventHandler(this.cbo_Page_Number_SelectedIndexChanged);
            // 
            // btn_Page_Right
            // 
            this.btn_Page_Right.BackgroundImage = global::script_application.Properties.Resources.right;
            this.btn_Page_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Page_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Page_Right.Location = new System.Drawing.Point(296, 10);
            this.btn_Page_Right.Name = "btn_Page_Right";
            this.btn_Page_Right.Size = new System.Drawing.Size(30, 35);
            this.btn_Page_Right.TabIndex = 1;
            this.btn_Page_Right.UseVisualStyleBackColor = true;
            this.btn_Page_Right.Click += new System.EventHandler(this.btn_Page_Right_Click);
            // 
            // btn_Page_Left
            // 
            this.btn_Page_Left.BackgroundImage = global::script_application.Properties.Resources.left;
            this.btn_Page_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Page_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Page_Left.Location = new System.Drawing.Point(10, 10);
            this.btn_Page_Left.Name = "btn_Page_Left";
            this.btn_Page_Left.Size = new System.Drawing.Size(30, 35);
            this.btn_Page_Left.TabIndex = 0;
            this.btn_Page_Left.UseVisualStyleBackColor = true;
            this.btn_Page_Left.Click += new System.EventHandler(this.btn_Page_Left_Click);
            // 
            // PageForm
            // 
            this.Controls.Add(this.tlp_base);
            this.MinimumSize = new System.Drawing.Size(835, 400);
            this.Name = "PageForm";
            this.Size = new System.Drawing.Size(944, 584);
            this.Load += new System.EventHandler(this.PageForm_Load);
            this.tlp_base.ResumeLayout(false);
            this.pnl_Left.ResumeLayout(false);
            this.pnl_Script.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Script)).EndInit();
            this.pnl_Preview.ResumeLayout(false);
            this.pnl_Line.ResumeLayout(false);
            this.pnl_Line.PerformLayout();
            this.pnl_Line_Info.ResumeLayout(false);
            this.pnl_Script_Control.ResumeLayout(false);
            this.pnl_Right.ResumeLayout(false);
            this.tlp_Script_Info.ResumeLayout(false);
            this.pnl_Images.ResumeLayout(false);
            this.tbl_Images.ResumeLayout(false);
            this.tbl_Image_Control.ResumeLayout(false);
            this.pnl_Image_Control.ResumeLayout(false);
            this.pnl_Image_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.pnl_Description.ResumeLayout(false);
            this.pnl_Description.PerformLayout();
            this.pnl_Page_Control.ResumeLayout(false);
            this.tbl_Page_Number.ResumeLayout(false);
            this.pnl_Overview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_base;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Panel pnl_Script_Control;
        private System.Windows.Forms.Button btn_Move_Up;
        private System.Windows.Forms.Button btn_Move_Down;
        private System.Windows.Forms.Button btn_Remove_Line;
        private System.Windows.Forms.Button btn_Add_Line;
        private System.Windows.Forms.Panel pnl_Line;
        private System.Windows.Forms.ComboBox cbo_Character;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.TextBox txt_Line;
        private System.Windows.Forms.Button btn_Edit_Styles;
        private System.Windows.Forms.Button btn_Cancel_Line;
        private System.Windows.Forms.Button btn_Save_Line;
        private System.Windows.Forms.Panel pnl_Line_Info;
        private System.Windows.Forms.TableLayoutPanel tlp_Script_Info;
        private System.Windows.Forms.Panel pnl_Images;
        private System.Windows.Forms.Panel pnl_Description;
        private System.Windows.Forms.Panel pnl_Page_Control;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Button btn_Page_Left;
        private System.Windows.Forms.Button btn_Page_Right;
        private System.Windows.Forms.TableLayoutPanel tbl_Page_Number;
        private System.Windows.Forms.ComboBox cbo_Page_Number;
        private System.Windows.Forms.TableLayoutPanel tbl_Images;
        private System.Windows.Forms.TableLayoutPanel tbl_Image_Control;
        private System.Windows.Forms.Button btn_Image_Right;
        private System.Windows.Forms.Button btn_Image_Left;
        private System.Windows.Forms.Panel pnl_Image_Control;
        private System.Windows.Forms.Button btn_Remove_Image;
        private System.Windows.Forms.Button btn_Add_Image;
        private System.Windows.Forms.PictureBox pic_Image;
        private System.Windows.Forms.TextBox txt_Caption;
        private System.Windows.Forms.Panel pnl_Overview;
        private System.Windows.Forms.Button btn_Overview;
        private System.Windows.Forms.Panel pnl_Preview;
        private System.Windows.Forms.Label lbl_Preview;
        private System.Windows.Forms.Panel pnl_Script;
        private System.Windows.Forms.DataGridView dgv_Script;
        private System.Windows.Forms.DataGridViewTextBoxColumn lines;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

