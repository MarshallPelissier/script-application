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

        public void New_Card(string summary = "")
        {
            ParentBaseForm = ParentForm as BaseForm;
            int index = Find_Number();            

            PageCard card = new PageCard(index+1, this);
            ParentBaseForm.file.Pages.Add(card.PageData);           
            card.Set_Page_Num(index+1);
            card.Set_Summary(summary);
            card.Contents = this;
            card.WasClicked += UsersGrid_WasClicked;
            flp_Page_Cards.Controls.Add(card);
            flp_Page_Cards.Controls.SetChildIndex(card,index);
            Reset_Numbers();
        }

        public void Move_Card(bool up)
        {
            int index = flp_Page_Cards.Controls.GetChildIndex(SelectedCard);
            index = up ? index - 1 : index + 1;
            if (flp_Page_Cards.Controls.Count == index)
            {
                index = 0;
            }
            flp_Page_Cards.Controls.SetChildIndex(SelectedCard, index);
            Reset_Numbers();
        }

        private int Find_Number()
        {
            if (SelectedCard != null)
            {
                return flp_Page_Cards.Controls.GetChildIndex(SelectedCard);             
            }
            else
            {
                return ParentBaseForm.file.Pages.Count;
            }
        }

        public void Reset_Numbers()
        {
            foreach (PageCard pcard in flp_Page_Cards.Controls)
            {
                pcard.Set_Page_Num(flp_Page_Cards.Controls.GetChildIndex(pcard) + 1);
            }
            Repopulate_List();
            Card_Count();
        }

        public void Repopulate_List()
        {
            ParentBaseForm.file.Pages.Clear();
            foreach (PageCard pcard in flp_Page_Cards.Controls)
            {
                ParentBaseForm.file.Pages.Add(pcard.PageData);
            }
        }

        public void Create_Cards()
        {
            flp_Page_Cards.Controls.Clear();
            foreach (string summary in ParentBaseForm.file.Summaries)
            {
                New_Card(summary);
            }
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
            New_Card();
        }

        public void Add_Selected_Card(PageCard card)
        {
            SelectedCard = card;
            btn_Edit_Card.Enabled = true;
            btn_Delete_Card.Enabled = true;
            Card_Count();
        }

        public void Remove_Selected_Card(PageCard card)
        {
            if (SelectedCard == card)
            {
                SelectedCard = null;
                btn_Edit_Card.Enabled = false;
                btn_Delete_Card.Enabled = false;
                Card_Count();
            }
        }

        private void btn_Edit_Card_Click(object sender, EventArgs e)
        {
            ParentBaseForm.file.Summaries.Clear();
            foreach (PageCard pcard in flp_Page_Cards.Controls)
            {
                ParentBaseForm.file.Summaries.Add(pcard.PageSummary);
            }
            ParentBaseForm.Edit_Page(SelectedCard.PageData);
        }

        private void btn_Delete_Card_Click(object sender, EventArgs e)
        {
            //prompt before deleting
            if (flp_Page_Cards.Controls.Contains(SelectedCard))
            {
                PageCard scard = flp_Page_Cards.Controls[flp_Page_Cards.Controls.GetChildIndex(SelectedCard)] as PageCard;
                ParentBaseForm.file.Pages.Remove(scard.PageData);
                scard.Dispose();
                Reset_Numbers();
            }
        }

        public PageCard SelectedCard;
        public BaseForm ParentBaseForm;
    }
}
