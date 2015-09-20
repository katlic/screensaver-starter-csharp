using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screensaver_starter_csharp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void SaveSettings()
        {
            // create or modify existing registry subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + Program.SCREENSAVER_TITLE);
            key.SetValue("displaySeconds", checkBoxSeconds.Checked.ToString());
            key.SetValue("hoursType", radioButton12.Checked ? "12" : "24");
        }

        private void LoadSettings()
        {
            // get values stored in registry subkey
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Program.SCREENSAVER_TITLE);
            if (key == null)
            {
                checkBoxSeconds.Checked = false;
                radioButton12.Checked = false;
                radioButton24.Checked = true;
            }
            else
            {
                checkBoxSeconds.Checked = Convert.ToBoolean((string)key.GetValue("displaySeconds"));
                if(((string)key.GetValue("hoursType")).Equals("12"))
                {
                    radioButton12.Checked = true;
                    radioButton24.Checked = false;
                }
                else
                {
                    radioButton12.Checked = false;
                    radioButton24.Checked = true;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }
    }
}
