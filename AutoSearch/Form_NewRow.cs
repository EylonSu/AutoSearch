using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSearch
{
    public partial class Form_NewRow : Form
    {
        string m_Query;
        bool m_IsDefault;

        public Form_NewRow()
        {
            InitializeComponent();
        }

        internal string GetQuery(out bool i_IsDefault)
        {
            DialogResult dialogResult = ShowDialog();
            if (dialogResult == DialogResult.Cancel)
            {
                throw new Exception("Cancel"); 
            }

            i_IsDefault = m_IsDefault;
            return m_Query;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            m_Query = txtBox_Query.Text;
            m_IsDefault = checkBox_Default.Checked;
        }
    }
}
