namespace ClipIt
{
    partial class ClipBoardHome
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
            this.components = new System.ComponentModel.Container();
            this.cmnuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlClipboardText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmnuTray
            // 
            this.cmnuTray.Name = "cmnuTray";
            this.cmnuTray.Size = new System.Drawing.Size(61, 4);
            // 
            // ctlClipboardText
            // 
            this.ctlClipboardText.Location = new System.Drawing.Point(0, -3);
            this.ctlClipboardText.Name = "ctlClipboardText";
            this.ctlClipboardText.Size = new System.Drawing.Size(281, 261);
            this.ctlClipboardText.TabIndex = 1;
            this.ctlClipboardText.Text = "";
            // 
            // ClipBoardHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ctlClipboardText);
            this.Name = "ClipBoardHome";
            this.Text = "ClipBoard";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmnuTray;
        private System.Windows.Forms.RichTextBox ctlClipboardText;
    }
}

