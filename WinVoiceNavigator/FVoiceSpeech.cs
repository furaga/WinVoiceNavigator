using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeechLib;

namespace WinVoiceNavigator
{
    class FVoiceSpeech
    {
        SpeechLib.SpVoice spVoice = null;

        string xmlFormat = @"<volume level='{0}'><rate speed='{1}'><pitch middle='{2}'>{3}</pitch></rate></voice>";

        private int volume = 50;
        private int speed = 0;
        private int pitch = 0;

        public int Volume { get { return volume; } set { volume = Math.Max(0, Math.Min(100, value)); } }
        public int Speed { get { return speed; } set { speed = Math.Max(-10, Math.Min(10, value)); } }
        public int Pitch { get { return pitch; } set { pitch = Math.Max(-10, Math.Min(10, value)); } }

        public void Initialize()
        {
            //合成音声エンジンを初期化する.
            this.spVoice = new SpeechLib.SpVoice();

            //合成音声エンジンで日本語を話す人を探す。(やらなくても動作はするけど、念のため)
            bool hit = false;
            foreach (SpObjectToken voiceperson in this.spVoice.GetVoices())
            {
                string language = voiceperson.GetAttribute("Language");
                Console.WriteLine(language);
                if (language == "411")
                {
                    //日本語を話す人だ!
                    spVoice.Voice = voiceperson; //君に読みあげて欲しい
                    break;
                }
            }
        }

        public bool CanSpeech { get { return spVoice.Status.RunningState != SpeechRunState.SRSEIsSpeaking; } }

        public bool Speak(string text)
        {
            if (false == CanSpeech)
            {
                return false;
            }

            spVoice.Speak(
                string.Format(xmlFormat, Volume, Speed, Pitch, text),
                SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFIsXML);

            return true;
        }
    }
}
