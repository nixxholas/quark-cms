namespace Delta.Trinity.Hotfixes
{
    public partial class SpellPower
    {
        public int ManaCost { get; set; }
        public float PowerCostPct { get; set; }
        public float PowerPctPerSecond { get; set; }
        public int RequiredAuraSpellId { get; set; }
        public float PowerCostMaxPct { get; set; }
        public byte OrderIndex { get; set; }
        public byte PowerType { get; set; }
        public int Id { get; set; }
        public int ManaCostPerLevel { get; set; }
        public int ManaPerSecond { get; set; }
        public int OptionalCost { get; set; }
        public int PowerDisplayId { get; set; }
        public int AltPowerBarId { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
