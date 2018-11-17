using Delta.Trinity.Auth;
using Microsoft.EntityFrameworkCore;
using Updates = Delta.Trinity.World.Updates;
using UpdatesInclude = Delta.Trinity.World.UpdatesInclude;

namespace Delta.DataAccess.Contexts.Trinity
{
    public partial class AuthDataContext : DbContext
    {
        public AuthDataContext()
        {
        }

        public AuthDataContext(DbContextOptions<AuthDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountAccess> AccountAccess { get; set; }
        public virtual DbSet<AccountBanned> AccountBanned { get; set; }
        public virtual DbSet<AccountLastPlayedCharacter> AccountLastPlayedCharacter { get; set; }
        public virtual DbSet<AccountMuted> AccountMuted { get; set; }
        public virtual DbSet<Autobroadcast> Autobroadcast { get; set; }
        public virtual DbSet<BattlenetAccountBan> BattlenetAccountBans { get; set; }
        public virtual DbSet<BattlenetAccountHeirloom> BattlenetAccountHeirlooms { get; set; }
        public virtual DbSet<BattlenetAccountMount> BattlenetAccountMounts { get; set; }
        public virtual DbSet<BattlenetAccount> BattlenetAccounts { get; set; }
        public virtual DbSet<BattlenetAccountToy> BattlenetAccountToys { get; set; }
        public virtual DbSet<BattlenetItemAppearances> BattlenetItemAppearances { get; set; }
        public virtual DbSet<BattlenetItemFavoriteAppearances> BattlenetItemFavoriteAppearances { get; set; }
        public virtual DbSet<BattlePets> BattlePets { get; set; }
        public virtual DbSet<BattlePetSlots> BattlePetSlots { get; set; }
        public virtual DbSet<Ip2nation> Ip2Nations { get; set; }
        public virtual DbSet<Ip2nationCountries> Ip2nationCountries { get; set; }
        public virtual DbSet<IpBanned> IpBanned { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<LogsIpActions> LogsIpActions { get; set; }
        public virtual DbSet<RbacAccountPermissions> RbacAccountPermissions { get; set; }
        public virtual DbSet<RbacDefaultPermissions> RbacDefaultPermissions { get; set; }
        public virtual DbSet<RbacLinkedPermissions> RbacLinkedPermissions { get; set; }
        public virtual DbSet<RbacPermissions> RbacPermissions { get; set; }
        public virtual DbSet<Realmcharacters> Realmcharacters { get; set; }
        public virtual DbSet<Realmlist> Realmlist { get; set; }
        public virtual DbSet<Updates> Updates { get; set; }
        public virtual DbSet<UpdatesInclude> UpdatesInclude { get; set; }
        public virtual DbSet<Uptime> Uptime { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-preview3-35497");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account", "auth");

                entity.HasIndex(e => e.Username)
                    .HasName("idx_username")
                    .IsUnique();

                entity.HasIndex(e => new { e.BattlenetAccount, e.BattlenetIndex })
                    .HasName("uk_bnet_acc")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BattlenetAccount)
                    .HasColumnName("battlenet_account")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BattlenetIndex)
                    .HasColumnName("battlenet_index")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Expansion)
                    .HasColumnName("expansion")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.FailedLogins)
                    .HasColumnName("failed_logins")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Joindate)
                    .HasColumnName("joindate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastAttemptIp)
                    .IsRequired()
                    .HasColumnName("last_attempt_ip")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("127.0.0.1");

                entity.Property(e => e.LastIp)
                    .IsRequired()
                    .HasColumnName("last_ip")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("127.0.0.1");

                entity.Property(e => e.LastLogin).HasColumnName("last_login");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockCountry)
                    .IsRequired()
                    .HasColumnName("lock_country")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("00");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Muteby)
                    .IsRequired()
                    .HasColumnName("muteby")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mutereason)
                    .IsRequired()
                    .HasColumnName("mutereason")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mutetime)
                    .HasColumnName("mutetime")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Online)
                    .HasColumnName("online")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Os)
                    .IsRequired()
                    .HasColumnName("os")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Recruiter)
                    .HasColumnName("recruiter")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegMail)
                    .IsRequired()
                    .HasColumnName("reg_mail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.S)
                    .IsRequired()
                    .HasColumnName("s")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Sessionkey)
                    .IsRequired()
                    .HasColumnName("sessionkey")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ShaPassHash)
                    .IsRequired()
                    .HasColumnName("sha_pass_hash")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TokenKey)
                    .IsRequired()
                    .HasColumnName("token_key")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.V)
                    .IsRequired()
                    .HasColumnName("v")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.BattlenetAccountNavigation)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.BattlenetAccount)
                    .HasConstraintName("fk_bnet_acc");
            });

            modelBuilder.Entity<AccountAccess>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.RealmId });

                entity.ToTable("account_access", "auth");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RealmId)
                    .HasColumnName("RealmID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Gmlevel)
                    .HasColumnName("gmlevel")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<AccountBanned>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Bandate });

                entity.ToTable("account_banned", "auth");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bandate)
                    .HasColumnName("bandate")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Bannedby)
                    .IsRequired()
                    .HasColumnName("bannedby")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Banreason)
                    .IsRequired()
                    .HasColumnName("banreason")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unbandate)
                    .HasColumnName("unbandate")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AccountLastPlayedCharacter>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.Region, e.Battlegroup });

                entity.ToTable("account_last_played_character", "auth");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Battlegroup)
                    .HasColumnName("battlegroup")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CharacterGuid)
                    .HasColumnName("characterGUID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CharacterName)
                    .HasColumnName("characterName")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LastPlayedTime)
                    .HasColumnName("lastPlayedTime")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RealmId)
                    .HasColumnName("realmId")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<AccountMuted>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Mutedate });

                entity.ToTable("account_muted", "auth");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mutedate)
                    .HasColumnName("mutedate")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mutedby)
                    .IsRequired()
                    .HasColumnName("mutedby")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mutereason)
                    .IsRequired()
                    .HasColumnName("mutereason")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mutetime)
                    .HasColumnName("mutetime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Autobroadcast>(entity =>
            {
                entity.HasKey(e => new { e.Realmid, e.Id });

                entity.ToTable("autobroadcast", "auth");

                entity.Property(e => e.Realmid)
                    .HasColumnName("realmid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("longtext");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<BattlenetAccountBan>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Bandate });

                entity.ToTable("battlenet_account_bans", "auth");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bandate)
                    .HasColumnName("bandate")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bannedby)
                    .IsRequired()
                    .HasColumnName("bannedby")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Banreason)
                    .IsRequired()
                    .HasColumnName("banreason")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unbandate)
                    .HasColumnName("unbandate")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlenetAccountHeirloom>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.ItemId });

                entity.ToTable("battlenet_account_heirlooms", "auth");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlenetAccountMount>(entity =>
            {
                entity.HasKey(e => new { e.BattlenetAccountId, e.MountSpellId });

                entity.ToTable("battlenet_account_mounts", "auth");

                entity.Property(e => e.BattlenetAccountId)
                    .HasColumnName("battlenetAccountId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MountSpellId)
                    .HasColumnName("mountSpellId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlenetAccount>(entity =>
            {
                entity.ToTable("battlenet_accounts", "auth");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.FailedLogins)
                    .HasColumnName("failed_logins")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Joindate)
                    .HasColumnName("joindate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastCharacterUndelete)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastIp)
                    .IsRequired()
                    .HasColumnName("last_ip")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("127.0.0.1");

                entity.Property(e => e.LastLogin).HasColumnName("last_login");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockCountry)
                    .IsRequired()
                    .HasColumnName("lock_country")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("00");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LoginTicket)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.LoginTicketExpiry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Online)
                    .HasColumnName("online")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Os)
                    .IsRequired()
                    .HasColumnName("os")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ShaPassHash)
                    .IsRequired()
                    .HasColumnName("sha_pass_hash")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BattlenetAccountToy>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.ItemId });

                entity.ToTable("battlenet_account_toys", "auth");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsFavourite)
                    .HasColumnName("isFavourite")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlenetItemAppearances>(entity =>
            {
                entity.HasKey(e => new { e.BattlenetAccountId, e.BlobIndex });

                entity.ToTable("battlenet_item_appearances", "auth");

                entity.Property(e => e.BattlenetAccountId)
                    .HasColumnName("battlenetAccountId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BlobIndex)
                    .HasColumnName("blobIndex")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AppearanceMask)
                    .HasColumnName("appearanceMask")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.BattlenetAccount)
                    .WithMany(p => p.BattlenetItemAppearances)
                    .HasForeignKey(d => d.BattlenetAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_battlenet_item_appearances");
            });

            modelBuilder.Entity<BattlenetItemFavoriteAppearances>(entity =>
            {
                entity.HasKey(e => new { e.BattlenetAccountId, e.ItemModifiedAppearanceId });

                entity.ToTable("battlenet_item_favorite_appearances", "auth");

                entity.Property(e => e.BattlenetAccountId)
                    .HasColumnName("battlenetAccountId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemModifiedAppearanceId)
                    .HasColumnName("itemModifiedAppearanceId")
                    .HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.BattlenetAccount)
                    .WithMany(p => p.BattlenetItemFavoriteAppearances)
                    .HasForeignKey(d => d.BattlenetAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_battlenet_item_favorite_appearances");
            });

            modelBuilder.Entity<BattlePets>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("battle_pets", "auth");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BattlenetAccountId)
                    .HasColumnName("battlenetAccountId")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Breed)
                    .HasColumnName("breed")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.Exp)
                    .HasColumnName("exp")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Health)
                    .HasColumnName("health")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Species)
                    .HasColumnName("species")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<BattlePetSlots>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.BattlenetAccountId });

                entity.ToTable("battle_pet_slots", "auth");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.BattlenetAccountId)
                    .HasColumnName("battlenetAccountId")
                    .HasColumnType("int(10)");

                entity.Property(e => e.BattlePetGuid)
                    .HasColumnName("battlePetGuid")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Ip2nation>(entity =>
            {
                entity.ToTable("ip2nation", "auth");
                
                entity.HasIndex(e => e.Ip);

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("int(11)");
                
                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<Ip2nationCountries>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("ip2nationCountries", "auth");

                entity.HasIndex(e => e.Code)
                    .HasName("code");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsoCode2)
                    .IsRequired()
                    .HasColumnName("iso_code_2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IsoCode3)
                    .HasColumnName("iso_code_3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IsoCountry)
                    .IsRequired()
                    .HasColumnName("iso_country")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<IpBanned>(entity =>
            {
                entity.HasKey(e => new { e.Ip, e.Bandate });

                entity.ToTable("ip_banned", "auth");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("127.0.0.1");

                entity.Property(e => e.Bandate)
                    .HasColumnName("bandate")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Bannedby)
                    .IsRequired()
                    .HasColumnName("bannedby")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("[Console]");

                entity.Property(e => e.Banreason)
                    .IsRequired()
                    .HasColumnName("banreason")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("no reason");

                entity.Property(e => e.Unbandate)
                    .HasColumnName("unbandate")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.ToTable("logs", "auth");

                entity.HasKey(e => new {e.Time, e.Realm, e.Type, e.Level, e.String}).HasName("Logs_CK");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Realm)
                    .HasColumnName("realm")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.String)
                    .HasColumnName("string")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<LogsIpActions>(entity =>
            {
                entity.ToTable("logs_ip_actions", "auth");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CharacterGuid)
                    .HasColumnName("character_guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("127.0.0.1");

                entity.Property(e => e.Systemnote)
                    .HasColumnName("systemnote")
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Unixtime)
                    .HasColumnName("unixtime")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<RbacAccountPermissions>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.PermissionId, e.RealmId });

                entity.ToTable("rbac_account_permissions", "auth");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("fk__rbac_account_roles__rbac_permissions");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permissionId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RealmId)
                    .HasColumnName("realmId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Granted)
                    .HasColumnName("granted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.RbacAccountPermissions)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("fk__rbac_account_permissions__account");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RbacAccountPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("fk__rbac_account_roles__rbac_permissions");
            });

            modelBuilder.Entity<RbacDefaultPermissions>(entity =>
            {
                entity.HasKey(e => new { e.SecId, e.PermissionId, e.RealmId });

                entity.ToTable("rbac_default_permissions", "auth");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("fk__rbac_default_permissions__rbac_permissions");

                entity.Property(e => e.SecId)
                    .HasColumnName("secId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permissionId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RealmId)
                    .HasColumnName("realmId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RbacDefaultPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk__rbac_default_permissions__rbac_permissions");
            });

            modelBuilder.Entity<RbacLinkedPermissions>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LinkedId });

                entity.ToTable("rbac_linked_permissions", "auth");

                entity.HasIndex(e => e.Id)
                    .HasName("fk__rbac_linked_permissions__rbac_permissions1");

                entity.HasIndex(e => e.LinkedId)
                    .HasName("fk__rbac_linked_permissions__rbac_permissions2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LinkedId)
                    .HasColumnName("linkedId")
                    .HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.RbacLinkedPermissionsIdNavigation)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("fk__rbac_linked_permissions__rbac_permissions1");

                entity.HasOne(d => d.Linked)
                    .WithMany(p => p.RbacLinkedPermissionsLinked)
                    .HasForeignKey(d => d.LinkedId)
                    .HasConstraintName("fk__rbac_linked_permissions__rbac_permissions2");
            });

            modelBuilder.Entity<RbacPermissions>(entity =>
            {
                entity.ToTable("rbac_permissions", "auth");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Realmcharacters>(entity =>
            {
                entity.HasKey(e => new { e.Realmid, e.Acctid });

                entity.ToTable("realmcharacters", "auth");

                entity.HasIndex(e => e.Acctid)
                    .HasName("acctid");

                entity.Property(e => e.Realmid)
                    .HasColumnName("realmid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Acctid)
                    .HasColumnName("acctid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Numchars)
                    .HasColumnName("numchars")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Realmlist>(entity =>
            {
                entity.ToTable("realmlist", "auth");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("127.0.0.1");

                entity.Property(e => e.AllowedSecurityLevel)
                    .HasColumnName("allowedSecurityLevel")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Battlegroup)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Gamebuild)
                    .HasColumnName("gamebuild")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("26972");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocalAddress)
                    .IsRequired()
                    .HasColumnName("localAddress")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("127.0.0.1");

                entity.Property(e => e.LocalSubnetMask)
                    .IsRequired()
                    .HasColumnName("localSubnetMask")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("255.255.255.0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Population)
                    .HasColumnName("population")
                    .HasColumnType("float unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("8085");

                entity.Property(e => e.Region)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Updates>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("updates", "auth");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasColumnType("char(40)");

                entity.Property(e => e.Speed)
                    .HasColumnName("speed")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("enum('RELEASED','ARCHIVED')")
                    .HasDefaultValueSql("RELEASED");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<UpdatesInclude>(entity =>
            {
                entity.HasKey(e => e.Path);

                entity.ToTable("updates_include", "auth");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("enum('RELEASED','ARCHIVED')")
                    .HasDefaultValueSql("RELEASED");
            });

            modelBuilder.Entity<Uptime>(entity =>
            {
                entity.HasKey(e => new { e.Realmid, e.Starttime });

                entity.ToTable("uptime", "auth");

                entity.Property(e => e.Realmid)
                    .HasColumnName("realmid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Starttime)
                    .HasColumnName("starttime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Maxplayers)
                    .HasColumnName("maxplayers")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Revision)
                    .IsRequired()
                    .HasColumnName("revision")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Trinitycore");

                entity.Property(e => e.Uptime1)
                    .HasColumnName("uptime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });
        }
    }
}
