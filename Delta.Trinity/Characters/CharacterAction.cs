namespace Delta.Trinity.Characters
{
    public partial class CharacterAction
    {
        public long Guid { get; set; }
        public byte Spec { get; set; }
        public byte Button { get; set; }
        public int Action { get; set; }
        public byte Type { get; set; }
    }
}
