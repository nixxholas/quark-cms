using System;
using System.Collections.Generic;
using System.Globalization;

namespace Delta.Trinity.Auth
{
    public partial class Account
    {
        public Account()
        {
            RbacAccountPermissions = new HashSet<RbacAccountPermissions>();
        }
        
        public Account(string username, string shaPassHash, string email)
        {
            Email = email.ToUpper(CultureInfo.InvariantCulture);
            RegMail = email.ToUpper(CultureInfo.InvariantCulture);;
            Username = username;
            ShaPassHash = shaPassHash;
            RbacAccountPermissions = new HashSet<RbacAccountPermissions>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string ShaPassHash { get; set; }
        public string Sessionkey { get; set; }
        public string V { get; set; }
        public string S { get; set; }
        public string TokenKey { get; set; }
        public string Email { get; set; }
        public string RegMail { get; set; }
        public DateTimeOffset Joindate { get; set; }
        public string LastIp { get; set; }
        public string LastAttemptIp { get; set; }
        public int FailedLogins { get; set; }
        public byte Locked { get; set; }
        public string LockCountry { get; set; }
        public DateTimeOffset? LastLogin { get; set; }
        public byte Online { get; set; }
        public byte Expansion { get; set; }
        public long Mutetime { get; set; }
        public string Mutereason { get; set; }
        public string Muteby { get; set; }
        public byte Locale { get; set; }
        public string Os { get; set; }
        public int Recruiter { get; set; }
        public int? BattlenetAccount { get; set; }
        public byte? BattlenetIndex { get; set; }

        public virtual BattlenetAccount BattlenetAccountNavigation { get; set; }
        public virtual ICollection<RbacAccountPermissions> RbacAccountPermissions { get; set; }
    }
}
