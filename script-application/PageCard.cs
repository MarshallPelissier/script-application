using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace script_application
{
    public partial class PageCard : UserControl
    {
        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                if (IsSelected)
                {
                    Selected();
                }
                else
                {
                    Deselected();
                }
            }
        }
        public ContentsForm Contents;
        public Page PageData;
        public int PageNum;
        public string PageSummary;

        public PageCard()
        {
            InitializeComponent();
        }

        public PageCard(int num, ContentsForm contform)
        {
            InitializeComponent();
            PageData = new Page(num);            
        }        

        public void Set_Page_Num(int num)
        {
            lbl_Page_Num.Text = num.ToString();
            PageData.PageNum = num;
            PageNum = num;
        }

        public void Set_Summary(string summary)
        {
            txt_Card_Desc.Text = summary;
            PageSummary = summary;
        }

        private void Selected()
        {
            pnl_Arrows.Visible = true;
            this.BorderStyle = BorderStyle.Fixed3D;
            Contents.Add_Selected_Card(this);
        }

        private void Deselected()
        {         
            pnl_Arrows.Visible = false;
            this.BorderStyle = BorderStyle.None;
            Contents.Remove_Selected_Card(this);
        }        

        public event EventHandler<EventArgs> WasClicked;

        private void PageCard_Load(object sender, EventArgs e) 
        {
            // Register the MouseClick event with the UC's surface.
            this.MouseClick += Control_MouseClick;
            // Register MouseClick with all child controls.
            RegisterMouseEvents(Controls);
            Deselected();
        }

        private void RegisterMouseEvents(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                // Subscribe the control to the 
                control.MouseClick += Control_MouseClick;
                if (control.HasChildren) RegisterMouseEvents(control.Controls);
            }
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            var wasClicked = WasClicked;
            if (wasClicked != null)
            {
                WasClicked(this, EventArgs.Empty);
            }
            // Select this UC on click.
            IsSelected = true;
        }       

        private void btn_Shift_Left_Click(object sender, EventArgs e)
        {
            Contents.Move_Card(true);
        }

        private void btn_Shift_Right_Click(object sender, EventArgs e)
        {
            Contents.Move_Card(false);
        }

        private void txt_Card_Desc_TextChanged(object sender, EventArgs e)
        {
            if (!Contents.IsLoading())
            {
                BaseForm bf = Contents.ParentForm as BaseForm;
                int pindex = bf.file.Pages.IndexOf(PageData);
                bf.file.Pages.RemoveAt(pindex);
                PageData.Description = txt_Card_Desc.Text;
                bf.file.Pages.Insert(pindex, PageData);
            }
        }        
    }
}
