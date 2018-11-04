using Delta.Trinity.Characters;
using Microsoft.EntityFrameworkCore;
using Updates = Delta.Trinity.World.Updates;
using UpdatesInclude = Delta.Trinity.World.UpdatesInclude;

namespace Delta.DataAccess.Contexts.Trinity
{
    public partial class CharactersDataContext : DbContext
    {
        public CharactersDataContext()
        {
        }

        public CharactersDataContext(DbContextOptions<CharactersDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountData> AccountData { get; set; }
        public virtual DbSet<AccountInstanceTimes> AccountInstanceTimes { get; set; }
        public virtual DbSet<AccountTutorial> AccountTutorial { get; set; }
        public virtual DbSet<ArenaTeam> ArenaTeam { get; set; }
        public virtual DbSet<ArenaTeamMember> ArenaTeamMember { get; set; }
        public virtual DbSet<Auctionhouse> Auctionhouse { get; set; }
        public virtual DbSet<BlackmarketAuctions> BlackmarketAuctions { get; set; }
        public virtual DbSet<Bugreport> Bugreport { get; set; }
        public virtual DbSet<CalendarEvents> CalendarEvents { get; set; }
        public virtual DbSet<CalendarInvites> CalendarInvites { get; set; }
        public virtual DbSet<Channels> Channels { get; set; }
        public virtual DbSet<CharacterAccountData> CharacterAccountData { get; set; }
        public virtual DbSet<CharacterAchievement> CharacterAchievement { get; set; }
        public virtual DbSet<CharacterAchievementProgress> CharacterAchievementProgress { get; set; }
        public virtual DbSet<CharacterAction> CharacterAction { get; set; }
        public virtual DbSet<CharacterArenaStats> CharacterArenaStats { get; set; }
        public virtual DbSet<CharacterAura> CharacterAura { get; set; }
        public virtual DbSet<CharacterAuraEffect> CharacterAuraEffect { get; set; }
        public virtual DbSet<CharacterBanned> CharacterBanned { get; set; }
        public virtual DbSet<CharacterBattlegroundData> CharacterBattlegroundData { get; set; }
        public virtual DbSet<CharacterBattlegroundRandom> CharacterBattlegroundRandom { get; set; }
        public virtual DbSet<CharacterCufProfiles> CharacterCufProfiles { get; set; }
        public virtual DbSet<CharacterCurrency> CharacterCurrency { get; set; }
        public virtual DbSet<CharacterDeclinedname> CharacterDeclinedname { get; set; }
        public virtual DbSet<CharacterEquipmentsets> CharacterEquipmentsets { get; set; }
        public virtual DbSet<CharacterFishingsteps> CharacterFishingsteps { get; set; }
        public virtual DbSet<CharacterGarrison> CharacterGarrison { get; set; }
        public virtual DbSet<CharacterGarrisonBlueprints> CharacterGarrisonBlueprints { get; set; }
        public virtual DbSet<CharacterGarrisonBuildings> CharacterGarrisonBuildings { get; set; }
        public virtual DbSet<CharacterGarrisonFollowerAbilities> CharacterGarrisonFollowerAbilities { get; set; }
        public virtual DbSet<CharacterGarrisonFollowers> CharacterGarrisonFollowers { get; set; }
        public virtual DbSet<CharacterGifts> CharacterGifts { get; set; }
        public virtual DbSet<CharacterGlyphs> CharacterGlyphs { get; set; }
        public virtual DbSet<CharacterHomebind> CharacterHomebind { get; set; }
        public virtual DbSet<CharacterInstance> CharacterInstance { get; set; }
        public virtual DbSet<CharacterInventory> CharacterInventory { get; set; }
        public virtual DbSet<CharacterPet> CharacterPet { get; set; }
        public virtual DbSet<CharacterPetDeclinedname> CharacterPetDeclinedname { get; set; }
        public virtual DbSet<CharacterPvpTalent> CharacterPvpTalent { get; set; }
        public virtual DbSet<CharacterQueststatus> CharacterQueststatus { get; set; }
        public virtual DbSet<CharacterQueststatusDaily> CharacterQueststatusDaily { get; set; }
        public virtual DbSet<CharacterQueststatusMonthly> CharacterQueststatusMonthly { get; set; }
        public virtual DbSet<CharacterQueststatusObjectives> CharacterQueststatusObjectives { get; set; }
        public virtual DbSet<CharacterQueststatusObjectivesCriteria> CharacterQueststatusObjectivesCriteria { get; set; }
        public virtual DbSet<CharacterQueststatusObjectivesCriteriaProgress> CharacterQueststatusObjectivesCriteriaProgress { get; set; }
        public virtual DbSet<CharacterQueststatusRewarded> CharacterQueststatusRewarded { get; set; }
        public virtual DbSet<CharacterQueststatusSeasonal> CharacterQueststatusSeasonal { get; set; }
        public virtual DbSet<CharacterQueststatusWeekly> CharacterQueststatusWeekly { get; set; }
        public virtual DbSet<CharacterReputation> CharacterReputation { get; set; }
        public virtual DbSet<Characters> Characters { get; set; }
        public virtual DbSet<CharacterSkills> CharacterSkills { get; set; }
        public virtual DbSet<CharacterSocial> CharacterSocial { get; set; }
        public virtual DbSet<CharacterSpell> CharacterSpell { get; set; }
        public virtual DbSet<CharacterSpellCharge> CharacterSpellCharges { get; set; }
        public virtual DbSet<CharacterSpellCooldown> CharacterSpellCooldown { get; set; }
        public virtual DbSet<CharacterStats> CharacterStats { get; set; }
        public virtual DbSet<CharacterTalent> CharacterTalent { get; set; }
        public virtual DbSet<CharacterTransmogOutfits> CharacterTransmogOutfits { get; set; }
        public virtual DbSet<CharacterVoidStorage> CharacterVoidStorage { get; set; }
        public virtual DbSet<Corpse> Corpse { get; set; }
        public virtual DbSet<CorpsePhases> CorpsePhases { get; set; }
        public virtual DbSet<CreatureRespawn> CreatureRespawn { get; set; }
        public virtual DbSet<GameEventConditionSave> GameEventConditionSave { get; set; }
        public virtual DbSet<GameEventSave> GameEventSave { get; set; }
        public virtual DbSet<GameobjectRespawn> GameobjectRespawn { get; set; }
        public virtual DbSet<GmBug> GmBug { get; set; }
        public virtual DbSet<GmComplaint> GmComplaint { get; set; }
        public virtual DbSet<GmComplaintChatlog> GmComplaintChatlog { get; set; }
        public virtual DbSet<GmSuggestion> GmSuggestion { get; set; }
        public virtual DbSet<GroupInstance> GroupInstance { get; set; }
        public virtual DbSet<GroupMember> GroupMember { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Guild> Guild { get; set; }
        public virtual DbSet<GuildAchievement> GuildAchievement { get; set; }
        public virtual DbSet<GuildAchievementProgress> GuildAchievementProgress { get; set; }
        public virtual DbSet<GuildBankEventlog> GuildBankEventlog { get; set; }
        public virtual DbSet<GuildBankItem> GuildBankItem { get; set; }
        public virtual DbSet<GuildBankRight> GuildBankRight { get; set; }
        public virtual DbSet<GuildBankTab> GuildBankTab { get; set; }
        public virtual DbSet<GuildEventlog> GuildEventlog { get; set; }
        public virtual DbSet<GuildFinderApplicant> GuildFinderApplicant { get; set; }
        public virtual DbSet<GuildFinderGuildSettings> GuildFinderGuildSettings { get; set; }
        public virtual DbSet<GuildMember> GuildMembers { get; set; }
        public virtual DbSet<GuildMemberWithdraw> GuildMemberWithdraw { get; set; }
        public virtual DbSet<GuildNewslog> GuildNewslog { get; set; }
        public virtual DbSet<GuildRank> GuildRank { get; set; }
        public virtual DbSet<Instance> Instance { get; set; }
        public virtual DbSet<InstanceReset> InstanceReset { get; set; }
        public virtual DbSet<InstanceScenarioProgress> InstanceScenarioProgress { get; set; }
        public virtual DbSet<ItemInstance> ItemInstance { get; set; }
        public virtual DbSet<ItemInstanceArtifact> ItemInstanceArtifact { get; set; }
        public virtual DbSet<ItemInstanceArtifactPowers> ItemInstanceArtifactPowers { get; set; }
        public virtual DbSet<ItemInstanceGems> ItemInstanceGems { get; set; }
        public virtual DbSet<ItemInstanceModifiers> ItemInstanceModifiers { get; set; }
        public virtual DbSet<ItemInstanceTransmog> ItemInstanceTransmog { get; set; }
        public virtual DbSet<ItemLootItems> ItemLootItems { get; set; }
        public virtual DbSet<ItemLootMoney> ItemLootMoney { get; set; }
        public virtual DbSet<ItemRefundInstance> ItemRefundInstance { get; set; }
        public virtual DbSet<ItemSoulboundTradeData> ItemSoulboundTradeData { get; set; }
        public virtual DbSet<LfgData> LfgData { get; set; }
        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<MailItems> MailItems { get; set; }
        public virtual DbSet<PetAura> PetAura { get; set; }
        public virtual DbSet<PetAuraEffect> PetAuraEffect { get; set; }
        public virtual DbSet<Petition> Petition { get; set; }
        public virtual DbSet<PetitionSign> PetitionSign { get; set; }
        public virtual DbSet<PetSpell> PetSpell { get; set; }
        public virtual DbSet<PetSpellCharge> PetSpellCharges { get; set; }
        public virtual DbSet<PetSpellCooldown> PetSpellCooldown { get; set; }
        public virtual DbSet<PoolQuestSave> PoolQuestSave { get; set; }
        public virtual DbSet<PvpstatsBattlegrounds> PvpstatsBattlegrounds { get; set; }
        public virtual DbSet<PvpstatsPlayers> PvpstatsPlayers { get; set; }
        public virtual DbSet<QuestTracker> QuestTracker { get; set; }
        public virtual DbSet<ReservedName> ReservedName { get; set; }
        public virtual DbSet<Updates> Updates { get; set; }
        public virtual DbSet<UpdatesInclude> UpdatesInclude { get; set; }
        public virtual DbSet<WardenAction> WardenAction { get; set; }
        public virtual DbSet<Worldstates> Worldstates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-preview3-35497");

            modelBuilder.Entity<AccountData>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.Type });

                entity.ToTable("account_data", "characters");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("blob");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AccountInstanceTimes>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.InstanceId });

                entity.ToTable("account_instance_times", "characters");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instanceId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReleaseTime)
                    .HasColumnName("releaseTime")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AccountTutorial>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("account_tutorial", "characters");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tut0)
                    .HasColumnName("tut0")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tut1)
                    .HasColumnName("tut1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tut2)
                    .HasColumnName("tut2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tut3)
                    .HasColumnName("tut3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tut4)
                    .HasColumnName("tut4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tut5)
                    .HasColumnName("tut5")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tut6)
                    .HasColumnName("tut6")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tut7)
                    .HasColumnName("tut7")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArenaTeam>(entity =>
            {
                entity.ToTable("arena_team", "characters");

                entity.Property(e => e.ArenaTeamId)
                    .HasColumnName("arenaTeamId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BackgroundColor)
                    .HasColumnName("backgroundColor")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BorderColor)
                    .HasColumnName("borderColor")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BorderStyle)
                    .HasColumnName("borderStyle")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CaptainGuid)
                    .HasColumnName("captainGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmblemColor)
                    .HasColumnName("emblemColor")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmblemStyle)
                    .HasColumnName("emblemStyle")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeasonGames)
                    .HasColumnName("seasonGames")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeasonWins)
                    .HasColumnName("seasonWins")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeekGames)
                    .HasColumnName("weekGames")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeekWins)
                    .HasColumnName("weekWins")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArenaTeamMember>(entity =>
            {
                entity.HasKey(e => new { e.ArenaTeamId, e.Guid });

                entity.ToTable("arena_team_member", "characters");

                entity.Property(e => e.ArenaTeamId)
                    .HasColumnName("arenaTeamId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PersonalRating)
                    .HasColumnName("personalRating")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeasonGames)
                    .HasColumnName("seasonGames")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeasonWins)
                    .HasColumnName("seasonWins")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeekGames)
                    .HasColumnName("weekGames")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeekWins)
                    .HasColumnName("weekWins")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Auctionhouse>(entity =>
            {
                entity.ToTable("auctionhouse", "characters");

                entity.HasIndex(e => e.Itemguid)
                    .HasName("item_guid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Auctioneerguid)
                    .HasColumnName("auctioneerguid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Buyguid)
                    .HasColumnName("buyguid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Buyoutprice)
                    .HasColumnName("buyoutprice")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deposit)
                    .HasColumnName("deposit")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Itemguid)
                    .HasColumnName("itemguid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Itemowner)
                    .HasColumnName("itemowner")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lastbid)
                    .HasColumnName("lastbid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Startbid)
                    .HasColumnName("startbid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BlackmarketAuctions>(entity =>
            {
                entity.HasKey(e => e.MarketId);

                entity.ToTable("blackmarket_auctions", "characters");

                entity.Property(e => e.MarketId)
                    .HasColumnName("marketId")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bidder)
                    .HasColumnName("bidder")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrentBid)
                    .HasColumnName("currentBid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NumBids)
                    .HasColumnName("numBids")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Bugreport>(entity =>
            {
                entity.ToTable("bugreport", "characters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("longtext");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<CalendarEvents>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("calendar_events", "characters");

                entity.Property(e => e.EventId)
                    .HasColumnName("EventID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EventType)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockDate)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Owner)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextureId)
                    .HasColumnName("TextureID")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CalendarInvites>(entity =>
            {
                entity.HasKey(e => e.InviteId);

                entity.ToTable("calendar_invites", "characters");

                entity.Property(e => e.InviteId)
                    .HasColumnName("InviteID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventId)
                    .HasColumnName("EventID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Invitee)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModerationRank)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseTime)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sender)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Channels>(entity =>
            {
                entity.HasKey(e => new { e.Name, e.Team });

                entity.ToTable("channels", "characters");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Announce)
                    .HasColumnName("announce")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BannedList)
                    .HasColumnName("bannedList")
                    .IsUnicode(false);

                entity.Property(e => e.LastUsed)
                    .HasColumnName("lastUsed")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Ownership)
                    .HasColumnName("ownership")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CharacterAccountData>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Type });

                entity.ToTable("character_account_data", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("blob");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterAchievement>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Achievement });

                entity.ToTable("character_achievement", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Achievement)
                    .HasColumnName("achievement")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterAchievementProgress>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Criteria });

                entity.ToTable("character_achievement_progress", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Criteria)
                    .HasColumnName("criteria")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterAction>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spec, e.Button });

                entity.ToTable("character_action", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spec)
                    .HasColumnName("spec")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Button)
                    .HasColumnName("button")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterArenaStats>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Slot });

                entity.ToTable("character_arena_stats", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.MatchMakerRating)
                    .HasColumnName("matchMakerRating")
                    .HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<CharacterAura>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.CasterGuid, e.ItemGuid, e.Spell, e.EffectMask });

                entity.ToTable("character_aura", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CasterGuid)
                    .HasColumnName("casterGuid")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("itemGuid")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectMask)
                    .HasColumnName("effectMask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CastItemLevel)
                    .HasColumnName("castItemLevel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.MaxDuration)
                    .HasColumnName("maxDuration")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecalculateMask)
                    .HasColumnName("recalculateMask")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RemainCharges)
                    .HasColumnName("remainCharges")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RemainTime)
                    .HasColumnName("remainTime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StackCount)
                    .HasColumnName("stackCount")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CharacterAuraEffect>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.CasterGuid, e.ItemGuid, e.Spell, e.EffectMask, e.EffectIndex });

                entity.ToTable("character_aura_effect", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CasterGuid)
                    .HasColumnName("casterGuid")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("itemGuid")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectMask)
                    .HasColumnName("effectMask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectIndex)
                    .HasColumnName("effectIndex")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BaseAmount)
                    .HasColumnName("baseAmount")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterBanned>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Bandate });

                entity.ToTable("character_banned", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
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

            modelBuilder.Entity<CharacterBattlegroundData>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("character_battleground_data", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instanceId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.JoinMapId)
                    .HasColumnName("joinMapId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JoinO)
                    .HasColumnName("joinO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JoinX)
                    .HasColumnName("joinX")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JoinY)
                    .HasColumnName("joinY")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JoinZ)
                    .HasColumnName("joinZ")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MountSpell)
                    .HasColumnName("mountSpell")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxiEnd)
                    .HasColumnName("taxiEnd")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxiStart)
                    .HasColumnName("taxiStart")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<CharacterBattlegroundRandom>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("character_battleground_random", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterCufProfiles>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Id });

                entity.ToTable("character_cuf_profiles", "characters");

                entity.HasIndex(e => e.Id)
                    .HasName("index");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BoolOptions)
                    .HasColumnName("boolOptions")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BottomOffset)
                    .HasColumnName("bottomOffset")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BottomPoint)
                    .HasColumnName("bottomPoint")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FrameHeight)
                    .HasColumnName("frameHeight")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FrameWidth)
                    .HasColumnName("frameWidth")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HealthText)
                    .HasColumnName("healthText")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LeftOffset)
                    .HasColumnName("leftOffset")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LeftPoint)
                    .HasColumnName("leftPoint")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SortBy)
                    .HasColumnName("sortBy")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TopOffset)
                    .HasColumnName("topOffset")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TopPoint)
                    .HasColumnName("topPoint")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterCurrency>(entity =>
            {
                entity.HasKey(e => new { e.CharacterGuid, e.Currency });

                entity.ToTable("character_currency", "characters");

                entity.Property(e => e.CharacterGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Currency).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Flags).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Quantity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TrackedQuantity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.WeeklyQuantity).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CharacterDeclinedname>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("character_declinedname", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Accusative)
                    .IsRequired()
                    .HasColumnName("accusative")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Dative)
                    .IsRequired()
                    .HasColumnName("dative")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Genitive)
                    .IsRequired()
                    .HasColumnName("genitive")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Instrumental)
                    .IsRequired()
                    .HasColumnName("instrumental")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Prepositional)
                    .IsRequired()
                    .HasColumnName("prepositional")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CharacterEquipmentsets>(entity =>
            {
                entity.HasKey(e => e.Setguid);

                entity.ToTable("character_equipmentsets", "characters");

                entity.HasIndex(e => e.Setindex)
                    .HasName("Idx_setindex");

                entity.HasIndex(e => new { e.Guid, e.Setguid, e.Setindex })
                    .HasName("idx_set")
                    .IsUnique();

                entity.Property(e => e.Setguid)
                    .HasColumnName("setguid")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AssignedSpecIndex)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Iconname)
                    .IsRequired()
                    .HasColumnName("iconname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IgnoreMask)
                    .HasColumnName("ignore_mask")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item0)
                    .HasColumnName("item0")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item1)
                    .HasColumnName("item1")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item10)
                    .HasColumnName("item10")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item11)
                    .HasColumnName("item11")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item12)
                    .HasColumnName("item12")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item13)
                    .HasColumnName("item13")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item14)
                    .HasColumnName("item14")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item15)
                    .HasColumnName("item15")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item16)
                    .HasColumnName("item16")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item17)
                    .HasColumnName("item17")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item18)
                    .HasColumnName("item18")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item2)
                    .HasColumnName("item2")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item3)
                    .HasColumnName("item3")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item4)
                    .HasColumnName("item4")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item5)
                    .HasColumnName("item5")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item6)
                    .HasColumnName("item6")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item7)
                    .HasColumnName("item7")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item8)
                    .HasColumnName("item8")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item9)
                    .HasColumnName("item9")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Setindex)
                    .HasColumnName("setindex")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterFishingsteps>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("character_fishingsteps", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FishingSteps)
                    .HasColumnName("fishingSteps")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterGarrison>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("character_garrison", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.FollowerActivationsRemainingToday)
                    .HasColumnName("followerActivationsRemainingToday")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SiteLevelId)
                    .HasColumnName("siteLevelId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterGarrisonBlueprints>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.BuildingId });

                entity.ToTable("character_garrison_blueprints", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BuildingId)
                    .HasColumnName("buildingId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterGarrisonBuildings>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.PlotInstanceId });

                entity.ToTable("character_garrison_buildings", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PlotInstanceId)
                    .HasColumnName("plotInstanceId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BuildingId)
                    .HasColumnName("buildingId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeBuilt)
                    .HasColumnName("timeBuilt")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<CharacterGarrisonFollowerAbilities>(entity =>
            {
                entity.HasKey(e => new { e.DbId, e.AbilityId, e.Slot });

                entity.ToTable("character_garrison_follower_abilities", "characters");

                entity.Property(e => e.DbId)
                    .HasColumnName("dbId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AbilityId)
                    .HasColumnName("abilityId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Db)
                    .WithMany(p => p.CharacterGarrisonFollowerAbilities)
                    .HasForeignKey(d => d.DbId)
                    .HasConstraintName("fk_foll_dbid");
            });

            modelBuilder.Entity<CharacterGarrisonFollowers>(entity =>
            {
                entity.HasKey(e => e.DbId);

                entity.ToTable("character_garrison_followers", "characters");

                entity.HasIndex(e => new { e.Guid, e.FollowerId })
                    .HasName("idx_guid_id")
                    .IsUnique();

                entity.Property(e => e.DbId)
                    .HasColumnName("dbId")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentBuilding)
                    .HasColumnName("currentBuilding")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrentMission)
                    .HasColumnName("currentMission")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FollowerId)
                    .HasColumnName("followerId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ItemLevelArmor)
                    .HasColumnName("itemLevelArmor")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("600");

                entity.Property(e => e.ItemLevelWeapon)
                    .HasColumnName("itemLevelWeapon")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("600");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("90");

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Xp)
                    .HasColumnName("xp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Gu)
                    .WithMany(p => p.CharacterGarrisonFollowers)
                    .HasForeignKey(d => d.Guid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_foll_owner");
            });

            modelBuilder.Entity<CharacterGifts>(entity =>
            {
                entity.HasKey(e => e.ItemGuid);

                entity.ToTable("character_gifts", "characters");

                entity.HasIndex(e => e.Guid)
                    .HasName("idx_guid");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("item_guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterGlyphs>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.TalentGroup, e.GlyphId });

                entity.ToTable("character_glyphs", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TalentGroup)
                    .HasColumnName("talentGroup")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GlyphId)
                    .HasColumnName("glyphId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterHomebind>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("character_homebind", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX)
                    .HasColumnName("posX")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosY)
                    .HasColumnName("posY")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosZ)
                    .HasColumnName("posZ")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zoneId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterInstance>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Instance });

                entity.ToTable("character_instance", "characters");

                entity.HasIndex(e => e.Instance)
                    .HasName("instance");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Instance)
                    .HasColumnName("instance")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExtendState)
                    .HasColumnName("extendState")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Permanent)
                    .HasColumnName("permanent")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterInventory>(entity =>
            {
                entity.HasKey(e => e.Item);

                entity.ToTable("character_inventory", "characters");

                entity.HasIndex(e => e.Guid)
                    .HasName("idx_guid");

                entity.HasIndex(e => new { e.Guid, e.Bag, e.Slot })
                    .HasName("guid")
                    .IsUnique();

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bag)
                    .HasColumnName("bag")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterPet>(entity =>
            {
                entity.ToTable("character_pet", "characters");

                entity.HasIndex(e => e.Owner)
                    .HasName("owner");

                entity.HasIndex(e => e.Slot)
                    .HasName("idx_slot");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Abdata)
                    .HasColumnName("abdata")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBySpell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Curhealth)
                    .HasColumnName("curhealth")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Curmana)
                    .HasColumnName("curmana")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Exp)
                    .HasColumnName("exp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Modelid)
                    .HasColumnName("modelid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Pet");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("bigint(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reactstate)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Renamed)
                    .HasColumnName("renamed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Savetime)
                    .HasColumnName("savetime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Specialization)
                    .HasColumnName("specialization")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterPetDeclinedname>(entity =>
            {
                entity.ToTable("character_pet_declinedname", "characters");

                entity.HasIndex(e => e.Owner)
                    .HasName("owner_key");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Accusative)
                    .IsRequired()
                    .HasColumnName("accusative")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Dative)
                    .IsRequired()
                    .HasColumnName("dative")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Genitive)
                    .IsRequired()
                    .HasColumnName("genitive")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Instrumental)
                    .IsRequired()
                    .HasColumnName("instrumental")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Prepositional)
                    .IsRequired()
                    .HasColumnName("prepositional")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CharacterPvpTalent>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.TalentId, e.TalentGroup });

                entity.ToTable("character_pvp_talent", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TalentId)
                    .HasColumnName("talentId")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.TalentGroup)
                    .HasColumnName("talentGroup")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterQueststatus>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest });

                entity.ToTable("character_queststatus", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Timer)
                    .HasColumnName("timer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterQueststatusDaily>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest });

                entity.ToTable("character_queststatus_daily", "characters");

                entity.HasIndex(e => e.Guid)
                    .HasName("idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterQueststatusMonthly>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest });

                entity.ToTable("character_queststatus_monthly", "characters");

                entity.HasIndex(e => e.Guid)
                    .HasName("idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterQueststatusObjectives>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest, e.Objective });

                entity.ToTable("character_queststatus_objectives", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objective)
                    .HasColumnName("objective")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterQueststatusObjectivesCriteria>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.QuestObjectiveId });

                entity.ToTable("character_queststatus_objectives_criteria", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.QuestObjectiveId)
                    .HasColumnName("questObjectiveId")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CharacterQueststatusObjectivesCriteriaProgress>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.CriteriaId });

                entity.ToTable("character_queststatus_objectives_criteria_progress", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CriteriaId)
                    .HasColumnName("criteriaId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterQueststatusRewarded>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest });

                entity.ToTable("character_queststatus_rewarded", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(10) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CharacterQueststatusSeasonal>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest });

                entity.ToTable("character_queststatus_seasonal", "characters");

                entity.HasIndex(e => e.Guid)
                    .HasName("idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Event)
                    .HasColumnName("event")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterQueststatusWeekly>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest });

                entity.ToTable("character_queststatus_weekly", "characters");

                entity.HasIndex(e => e.Guid)
                    .HasName("idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterReputation>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Faction });

                entity.ToTable("character_reputation", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Faction)
                    .HasColumnName("faction")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Standing)
                    .HasColumnName("standing")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Characters>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("characters", "characters");

                entity.HasIndex(e => e.Account)
                    .HasName("idx_account");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_name");

                entity.HasIndex(e => e.Online)
                    .HasName("idx_online");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActionBars)
                    .HasColumnName("actionBars")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActiveTalentGroup)
                    .HasColumnName("activeTalentGroup")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AtLogin)
                    .HasColumnName("at_login")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BankSlots)
                    .HasColumnName("bankSlots")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChosenTitle)
                    .HasColumnName("chosenTitle")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cinematic)
                    .HasColumnName("cinematic")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomDisplay1)
                    .HasColumnName("customDisplay1")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomDisplay2)
                    .HasColumnName("customDisplay2")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomDisplay3)
                    .HasColumnName("customDisplay3")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeathExpireTime)
                    .HasColumnName("death_expire_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeleteDate)
                    .HasColumnName("deleteDate")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DeleteInfosAccount)
                    .HasColumnName("deleteInfos_Account")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DeleteInfosName)
                    .HasColumnName("deleteInfos_Name")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Drunk)
                    .HasColumnName("drunk")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DungeonDifficulty)
                    .HasColumnName("dungeonDifficulty")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EquipmentCache)
                    .HasColumnName("equipmentCache")
                    .HasColumnType("longtext");

                entity.Property(e => e.ExploredZones)
                    .HasColumnName("exploredZones")
                    .HasColumnType("longtext");

                entity.Property(e => e.ExtraFlags)
                    .HasColumnName("extra_flags")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Face)
                    .HasColumnName("face")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FacialStyle)
                    .HasColumnName("facialStyle")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GrantableLevels)
                    .HasColumnName("grantableLevels")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HairColor)
                    .HasColumnName("hairColor")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HairStyle)
                    .HasColumnName("hairStyle")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Health)
                    .HasColumnName("health")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Honor)
                    .HasColumnName("honor")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HonorLevel)
                    .HasColumnName("honorLevel")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HonorRestBonus)
                    .HasColumnName("honorRestBonus")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HonorRestState)
                    .HasColumnName("honorRestState")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instance_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InventorySlots)
                    .HasColumnName("inventorySlots")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("16");

                entity.Property(e => e.IsLogoutResting)
                    .HasColumnName("is_logout_resting")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KnownTitles)
                    .HasColumnName("knownTitles")
                    .HasColumnType("longtext");

                entity.Property(e => e.LastLoginBuild)
                    .HasColumnName("lastLoginBuild")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Latency)
                    .HasColumnName("latency")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LegacyRaidDifficulty)
                    .HasColumnName("legacyRaidDifficulty")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Leveltime)
                    .HasColumnName("leveltime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LogoutTime)
                    .HasColumnName("logout_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LootSpecId)
                    .HasColumnName("lootSpecId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Money)
                    .HasColumnName("money")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Online)
                    .HasColumnName("online")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orientation)
                    .HasColumnName("orientation")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerFlags)
                    .HasColumnName("playerFlags")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerFlagsEx)
                    .HasColumnName("playerFlagsEx")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PositionX)
                    .HasColumnName("position_x")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PositionY)
                    .HasColumnName("position_y")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PositionZ)
                    .HasColumnName("position_z")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Power1)
                    .HasColumnName("power1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Power2)
                    .HasColumnName("power2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Power3)
                    .HasColumnName("power3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Power4)
                    .HasColumnName("power4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Power5)
                    .HasColumnName("power5")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Power6)
                    .HasColumnName("power6")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrestigeLevel)
                    .HasColumnName("prestigeLevel")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrimarySpecialization)
                    .HasColumnName("primarySpecialization")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaidDifficulty)
                    .HasColumnName("raidDifficulty")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("14");

                entity.Property(e => e.ResettalentsCost)
                    .HasColumnName("resettalents_cost")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResettalentsTime)
                    .HasColumnName("resettalents_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RestBonus)
                    .HasColumnName("rest_bonus")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RestState)
                    .HasColumnName("restState")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skin)
                    .HasColumnName("skin")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StableSlots)
                    .HasColumnName("stable_slots")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxiPath)
                    .HasColumnName("taxi_path")
                    .IsUnicode(false);

                entity.Property(e => e.Taximask)
                    .IsRequired()
                    .HasColumnName("taximask")
                    .IsUnicode(false);

                entity.Property(e => e.TodayKills)
                    .HasColumnName("todayKills")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalKills)
                    .HasColumnName("totalKills")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Totaltime)
                    .HasColumnName("totaltime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransO)
                    .HasColumnName("trans_o")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransX)
                    .HasColumnName("trans_x")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransY)
                    .HasColumnName("trans_y")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransZ)
                    .HasColumnName("trans_z")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transguid)
                    .HasColumnName("transguid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WatchedFaction)
                    .HasColumnName("watchedFaction")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Xp)
                    .HasColumnName("xp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YesterdayKills)
                    .HasColumnName("yesterdayKills")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zone)
                    .HasColumnName("zone")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterSkills>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Skill });

                entity.ToTable("character_skills", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Skill)
                    .HasColumnName("skill")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Max)
                    .HasColumnName("max")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<CharacterSocial>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Friend, e.Flags });

                entity.ToTable("character_social", "characters");

                entity.HasIndex(e => e.Friend)
                    .HasName("friend");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Friend)
                    .HasColumnName("friend")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasMaxLength(48)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CharacterSpell>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell });

                entity.ToTable("character_spell", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Disabled)
                    .HasColumnName("disabled")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterSpellCharge>(entity =>
            {
                entity.HasIndex(e => e.Guid).HasName("idx_guid");
                
                entity.ToTable("character_spell_charges", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");
                
                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RechargeStart)
                    .HasColumnName("rechargeStart")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RechargeEnd)
                    .HasColumnName("rechargeEnd")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CharacterSpellCooldown>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell });

                entity.ToTable("character_spell_cooldown", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryEnd)
                    .HasColumnName("categoryEnd")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterStats>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("character_stats", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Agility)
                    .HasColumnName("agility")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Armor)
                    .HasColumnName("armor")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttackPower)
                    .HasColumnName("attackPower")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BlockPct)
                    .HasColumnName("blockPct")
                    .HasColumnType("float unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CritPct)
                    .HasColumnName("critPct")
                    .HasColumnType("float unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DodgePct)
                    .HasColumnName("dodgePct")
                    .HasColumnType("float unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Intellect)
                    .HasColumnName("intellect")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Maxhealth)
                    .HasColumnName("maxhealth")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Maxpower1)
                    .HasColumnName("maxpower1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Maxpower2)
                    .HasColumnName("maxpower2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Maxpower3)
                    .HasColumnName("maxpower3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Maxpower4)
                    .HasColumnName("maxpower4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Maxpower5)
                    .HasColumnName("maxpower5")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Maxpower6)
                    .HasColumnName("maxpower6")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParryPct)
                    .HasColumnName("parryPct")
                    .HasColumnType("float unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangedAttackPower)
                    .HasColumnName("rangedAttackPower")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangedCritPct)
                    .HasColumnName("rangedCritPct")
                    .HasColumnType("float unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResArcane)
                    .HasColumnName("resArcane")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResFire)
                    .HasColumnName("resFire")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResFrost)
                    .HasColumnName("resFrost")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResHoly)
                    .HasColumnName("resHoly")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResNature)
                    .HasColumnName("resNature")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResShadow)
                    .HasColumnName("resShadow")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Resilience)
                    .HasColumnName("resilience")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellCritPct)
                    .HasColumnName("spellCritPct")
                    .HasColumnType("float unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellPower)
                    .HasColumnName("spellPower")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stamina)
                    .HasColumnName("stamina")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Strength)
                    .HasColumnName("strength")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterTalent>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.TalentId, e.TalentGroup });

                entity.ToTable("character_talent", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TalentId)
                    .HasColumnName("talentId")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.TalentGroup)
                    .HasColumnName("talentGroup")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterTransmogOutfits>(entity =>
            {
                entity.HasKey(e => e.Setguid);

                entity.ToTable("character_transmog_outfits", "characters");

                entity.HasIndex(e => e.Setindex)
                    .HasName("Idx_setindex");

                entity.HasIndex(e => new { e.Guid, e.Setguid, e.Setindex })
                    .HasName("idx_set")
                    .IsUnique();

                entity.Property(e => e.Setguid)
                    .HasColumnName("setguid")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Appearance0)
                    .HasColumnName("appearance0")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance1)
                    .HasColumnName("appearance1")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance10)
                    .HasColumnName("appearance10")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance11)
                    .HasColumnName("appearance11")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance12)
                    .HasColumnName("appearance12")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance13)
                    .HasColumnName("appearance13")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance14)
                    .HasColumnName("appearance14")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance15)
                    .HasColumnName("appearance15")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance16)
                    .HasColumnName("appearance16")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance17)
                    .HasColumnName("appearance17")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance18)
                    .HasColumnName("appearance18")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance2)
                    .HasColumnName("appearance2")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance3)
                    .HasColumnName("appearance3")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance4)
                    .HasColumnName("appearance4")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance5)
                    .HasColumnName("appearance5")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance6)
                    .HasColumnName("appearance6")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance7)
                    .HasColumnName("appearance7")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance8)
                    .HasColumnName("appearance8")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Appearance9)
                    .HasColumnName("appearance9")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Iconname)
                    .IsRequired()
                    .HasColumnName("iconname")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IgnoreMask)
                    .HasColumnName("ignore_mask")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MainHandEnchant)
                    .HasColumnName("mainHandEnchant")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OffHandEnchant)
                    .HasColumnName("offHandEnchant")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Setindex)
                    .HasColumnName("setindex")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterVoidStorage>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("character_void_storage", "characters");

                entity.HasIndex(e => e.PlayerGuid)
                    .HasName("idx_player");

                entity.HasIndex(e => new { e.PlayerGuid, e.Slot })
                    .HasName("idx_player_slot")
                    .IsUnique();

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtifactKnowledgeLevel)
                    .HasColumnName("artifactKnowledgeLevel")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BonusListIds)
                    .HasColumnName("bonusListIDs")
                    .IsUnicode(false);

                entity.Property(e => e.Context)
                    .HasColumnName("context")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatorGuid)
                    .HasColumnName("creatorGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FixedScalingLevel)
                    .HasColumnName("fixedScalingLevel")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemEntry)
                    .HasColumnName("itemEntry")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.PlayerGuid)
                    .HasColumnName("playerGuid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RandomProperty)
                    .HasColumnName("randomProperty")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RandomPropertyType)
                    .HasColumnName("randomPropertyType")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SuffixFactor)
                    .HasColumnName("suffixFactor")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeId)
                    .HasColumnName("upgradeId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Corpse>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("corpse", "characters");

                entity.HasIndex(e => e.CorpseType)
                    .HasName("idx_type");

                entity.HasIndex(e => e.InstanceId)
                    .HasName("idx_instance");

                entity.HasIndex(e => e.Time)
                    .HasName("idx_time");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bytes1)
                    .HasColumnName("bytes1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bytes2)
                    .HasColumnName("bytes2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CorpseType)
                    .HasColumnName("corpseType")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayId)
                    .HasColumnName("displayId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DynFlags)
                    .HasColumnName("dynFlags")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instanceId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCache)
                    .IsRequired()
                    .HasColumnName("itemCache")
                    .IsUnicode(false);

                entity.Property(e => e.MapId)
                    .HasColumnName("mapId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orientation)
                    .HasColumnName("orientation")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX)
                    .HasColumnName("posX")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosY)
                    .HasColumnName("posY")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosZ)
                    .HasColumnName("posZ")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CorpsePhases>(entity =>
            {
                entity.HasKey(e => new { e.OwnerGuid, e.PhaseId });

                entity.ToTable("corpse_phases", "characters");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseId).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CreatureRespawn>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.InstanceId });

                entity.ToTable("creature_respawn", "characters");

                entity.HasIndex(e => e.InstanceId)
                    .HasName("idx_instance");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instanceId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapId")
                    .HasColumnType("smallint(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RespawnTime)
                    .HasColumnName("respawnTime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GameEventConditionSave>(entity =>
            {
                entity.HasKey(e => new { e.EventEntry, e.ConditionId });

                entity.ToTable("game_event_condition_save", "characters");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("condition_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Done)
                    .HasColumnName("done")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GameEventSave>(entity =>
            {
                entity.HasKey(e => e.EventEntry);

                entity.ToTable("game_event_save", "characters");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.NextStart)
                    .HasColumnName("next_start")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<GameobjectRespawn>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.InstanceId });

                entity.ToTable("gameobject_respawn", "characters");

                entity.HasIndex(e => e.InstanceId)
                    .HasName("idx_instance");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instanceId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapId")
                    .HasColumnType("smallint(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RespawnTime)
                    .HasColumnName("respawnTime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GmBug>(entity =>
            {
                entity.ToTable("gm_bug", "characters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("assignedTo")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClosedBy)
                    .HasColumnName("closedBy")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Facing)
                    .HasColumnName("facing")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .IsUnicode(false);

                entity.Property(e => e.PlayerGuid)
                    .HasColumnName("playerGuid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PosX)
                    .HasColumnName("posX")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosY)
                    .HasColumnName("posY")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosZ)
                    .HasColumnName("posZ")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GmComplaint>(entity =>
            {
                entity.ToTable("gm_complaint", "characters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("assignedTo")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClosedBy)
                    .HasColumnName("closedBy")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .IsUnicode(false);

                entity.Property(e => e.ComplaintType)
                    .HasColumnName("complaintType")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Facing)
                    .HasColumnName("facing")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .IsUnicode(false);

                entity.Property(e => e.PlayerGuid)
                    .HasColumnName("playerGuid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PosX)
                    .HasColumnName("posX")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosY)
                    .HasColumnName("posY")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosZ)
                    .HasColumnName("posZ")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReportLineIndex)
                    .HasColumnName("reportLineIndex")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TargetCharacterGuid)
                    .HasColumnName("targetCharacterGuid")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<GmComplaintChatlog>(entity =>
            {
                entity.HasKey(e => new { e.ComplaintId, e.LineId });

                entity.ToTable("gm_complaint_chatlog", "characters");

                entity.Property(e => e.ComplaintId)
                    .HasColumnName("complaintId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LineId)
                    .HasColumnName("lineId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<GmSuggestion>(entity =>
            {
                entity.ToTable("gm_suggestion", "characters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("assignedTo")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClosedBy)
                    .HasColumnName("closedBy")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Facing)
                    .HasColumnName("facing")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .IsUnicode(false);

                entity.Property(e => e.PlayerGuid)
                    .HasColumnName("playerGuid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PosX)
                    .HasColumnName("posX")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosY)
                    .HasColumnName("posY")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosZ)
                    .HasColumnName("posZ")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GroupInstance>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Instance });

                entity.ToTable("group_instance", "characters");

                entity.HasIndex(e => e.Instance)
                    .HasName("instance");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Instance)
                    .HasColumnName("instance")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Permanent)
                    .HasColumnName("permanent")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GroupMember>(entity =>
            {
                entity.HasKey(e => e.MemberGuid);

                entity.ToTable("group_member", "characters");

                entity.Property(e => e.MemberGuid)
                    .HasColumnName("memberGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MemberFlags)
                    .HasColumnName("memberFlags")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Roles)
                    .HasColumnName("roles")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subgroup)
                    .HasColumnName("subgroup")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("groups", "characters");

                entity.HasIndex(e => e.LeaderGuid)
                    .HasName("leaderGuid");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Difficulty)
                    .HasColumnName("difficulty")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.GroupType)
                    .HasColumnName("groupType")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Icon1)
                    .IsRequired()
                    .HasColumnName("icon1")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Icon2)
                    .IsRequired()
                    .HasColumnName("icon2")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Icon3)
                    .IsRequired()
                    .HasColumnName("icon3")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Icon4)
                    .IsRequired()
                    .HasColumnName("icon4")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Icon5)
                    .IsRequired()
                    .HasColumnName("icon5")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Icon6)
                    .IsRequired()
                    .HasColumnName("icon6")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Icon7)
                    .IsRequired()
                    .HasColumnName("icon7")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Icon8)
                    .IsRequired()
                    .HasColumnName("icon8")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.LeaderGuid)
                    .HasColumnName("leaderGuid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LegacyRaidDifficulty)
                    .HasColumnName("legacyRaidDifficulty")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.LootMethod)
                    .HasColumnName("lootMethod")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootThreshold)
                    .HasColumnName("lootThreshold")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LooterGuid)
                    .HasColumnName("looterGuid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MasterLooterGuid)
                    .HasColumnName("masterLooterGuid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RaidDifficulty)
                    .HasColumnName("raidDifficulty")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("14");
            });

            modelBuilder.Entity<Guild>(entity =>
            {
                entity.ToTable("guild", "characters");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BackgroundColor)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BankMoney)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BorderColor)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BorderStyle)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmblemColor)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmblemStyle)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasColumnName("info")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Leaderguid)
                    .HasColumnName("leaderguid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Motd)
                    .IsRequired()
                    .HasColumnName("motd")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuildAchievement>(entity =>
            {
                entity.HasKey(e => new { e.GuildId, e.Achievement });

                entity.ToTable("guild_achievement", "characters");

                entity.Property(e => e.GuildId)
                    .HasColumnName("guildId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Achievement)
                    .HasColumnName("achievement")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Guids)
                    .IsRequired()
                    .HasColumnName("guids")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuildAchievementProgress>(entity =>
            {
                entity.HasKey(e => new { e.GuildId, e.Criteria });

                entity.ToTable("guild_achievement_progress", "characters");

                entity.Property(e => e.GuildId)
                    .HasColumnName("guildId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Criteria)
                    .HasColumnName("criteria")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CompletedGuid)
                    .HasColumnName("completedGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildBankEventlog>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.LogGuid, e.TabId });

                entity.ToTable("guild_bank_eventlog", "characters");

                entity.HasIndex(e => e.Guildid)
                    .HasName("guildid_key");

                entity.HasIndex(e => e.LogGuid)
                    .HasName("Idx_LogGuid");

                entity.HasIndex(e => e.PlayerGuid)
                    .HasName("Idx_PlayerGuid");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LogGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DestTabId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemOrMoney)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStackCount)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildBankItem>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.TabId, e.SlotId });

                entity.ToTable("guild_bank_item", "characters");

                entity.HasIndex(e => e.Guildid)
                    .HasName("guildid_key");

                entity.HasIndex(e => e.ItemGuid)
                    .HasName("Idx_item_guid");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SlotId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("item_guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildBankRight>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.TabId, e.Rid });

                entity.ToTable("guild_bank_right", "characters");

                entity.HasIndex(e => e.Guildid)
                    .HasName("guildid_key");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gbright)
                    .HasColumnName("gbright")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SlotPerDay)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildBankTab>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.TabId });

                entity.ToTable("guild_bank_tab", "characters");

                entity.HasIndex(e => e.Guildid)
                    .HasName("guildid_key");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabIcon)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TabName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TabText)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuildEventlog>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.LogGuid });

                entity.ToTable("guild_eventlog", "characters");

                entity.HasIndex(e => e.LogGuid)
                    .HasName("Idx_LogGuid");

                entity.HasIndex(e => e.PlayerGuid1)
                    .HasName("Idx_PlayerGuid1");

                entity.HasIndex(e => e.PlayerGuid2)
                    .HasName("Idx_PlayerGuid2");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LogGuid).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EventType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.NewRank).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PlayerGuid1).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PlayerGuid2).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TimeStamp).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<GuildFinderApplicant>(entity =>
            {
                entity.HasKey(e => new { e.GuildId, e.PlayerGuid });

                entity.ToTable("guild_finder_applicant", "characters");

                entity.Property(e => e.GuildId)
                    .HasColumnName("guildId")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerGuid)
                    .HasColumnName("playerGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Availability)
                    .HasColumnName("availability")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassRole)
                    .HasColumnName("classRole")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Interests)
                    .HasColumnName("interests")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<GuildFinderGuildSettings>(entity =>
            {
                entity.HasKey(e => e.GuildId);

                entity.ToTable("guild_finder_guild_settings", "characters");

                entity.Property(e => e.GuildId)
                    .HasColumnName("guildId")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Availability)
                    .HasColumnName("availability")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassRoles)
                    .HasColumnName("classRoles")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Interests)
                    .HasColumnName("interests")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Listed)
                    .HasColumnName("listed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });
            
            modelBuilder.Entity<GuildMember>(entity =>
            {
                entity.HasKey(e => e.Guid).HasName("guid_key");

                entity.ToTable("guild_member", "characters");

                entity.HasIndex(e => e.Guid).HasName("guid_key").IsUnique();
                entity.HasIndex(e => e.Guildid).HasName("guildid_key");
                entity.HasIndex(e => new { e.Guildid, e.Rank }).HasName("guildid_rank_key");
                
                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Pnote)
                    .HasColumnName("pnote")
                    .HasColumnType("varchar(31)");

                entity.Property(e => e.Offnote)
                    .HasColumnName("offnote")
                    .HasColumnType("varchar(31)");
            });

            modelBuilder.Entity<GuildMemberWithdraw>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("guild_member_withdraw", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Money)
                    .HasColumnName("money")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tab0)
                    .HasColumnName("tab0")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tab1)
                    .HasColumnName("tab1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tab2)
                    .HasColumnName("tab2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tab3)
                    .HasColumnName("tab3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tab4)
                    .HasColumnName("tab4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tab5)
                    .HasColumnName("tab5")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tab6)
                    .HasColumnName("tab6")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tab7)
                    .HasColumnName("tab7")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildNewslog>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.LogGuid });

                entity.ToTable("guild_newslog", "characters");

                entity.HasIndex(e => e.Guildid)
                    .HasName("guildid_key");

                entity.HasIndex(e => e.LogGuid)
                    .HasName("Idx_LogGuid");

                entity.HasIndex(e => e.PlayerGuid)
                    .HasName("Idx_PlayerGuid");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LogGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildRank>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.Rid });

                entity.ToTable("guild_rank", "characters");

                entity.HasIndex(e => e.Rid)
                    .HasName("Idx_rid");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BankMoneyPerDay)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rights)
                    .HasColumnName("rights")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rname)
                    .IsRequired()
                    .HasColumnName("rname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Instance>(entity =>
            {
                entity.ToTable("instance", "characters");

                entity.HasIndex(e => e.Difficulty)
                    .HasName("difficulty");

                entity.HasIndex(e => e.Map)
                    .HasName("map");

                entity.HasIndex(e => e.Resettime)
                    .HasName("resettime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CompletedEncounters)
                    .HasColumnName("completedEncounters")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Difficulty)
                    .HasColumnName("difficulty")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EntranceId)
                    .HasColumnName("entranceId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Resettime)
                    .HasColumnName("resettime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<InstanceReset>(entity =>
            {
                entity.HasKey(e => new { e.Mapid, e.Difficulty });

                entity.ToTable("instance_reset", "characters");

                entity.HasIndex(e => e.Difficulty)
                    .HasName("difficulty");

                entity.Property(e => e.Mapid)
                    .HasColumnName("mapid")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty)
                    .HasColumnName("difficulty")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Resettime)
                    .HasColumnName("resettime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<InstanceScenarioProgress>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Criteria });

                entity.ToTable("instance_scenario_progress", "characters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Criteria)
                    .HasColumnName("criteria")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemInstance>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("item_instance", "characters");

                entity.HasIndex(e => e.OwnerGuid)
                    .HasName("idx_owner_guid");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BattlePetBreedData)
                    .HasColumnName("battlePetBreedData")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BattlePetDisplayId)
                    .HasColumnName("battlePetDisplayId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BattlePetLevel)
                    .HasColumnName("battlePetLevel")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BattlePetSpeciesId)
                    .HasColumnName("battlePetSpeciesId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BonusListIds)
                    .HasColumnName("bonusListIDs")
                    .IsUnicode(false);

                entity.Property(e => e.Charges)
                    .HasColumnName("charges")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Context)
                    .HasColumnName("context")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatorGuid)
                    .HasColumnName("creatorGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Durability)
                    .HasColumnName("durability")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnchantIllusion)
                    .HasColumnName("enchantIllusion")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantments)
                    .IsRequired()
                    .HasColumnName("enchantments")
                    .IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GiftCreatorGuid)
                    .HasColumnName("giftCreatorGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemEntry)
                    .HasColumnName("itemEntry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("owner_guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayedTime)
                    .HasColumnName("playedTime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RandomPropertyId)
                    .HasColumnName("randomPropertyId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RandomPropertyType)
                    .HasColumnName("randomPropertyType")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .IsUnicode(false);

                entity.Property(e => e.Transmogrification)
                    .HasColumnName("transmogrification")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeId)
                    .HasColumnName("upgradeId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemInstanceArtifact>(entity =>
            {
                entity.HasKey(e => e.ItemGuid);

                entity.ToTable("item_instance_artifact", "characters");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("itemGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtifactAppearanceId)
                    .HasColumnName("artifactAppearanceId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactTierId)
                    .HasColumnName("artifactTierId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Xp)
                    .HasColumnName("xp")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemInstanceArtifactPowers>(entity =>
            {
                entity.HasKey(e => new { e.ItemGuid, e.ArtifactPowerId });

                entity.ToTable("item_instance_artifact_powers", "characters");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("itemGuid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ArtifactPowerId)
                    .HasColumnName("artifactPowerId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PurchasedRank)
                    .HasColumnName("purchasedRank")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemInstanceGems>(entity =>
            {
                entity.HasKey(e => e.ItemGuid);

                entity.ToTable("item_instance_gems", "characters");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("itemGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.GemBonuses1)
                    .HasColumnName("gemBonuses1")
                    .IsUnicode(false);

                entity.Property(e => e.GemBonuses2)
                    .HasColumnName("gemBonuses2")
                    .IsUnicode(false);

                entity.Property(e => e.GemBonuses3)
                    .HasColumnName("gemBonuses3")
                    .IsUnicode(false);

                entity.Property(e => e.GemContext1)
                    .HasColumnName("gemContext1")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GemContext2)
                    .HasColumnName("gemContext2")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GemContext3)
                    .HasColumnName("gemContext3")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GemItemId1)
                    .HasColumnName("gemItemId1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GemItemId2)
                    .HasColumnName("gemItemId2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GemItemId3)
                    .HasColumnName("gemItemId3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GemScalingLevel1)
                    .HasColumnName("gemScalingLevel1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GemScalingLevel2)
                    .HasColumnName("gemScalingLevel2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GemScalingLevel3)
                    .HasColumnName("gemScalingLevel3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemInstanceModifiers>(entity =>
            {
                entity.HasKey(e => e.ItemGuid);

                entity.ToTable("item_instance_modifiers", "characters");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("itemGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtifactKnowledgeLevel)
                    .HasColumnName("artifactKnowledgeLevel")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FixedScalingLevel)
                    .HasColumnName("fixedScalingLevel")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemInstanceTransmog>(entity =>
            {
                entity.HasKey(e => e.ItemGuid);

                entity.ToTable("item_instance_transmog", "characters");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("itemGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemModifiedAppearanceAllSpecs)
                    .HasColumnName("itemModifiedAppearanceAllSpecs")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemModifiedAppearanceSpec1)
                    .HasColumnName("itemModifiedAppearanceSpec1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemModifiedAppearanceSpec2)
                    .HasColumnName("itemModifiedAppearanceSpec2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemModifiedAppearanceSpec3)
                    .HasColumnName("itemModifiedAppearanceSpec3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemModifiedAppearanceSpec4)
                    .HasColumnName("itemModifiedAppearanceSpec4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellItemEnchantmentAllSpecs)
                    .HasColumnName("spellItemEnchantmentAllSpecs")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellItemEnchantmentSpec1)
                    .HasColumnName("spellItemEnchantmentSpec1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellItemEnchantmentSpec2)
                    .HasColumnName("spellItemEnchantmentSpec2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellItemEnchantmentSpec3)
                    .HasColumnName("spellItemEnchantmentSpec3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellItemEnchantmentSpec4)
                    .HasColumnName("spellItemEnchantmentSpec4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemLootItems>(entity =>
            {
                entity.HasKey(e => new { e.ContainerId, e.ItemId });

                entity.ToTable("item_loot_items", "characters");

                entity.Property(e => e.ContainerId)
                    .HasColumnName("container_id")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Blocked)
                    .HasColumnName("blocked")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BonusListIds)
                    .HasColumnName("bonus_list_ids")
                    .IsUnicode(false);

                entity.Property(e => e.Context)
                    .HasColumnName("context")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Counted)
                    .HasColumnName("counted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ffa)
                    .HasColumnName("ffa")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FollowRules)
                    .HasColumnName("follow_rules")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount)
                    .HasColumnName("item_count")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NeedsQuest)
                    .HasColumnName("needs_quest")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RndProp)
                    .HasColumnName("rnd_prop")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RndSuffix)
                    .HasColumnName("rnd_suffix")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RndType)
                    .HasColumnName("rnd_type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnderThreshold)
                    .HasColumnName("under_threshold")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemLootMoney>(entity =>
            {
                entity.HasKey(e => e.ContainerId);

                entity.ToTable("item_loot_money", "characters");

                entity.Property(e => e.ContainerId)
                    .HasColumnName("container_id")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Money)
                    .HasColumnName("money")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemRefundInstance>(entity =>
            {
                entity.HasKey(e => new { e.ItemGuid, e.PlayerGuid });

                entity.ToTable("item_refund_instance", "characters");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("item_guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PlayerGuid)
                    .HasColumnName("player_guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PaidExtendedCost)
                    .HasColumnName("paidExtendedCost")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PaidMoney)
                    .HasColumnName("paidMoney")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSoulboundTradeData>(entity =>
            {
                entity.HasKey(e => e.ItemGuid);

                entity.ToTable("item_soulbound_trade_data", "characters");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("itemGuid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowedPlayers)
                    .IsRequired()
                    .HasColumnName("allowedPlayers")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LfgData>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("lfg_data", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dungeon)
                    .HasColumnName("dungeon")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Mail>(entity =>
            {
                entity.ToTable("mail", "characters");

                entity.HasIndex(e => e.Receiver)
                    .HasName("idx_receiver");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("longtext");

                entity.Property(e => e.Checked)
                    .HasColumnName("checked")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cod)
                    .HasColumnName("cod")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeliverTime)
                    .HasColumnName("deliver_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpireTime)
                    .HasColumnName("expire_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasItems)
                    .HasColumnName("has_items")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MailTemplateId)
                    .HasColumnName("mailTemplateId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MessageType)
                    .HasColumnName("messageType")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Money)
                    .HasColumnName("money")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Receiver)
                    .HasColumnName("receiver")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stationery)
                    .HasColumnName("stationery")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("41");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<MailItems>(entity =>
            {
                entity.HasKey(e => e.ItemGuid);

                entity.ToTable("mail_items", "characters");

                entity.HasIndex(e => e.MailId)
                    .HasName("idx_mail_id");

                entity.HasIndex(e => e.Receiver)
                    .HasName("idx_receiver");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("item_guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MailId)
                    .HasColumnName("mail_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Receiver)
                    .HasColumnName("receiver")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PetAura>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell, e.EffectMask });

                entity.ToTable("pet_aura", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectMask)
                    .HasColumnName("effectMask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CasterGuid)
                    .IsRequired()
                    .HasColumnName("casterGuid")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.MaxDuration)
                    .HasColumnName("maxDuration")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecalculateMask)
                    .HasColumnName("recalculateMask")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RemainCharges)
                    .HasColumnName("remainCharges")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RemainTime)
                    .HasColumnName("remainTime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StackCount)
                    .HasColumnName("stackCount")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PetAuraEffect>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.CasterGuid, e.Spell, e.EffectMask, e.EffectIndex });

                entity.ToTable("pet_aura_effect", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CasterGuid)
                    .HasColumnName("casterGuid")
                    .HasColumnType("binary(16)");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectMask)
                    .HasColumnName("effectMask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectIndex)
                    .HasColumnName("effectIndex")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BaseAmount)
                    .HasColumnName("baseAmount")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Petition>(entity =>
            {
                entity.HasKey(e => e.Ownerguid);

                entity.ToTable("petition", "characters");

                entity.HasIndex(e => new { e.Ownerguid, e.Petitionguid })
                    .HasName("index_ownerguid_petitionguid")
                    .IsUnique();

                entity.Property(e => e.Ownerguid)
                    .HasColumnName("ownerguid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Petitionguid)
                    .HasColumnName("petitionguid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PetitionSign>(entity =>
            {
                entity.HasKey(e => new { e.Petitionguid, e.Playerguid });

                entity.ToTable("petition_sign", "characters");

                entity.HasIndex(e => e.Ownerguid)
                    .HasName("Idx_ownerguid");

                entity.HasIndex(e => e.Playerguid)
                    .HasName("Idx_playerguid");

                entity.Property(e => e.Petitionguid)
                    .HasColumnName("petitionguid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Playerguid)
                    .HasColumnName("playerguid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ownerguid)
                    .HasColumnName("ownerguid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PlayerAccount)
                    .HasColumnName("player_account")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PetSpell>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell });

                entity.ToTable("pet_spell", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });
            
            modelBuilder.Entity<PetSpellCharge>(entity =>
            {
                entity.HasIndex(e => e.Guid).HasName("idx_guid");

                entity.ToTable("pet_spell_charges", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RechargeStart)
                    .HasColumnName("rechargeStart")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RechargeEnd)
                    .HasColumnName("rechargeEnd")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PetSpellCooldown>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell });

                entity.ToTable("pet_spell_cooldown", "characters");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryEnd)
                    .HasColumnName("categoryEnd")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PoolQuestSave>(entity =>
            {
                entity.HasKey(e => new { e.PoolId, e.QuestId });

                entity.ToTable("pool_quest_save", "characters");

                entity.Property(e => e.PoolId)
                    .HasColumnName("pool_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PvpstatsBattlegrounds>(entity =>
            {
                entity.ToTable("pvpstats_battlegrounds", "characters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BracketId)
                    .HasColumnName("bracket_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.WinnerFaction)
                    .HasColumnName("winner_faction")
                    .HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<PvpstatsPlayers>(entity =>
            {
                entity.HasKey(e => new { e.BattlegroundId, e.CharacterGuid });

                entity.ToTable("pvpstats_players", "characters");

                entity.Property(e => e.BattlegroundId)
                    .HasColumnName("battleground_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CharacterGuid)
                    .HasColumnName("character_guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Attr1)
                    .HasColumnName("attr_1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attr2)
                    .HasColumnName("attr_2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attr3)
                    .HasColumnName("attr_3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attr4)
                    .HasColumnName("attr_4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attr5)
                    .HasColumnName("attr_5")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScoreBonusHonor)
                    .HasColumnName("score_bonus_honor")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScoreDamageDone)
                    .HasColumnName("score_damage_done")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScoreDeaths)
                    .HasColumnName("score_deaths")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScoreHealingDone)
                    .HasColumnName("score_healing_done")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScoreHonorableKills)
                    .HasColumnName("score_honorable_kills")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScoreKillingBlows)
                    .HasColumnName("score_killing_blows")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Winner)
                    .HasColumnName("winner")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<QuestTracker>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CharacterGuid });

                entity.ToTable("quest_tracker", "characters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CharacterGuid)
                    .HasColumnName("character_guid")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CompletedByGm)
                    .HasColumnName("completed_by_gm")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CoreHash)
                    .IsRequired()
                    .HasColumnName("core_hash")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CoreRevision)
                    .IsRequired()
                    .HasColumnName("core_revision")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestAbandonTime).HasColumnName("quest_abandon_time");

                entity.Property(e => e.QuestAcceptTime).HasColumnName("quest_accept_time");

                entity.Property(e => e.QuestCompleteTime).HasColumnName("quest_complete_time");
            });

            modelBuilder.Entity<ReservedName>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("reserved_name", "characters");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Updates>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("updates", "characters");

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

                entity.ToTable("updates_include", "characters");

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

            modelBuilder.Entity<WardenAction>(entity =>
            {
                entity.HasKey(e => e.WardenId);

                entity.ToTable("warden_action", "characters");

                entity.Property(e => e.WardenId)
                    .HasColumnName("wardenId")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Worldstates>(entity =>
            {
                entity.HasKey(e => e.Entry);

                entity.ToTable("worldstates", "characters");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });
        }
    }
}
