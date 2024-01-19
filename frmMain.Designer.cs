namespace TamilTypewriter
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            chkTamilOn = new CheckBox();
            txtBox = new TextBox();
            SuspendLayout();
            // 
            // chkTamilOn
            // 
            chkTamilOn.AutoSize = true;
            chkTamilOn.Checked = true;
            chkTamilOn.CheckState = CheckState.Checked;
            chkTamilOn.Location = new Point(12, 12);
            chkTamilOn.Name = "chkTamilOn";
            chkTamilOn.Size = new Size(76, 24);
            chkTamilOn.TabIndex = 0;
            chkTamilOn.Text = "&Tamil";
            chkTamilOn.UseVisualStyleBackColor = true;
            chkTamilOn.CheckedChanged += chkTamilOn_CheckedChanged;
            // 
            // txtBox
            // 
            txtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox.Location = new Point(12, 52);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(714, 305);
            txtBox.TabIndex = 1;
            txtBox.KeyPress += txtBox_KeyPress_1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 369);
            Controls.Add(txtBox);
            Controls.Add(chkTamilOn);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            Text = "Tamil typewriter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkTamilOn;
        private TextBox txtBox;
    }
}