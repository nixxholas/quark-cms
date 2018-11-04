namespace Delta.Trinity.Hotfixes
{
    public partial class Item
    {
        public int Id { get; set; }
        public int IconFileDataId { get; set; }
        public byte ClassId { get; set; }
        public byte SubclassId { get; set; }
        public byte SoundOverrideSubclassId { get; set; }
        public byte Material { get; set; }
        public byte InventoryType { get; set; }
        public byte SheatheType { get; set; }
        public byte ItemGroupSoundsId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
