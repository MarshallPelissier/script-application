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

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        public File file = new File();
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
            ofd.Filter = "TDF|*.tdf";
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
                file = JsonConvert.DeserializeObject<File>(De_Serial, _jsonSettings);
                SaveFile = ofd.FileName;

                ctf_Contents_Main.Create_Cards();
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
            }
            else
            {
                Save_As_File();
            }
        }

        protected virtual void Save_As_File()
        {
            sfd.Filter = "TDF|*.tdf";
            sfd.Title = "Select Location to Save";
            string Serial;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Serial = JsonConvert.SerializeObject(file, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                System.IO.StreamWriter output = new System.IO.StreamWriter(sfd.FileName);
                output.Write(Serial);
                output.Close();
                SaveFile = sfd.FileName;
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
            DialogResult dlg = MessageBox.Show("Save changes?", "To Do", MessageBoxButtons.YesNoCancel);

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

        private void tsm_New_Click(object sender, EventArgs e)
        {
            New_File();
        }

        private void tsm_Open_Click(object sender, EventArgs e)
        {
            Open_File();
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

        public void To_Page(Page page = null)
        {
            pgf_Page.Visible = true;
            ctf_Contents_Main.Visible = false;

        }

        public void From_Page()
        {
            pgf_Page.Visible = false;
            ctf_Contents_Main.Visible = true;
        }
        //Page Menu
        //  New Page

        public void New_Page()
        {
            //save any changed data (title, summary, card order)
            ctf_Contents_Main.New_Card();
            To_Page();
        }

        public void Edit_Page(Page page)
        {
            //save any changed data (title, summary, card order)
            To_Page(page);
        }        

        private void tsm_New_Page_Click(object sender, EventArgs e)
        {
            New_Page();
        }

        private void tsm_Overview_Click(object sender, EventArgs e)
        {
            From_Page();
        }

        private void tsm_Line_Click(object sender, EventArgs e)
        {
            var myForm = new Styles();
            myForm.Show();
        }
    }
}
