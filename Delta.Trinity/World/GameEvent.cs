using System;

namespace Delta.Trinity.World
{
    public partial class GameEvent
    {
        public byte EventEntry { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }
        public long Occurence { get; set; }
        public long Length { get; set; }
        public int Holiday { get; set; }
        public string Description { get; set; }
        public byte WorldEvent { get; set; }
        public byte? Announce { get; set; }
    }
}
