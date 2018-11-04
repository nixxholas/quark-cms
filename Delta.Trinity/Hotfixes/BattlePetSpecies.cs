namespace Delta.Trinity.Hotfixes
{
    public partial class BattlePetSpecies
    {
        public string SourceText { get; set; }
        public string Description { get; set; }
        public int CreatureId { get; set; }
        public int IconFileDataId { get; set; }
        public int SummonSpellId { get; set; }
        public short Flags { get; set; }
        public byte PetTypeEnum { get; set; }
        public byte SourceTypeEnum { get; set; }
        public int Id { get; set; }
        public int CardUimodelSceneId { get; set; }
        public int LoadoutUimodelSceneId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
