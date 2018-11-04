namespace Delta.Trinity.Characters
{
    public partial class CharacterSpell
    {
        public long Guid { get; set; }
        public int Spell { get; set; }
        public byte Active { get; set; }
        public byte Disabled { get; set; }
    }
}
