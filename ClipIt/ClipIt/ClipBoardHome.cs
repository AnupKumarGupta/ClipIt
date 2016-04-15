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
    public partial class ClipBoardHome : Form
    {
        #region Variables

        private KeyboardHookListener keyListener;
        Stack<string> strStack = new Stack<string>();
        Stack<KeyEventArgs> keyStack = new Stack<KeyEventArgs>();

        #endregion

        #region OnLoadEvents
        public ClipBoardHome()
        {
            InitializeComponent();
            //Clipboard.Clear();
            ActivateGlobalObject();
        }
        public void ActivateGlobalObject()
        {
            mouseKeyEvntProvider.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;

            keyListener = new KeyboardHookListener(new GlobalHooker());
            keyListener.Enabled = true;
            keyListener.KeyDown += mouseKeyEvntProvider_KeyDown;
        }

        #endregion

        #region BasicFunctions

        public void AddKeysToStack(KeyEventArgs key)
        {
                string keyData = key.KeyData.ToString();

            if (keyData.ToString() == ResourceFile.CodeTextMapping.LControl || keyData.ToString() == ResourceFile.CodeTextMapping.RControl)
            {
                keyStack.Push(key);
            }
        }
        public bool IsCopyInstructionPassed(KeyEventArgs key)
        {
            string keyData = key.KeyData.ToString();
            string keyLastPressed = keyStack.Count > 0 ? keyStack.Peek().KeyData.ToString() : "";

            if (keyData == ResourceFile.CodeTextMapping.Copy || (keyData == ResourceFile.CodeTextMapping.C && (keyLastPressed == ResourceFile.CodeTextMapping.LControl || keyLastPressed == ResourceFile.CodeTextMapping.RControl)))
                return true;
            else
                return false;
        }
        public bool IsPasteInstructionPassed(KeyEventArgs key)
        {
            string keyData = key.KeyData.ToString();
            string keyLastPressed = keyStack.Count > 0 ? keyStack.Peek().KeyData.ToString() : "";

            if (keyData == ResourceFile.CodeTextMapping.Paste || (keyData == ResourceFile.CodeTextMapping.V && (keyLastPressed == ResourceFile.CodeTextMapping.LControl || keyLastPressed == ResourceFile.CodeTextMapping.RControl)))
                return true;
            else
                return false;
        }

        #endregion

        #region KeyPressEvents
        private void mouseKeyEvntProvider_KeyDown(object sender, KeyEventArgs e)
        {
            AddKeysToStack(e);
            if (IsCopyInstructionPassed(e))
            {
                strStack.Push(Clipboard.GetText());
                
                if (!(strStack.Peek() == ""))
                    Clipboard.SetText(strStack.Peek());
            }
            else if (IsPasteInstructionPassed(e))
            {
                if (strStack.Count > 0 && strStack.Peek() != "")
                    Clipboard.SetText(strStack.Pop());
                //else if (strStack.ToArray().Length == 1)
                //    Clipboard.SetText(strStack.Peek());
            }

            //string[] str = strStack.ToArray();
            //foreach (var item in str)
            //{
            //    txtBoxData.Text += item;
            //}
        }

        #endregion

        #region FormCloseEvent
        public void DeactivateGlobalObject()
        {
            keyListener.Dispose();
        }
        #endregion
    }
}
