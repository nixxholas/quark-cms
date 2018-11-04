using System;

namespace Delta.Trinity.Hotfixes
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
