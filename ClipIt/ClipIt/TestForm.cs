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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            Activate();
        }
        private KeyboardHookListener m_keyListener;
        public void Activate()
        {
            mouseKeyEvntProviderDemo.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;
            
            // Note: for an application hook, use the AppHooker class instead
            m_keyListener = new KeyboardHookListener(new GlobalHooker());

            // The listener is not enabled by default
            m_keyListener.Enabled = true;

            // Set the event handler
            // recommended to use the Extended handlers, which allow input suppression among other additional information
            m_keyListener.KeyDown += mouseKeyEvntProviderDemo_KeyDown;
        }
        private void mouseKeyEvntProviderDemo_KeyDown(object sender, KeyEventArgs e)
        {
            //Console.Write("Hi");
            richTextBoxData.Text = e.KeyData.ToString() + "  " + e.KeyCode.ToString() + " " + e.KeyValue.ToString();
            ;
        }
        private void mouseKeyEvntProviderDemo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.Write("Hi");
            richTextBoxData.Text = e.KeyChar.ToString();

        }
        private void mouseKeyEvntProviderDemo_KeyUp(object sender, KeyEventArgs e)
        {
            Console.Write("Hi");
            richTextBoxData.Text = e.KeyData.ToString();

        }
        public void Deactivate()
        {
            m_keyListener.Dispose();
        }
    }
}
