namespace Delta.Trinity.Hotfixes
{
    public partial class SpellLearnSpell
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int LearnSpellId { get; set; }
        public int OverridesSpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
