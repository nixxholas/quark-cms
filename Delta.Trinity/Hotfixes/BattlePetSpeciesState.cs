namespace Delta.Trinity.Hotfixes
{
    public partial class BattlePetSpeciesState
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public byte BattlePetStateId { get; set; }
        public short BattlePetSpeciesId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
