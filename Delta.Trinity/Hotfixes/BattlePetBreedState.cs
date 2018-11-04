namespace Delta.Trinity.Hotfixes
{
    public partial class BattlePetBreedState
    {
        public int Id { get; set; }
        public short Value { get; set; }
        public byte BattlePetStateId { get; set; }
        public byte BattlePetBreedId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
