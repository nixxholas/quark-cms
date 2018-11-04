namespace Delta.Trinity.Characters
{
    public partial class CharacterSocial
    {
        public long Guid { get; set; }
        public long Friend { get; set; }
        public byte Flags { get; set; }
        public string Note { get; set; }
    }
}
