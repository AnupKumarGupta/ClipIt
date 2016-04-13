using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipIt
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
            //PutCopiedDataToTextBox();
        }

        public void PutCopiedDataToTextBox()
        {
            rchTxtClipBoardData.Text = Clipboard.GetData(DataFormats.Text).ToString();
        }

        private void btnSetData_Click(object sender, EventArgs e)
        {
            string str = rchTxtClipBoardData.Text;
            string[] strArray = str.Split('\n');
            Clipboard.SetText(rchTxtClipBoardData.Text);

        }
       

        private void mouseKeyEventProvider1_KeyPress(object sender, KeyPressEventArgs e)
        {
            rchTxtClipBoardData.Text += string.Format("MouseDown: \t{0}; \t System Timestamp: \t{1}", e.KeyChar,e.ToString());

        }

    }

}
