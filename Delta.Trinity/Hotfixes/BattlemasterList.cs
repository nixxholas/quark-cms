namespace Delta.Trinity.Hotfixes
{
    public partial class BattlemasterList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GameType { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int IconFileDataId { get; set; }
        public short MapId1 { get; set; }
        public short MapId2 { get; set; }
        public short MapId3 { get; set; }
        public short MapId4 { get; set; }
        public short MapId5 { get; set; }
        public short MapId6 { get; set; }
        public short MapId7 { get; set; }
        public short MapId8 { get; set; }
        public short MapId9 { get; set; }
        public short MapId10 { get; set; }
        public short MapId11 { get; set; }
        public short MapId12 { get; set; }
        public short MapId13 { get; set; }
        public short MapId14 { get; set; }
        public short MapId15 { get; set; }
        public short MapId16 { get; set; }
        public short HolidayWorldState { get; set; }
        public short RequiredPlayerConditionId { get; set; }
        public byte InstanceType { get; set; }
        public byte GroupsAllowed { get; set; }
        public byte MaxGroupSize { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public byte RatedPlayers { get; set; }
        public byte MinPlayers { get; set; }
        public byte MaxPlayers { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
