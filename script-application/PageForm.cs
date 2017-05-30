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
        private BaseForm _baseform;
        private Page _page;
        private Page _pageTemp;
        private Line _line;

        public PageForm()
        {
            InitializeComponent();
        }

        private void PageForm_Load(object sender, EventArgs e)
        {
            _baseform = ParentForm as BaseForm;
            pnl_Line.Visible = false;
            
        }

        private void btn_Add_Line_Click(object sender, EventArgs e)
        {
            pnl_Line.Visible = true;
            dgv_Script.ClearSelection();
            _line = null;
            txt_Line.Text = "";
        }

        private void btn_Remove_Line_Click(object sender, EventArgs e)
        {
            _baseform.data_changed();
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
            _baseform.data_changed();
        }

        private void btn_Overview_Click(object sender, EventArgs e)
        {
            BaseForm baseForm = ParentForm as BaseForm;
            baseForm.From_Page();
        }

        private void txt_Line_TextChanged(object sender, EventArgs e)
        {
            Preview_Line();
        }

        public void Load_Page(Page page)
        {
            _baseform = ParentForm as BaseForm;
            pnl_Line.Visible = false;
            Populate_Types();
            Populate_Char();
            Update_List(page);
        }

        private void Populate_Types()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();
            ComboboxItem NewItem = new ComboboxItem();
            NewItem.Text = "Types";
            NewItem.Value = new Types();
            items.Add(NewItem);

            foreach (Types type in _baseform.file.Types)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = type.TypeName;
                item.Value = type;
                items.Add(item);
            }
            cbo_Type.DataSource = null;
            cbo_Type.Items.Clear();
            cbo_Type.DisplayMember = "Text";
            cbo_Type.ValueMember = "Value";
            cbo_Type.DataSource = items;
        }

        private void Populate_Char()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();
            ComboboxItem NewItem = new ComboboxItem();
            NewItem.Text = "Characters";
            NewItem.Value = "Characters";
            items.Add(NewItem);

            foreach (string character in _baseform.file.Characters)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = character;
                item.Value = character;
                items.Add(item);
            }
            cbo_Character.DataSource = null;
            cbo_Character.Items.Clear();
            cbo_Character.DisplayMember = "Text";
            cbo_Character.ValueMember = "Value";
            cbo_Character.DataSource = items;
        }

        public void Update_List(Page page = null)
        {
            if (page != null)
            {
                _page = page;
                _pageTemp = page;
            }
            dgv_Script.Rows.Clear();

            foreach (Line l in _page.Lines)
            {
                dgv_Script.Rows.Add(l.ToString(),l);
            }
        }

        private void Preview_Line()
        {
            //Show line as preview with formating
            if (txt_Line.Text != "")
            {
                Line preview = new Line(txt_Line.Text);
                preview.type = Get_Type();
                preview.character = Get_Character();

                pnl_Preview.Visible = true;
                lbl_Preview.Text = preview.ToString();

            }
            else
            {
                pnl_Preview.Visible = false;
            }
        }

        private void Save_Line()
        {
            if (txt_Line.Text != "")
            {
                bool check = (_line == null);
                int index = -1;
                if (check)
                {
                    _line = new Line(txt_Line.Text);

                }
                else
                {
                    index = _page.Lines.IndexOf(_line);
                    _page.Lines.RemoveAt(index);
                    _line.line = txt_Line.Text;
                }
                _line.type = Get_Type();
                _line.character = Get_Character();

                pnl_Preview.Visible = true;
                lbl_Preview.Text = _line.ToString();

                if (check)
                {
                    _page.Lines.Add(_line);
                }
                else
                {
                    _page.Lines.Insert(index, _line);
                }
                _line = null;
                Update_List();
                txt_Line.Text = "";
                dgv_Script.ClearSelection();
                pnl_Line.Visible = false;

                int pindex = _baseform.file.Pages.IndexOf(_pageTemp);
                _baseform.file.Pages.RemoveAt(pindex);
                _baseform.file.Pages.Insert(pindex, _page);

            }
        }

        private Types Get_Type()
        {
            ComboboxItem citem;
            if (cbo_Type.SelectedItem is ComboboxItem)
            {
                citem = cbo_Type.SelectedItem as ComboboxItem;
                return citem.Value as Types;
            }
            return null;
        }

        private string Get_Character()
        {
            ComboboxItem citem;
            if (cbo_Character.SelectedItem is ComboboxItem)
            {
                citem = cbo_Character.SelectedItem as ComboboxItem;
                return citem.Text;
            }
            return null;
        }

        private void cbo_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preview_Line();
        }

        private void cbo_Character_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preview_Line();
        }

        private void btn_Edit_Styles_Click(object sender, EventArgs e)
        {
            var myForm = new Styles(_baseform);
            myForm.Show();
        }

        private void btn_Save_Line_Click_1(object sender, EventArgs e)
        {
            Save_Line();
        }

        private void dgv_Script_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_Script_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Script.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Script.SelectedRows)
                {
                    txt_Line.Text = row.Cells[0].Value.ToString();
                    _line = row.Cells[1].Value as Line;
                }
                pnl_Line.Visible = true;
            }            
        }
    }
}
