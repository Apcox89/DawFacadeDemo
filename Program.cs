using System;

namespace DAWFacadeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the DAW facade
            DAWFacade daw = new DAWFacade();

            // Simulate recording a track
            daw.RecordTrack();

            // Stop the recording
            daw.StopRecording();

            // Apply an effect to the track
            daw.ApplyEffectToTrack(1, "Reverb");

            // Adjust volume
            daw.AdjustTrackVolume(1, 75);

            // Play the track
            daw.PlayTrack();

            // Export the project
            daw.ExportProject("MP3");

            // Keep console open
            Console.WriteLine("\nDAW operations completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
