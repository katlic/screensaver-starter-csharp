namespace screensaver_starter_csharp
{
    partial class Screensaver
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
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerMove
            // 
            this.timerMove.Interval = 5000;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // timerClock
            // 
            this.timerClock.Interval = 500;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // labelClock
            // 
            this.labelClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClock.AutoSize = true;
            this.labelClock.BackColor = System.Drawing.Color.Transparent;
            this.labelClock.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.Color.White;
            this.labelClock.Location = new System.Drawing.Point(552, 354);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(236, 75);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "88:88:88";
            this.labelClock.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Screensaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screensaver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Screensaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Screensaver_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Screensaver_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Screensaver_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Screensaver_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label labelClock;
    }
}