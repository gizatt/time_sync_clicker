using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace time_sync_clicker_csharp
{
    public partial class Form1 : Form
    {
        private System.DateTime click_time;
        private System.TimeSpan offset_from_clock = System.TimeSpan.Zero;
        private uint buffer_time;
        public Form1()
        {
            InitializeComponent();
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
            
            this.click_time = DateTime.MinValue;
            this.buffer_time = 5;
            textBoxBufferSecs.Text = this.buffer_time.ToString();

            Update_Offset();
        }

        private void Update_Offset()
        {
            // Synchronize against web NTP
            this.offset_from_clock = GetNetworkTime() - DateTime.Now;
            label_offset.Text = this.offset_from_clock.TotalSeconds.ToString();
        }
        private System.DateTime Get_Accurate_Now()
        {
            return DateTime.Now + offset_from_clock;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            // Figure out when to click; want to click at an
            // even 10 second interval more than 5 seconds in
            // the future.
            var now = Get_Accurate_Now();

            int next_10s_secs = 10 - (now.Second % 10);
            var new_click_time = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            while (next_10s_secs <= this.buffer_time) {
                next_10s_secs += 10;
            }
            this.click_time = new_click_time.AddSeconds(next_10s_secs);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var now = Get_Accurate_Now();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            uint userVal;
            if (uint.TryParse(textBoxBufferSecs.Text, out userVal))
            {
                this.buffer_time = userVal;
            }
            else
            {
                textBoxBufferSecs.Text = this.buffer_time.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label_time_to_click_Click(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.click_time = DateTime.MinValue;
            label_time_to_click.Text = "Canceled.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*
         * https://stackoverflow.com/questions/1193955/how-to-query-an-ntp-server-using-c
         * Answer from MaxKlaxx 
         */
        private static DateTime GetNetworkTime()
        { 
            const string NtpServer = "pool.ntp.org";

            const int DaysTo1900 = 1900 * 365 + 95; // 95 = offset for leap-years etc.
            const long TicksPerSecond = 10000000L;
            const long TicksPerDay = 24 * 60 * 60 * TicksPerSecond;
            const long TicksTo1900 = DaysTo1900 * TicksPerDay;

            var ntpData = new byte[48];
            ntpData[0] = 0x1B; // LeapIndicator = 0 (no warning), VersionNum = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(NtpServer).AddressList;
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            long pingDuration = Stopwatch.GetTimestamp(); // temp access (JIT-Compiler need some time at first call)
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);
                socket.ReceiveTimeout = 5000;
                socket.Send(ntpData);
                pingDuration = Stopwatch.GetTimestamp(); // after Send-Method to reduce WinSocket API-Call time

                socket.Receive(ntpData);
                pingDuration = Stopwatch.GetTimestamp() - pingDuration;
            }

            long pingTicks = pingDuration * TicksPerSecond / Stopwatch.Frequency;

            // optional: display response-time
            Console.WriteLine("{0:N2} ms", new TimeSpan(pingTicks).TotalMilliseconds);

            long intPart = (long)ntpData[40] << 24 | (long)ntpData[41] << 16 | (long)ntpData[42] << 8 | ntpData[43];
            long fractPart = (long)ntpData[44] << 24 | (long)ntpData[45] << 16 | (long)ntpData[46] << 8 | ntpData[47];
            long netTicks = intPart * TicksPerSecond + (fractPart * TicksPerSecond >> 32);

            var networkDateTime = new DateTime(TicksTo1900 + netTicks + pingTicks / 2);

            return networkDateTime.ToLocalTime(); // without ToLocalTime() = faster
        }

        private async void timer_timesync_Tick(object sender, EventArgs e)
        {
            Update_Offset();
        }
    }

}
