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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            speech.Volume = (int)numericUpDown1.Value;
            speech.Speed = (int)numericUpDown2.Value;
            speech.Pitch= (int)numericUpDown3.Value;
            speech.Speak(textBox1.Text);
        }
    }
}
