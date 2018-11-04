namespace Delta.Trinity.Characters
{
    public partial class GroupMember
    {
        public int Guid { get; set; }
        public long MemberGuid { get; set; }
        public byte MemberFlags { get; set; }
        public byte Subgroup { get; set; }
        public byte Roles { get; set; }
    }
}
