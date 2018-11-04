namespace Delta.Trinity.Hotfixes
{
    public partial class DungeonEncounter
    {
        public string Name { get; set; }
        public int CreatureDisplayId { get; set; }
        public short MapId { get; set; }
        public byte DifficultyId { get; set; }
        public byte Bit { get; set; }
        public byte Flags { get; set; }
        public int Id { get; set; }
        public int OrderIndex { get; set; }
        public int SpellIconFileId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
