using System;

namespace Delta.Trinity.Characters
{
    public partial class Updates
    {
        public string Name { get; set; }
        public string Hash { get; set; }
        public string State { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public int Speed { get; set; }
    }
}
