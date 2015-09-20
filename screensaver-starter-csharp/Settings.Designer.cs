namespace screensaver_starter_csharp
{
    partial class Settings
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
            this.groupBoxClock = new System.Windows.Forms.GroupBox();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.checkBoxSeconds = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxClock.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClock
            // 
            this.groupBoxClock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClock.Controls.Add(this.radioButton24);
            this.groupBoxClock.Controls.Add(this.radioButton12);
            this.groupBoxClock.Controls.Add(this.checkBoxSeconds);
            this.groupBoxClock.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClock.Name = "groupBoxClock";
            this.groupBoxClock.Size = new System.Drawing.Size(204, 77);
            this.groupBoxClock.TabIndex = 0;
            this.groupBoxClock.TabStop = false;
            this.groupBoxClock.Text = "Clock";
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Checked = true;
            this.radioButton24.Location = new System.Drawing.Point(125, 42);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(61, 17);
            this.radioButton24.TabIndex = 2;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "24 hour";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(6, 42);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(61, 17);
            this.radioButton12.TabIndex = 1;
            this.radioButton12.Text = "12 hour";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeconds
            // 
            this.checkBoxSeconds.AutoSize = true;
            this.checkBoxSeconds.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSeconds.Name = "checkBoxSeconds";
            this.checkBoxSeconds.Size = new System.Drawing.Size(101, 17);
            this.checkBoxSeconds.TabIndex = 0;
            this.checkBoxSeconds.Text = "display seconds";
            this.checkBoxSeconds.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Location = new System.Drawing.Point(12, 100);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(141, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 131);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.groupBoxClock.ResumeLayout(false);
            this.groupBoxClock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClock;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.CheckBox checkBoxSeconds;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}