using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Snake
{
    public class Heli
    {
        
        public async Task Tagaplaamis_Mangida(string Path)
        {
            await Task.Run(() =>
            {
                using (AudioFileReader audioFileReader = new AudioFileReader(Path))
                using (IWavePlayer waveOutDevice = new WaveOutEvent { })
                {
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                    while (waveOutDevice.PlaybackState==PlaybackState.Playing)
                    {
                        Thread.Sleep(50);
                    }
                }
            });
        }
    }
}

