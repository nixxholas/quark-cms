namespace Delta.Trinity.Hotfixes
{
    public partial class ChrSpecialization
    {
        public string Name { get; set; }
        public string FemaleName { get; set; }
        public string Description { get; set; }
        public int MasterySpellId1 { get; set; }
        public int MasterySpellId2 { get; set; }
        public byte ClassId { get; set; }
        public byte OrderIndex { get; set; }
        public byte PetTalentType { get; set; }
        public byte Role { get; set; }
        public byte PrimaryStatPriority { get; set; }
        public int Id { get; set; }
        public int SpellIconFileId { get; set; }
        public int Flags { get; set; }
        public int AnimReplacements { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
