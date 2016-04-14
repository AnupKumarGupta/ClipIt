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
            this.groupBox_TextBox = new System.Windows.Forms.GroupBox();
            this.txtBoxData = new System.Windows.Forms.RichTextBox();
            this.mouseKeyEvntProvider = new MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider();
            this.groupBox_TextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_TextBox
            // 
            this.groupBox_TextBox.Controls.Add(this.txtBoxData);
            this.groupBox_TextBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox_TextBox.Name = "groupBox_TextBox";
            this.groupBox_TextBox.Size = new System.Drawing.Size(108, 95);
            this.groupBox_TextBox.TabIndex = 0;
            this.groupBox_TextBox.TabStop = false;
            // 
            // txtBoxData
            // 
            this.txtBoxData.Location = new System.Drawing.Point(6, 19);
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(96, 70);
            this.txtBoxData.TabIndex = 0;
            this.txtBoxData.Text = "";
            // 
            // mouseKeyEvntProvider
            // 
            this.mouseKeyEvntProvider.Enabled = false;
            this.mouseKeyEvntProvider.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;
            this.mouseKeyEvntProvider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mouseKeyEvntProvider_KeyDown);
            // 
            // ClipBoardHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(135, 131);
            this.Controls.Add(this.groupBox_TextBox);
            this.Name = "ClipBoardHome";
            this.Text = "ClipBoard";
            this.groupBox_TextBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_TextBox;
        private System.Windows.Forms.RichTextBox txtBoxData;
        private MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider mouseKeyEvntProvider;
    }
}