namespace Delta.Trinity.Auth
{
    public partial class BattlenetAccountBan
    {
        public int Id { get; set; }
        public int Bandate { get; set; }
        public int Unbandate { get; set; }
        public string Bannedby { get; set; }
        public string Banreason { get; set; }
    }
}
