namespace ClipIt
{
    partial class LandingForm
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
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.rchTxtClipBoardData = new System.Windows.Forms.RichTextBox();
            this.groupBoxBtn = new System.Windows.Forms.GroupBox();
            this.btnSetData = new System.Windows.Forms.Button();
            this.mouseKeyEventProvider1 = new MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider();
            this.groupBoxText.SuspendLayout();
            this.groupBoxBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.rchTxtClipBoardData);
            this.groupBoxText.Location = new System.Drawing.Point(13, 12);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(259, 114);
            this.groupBoxText.TabIndex = 0;
            this.groupBoxText.TabStop = false;
            // 
            // rchTxtClipBoardData
            // 
            this.rchTxtClipBoardData.Location = new System.Drawing.Point(7, 20);
            this.rchTxtClipBoardData.Name = "rchTxtClipBoardData";
            this.rchTxtClipBoardData.Size = new System.Drawing.Size(246, 88);
            this.rchTxtClipBoardData.TabIndex = 0;
            this.rchTxtClipBoardData.Text = "";
            // 
            // groupBoxBtn
            // 
            this.groupBoxBtn.Controls.Add(this.btnSetData);
            this.groupBoxBtn.Location = new System.Drawing.Point(13, 133);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(259, 63);
            this.groupBoxBtn.TabIndex = 1;
            this.groupBoxBtn.TabStop = false;
            // 
            // btnSetData
            // 
            this.btnSetData.Location = new System.Drawing.Point(86, 19);
            this.btnSetData.Name = "btnSetData";
            this.btnSetData.Size = new System.Drawing.Size(91, 23);
            this.btnSetData.TabIndex = 0;
            this.btnSetData.Text = "Set Data";
            this.btnSetData.UseVisualStyleBackColor = true;
            this.btnSetData.Click += new System.EventHandler(this.btnSetData_Click);
            // 
            // mouseKeyEventProvider1
            // 
            this.mouseKeyEventProvider1.Enabled = false;
            this.mouseKeyEventProvider1.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBoxBtn);
            this.Controls.Add(this.groupBoxText);
            this.Name = "LandingForm";
            this.Text = "Clip It";
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.RichTextBox rchTxtClipBoardData;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.Button btnSetData;
        private MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider mouseKeyEventProvider1;

    }
}

