using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork.Helpers
{
    public class SoundPlayer
    {
        private IWavePlayer waveOut;
        private AudioFileReader audioFile;
        public void PlaySound(String soundPath)
        {

            if (File.Exists(soundPath))
            {
                waveOut?.Stop();
                waveOut?.Dispose();
                audioFile?.Dispose();
                waveOut = new WaveOutEvent();
                audioFile = new AudioFileReader(soundPath)
                {
                    Volume = ((float)(SettingsManager.Volume) / 100),
                };

                waveOut.Init(audioFile);
                waveOut.Play();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
    }
}
