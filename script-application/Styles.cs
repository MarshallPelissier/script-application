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
    public partial class Styles : Form
    {
        public BaseForm Baseform;

        public Styles()
        {
            InitializeComponent();
        }

        public Styles(BaseForm baseform)
        {
            InitializeComponent();
            Baseform = baseform;
        }

        private void Styles_Load(object sender, EventArgs e)
        {
            Populate_Combo_Type();
            Populate_Combo_Char();
        }

        public void Populate_Combo_Type()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();
            ComboboxItem NewItem = new ComboboxItem();
            NewItem.Text = "New";
            NewItem.Value = new Types();
            items.Add(NewItem);

            foreach (Types type in Baseform.file.Types)
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
            Check_Data_Type();
        }

        public void Populate_Fields_Type()
        {
            ComboboxItem citem;
            Types titem;
            if ( cbo_Type.SelectedItem is ComboboxItem)
            {
                citem = cbo_Type.SelectedItem as ComboboxItem;
                if (citem.Value is Types)
                {
                    titem = citem.Value as Types;
                    txt_Type_Name.Text = titem.TypeName;
                    txt_Type_Pre.Text = titem.PreLine;
                    txt_Type_Post.Text = titem.PostLine;
                    txt_Type_Post_Char.Text = titem.PostCharacter;
                    chk_Type_Character.Checked = titem.Character;
                }
            }
        }

        private void Check_Data_Type()
        {
            bool sameName = false;
            foreach (ComboboxItem item in cbo_Type.Items)
            {
                if (item.Text == txt_Type_Name.Text && item != cbo_Type.SelectedItem)
                {
                    sameName = true;
                }
            }
            if (cbo_Type.Text == "" ||
                txt_Type_Name.Text == "" ||
                txt_Type_Pre.Text == "" ||
                txt_Type_Post.Text == "" ||
                (txt_Type_Post_Char.Text == "" &&
                chk_Type_Character.Checked) ||
                sameName)
            {
                btn_Type_Save.Enabled = false;
            }
            else
            {
                btn_Type_Save.Enabled = true;
            }
        }

        private void cbo_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check_Data_Type();
            if (cbo_Type.SelectedItem != null)
            {
                if (cbo_Type.SelectedItem.ToString() == "New")
                {
                    btn_Type_Delete.Enabled = false;                   
                }
                else
                {
                    btn_Type_Delete.Enabled = true;
                }
                Populate_Fields_Type();
            }
        }       

        private void Type_Data_Changed(object sender, EventArgs e)
        {
            Check_Data_Type();
        }

        private void btn_Type_Save_Click(object sender, EventArgs e)
        {
            Baseform.data_changed();
            if (cbo_Type.SelectedItem.ToString() == "New")
            {
                Types newType = new Types();
                newType.TypeName = txt_Type_Name.Text;
                newType.PreLine = txt_Type_Pre.Text;
                newType.PostLine = txt_Type_Post.Text;
                newType.PostCharacter = txt_Type_Post_Char.Text;
                newType.Character = chk_Type_Character.Checked;
                Baseform.file.Types.Add(newType);
            }
            else
            {
                ComboboxItem citem;
                Types titem;
                if ( cbo_Type.SelectedItem is ComboboxItem)
                {
                    citem = cbo_Type.SelectedItem as ComboboxItem;
                    if (citem.Value is Types)
                    {
                        titem = citem.Value as Types;
                        //Baseform.file.Types.IndexOf(titem);
                        titem.TypeName = txt_Type_Name.Text;
                        titem.PreLine = txt_Type_Pre.Text;
                        titem.PostLine = txt_Type_Post.Text;
                        titem.PostCharacter = txt_Type_Post_Char.Text;
                        titem.Character = chk_Type_Character.Checked;
                    }
                }
            }
            Populate_Combo_Type();
            Populate_Fields_Type();
        }

        private void btn_Type_Delete_Click(object sender, EventArgs e)
        {
            ComboboxItem citem;
            Types titem;
            if (cbo_Type.SelectedItem is ComboboxItem)
            {
                citem = cbo_Type.SelectedItem as ComboboxItem;
                if (citem.Value is Types)
                {
                    titem = citem.Value as Types;
                    Baseform.file.Types.Remove(titem);
                }
            }
            Populate_Combo_Type();
            Populate_Fields_Type();
        }

        //Characters

        public void Populate_Combo_Char()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();
            ComboboxItem NewItem = new ComboboxItem();
            NewItem.Text = "New";
            NewItem.Value = "";
            items.Add(NewItem);

            foreach (string character in Baseform.file.Characters)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = character;
                item.Value = character;
                items.Add(item);
            }
            cbo_Char.DataSource = null;
            cbo_Char.Items.Clear();
            cbo_Char.DisplayMember = "Text";
            cbo_Char.ValueMember = "Value";
            cbo_Char.DataSource = items;
            Check_Data_Char();
        }

        public void Populate_Fields_Char()
        {
            ComboboxItem citem;
            if (cbo_Char.SelectedItem is ComboboxItem)
            {
                citem = cbo_Char.SelectedItem as ComboboxItem;
                txt_Char_Name.Text = citem.Value.ToString();      
            }
        }

        public void Check_Data_Char()
        {
            bool sameName = false;
            foreach (ComboboxItem item in cbo_Char.Items)
            {
                if (item.Text == txt_Char_Name.Text && item != cbo_Char.SelectedItem)
                {
                    sameName = true;
                }
            }
            if (txt_Char_Name.Text == "" || sameName)
            {
                btn_Char_Save.Enabled = false;
            }
            else
            {
                btn_Char_Save.Enabled = true;
            }
        }

        private void cbo_Char_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check_Data_Char();
            if (cbo_Char.SelectedItem != null)
            {
                if (cbo_Char.SelectedItem.ToString() == "New")
                {
                    btn_Char_Delete.Enabled = false;
                }
                else
                {
                    btn_Char_Delete.Enabled = true;
                }
                Populate_Fields_Char();
            }
        }

        private void Char_Data_Changed(object sender, EventArgs e)
        {
            Check_Data_Char();
        }

        private void btn_Char_Save_Click(object sender, EventArgs e)
        {
            Baseform.data_changed();
            if (cbo_Char.SelectedItem.ToString() == "New")
            {
                string character = txt_Char_Name.Text;
                Baseform.file.Characters.Add(character);
            }
            else
            {
                ComboboxItem citem;
                if (cbo_Char.SelectedItem is ComboboxItem)
                {
                    citem = cbo_Char.SelectedItem as ComboboxItem;
                    int index = Baseform.file.Characters.IndexOf(citem.Text);
                    if (index > -1)
                    {
                        Baseform.file.Characters.RemoveAt(index);
                        Baseform.file.Characters.Add(txt_Char_Name.Text);
                    }
                }
            }
            Populate_Combo_Char();
            Populate_Fields_Char();
        }

        private void btn_Char_Delete_Click(object sender, EventArgs e)
        {
            ComboboxItem citem;
            if (cbo_Char.SelectedItem is ComboboxItem)
            {
                citem = cbo_Char.SelectedItem as ComboboxItem;
                int index = Baseform.file.Characters.IndexOf(citem.Text);
                if (index > -1)
                {
                    Baseform.file.Characters.RemoveAt(index);
                }
                
            }
            Populate_Combo_Char();
            Populate_Fields_Char();
        }
    }
}
