namespace Delta.Trinity.Characters
{
    public partial class CharacterAuraEffect
    {
        public long Guid { get; set; }
        public byte[] CasterGuid { get; set; }
        public byte[] ItemGuid { get; set; }
        public int Spell { get; set; }
        public int EffectMask { get; set; }
        public byte EffectIndex { get; set; }
        public int Amount { get; set; }
        public int BaseAmount { get; set; }
    }
}
