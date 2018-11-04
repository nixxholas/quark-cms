namespace Delta.Trinity.Hotfixes
{
    public partial class CreatureFamily
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float MinScale { get; set; }
        public float MaxScale { get; set; }
        public int IconFileId { get; set; }
        public short SkillLine1 { get; set; }
        public short SkillLine2 { get; set; }
        public short PetFoodMask { get; set; }
        public byte MinScaleLevel { get; set; }
        public byte MaxScaleLevel { get; set; }
        public byte PetTalentType { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
