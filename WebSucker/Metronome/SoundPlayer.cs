using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSucker.Metronome
{
    class SoundPlayer
    {
        AudioFileReader audioFile;
        WaveOutEvent outputDevice;

        public SoundPlayer()
        {
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }
        public async void PlaySound(float volume)
        {
            using (var audioFile = new AudioFileReader("sounds/tick.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Volume = volume / 100;
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    await Task.Delay(5);

                }
            }
        }
    }
}