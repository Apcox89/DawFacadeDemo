namespace DAWFacadeDemo
{
    public class DAWFacade
    {
        private AudioTrack _track;
        private Mixer _mixer;
        private Exporter _exporter;

        public DAWFacade()
        {
            _track = new AudioTrack();
            _mixer = new Mixer();
            _exporter = new Exporter();
        }

        public void RecordTrack()
        {
            Console.WriteLine("Preparing to record...");
            _track.Record();
        }

        public void StopRecording()
        {
            Console.WriteLine("Stopping recording...");
            _track.Stop();
        }

        public void PlayTrack()
        {
            Console.WriteLine("Playing the recorded track...");
            _track.Play();
        }

        public void AdjustTrackVolume(int trackNumber, int level)
        {
            Console.WriteLine($"Adjusting volume for track {trackNumber}.");
            _mixer.SetVolume(trackNumber, level);
        }

        public void ApplyEffectToTrack(int trackNumber, string effect)
        {
            Console.WriteLine($"Applying {effect} effect to track {trackNumber}.");
            _mixer.ApplyEffect(trackNumber, effect);
        }

        public void ExportProject(string format)
        {
            Console.WriteLine("Exporting the project...");
            _exporter.Export(format);
        }
    }
}


