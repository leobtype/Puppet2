using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using System.Threading;

namespace Puppet2
{
    public class SoundPlayer
    {
        public SoundPlayer(string file)
        {
            Mp3FileReader reader = new Mp3FileReader(file);
            WaveStream pcmStream = WaveFormatConversionStream.CreatePcmStream(reader);
            BlockAlignReductionStream baStream = new BlockAlignReductionStream(pcmStream);

            waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback());
            waveOut.Init(baStream);
        }

        private WaveOut waveOut;
        private BlockAlignReductionStream baStream;

        public void Play()
        {
            baStream.Position = 0;
            waveOut.Play();
            while (waveOut.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(100);
            }
        }

        public void Stop()
        {
            if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Stop();
                baStream.Position = 0;
            }
        }
    }
}
