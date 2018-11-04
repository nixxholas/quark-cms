namespace Delta.Trinity.Hotfixes
{
    public partial class SpellItemEnchantment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EffectArg1 { get; set; }
        public int EffectArg2 { get; set; }
        public int EffectArg3 { get; set; }
        public float EffectScalingPoints1 { get; set; }
        public float EffectScalingPoints2 { get; set; }
        public float EffectScalingPoints3 { get; set; }
        public int TransmogCost { get; set; }
        public int IconFileDataId { get; set; }
        public short EffectPointsMin1 { get; set; }
        public short EffectPointsMin2 { get; set; }
        public short EffectPointsMin3 { get; set; }
        public short ItemVisual { get; set; }
        public short Flags { get; set; }
        public short RequiredSkillId { get; set; }
        public short RequiredSkillRank { get; set; }
        public short ItemLevel { get; set; }
        public byte Charges { get; set; }
        public byte Effect1 { get; set; }
        public byte Effect2 { get; set; }
        public byte Effect3 { get; set; }
        public byte ConditionId { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public byte ScalingClass { get; set; }
        public byte ScalingClassRestricted { get; set; }
        public int TransmogPlayerConditionId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
