namespace Delta.Trinity.Auth
{
    public partial class RbacLinkedPermissions
    {
        public int Id { get; set; }
        public int LinkedId { get; set; }

        public virtual RbacPermissions IdNavigation { get; set; }
        public virtual RbacPermissions Linked { get; set; }
    }
}
