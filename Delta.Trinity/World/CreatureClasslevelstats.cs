namespace Delta.Trinity.World
{
    public partial class CreatureClasslevelstats
    {
        public byte Level { get; set; }
        public byte Class { get; set; }
        public int Basemana { get; set; }
        public int Basearmor { get; set; }
        public short Attackpower { get; set; }
        public short Rangedattackpower { get; set; }
        public float DamageBase { get; set; }
        public float DamageExp1 { get; set; }
        public float DamageExp2 { get; set; }
        public float DamageExp3 { get; set; }
        public float DamageExp4 { get; set; }
        public float DamageExp5 { get; set; }
        public string Comment { get; set; }
    }
}
