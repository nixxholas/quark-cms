namespace Delta.Trinity.Characters
{
    public partial class PvpstatsPlayers
    {
        public long BattlegroundId { get; set; }
        public long CharacterGuid { get; set; }
        public short Winner { get; set; }
        public int ScoreKillingBlows { get; set; }
        public int ScoreDeaths { get; set; }
        public int ScoreHonorableKills { get; set; }
        public int ScoreBonusHonor { get; set; }
        public int ScoreDamageDone { get; set; }
        public int ScoreHealingDone { get; set; }
        public int Attr1 { get; set; }
        public int Attr2 { get; set; }
        public int Attr3 { get; set; }
        public int Attr4 { get; set; }
        public int Attr5 { get; set; }
    }
}
