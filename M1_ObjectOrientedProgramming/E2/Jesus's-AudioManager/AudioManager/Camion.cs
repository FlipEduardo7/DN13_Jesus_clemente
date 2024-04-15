using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioManager
{
    public class Camion : Vehiculo
    {
        public override void VehicleSound()
        {
            AudioFileReader audioFile = new AudioFileReader("Resources/truck.mp3");
            WaveOutEvent waveOutEvent = new WaveOutEvent();
            waveOutEvent.Init(audioFile);
            waveOutEvent.Play();
            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(1000);
            }
            audioFile.Dispose();
            waveOutEvent.Dispose();
        }
    }
}
