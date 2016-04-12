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
            PutCopiedDataToTextBox();
        }

        public void PutCopiedDataToTextBox()
        {
            rchTxtClipBoardData.Text = Clipboard.GetData(DataFormats.Text).ToString();
        }

        private void btnSetData_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rchTxtClipBoardData.Text);

        }
    }
}
