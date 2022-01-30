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

namespace time_sync_clicker_csharp
{
    public partial class Form1 : Form
    {
        private System.DateTime click_time;
        public Form1()
        {
            InitializeComponent();
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
            
            this.click_time = DateTime.MinValue;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Figure out when to click; want to click at an
            // even 10 second interval more than 3 seconds in
            // the future.
            var now = DateTime.Now;

            int next_10s_secs = 10 - (now.Second % 10);
            var new_click_time = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            if (next_10s_secs <= 3) {
                next_10s_secs += 10;
            }
            this.click_time = new_click_time.AddSeconds(next_10s_secs);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            label_time.Text = now.ToString("hh:mm:ss tt");

            if (click_time != DateTime.MinValue)
            {
                if (click_time > now)
                {
                    label_time_to_click.Text = (this.click_time - now).TotalSeconds.ToString("0.##");
                }
                else
                {
                    uint X = (uint) Cursor.Position.X;
                    uint Y = (uint) Cursor.Position.Y;
                    Win32.mouse_event(Win32.MOUSEEVENTF_LEFTDOWN | Win32.MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

                    this.click_time = DateTime.MinValue;
                    label_time_to_click.Text = "Clicked!";
                }
            }
        }
        public class Win32
        {
            [DllImport("User32.Dll")]
            public static extern long SetCursorPos(int x, int y);

            [DllImport("User32.Dll")]
            public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

            [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
            public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
            //Mouse actions
            public const int MOUSEEVENTF_LEFTDOWN = 0x02;
            public const int MOUSEEVENTF_LEFTUP = 0x04;
            public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
            public const int MOUSEEVENTF_RIGHTUP = 0x10;
            // Absolute coords
            public const int MOUSEEVENTF_ABSOLUTE = 0x8000;

            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int x;
                public int y;
            }
        }
    }

}
