using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Web;
using System.Net;

namespace AutoSearch
{
    public partial class AutoSearch : Form
    {
        public AutoSearch()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string google = @"https://www.google.co.il/search?q=";

            string txtToSearch = txtBox_Input.Text;

            string suffix = getChosenRadioBtnText();

            string query = txtToSearch + " " + suffix;
            query = WebUtility.UrlEncode(query);
            Process.Start(google + query);
            Close();
        }

        private string getChosenRadioBtnText()
        {
            string res = string.Empty;

            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    if ((control as RadioButton).Checked)
                    {
                        res = (control as RadioButton).Text;
                    }
                }
            }

            return res;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            RadioButton newRadioBtn;
            bool isDefault;
            Form_NewRow formNewRow = new Form_NewRow();

            try
            {
                string query = formNewRow.GetQuery(out isDefault);
            }
            catch (Exception)
            {
                return;
            }
            
            createNewRow(query, out newRadioBtn);
            newRadioBtn.Checked = true;
            addToRowsFile(query, isDefault);
        }
    }
}
