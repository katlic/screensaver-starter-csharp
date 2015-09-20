using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screensaver_starter_csharp
{
    static class Program
    {
        public const string SCREENSAVER_TITLE = "Katlic_ScreenSaver_Clock";
        
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // handle arguments
            if (args.Length > 0)
            {
                string firstArg = args[0].ToLower().Trim();
                string secondArg = null;

                // handle cases where arguments are separated by a colon
                if (firstArg.Length > 2)
                {
                    secondArg = firstArg.Substring(3).Trim();
                    firstArg = firstArg.Substring(0, 2);
                }
                else if (args.Length > 1)
                {
                    secondArg = args[1];
                }

                // check for /c /p /s
                if (firstArg == "/c")
                {
                    // configuration mode
                    Application.Run(new Settings());
                }
                else if (firstArg == "/p")
                {
                    // preview mode
                    if (secondArg == null)
                    {
                        MessageBox.Show("No window handle provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    IntPtr previewWndHandle = new IntPtr(long.Parse(secondArg));
                    Application.Run(new Screensaver(previewWndHandle));
                }
                else if(firstArg == "/s")
                {
                    // full-screen mode
                    ShowScreensaver();
                    Application.Run();
                }
                else
                {
                    // undefined
                    MessageBox.Show("Invalid argument \"" + firstArg + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // no arguments, treat like /s(was /c)
                ShowScreensaver();
                Application.Run();
            }
        }

        static void ShowScreensaver()
        {
            // display on all screens
            foreach (Screen screen in Screen.AllScreens)
            {
                Screensaver screensaver = new Screensaver(screen.Bounds);
                screensaver.Show();
            }
        }
    }
}
