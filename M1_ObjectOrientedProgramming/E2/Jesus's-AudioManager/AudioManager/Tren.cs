﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    public class Tren : Vehiculo
    {
        public override void VehicleSound()
        {
            AudioFileReader audioFile = new AudioFileReader("Resources/train.wav");
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
