namespace Delta.Trinity.Characters
{
    public partial class CharacterSpellCooldown
    {
        public long Guid { get; set; }
        public int Spell { get; set; }
        public int Item { get; set; }
        public int Time { get; set; }
        public int CategoryId { get; set; }
        public int CategoryEnd { get; set; }
    }
}
