using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace script_application
{
    public partial class PageForm : UserControl
    {
        private BaseForm _baseform;
        private Page _page;
        private Page _pageTemp;
        private Line _line;
        private int _imageIndex = -1;
        private string _appPath;
        private bool _loading = false;

        public PageForm()
        {
            InitializeComponent();
        }
        
        private void PageForm_Load(object sender, EventArgs e)
        {
            _baseform = ParentForm as BaseForm;
            pnl_Line.Visible = false;          
        }

        public void Load_Page(Page page)
        {
            _loading = true;
            _baseform = ParentForm as BaseForm;
            pnl_Preview.Visible = true;
            pnl_Line.Visible = false;
            pnl_Preview.Visible = false;
            txt_Line.Clear();
            txt_Caption.Clear();
            Populate_Types();
            Populate_Char();
            _appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";
            if (Directory.Exists(_appPath) == false)
            {
                Directory.CreateDirectory(_appPath);
            }
            Update_List(page);
            Update_Image(-1, true);
            dgv_Script.ClearSelection();
            pnl_Line.Visible = false;
            pnl_Preview.Visible = false;
            _line = null;
            txt_Line.Text = "";
            btn_Remove_Line.Enabled = false;
            cbo_Page_Number.Text = "Page # " + page.PageNum;
            txt_Description.Text = page.Description;
            Populate_Pages();
            _loading = false;
        }

        // combo box logic and events
        private void Populate_Pages()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();
            ComboboxItem NewItem = new ComboboxItem();
            NewItem.Text = "Page # " + _page.PageNum;
            NewItem.Value = -1;
            items.Add(NewItem);

            foreach (Page page in _baseform.file.Pages)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = "# " + page.PageNum;
                item.Value = page.PageNum;
                items.Add(item);
            }

            cbo_Page_Number.DataSource = null;
            //cbo_Page_Number.Items.Clear();
            cbo_Page_Number.DisplayMember = "Text";
            cbo_Page_Number.ValueMember = "Value";
            cbo_Page_Number.DataSource = items;
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

        private void cbo_Page_Number_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem citem;
            if (cbo_Page_Number.SelectedItem is ComboboxItem)
            {
                citem = cbo_Page_Number.SelectedItem as ComboboxItem;
                int index = Convert.ToInt32(citem.Value) - 1;
                if (index > -1)
                {
                    _baseform.To_Page(_baseform.file.Pages[index]);
                }
            }
        }

        private void cbo_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preview_Line();
        }

        private void cbo_Character_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preview_Line();
        }

        //Line manipulation logic and events
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
                Line tempL = _line;
                Update_List();
                txt_Line.Text = "";
                dgv_Script.ClearSelection();
                _line = tempL;
                Set_Comboboxes();
                _line = null;
                btn_Remove_Line.Enabled = false;

                int pindex = _baseform.file.Pages.IndexOf(_pageTemp);
                _baseform.file.Pages.RemoveAt(pindex);
                _baseform.file.Pages.Insert(pindex, _page);
                _pageTemp = _page;

            }
        }

        private void Move_Line(bool down = false)
        {
            if (dgv_Script.SelectedRows.Count > 0 && _line != null)
            {
                int index = _page.Lines.IndexOf(_line);
                int max = _page.Lines.Count -1;
                if (down)
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
                _page.Lines.Remove(_line);
                _page.Lines.Insert(index, _line);

                int pindex = _baseform.file.Pages.IndexOf(_pageTemp);
                _baseform.file.Pages.RemoveAt(pindex);
                _baseform.file.Pages.Insert(pindex, _page);
                _pageTemp = _page;

                Update_List(_page);
                dgv_Script.ClearSelection();
                dgv_Script.Rows[index].Selected = true;
            }
        }

        private bool Remove_Dialog()
        {
            DialogResult dlg = MessageBox.Show("Remove Line?", "Script App", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {               
                return true;
            }
            if (dlg == DialogResult.No)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        private void Set_Comboboxes()
        {
            if (_line.type != null && _line.type.TypeName != null)
            {
                cbo_Type.SelectedIndex = cbo_Type.FindStringExact(_line.type.TypeName);
            }
            else
            {
                cbo_Type.SelectedIndex = cbo_Type.FindStringExact("Types");
            }

            if (_line.character != null)
            {
                cbo_Character.SelectedIndex = cbo_Character.FindStringExact(_line.character);
            }
            else
            {
                cbo_Character.SelectedIndex = cbo_Character.FindStringExact("Characters");
            }
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
            if (Remove_Dialog())
            {
                _baseform.data_changed();
                pnl_Line.Visible = false;

                _page.Lines.Remove(_line);

                int pindex = _baseform.file.Pages.IndexOf(_pageTemp);
                _baseform.file.Pages.RemoveAt(pindex);
                _baseform.file.Pages.Insert(pindex, _page);
                _pageTemp = _page;

                Update_List(_page);
                dgv_Script.ClearSelection();
            }
        }

        private void btn_Cancel_Line_Click(object sender, EventArgs e)
        {
            pnl_Line.Visible = false;
            txt_Line.Text = "";
            cbo_Type.SelectedIndex = -1;
            cbo_Type.Text = "Type";
            cbo_Character.SelectedIndex = -1;
            cbo_Character.Text = "Character";
            _line = null;
            txt_Line.Text = "";
            btn_Remove_Line.Enabled = false;
            dgv_Script.ClearSelection();
        }

        private void btn_Save_Line_Click(object sender, EventArgs e)
        {
            //apply the format to the line then save.
            Save_Line();
            _baseform.data_changed();
        }
        
        private void txt_Line_TextChanged(object sender, EventArgs e)
        {
            Preview_Line();
        }        
                
        private void btn_Edit_Styles_Click(object sender, EventArgs e)
        {
            var myForm = new Styles(_baseform);
            myForm.Show();
        }

        private void dgv_Script_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Script.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Script.SelectedRows)
                {                   
                    _line = row.Cells[1].Value as Line;
                    txt_Line.Text = _line.line;
                }
                pnl_Line.Visible = true;

                Set_Comboboxes();
                //if (_line.type != null && _line.type.TypeName != null)
                //{
                //    cbo_Type.SelectedIndex = cbo_Type.FindStringExact(_line.type.TypeName);
                //}
                //else
                //{
                //    cbo_Type.SelectedIndex = cbo_Type.FindStringExact("Types");
                //}

                //if (_line.character != null)
                //{
                //    cbo_Character.SelectedIndex = cbo_Character.FindStringExact(_line.character);
                //}
                //else
                //{
                //    cbo_Character.SelectedIndex = cbo_Character.FindStringExact("Characters");
                //}
                btn_Remove_Line.Enabled = true;
            }
            else
            {
                _line = null;
                btn_Remove_Line.Enabled = false;
            }
        }

        private void btn_Move_Up_Click(object sender, EventArgs e)
        {
            Move_Line();
        }

        private void btn_Move_Down_Click(object sender, EventArgs e)
        {
            Move_Line(true);
        }  

        //Image logic and events
        private void Change_Image(bool left = true)
        {
            int index = _imageIndex;
            if(left)
            {
                index--;
                if (index < 0)
                {
                    index = _page.Images.Count - 1;
                }
            }
            else
            {
                index++;
                if (index >= _page.Images.Count)
                {
                    index = 0;
                }
            }
            Update_Image(index);
        }
        
        private void Update_Image(int index, bool load = false)
        {
            if (index > -1)
            {
                pic_Image.Image = new Bitmap(_appPath + _page.Images[index]);
                _imageIndex = index;
                btn_Remove_Image.Enabled = true;
            }
            else
            {                
                pic_Image.Image = null;
                btn_Remove_Image.Enabled = false;
            }
            if (load)
            {
                if (_page.Images.Count > 0)
                {
                    pic_Image.Image = new Bitmap(_appPath + _page.Images[0]);
                    _imageIndex = 0;
                    btn_Remove_Image.Enabled = true;
                }
            }
        }
        
        private void btn_Add_Image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Images |* .png; *jpg; *jpeg; *.bmp";

                

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string iName = dlg.SafeFileName;   
                        string filepath = dlg.FileName;
                        string newpath = "_" + _baseform.file.Project_Name + "_" + iName;
                        File.Copy(filepath, _appPath + newpath);

                        Bitmap temp = new Bitmap(_appPath + newpath);
                        _page.Images.Add(newpath);
                        _imageIndex = _page.Images.IndexOf(newpath);

                        int pindex = _baseform.file.Pages.IndexOf(_pageTemp);
                        _baseform.file.Pages.RemoveAt(pindex);
                        _baseform.file.Pages.Insert(pindex, _page);
                        _pageTemp = _page;

                        Update_Image(_imageIndex);
                        _baseform.data_changed();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Unable to open file " + exp.Message);
                    }

                    // PictureBox PictureBox1 = new PictureBox();
                    // PictureBox1.Image = new Bitmap(dlg.FileName);

                    // Add the new control to its parent's controls collection
                    //this.Controls.Add(PictureBox1);


                }
            }
        }

        private void btn_Remove_Image_Click(object sender, EventArgs e)
        {
            List<string> images = new List<string>();
            int index = _imageIndex;
            foreach (string img in _page.Images)
            {
                images.Add(img);
            }
            _page.Images.RemoveAt(_imageIndex);
            int pindex = _baseform.file.Pages.IndexOf(_pageTemp);
            _baseform.file.Pages.RemoveAt(pindex);
            _imageIndex = -1;
            Update_Image(-1, true);
            _baseform.file.Pages.Insert(pindex, _page);
            try
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers(); 
                File.Delete(_appPath + images[index]);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to delete file " + exp.Message);
            }
            _pageTemp = _page;
            _baseform.data_changed();
        }

        private void btn_Image_Right_Click(object sender, EventArgs e)
        {
            Change_Image(false);
        }

        private void btn_Image_Left_Click(object sender, EventArgs e)
        {
            Change_Image(true);
        }

        //Page navigation logic and events
        private void Change_Page(bool up = false)
        {
            int index = _baseform.file.Pages.IndexOf(_pageTemp);
            int max = _baseform.file.Pages.Count - 1;
            if (max < 1)
            {
                return;
            }
            if (up)
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
            Load_Page(_baseform.file.Pages[index]);
        }

        private void btn_Overview_Click(object sender, EventArgs e)
        {           
            _baseform.From_Page();
        }

        private void btn_Page_Right_Click(object sender, EventArgs e)
        {
            Change_Page(true);
        }

        private void btn_Page_Left_Click(object sender, EventArgs e)
        {
            Change_Page(false);
        }

        private void txt_Description_TextChanged(object sender, EventArgs e)
        {
            if (!_loading)
            {
                _baseform.data_changed();
            }
            _page.Description = txt_Description.Text;

            int pindex = _baseform.file.Pages.IndexOf(_pageTemp);
            _baseform.file.Pages.RemoveAt(pindex);
            _baseform.file.Pages.Insert(pindex, _page);
            _pageTemp = _page;
        }                     
    }
}
