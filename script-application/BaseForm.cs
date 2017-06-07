using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace script_application
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public BaseForm(string fileName)
        {            
            InitializeComponent();
            if (fileName != null)
            {
                string De_Serial;

                var _jsonSettings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    ObjectCreationHandling = ObjectCreationHandling.Auto
                };

                System.IO.StreamReader input = new System.IO.StreamReader(fileName);
                De_Serial = input.ReadToEnd();
                input.Close();
                file = JsonConvert.DeserializeObject<Files>(De_Serial, _jsonSettings);
                SaveFile = fileName;

                change = false;
                ctf_Contents_Main.Create_Cards();
                From_Page();
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        public Files file = new Files();
        static public string SaveFile = "";
        static public bool change = false;

        public Page SelectedPage;

        //File Menu
        //  New File
        //  Open File
        //  Save File
        //  Save As File
        //  Exit

        public void data_changed()
        {
            change = true;
        }

        private void New_File()
        {
            // Ask to save, delete the file, create a new file, clear all forms
        }

        protected virtual void Open_File()
        {            
            ofd.Filter = "COMIC|*.comic";
            ofd.Title = "Select File to Open";
            string De_Serial;

            var _jsonSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ObjectCreationHandling = ObjectCreationHandling.Auto
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader input = new System.IO.StreamReader(ofd.FileName);
                De_Serial = input.ReadToEnd();
                input.Close();
                file = JsonConvert.DeserializeObject<Files>(De_Serial, _jsonSettings);
                SaveFile = ofd.FileName;

                change = false;
                ctf_Contents_Main.Create_Cards();
                From_Page();
            }
        }

        protected virtual void Save_File()
        {
            var _jsonSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ObjectCreationHandling = ObjectCreationHandling.Auto
            };

            if (SaveFile != "")
            {
                string Serial;
                Serial = JsonConvert.SerializeObject(file, Formatting.Indented, _jsonSettings);
                System.IO.StreamWriter output = new System.IO.StreamWriter(SaveFile);
                output.Write(Serial);
                output.Close();
                change = false;
            }
            else
            {
                Save_As_File();
            }
        }

        protected virtual void Save_As_File()
        {
            sfd.Filter = "COMIC|*.comic";
            sfd.Title = "Select Location to Save";
            string Serial;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Serial = JsonConvert.SerializeObject(file, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                System.IO.StreamWriter output = new System.IO.StreamWriter(sfd.FileName);
                output.Write(Serial);
                output.Close();
                SaveFile = sfd.FileName;
                change = false;
            }
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (change == true)
            {
                Closing_Dialog(e);
            }
        }

        private void Closing_Dialog(FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Save changes?", "Script App", MessageBoxButtons.YesNoCancel);            
            if (dlg == DialogResult.Yes)
            {
                Save_File();
                if (SaveFile == "")
                {
                    Closing_Dialog(e);
                }
                e.Cancel = false;
            }
            if (dlg == DialogResult.No)
            {
                e.Cancel = false;
            }

            if (dlg == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        public void To_Page(Page page)
        {
            pgf_Page.Visible = true;
            ctf_Contents_Main.Visible = false;
            pgf_Page.Load_Page(page);

        }

        public void From_Page()
        {
            pgf_Page.Visible = false;
            ctf_Contents_Main.Visible = true;
            ctf_Contents_Main.Create_Cards();
        }        

        private bool Save_Dialog()
        {
            DialogResult dlg = MessageBox.Show("Save changes?", "Script App", MessageBoxButtons.YesNoCancel);
            if (dlg == DialogResult.Yes)
            {
                Save_File();
                return true;
            }
            if (dlg == DialogResult.No)
            {
               return true;
            }

            if (dlg == DialogResult.Cancel)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        private void tsm_New_Click(object sender, EventArgs e)
        {
            New_File();
        }

        private void tsm_Open_Click(object sender, EventArgs e)
        {
            if (change == true)
            {
                if (Save_Dialog())
                {
                    Open_File();
                }
            }
            else
            {
                Open_File();
            }
        }

        private void tsm_Save_Click(object sender, EventArgs e)
        {
            Save_File();
        }

        private void tsm_Save_As_Click(object sender, EventArgs e)
        {
            Save_As_File();
        }

        private void tsm_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Edit_Page(Page page)
        {
            //save any changed data (title, summary, card order)
            To_Page(page);
        }               

        private void tsm_Line_Click(object sender, EventArgs e)
        {
            var myForm = new Styles(this);
            myForm.Show();
        }
    }
}
