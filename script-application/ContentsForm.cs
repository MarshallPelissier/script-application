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
    public partial class ContentsForm : UserControl
    {       
        public ContentsForm()
        {
            InitializeComponent();
        }

        private void ContentsForm_Load(object sender, EventArgs e)
        {
            _loading = true;
            _baseform = ParentForm as BaseForm;
            txt_Title.Text = _baseform.file.Project_Name;
            txt_Summary.Text = _baseform.file.Summary;
            _loading = false;
        }

        public void New_Card(Page page)
        {
            int index = Find_Number();            
            PageCard card = new PageCard(index+1, this);
            if (page == null)
            {
                page = new Page(index+1);
                _baseform.file.Pages.Insert(index,page);
            }
            card.Contents = this;
            card.Set_Page_Num(index + 1);
            card.PageData = page;
            card.Set_Summary(page.Description);
            card.WasClicked += UsersGrid_WasClicked;
            flp_Page_Cards.Controls.Add(card);
            flp_Page_Cards.Controls.SetChildIndex(card,index);
            Reset_Numbers();                       
        }

        public void Move_Card(bool up)
        {                       
            int pindex = _baseform.file.Pages.IndexOf(SelectedCard.PageData);
            int index = pindex;
            int max = _baseform.file.Pages.Count - 1;

            if (!up)
            {
                index++;
                if (index > max)
                {
                    index = 0;
                }
            }
            else
            {
                index--;
                if (index < 0)
                {
                    index = max;
                }
            }
            
            _baseform.file.Pages.RemoveAt(pindex);
            _baseform.file.Pages.Insert(index,SelectedCard.PageData);
            Create_Cards();

        }

        private int Find_Number()
        {
            if (SelectedCard != null)
            {
                return flp_Page_Cards.Controls.GetChildIndex(SelectedCard);             
            }
            else
            {
                //return ParentBaseForm.file.Pages.Count;
                return 0;
            }
        }

        public void Reset_Numbers()
        {
            foreach (PageCard pcard in flp_Page_Cards.Controls)
            {
                pcard.Set_Page_Num(flp_Page_Cards.Controls.GetChildIndex(pcard) + 1);
            }
            //Repopulate_List();
            Card_Count();
        }        

        public void Create_Cards()
        {
            _baseform = ParentForm as BaseForm;
            _loadingCards = true;
            flp_Page_Cards.Controls.Clear();
            SelectedCard = null;
            
            for (int i = _baseform.file.Pages.Count - 1; i >= 0; i--)
            {
                Page page = _baseform.file.Pages[i];
                New_Card(page);
            }
            _loadingCards = false;
        }

        public void Card_Count()
        {
            int max = flp_Page_Cards.Controls.Count;
            
            int cur = SelectedCard != null ? SelectedCard.PageNum : 0;
            lbl_Card_Count.Text = cur + " : " + max; 
        }

        void UsersGrid_WasClicked(object sender, EventArgs e)
        {
            // Set IsSelected for all UCs in the FlowLayoutPanel to false. 
            foreach (Control c in flp_Page_Cards.Controls)
            {
                if (c is PageCard)
                {
                    ((PageCard)c).IsSelected = false;
                }
            }
        }

        private void btn_New_Card_Click(object sender, EventArgs e)
        {
            New_Card(null);
        }

        public void Add_Selected_Card(PageCard card)
        {
            SelectedCard = card;
            btn_Edit_Card.Enabled = true;
            btn_Duplicate_Card.Enabled = true;
            btn_Delete_Card.Enabled = true;
            Card_Count();
        }

        public void Remove_Selected_Card(PageCard card)
        {
            if (SelectedCard == card)
            {
                SelectedCard = null;
                btn_Edit_Card.Enabled = false;
                btn_Duplicate_Card.Enabled = false;
                btn_Delete_Card.Enabled = false;
                Card_Count();
                _baseform.data_changed();
            }
        }

        private void btn_Edit_Card_Click(object sender, EventArgs e)
        {
            _baseform.Edit_Page(SelectedCard.PageData);
        }

        private void btn_Duplicate_Card_Click(object sender, EventArgs e)
        {
            Page temp = new Page(SelectedCard.PageData.PageNum + 1);
            temp.Description = SelectedCard.PageData.Description;
            temp.Images = SelectedCard.PageData.Images;
            temp.Lines = SelectedCard.PageData.Lines;
            _baseform.file.Pages.Insert(temp.PageNum - 1, temp);

            Create_Cards();

            _baseform.data_changed();
        } 
 
        private void btn_Delete_Card_Click(object sender, EventArgs e)
        {
            //prompt before deleting
            if (flp_Page_Cards.Controls.Contains(SelectedCard))
            {
                PageCard scard = flp_Page_Cards.Controls[flp_Page_Cards.Controls.GetChildIndex(SelectedCard)] as PageCard;
                _baseform.file.Pages.Remove(scard.PageData);
                scard.Dispose();
                Reset_Numbers();
            }
        }

        private bool _loading = false;
        private bool _loadingCards;        
        public bool IsLoading()
        {
            return _loadingCards;
        }
        public PageCard SelectedCard;
        public BaseForm _baseform;

        private void txt_Title_TextChanged(object sender, EventArgs e)
        {
            _baseform.file.Project_Name = txt_Title.Text;
            if (!_loading)
            {
                _baseform.data_changed();
            }
        }

        private void txt_Summary_TextChanged(object sender, EventArgs e)
        {
            _baseform.file.Summary = txt_Summary.Text;
            if (!_loading)
            {
                _baseform.data_changed();
            }
        }

             
    }
}
