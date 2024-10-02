using System;

namespace DAWFacadeDemo
{
        public class AudioTrack
        {
            public void Record()
            {
                Console.WriteLine("Recording audio track.");
            }

            public void Stop()
            {
                Console.WriteLine("Stopped recording.");
            }

            public void Play()
            {
                Console.WriteLine("Playing audio track.");
            }
        }

        public class Mixer
        {
            public void SetVolume(int trackNumber, int level)
            {
                Console.WriteLine($"Setting volume for track {trackNumber} to {level}.");
            }

            public void ApplyEffect(int trackNumber, string effect)
            {
                Console.WriteLine($"Applying {effect} effect to track {trackNumber}.");
            }
        }

        public class Exporter
        {
            public void Export(string format)
            {
                Console.WriteLine($"Exporting project to {format} format.");
            }
        }
}


