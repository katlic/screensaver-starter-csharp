using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screensaver_starter_csharp
{
    public partial class Screensaver : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        // general properties
        Point mouseLocation;
        Random rand = new Random();
        bool previewMode = false;

        // clock properties
        bool militaryTime;
        bool showSeconds;

        public Screensaver()
        {
            InitializeComponent();
        }

        public Screensaver(Rectangle bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        public Screensaver(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            // set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // make this a child window so it will close when the parent closes
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            // make text smaller
            labelClock.Font = new System.Drawing.Font("Arial", 8);

            previewMode = true;
        }

        void LoadSettings()
        {
            // get values stored in registry subkey
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Program.SCREENSAVER_TITLE);
            if (key == null)
            {
                showSeconds = false;
                militaryTime = true;
            }
            else
            {
                showSeconds = Convert.ToBoolean((string)key.GetValue("displaySeconds"));
                if (((string)key.GetValue("hoursType")).Equals("12"))
                {
                    militaryTime = false;
                }
                else
                {
                    militaryTime = true;
                }
            }
        }

        private void Screensaver_Load(object sender, EventArgs e)
        {
            LoadSettings();

            labelClock.Text = "";

            // hide cursor and bring window to front
            Cursor.Hide();
            TopMost = true;

            // start movement timer
            timerMove.Interval = 5000;
            timerMove.Start();

            // start clock timer
            timerClock.Interval = 500;
            timerClock.Start();
            timerClock_Tick(this, null);
        }

        private void Screensaver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
            {
                Application.Exit();
            }
        }

        private void Screensaver_MouseClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
            {
                Application.Exit();
            }
        }

        private void Screensaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!previewMode)
            {
                if (!mouseLocation.IsEmpty)
                {
                    // terminate if mouse moves a significant distance
                    if (Math.Abs(mouseLocation.X - e.X) > 5 || Math.Abs(mouseLocation.Y - e.Y) > 5)
                    {
                        Application.Exit();
                    }
                }

                // update current moust location
                mouseLocation = e.Location;
            }
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            labelClock.Left = rand.Next(Math.Max(1, Bounds.Width - labelClock.Width));
            labelClock.Top = rand.Next(Math.Max(1, Bounds.Height - labelClock.Height));
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            string format = (militaryTime ? "HH:mm" + (showSeconds ? ":ss" : "") : "h:mm" + (showSeconds ? ":ss" : "") + " tt");

            labelClock.Text = DateTime.Now.ToString(format);
        }
    }
}
