namespace Delta.Trinity.Hotfixes
{
    public partial class FactionTemplate
    {
        public int Id { get; set; }
        public short Faction { get; set; }
        public short Flags { get; set; }
        public short Enemies1 { get; set; }
        public short Enemies2 { get; set; }
        public short Enemies3 { get; set; }
        public short Enemies4 { get; set; }
        public short Friend1 { get; set; }
        public short Friend2 { get; set; }
        public short Friend3 { get; set; }
        public short Friend4 { get; set; }
        public byte FactionGroup { get; set; }
        public byte FriendGroup { get; set; }
        public byte EnemyGroup { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
