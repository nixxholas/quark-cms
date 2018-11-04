namespace Delta.Trinity.Hotfixes
{
    public partial class CreatureDisplayInfoExtra
    {
        public int Id { get; set; }
        public int BakeMaterialResourcesId { get; set; }
        public int HdbakeMaterialResourcesId { get; set; }
        public byte DisplayRaceId { get; set; }
        public byte DisplaySexId { get; set; }
        public byte DisplayClassId { get; set; }
        public byte SkinId { get; set; }
        public byte FaceId { get; set; }
        public byte HairStyleId { get; set; }
        public byte HairColorId { get; set; }
        public byte FacialHairId { get; set; }
        public byte CustomDisplayOption1 { get; set; }
        public byte CustomDisplayOption2 { get; set; }
        public byte CustomDisplayOption3 { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
