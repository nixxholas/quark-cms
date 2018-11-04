namespace Delta.Trinity.Auth
{
    public partial class RbacDefaultPermissions
    {
        public int SecId { get; set; }
        public int PermissionId { get; set; }
        public int RealmId { get; set; }

        public virtual RbacPermissions Permission { get; set; }
    }
}
