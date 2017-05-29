using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace script_application
{
    public partial class PageForm : UserControl
    {
        public PageForm()
        {
            InitializeComponent();
        }        

        private void btn_Add_Line_Click(object sender, EventArgs e)
        {
            pnl_Line.Visible = true;
        }

        private void btn_Remove_Line_Click(object sender, EventArgs e)
        {
            pnl_Line.Visible = false;
        }

        private void btn_Cancel_Line_Click(object sender, EventArgs e)
        {
            pnl_Line.Visible = false;
            txt_Line.Text = "";
            cbo_Type.SelectedIndex = -1;
            cbo_Type.Text = "Type";
            cbo_Character.SelectedIndex = -1;
            cbo_Character.Text = "Character";
        }

        private void btn_Save_Line_Click(object sender, EventArgs e)
        {
            //apply the format to the line then save.
        }

        private void btn_Overview_Click(object sender, EventArgs e)
        {
            BaseForm baseForm = ParentForm as BaseForm;
            baseForm.From_Page();
        }
    }
}
