namespace Delta.Trinity.Hotfixes
{
    public partial class LfgDungeons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }
        public float MinGear { get; set; }
        public short MaxLevel { get; set; }
        public short TargetLevelMax { get; set; }
        public short MapId { get; set; }
        public short RandomId { get; set; }
        public short ScenarioId { get; set; }
        public short FinalEncounterId { get; set; }
        public short BonusReputationAmount { get; set; }
        public short MentorItemLevel { get; set; }
        public short RequiredPlayerConditionId { get; set; }
        public byte MinLevel { get; set; }
        public byte TargetLevel { get; set; }
        public byte TargetLevelMin { get; set; }
        public byte DifficultyId { get; set; }
        public byte TypeId { get; set; }
        public byte Faction { get; set; }
        public byte ExpansionLevel { get; set; }
        public byte OrderIndex { get; set; }
        public byte GroupId { get; set; }
        public byte CountTank { get; set; }
        public byte CountHealer { get; set; }
        public byte CountDamage { get; set; }
        public byte MinCountTank { get; set; }
        public byte MinCountHealer { get; set; }
        public byte MinCountDamage { get; set; }
        public byte Subtype { get; set; }
        public byte MentorCharLevel { get; set; }
        public int IconTextureFileId { get; set; }
        public int RewardsBgTextureFileId { get; set; }
        public int PopupBgTextureFileId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
