using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen
{
    public partial class FormMain : Form
    {

        String ProcessName = "L2";

        Bitmap pic1;
        Bitmap pic2;

        System.Media.SoundPlayer player;

        double timeRefresh = 0.1;

        bool TrackingIsActive = false;
        Color TrackingColor;
        int TrackingX;
        int TrackingY;

        int selectedWindow = 1;

        DateTime lastSound;
        DateTime? firstAlarm;
        DateTime? lastUpdate;


        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureWindows();
        }

        public void CaptureWindows()
        {
            if (Properties.Settings.Default.LastColor != null)
            {
                panelColor1.BackColor = Properties.Settings.Default.LastColor;
            }
            var items = Process.GetProcesses();
            int i = 0;
            foreach (var proc in items)
            {
                if (proc.ProcessName == ProcessName)
                {
                    i++;
                    var rect = new User32.Rect();
                    User32.GetWindowRect(proc.MainWindowHandle, ref rect);
                    int width = rect.right - rect.left;
                    int height = rect.bottom - rect.top;
                    var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
                    Graphics graphics = Graphics.FromImage(bmp);
                    graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                    // bmp.Save("test_" + i.ToString() + ".png", ImageFormat.Png);
                    pictureBoxMain.Image = bmp;
                    switch (i)
                    {
                        case 1:
                            pic1 = bmp;
                            pictureBox1.Image = pic1;
                            break;
                        case 2:
                            pic2 = bmp;
                            pictureBox2.Image = pic2;
                            break;
                    }
                }
                showActiveWindow();
            }
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            MouseEventArgs rato = e as MouseEventArgs;
            Bitmap b = ((Bitmap)pictureBoxMain.Image);
            //int x = rato.X * b.Width / pictureBoxMain.ClientSize.Width;
            //int y = rato.Y * b.Height / pictureBoxMain.ClientSize.Height;
            int x = rato.X;
            int y = rato.Y;
            Color c = b.GetPixel(x, y);
            TrackingColor = c;
            panelColor1.BackColor = c;
            Properties.Settings.Default.LastColor = c;
            TrackingX = x;
            TrackingY = y;
            Properties.Settings.Default.LastX = x;
            Properties.Settings.Default.LastY = y;
            Properties.Settings.Default.Save();
            //String text = "color R:" + c.R.ToString() + " G:" + c.G.ToString() + " B:" + c.B.ToString();
            //text += "\nX: " + x.ToString() + " Y: " + y.ToString();
            //Console.WriteLine(text);
        }

        private async void buttonTracking_Click(object sender, EventArgs e)
        {
            firstAlarm = null;
            if (player != null)
            {
                player.Stop();
            }
            TrackingIsActive = !TrackingIsActive;
            if (TrackingIsActive)
            {
                toolStripStatusLabel.Text = "";
                buttonTracking.ForeColor = Color.Red;
                await Tracking();
            }
            else
            {
                buttonTracking.ForeColor = Color.Black;
                labelAlarm.Text = "";
            }
        }

        void showActiveWindow()
        {
            panel1.BackColor = Color.Gray;
            panel2.BackColor = Color.Gray;
            if (selectedWindow == 1)
            {
                panel1.BackColor = Color.Red;
                pictureBoxMain.Image = pic1;
            }
            if (selectedWindow == 2)
            {
                panel2.BackColor = Color.Red;
                pictureBoxMain.Image = pic2;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selectedWindow = 1;
            showActiveWindow();
            Properties.Settings.Default.LastWindow = 1;
            Properties.Settings.Default.Save();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectedWindow = 2;
            showActiveWindow();
            Properties.Settings.Default.LastWindow = 2;
            Properties.Settings.Default.Save();
        }

        private async Task Tracking()
        {
            var items = Process.GetProcesses();
            do
            {
                int i = 0;
                foreach (var proc in items)
                {
                    if (proc.ProcessName == ProcessName)
                    {
                        i++;
                        if (selectedWindow != i)
                        {
                            continue;
                        }
                        Color? c0 = null;
                        Bitmap bmp = null;
                        try
                        {
                            var rect = new User32.Rect();
                            User32.GetWindowRect(proc.MainWindowHandle, ref rect);

                            int width = rect.right - rect.left;
                            int height = rect.bottom - rect.top;

                            bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
                            Graphics graphics = Graphics.FromImage(bmp);
                            graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                            graphics.Dispose();
                            c0 = bmp.GetPixel(TrackingX, TrackingY);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        if (c0 == null || bmp == null)
                        {
                            continue;
                        }
                        labelTime.Text = DateTime.Now.ToString();
                        Color c = (Color)c0;
                        panelColor2.BackColor = c;
                        // String text = "color R:" + c.R.ToString() + " G:" + c.G.ToString() + " B:" + c.B.ToString() + "\n" + DateTime.Now.ToString();
                        // Console.WriteLine(text);
                        if (lastUpdate == null || lastUpdate < DateTime.Now.AddSeconds(-5))
                        {
                            if (pictureBoxSecond.Image != null) pictureBoxSecond.Image.Dispose();
                            pictureBoxSecond.Image = (Bitmap)bmp.Clone();
                            lastUpdate = DateTime.Now;
                        }
                        bmp.Dispose();
                        if (c == TrackingColor)
                        {
                            labelAlarm.Text = "";
                        }
                        else
                        {
                            labelAlarm.Text = "Alarm!";
                            if (checkBoxSound.Checked && (lastSound == null || lastSound < DateTime.Now.AddSeconds(-1)))
                            {
                                // System.Media.SystemSounds.Hand.Play();
                                if (player != null)
                                {
                                    player.Play();
                                }
                                lastSound = DateTime.Now;
                            }
                            if (firstAlarm == null)
                            {
                                firstAlarm = DateTime.Now;
                                toolStripStatusLabel.Text = "Time: " + firstAlarm.ToString();
                            }
                        }

                    }
                }
                await Task.Delay((int)(timeRefresh * 1000));
                // Thread.Sleep(1000);
            } while (TrackingIsActive);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RefreshTime > 0)
            {
                timeRefresh = Properties.Settings.Default.RefreshTime;
            }
            if (Properties.Settings.Default.LastWindow > 0)
            {
                selectedWindow = Properties.Settings.Default.LastWindow;
            }
            if (Properties.Settings.Default.LastX > 0)
            {
                TrackingX = Properties.Settings.Default.LastX;
            }
            if (Properties.Settings.Default.LastY > 0)
            {
                TrackingY = Properties.Settings.Default.LastY;
            }
            if (Properties.Settings.Default.LastColor != null)
            {
                TrackingColor = Properties.Settings.Default.LastColor;
            }
            String path = "alarm_clock.wav";
            if (File.Exists(path))
            {
                player = new System.Media.SoundPlayer(path);
            }
            CaptureWindows();
        }

        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct Rect
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        }



        //void GetProcesses()
        //{
        //    var items = Process.GetProcesses();
        //    foreach (var item in items)
        //    {
        //        Console.WriteLine(item.ProcessName);
        //    }
        //}

        //public void CaptureApplication(string procName)
        //{
        //    var proc = Process.GetProcessesByName(procName)[0];
        //    var rect = new User32.Rect();
        //    User32.GetWindowRect(proc.MainWindowHandle, ref rect);

        //    int width = rect.right - rect.left;
        //    int height = rect.bottom - rect.top;

        //    var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        //    Graphics graphics = Graphics.FromImage(bmp);
        //    graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

        //    bmp.Save("test.png", ImageFormat.Png);
        //}

    }

}
