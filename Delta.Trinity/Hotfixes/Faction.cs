namespace Delta.Trinity.Hotfixes
{
    public partial class Faction
    {
        public long ReputationRaceMask1 { get; set; }
        public long ReputationRaceMask2 { get; set; }
        public long ReputationRaceMask3 { get; set; }
        public long ReputationRaceMask4 { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int ReputationBase1 { get; set; }
        public int ReputationBase2 { get; set; }
        public int ReputationBase3 { get; set; }
        public int ReputationBase4 { get; set; }
        public float ParentFactionMod1 { get; set; }
        public float ParentFactionMod2 { get; set; }
        public int ReputationMax1 { get; set; }
        public int ReputationMax2 { get; set; }
        public int ReputationMax3 { get; set; }
        public int ReputationMax4 { get; set; }
        public short ReputationIndex { get; set; }
        public short ReputationClassMask1 { get; set; }
        public short ReputationClassMask2 { get; set; }
        public short ReputationClassMask3 { get; set; }
        public short ReputationClassMask4 { get; set; }
        public short ReputationFlags1 { get; set; }
        public short ReputationFlags2 { get; set; }
        public short ReputationFlags3 { get; set; }
        public short ReputationFlags4 { get; set; }
        public short ParentFactionId { get; set; }
        public short ParagonFactionId { get; set; }
        public byte ParentFactionCap1 { get; set; }
        public byte ParentFactionCap2 { get; set; }
        public byte Expansion { get; set; }
        public byte Flags { get; set; }
        public byte FriendshipRepId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
