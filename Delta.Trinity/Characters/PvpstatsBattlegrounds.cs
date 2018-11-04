using System;

namespace Delta.Trinity.Characters
{
    public partial class PvpstatsBattlegrounds
    {
        public long Id { get; set; }
        public byte WinnerFaction { get; set; }
        public byte BracketId { get; set; }
        public byte Type { get; set; }
        public DateTime Date { get; set; }
    }
}
