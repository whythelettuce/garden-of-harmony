namespace Content.Shared.Speech
{
    public sealed class SpeakAttemptEvent : CancellableEntityEventArgs
    {
        public SpeakAttemptEvent(EntityUid uid, bool whisper) // Imp change for Harmony Hypophonia port, addition of Whisper boolean
        {
            Uid = uid;
            Whisper = whisper; // Imp change for Harmony Hypophonia port
        }

        public EntityUid Uid { get; }
        public bool Whisper { get; } // Imp change for Harmony Hypophonia port
    }
}
