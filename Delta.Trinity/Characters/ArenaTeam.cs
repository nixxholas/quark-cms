namespace Delta.Trinity.Characters
{
    public partial class ArenaTeam
    {
        public int ArenaTeamId { get; set; }
        public string Name { get; set; }
        public long CaptainGuid { get; set; }
        public byte Type { get; set; }
        public short Rating { get; set; }
        public short SeasonGames { get; set; }
        public short SeasonWins { get; set; }
        public short WeekGames { get; set; }
        public short WeekWins { get; set; }
        public int Rank { get; set; }
        public int BackgroundColor { get; set; }
        public byte EmblemStyle { get; set; }
        public int EmblemColor { get; set; }
        public byte BorderStyle { get; set; }
        public int BorderColor { get; set; }
    }
}
