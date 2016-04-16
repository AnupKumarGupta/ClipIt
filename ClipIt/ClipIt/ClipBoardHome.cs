using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipIt.Win32;
using System.Diagnostics;

namespace ClipIt
{
    public partial class ClipBoardHome : Form
    {

        #region Clipboard Formats

        string[] formatsSupported = new string[] 
		{
			DataFormats.Bitmap,
			DataFormats.CommaSeparatedValue,
			DataFormats.Dib,
			DataFormats.Dif,
			DataFormats.EnhancedMetafile,
			DataFormats.FileDrop,
			DataFormats.Html,
			DataFormats.Locale,
			DataFormats.MetafilePict,
			DataFormats.OemText,
			DataFormats.Palette,
			DataFormats.PenData,
			DataFormats.Riff,
			DataFormats.Rtf,
			DataFormats.Serializable,
			DataFormats.StringFormat,
			DataFormats.SymbolicLink,
			DataFormats.Text,
			DataFormats.Tiff,
			DataFormats.UnicodeText,
			DataFormats.WaveAudio
		};

        string[] formatsSupportedlDesc = new String[] 
		{
			"Bitmap",
			"CommaSeparatedValue",
			"Dib",
			"Dif",
			"EnhancedMetafile",
			"FileDrop",
			"Html",
			"Locale",
			"MetafilePict",
			"OemText",
			"Palette",
			"PenData",
			"Riff",
			"Rtf",
			"Serializable",
			"StringFormat",
			"SymbolicLink",
			"Text",
			"Tiff",
			"UnicodeText",
			"WaveAudio"
		};

        #endregion

        #region Local Variables
        IntPtr _ClipboardViewerNext;
        #endregion

        #region On Load Events
        public ClipBoardHome()
        {
            InitializeComponent();
        } 
        #endregion

        #region External Event Handlers
        private void RegisterClipboardViewer()
        {
            _ClipboardViewerNext = Win32.User32.SetClipboardViewer(this.Handle);
        }
        private void UnregisterClipboardViewer()
        {
            Win32.User32.ChangeClipboardChain(this.Handle, _ClipboardViewerNext);
        }
        private void GetClipboardData()
        {

            IDataObject iData = new DataObject();
            string typeOfData = string.Empty;
            string copiedContent = string.Empty;
            try
            {
                iData = Clipboard.GetDataObject();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            //catch (System.Runtime.InteropServices.ExternalException externEx)
            //{
            //    Debug.WriteLine("InteropServices.ExternalException: {0}", externEx.Message);
            //    return;
            //}
            //Used For some execptions in Access and Excel

            #region Get the Type of Data
            // Get RTF if it is present
            if (iData.GetDataPresent(DataFormats.Rtf))
            {
                ctlClipboardText.Rtf = (string)iData.GetData(DataFormats.Rtf);

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    typeOfData = "RTF";
                }
            }
            else
            {
                // Get Text if it is present
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    ctlClipboardText.Text = (string)iData.GetData(DataFormats.Text);
                    typeOfData = "Text";
                    Debug.WriteLine((string)iData.GetData(DataFormats.Text));
                }
                else
                {
                    // Only showing RTF or TEXT
                    // To work on music and images etc
                    ctlClipboardText.Text = "(cannot display this format)";
                }
            } 
            #endregion
        }
        protected override void WndProc(ref Message m)
        {
            switch ((Win32.Msgs)m.Msg)
            {
                //
                // The WM_DRAWCLIPBOARD message is sent to the first window 
                // in the clipboard viewer chain when the content of the 
                // clipboard changes. This enables a clipboard viewer 
                // window to display the new content of the clipboard. 
                //
                case Win32.Msgs.WM_DRAWCLIPBOARD:

                    Debug.WriteLine("WindowProc DRAWCLIPBOARD: " + m.Msg, "WndProc");

                    GetClipboardData();

                    //
                    // Each window that receives the WM_DRAWCLIPBOARD message 
                    // must call the SendMessage function to pass the message 
                    // on to the next window in the clipboard viewer chain.
                    //
                    Win32.User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    break;


                //
                // The WM_CHANGECBCHAIN message is sent to the first window 
                // in the clipboard viewer chain when a window is being 
                // removed from the chain. 
                //
                case Win32.Msgs.WM_CHANGECBCHAIN:
                    Debug.WriteLine("WM_CHANGECBCHAIN: lParam: " + m.LParam, "WndProc");

                    // When a clipboard viewer window receives the WM_CHANGECBCHAIN message, 
                    // it should call the SendMessage function to pass the message to the 
                    // next window in the chain, unless the next window is the window 
                    // being removed. In this case, the clipboard viewer should save 
                    // the handle specified by the lParam parameter as the next window in the chain. 

                    //
                    // wParam is the Handle to the window being removed from 
                    // the clipboard viewer chain 
                    // lParam is the Handle to the next window in the chain 
                    // following the window being removed. 
                    if (m.WParam == _ClipboardViewerNext)
                    {
                        //
                        // If wParam is the next clipboard viewer then it
                        // is being removed so update pointer to the next
                        // window in the clipboard chain
                        //
                        _ClipboardViewerNext = m.LParam;
                    }
                    else
                    {
                        Win32.User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    }
                    break;

                case Win32.Msgs.WM_PASTE:
                    ctlClipboardText.Text = "Pasted";
                    break;

                default:
                    //
                    // Let the form process the messages that we are
                    // not interested in
                    //
                    base.WndProc(ref m);
                    break;

            }

        } 

        #endregion


        #region Internal Event Handlers
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            RegisterClipboardViewer();
        }
        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            UnregisterClipboardViewer();
        }
        #endregion
    }
}
