namespace Delta.Trinity.World
{
    public partial class CreatureOnkillReputation
    {
        public int CreatureId { get; set; }
        public short RewOnKillRepFaction1 { get; set; }
        public short RewOnKillRepFaction2 { get; set; }
        public byte MaxStanding1 { get; set; }
        public byte IsTeamAward1 { get; set; }
        public int RewOnKillRepValue1 { get; set; }
        public byte MaxStanding2 { get; set; }
        public byte IsTeamAward2 { get; set; }
        public int RewOnKillRepValue2 { get; set; }
        public byte TeamDependent { get; set; }
    }
}
