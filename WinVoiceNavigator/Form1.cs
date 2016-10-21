using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WinVoiceNavigator
{
    public partial class Form1 : Form
    {
        FVoiceSpeech speech = new FVoiceSpeech();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           speech.Initialize();

           mapping["devenv"] = "Visual Studio";
        }

        void speak()
        {
            speech.Volume = (int)volume.Value;
            speech.Speed = (int)speed.Value;
            speech.Pitch = (int)pitch.Value;

            string text = focusWindowNameLabel.Text;
            if (mapping.ContainsKey(text))
            {
                text = mapping[text];
            }
            speech.Speak(text);
        }

        Dictionary<string, string> mapping = new Dictionary<string,string>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            var process = WinAPI.GetActiveProcess();

            string text = process.ProcessName;
            if (text == "chrome")
            {
                text = process.MainWindowTitle;
            }

            const int MaxTextLength = 32;
            if (text.Length > MaxTextLength)
            {
                text = text.Substring(0, MaxTextLength);
            }

            if (text != focusWindowNameLabel.Text)
            {
                focusWindowNameLabel.Text = text;
                speak();
            }
        }

        private void enableCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableCBox.Checked)
            {
                timer.Enabled = true;
            }
            else
            {
                timer.Enabled = false;
            }
        }
    }

    public class WinAPI
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        /// アクティブプロセス
        public static Process GetActiveProcess()
        {
            // アクティブなウィンドウハンドルの取得
            IntPtr hWnd = WinAPI.GetForegroundWindow();
            int id;
            // ウィンドウハンドルからプロセスIDを取得
            WinAPI.GetWindowThreadProcessId(hWnd, out id);
            Process process = Process.GetProcessById(id);
            return process;
        }
    }

}