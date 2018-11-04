namespace Delta.Trinity.Characters
{
    public partial class CharacterAura
    {
        public long Guid { get; set; }
        public byte[] CasterGuid { get; set; }
        public byte[] ItemGuid { get; set; }
        public int Spell { get; set; }
        public int EffectMask { get; set; }
        public int RecalculateMask { get; set; }
        public byte StackCount { get; set; }
        public int MaxDuration { get; set; }
        public int RemainTime { get; set; }
        public byte RemainCharges { get; set; }
        public int CastItemLevel { get; set; }
    }
}
