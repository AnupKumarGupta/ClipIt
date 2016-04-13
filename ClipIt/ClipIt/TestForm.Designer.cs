namespace ClipIt
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.mouseKeyEvntProviderDemo = new MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider();
            this.SuspendLayout();
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.Location = new System.Drawing.Point(25, 23);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.Size = new System.Drawing.Size(221, 204);
            this.richTextBoxData.TabIndex = 0;
            this.richTextBoxData.Text = "";
            // 
            // mouseKeyEvntProviderDemo
            // 
            this.mouseKeyEvntProviderDemo.Enabled = false;
            this.mouseKeyEvntProviderDemo.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;
            this.mouseKeyEvntProviderDemo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mouseKeyEvntProviderDemo_KeyPress);
            this.mouseKeyEvntProviderDemo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mouseKeyEvntProviderDemo_KeyUp);
            this.mouseKeyEvntProviderDemo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mouseKeyEvntProviderDemo_KeyDown);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.richTextBoxData);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxData;
        private MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider mouseKeyEvntProviderDemo;

    }
}