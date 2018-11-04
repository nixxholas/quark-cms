namespace Delta.Trinity.Hotfixes
{
    public partial class ChrClasses
    {
        public string PetNameToken { get; set; }
        public string Name { get; set; }
        public string NameFemale { get; set; }
        public string NameMale { get; set; }
        public string Filename { get; set; }
        public int CreateScreenFileDataId { get; set; }
        public int SelectScreenFileDataId { get; set; }
        public int LowResScreenFileDataId { get; set; }
        public int IconFileDataId { get; set; }
        public int StartingLevel { get; set; }
        public short Flags { get; set; }
        public short CinematicSequenceId { get; set; }
        public short DefaultSpec { get; set; }
        public byte DisplayPower { get; set; }
        public byte SpellClassSet { get; set; }
        public byte AttackPowerPerStrength { get; set; }
        public byte AttackPowerPerAgility { get; set; }
        public byte RangedAttackPowerPerAgility { get; set; }
        public byte PrimaryStatPriority { get; set; }
        public int Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
