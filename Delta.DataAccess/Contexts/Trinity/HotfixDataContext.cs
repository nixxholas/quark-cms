using Delta.Trinity.Hotfixes;
using Microsoft.EntityFrameworkCore;
using Creature = Delta.Trinity.World.Creature;
using SpellLearnSpell = Delta.Trinity.World.SpellLearnSpell;
using Updates = Delta.Trinity.World.Updates;
using UpdatesInclude = Delta.Trinity.World.UpdatesInclude;

namespace Delta.DataAccess.Contexts.Trinity
{
    public partial class HotfixDataContext : DbContext
    {
        public HotfixDataContext()
        {
        }

        public HotfixDataContext(DbContextOptions<HotfixDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Achievement> Achievement { get; set; }
        public virtual DbSet<AchievementLocale> AchievementLocale { get; set; }
        public virtual DbSet<AnimKit> AnimKit { get; set; }
        public virtual DbSet<AreaGroupMember> AreaGroupMember { get; set; }
        public virtual DbSet<AreaTable> AreaTable { get; set; }
        public virtual DbSet<AreaTableLocale> AreaTableLocale { get; set; }
        public virtual DbSet<AreaTrigger> AreaTrigger { get; set; }
        public virtual DbSet<ArmorLocation> ArmorLocation { get; set; }
        public virtual DbSet<Artifact> Artifact { get; set; }
        public virtual DbSet<ArtifactAppearance> ArtifactAppearance { get; set; }
        public virtual DbSet<ArtifactAppearanceLocale> ArtifactAppearanceLocale { get; set; }
        public virtual DbSet<ArtifactAppearanceSet> ArtifactAppearanceSet { get; set; }
        public virtual DbSet<ArtifactAppearanceSetLocale> ArtifactAppearanceSetLocale { get; set; }
        public virtual DbSet<ArtifactCategory> ArtifactCategory { get; set; }
        public virtual DbSet<ArtifactLocale> ArtifactLocale { get; set; }
        public virtual DbSet<ArtifactPower> ArtifactPower { get; set; }
        public virtual DbSet<ArtifactPowerLink> ArtifactPowerLink { get; set; }
        public virtual DbSet<ArtifactPowerPicker> ArtifactPowerPicker { get; set; }
        public virtual DbSet<ArtifactPowerRank> ArtifactPowerRank { get; set; }
        public virtual DbSet<ArtifactQuestXp> ArtifactQuestXp { get; set; }
        public virtual DbSet<ArtifactTier> ArtifactTier { get; set; }
        public virtual DbSet<ArtifactUnlock> ArtifactUnlock { get; set; }
        public virtual DbSet<AuctionHouse> AuctionHouse { get; set; }
        public virtual DbSet<AuctionHouseLocale> AuctionHouseLocale { get; set; }
        public virtual DbSet<BankBagSlotPrices> BankBagSlotPrices { get; set; }
        public virtual DbSet<BannedAddons> BannedAddons { get; set; }
        public virtual DbSet<BarberShopStyle> BarberShopStyle { get; set; }
        public virtual DbSet<BarberShopStyleLocale> BarberShopStyleLocale { get; set; }
        public virtual DbSet<BattlemasterList> BattlemasterList { get; set; }
        public virtual DbSet<BattlemasterListLocale> BattlemasterListLocale { get; set; }
        public virtual DbSet<BattlePetBreedQuality> BattlePetBreedQuality { get; set; }
        public virtual DbSet<BattlePetBreedState> BattlePetBreedState { get; set; }
        public virtual DbSet<BattlePetSpecies> BattlePetSpecies { get; set; }
        public virtual DbSet<BattlePetSpeciesLocale> BattlePetSpeciesLocale { get; set; }
        public virtual DbSet<BattlePetSpeciesState> BattlePetSpeciesState { get; set; }
        public virtual DbSet<BroadcastText> BroadcastText { get; set; }
        public virtual DbSet<BroadcastTextLocale> BroadcastTextLocale { get; set; }
        public virtual DbSet<CfgRegions> CfgRegions { get; set; }
        public virtual DbSet<CharacterFacialHairStyles> CharacterFacialHairStyles { get; set; }
        public virtual DbSet<CharBaseSection> CharBaseSection { get; set; }
        public virtual DbSet<CharSections> CharSections { get; set; }
        public virtual DbSet<CharStartOutfit> CharStartOutfit { get; set; }
        public virtual DbSet<CharTitles> CharTitles { get; set; }
        public virtual DbSet<CharTitlesLocale> CharTitlesLocale { get; set; }
        public virtual DbSet<ChatChannels> ChatChannels { get; set; }
        public virtual DbSet<ChatChannelsLocale> ChatChannelsLocale { get; set; }
        public virtual DbSet<ChrClasses> ChrClasses { get; set; }
        public virtual DbSet<ChrClassesLocale> ChrClassesLocale { get; set; }
        public virtual DbSet<ChrClassesXPowerTypes> ChrClassesXPowerTypes { get; set; }
        public virtual DbSet<ChrRaces> ChrRaces { get; set; }
        public virtual DbSet<ChrRacesLocale> ChrRacesLocale { get; set; }
        public virtual DbSet<ChrSpecialization> ChrSpecialization { get; set; }
        public virtual DbSet<ChrSpecializationLocale> ChrSpecializationLocale { get; set; }
        public virtual DbSet<CinematicCamera> CinematicCamera { get; set; }
        public virtual DbSet<CinematicSequences> CinematicSequences { get; set; }
        public virtual DbSet<ConversationLine> ConversationLine { get; set; }
        public virtual DbSet<Creature> Creature { get; set; }
        public virtual DbSet<CreatureDifficulty> CreatureDifficulty { get; set; }
        public virtual DbSet<CreatureDisplayInfo> CreatureDisplayInfo { get; set; }
        public virtual DbSet<CreatureDisplayInfoExtra> CreatureDisplayInfoExtra { get; set; }
        public virtual DbSet<CreatureFamily> CreatureFamily { get; set; }
        public virtual DbSet<CreatureFamilyLocale> CreatureFamilyLocale { get; set; }
        public virtual DbSet<CreatureModelData> CreatureModelData { get; set; }
        public virtual DbSet<CreatureType> CreatureType { get; set; }
        public virtual DbSet<CreatureTypeLocale> CreatureTypeLocale { get; set; }
        public virtual DbSet<Criteria> Criteria { get; set; }
        public virtual DbSet<CriteriaTree> CriteriaTree { get; set; }
        public virtual DbSet<CriteriaTreeLocale> CriteriaTreeLocale { get; set; }
        public virtual DbSet<CurrencyTypes> CurrencyTypes { get; set; }
        public virtual DbSet<CurrencyTypesLocale> CurrencyTypesLocale { get; set; }
        public virtual DbSet<Curve> Curve { get; set; }
        public virtual DbSet<CurvePoint> CurvePoint { get; set; }
        public virtual DbSet<DestructibleModelData> DestructibleModelData { get; set; }
        public virtual DbSet<Difficulty> Difficulty { get; set; }
        public virtual DbSet<DifficultyLocale> DifficultyLocale { get; set; }
        public virtual DbSet<DungeonEncounter> DungeonEncounter { get; set; }
        public virtual DbSet<DungeonEncounterLocale> DungeonEncounterLocale { get; set; }
        public virtual DbSet<DurabilityCosts> DurabilityCosts { get; set; }
        public virtual DbSet<DurabilityQuality> DurabilityQuality { get; set; }
        public virtual DbSet<Emotes> Emotes { get; set; }
        public virtual DbSet<EmotesText> EmotesText { get; set; }
        public virtual DbSet<EmotesTextSound> EmotesTextSound { get; set; }
        public virtual DbSet<Faction> Faction { get; set; }
        public virtual DbSet<FactionLocale> FactionLocale { get; set; }
        public virtual DbSet<FactionTemplate> FactionTemplate { get; set; }
        public virtual DbSet<GameobjectDisplayInfo> GameobjectDisplayInfo { get; set; }
        public virtual DbSet<Gameobjects> Gameobjects { get; set; }
        public virtual DbSet<GameobjectsLocale> GameobjectsLocale { get; set; }
        public virtual DbSet<GarrAbility> GarrAbility { get; set; }
        public virtual DbSet<GarrAbilityLocale> GarrAbilityLocale { get; set; }
        public virtual DbSet<GarrBuilding> GarrBuilding { get; set; }
        public virtual DbSet<GarrBuildingLocale> GarrBuildingLocale { get; set; }
        public virtual DbSet<GarrBuildingPlotInst> GarrBuildingPlotInst { get; set; }
        public virtual DbSet<GarrClassSpec> GarrClassSpec { get; set; }
        public virtual DbSet<GarrClassSpecLocale> GarrClassSpecLocale { get; set; }
        public virtual DbSet<GarrFollower> GarrFollower { get; set; }
        public virtual DbSet<GarrFollowerLocale> GarrFollowerLocale { get; set; }
        public virtual DbSet<GarrFollowerXAbility> GarrFollowerXAbility { get; set; }
        public virtual DbSet<GarrPlot> GarrPlot { get; set; }
        public virtual DbSet<GarrPlotBuilding> GarrPlotBuilding { get; set; }
        public virtual DbSet<GarrPlotInstance> GarrPlotInstance { get; set; }
        public virtual DbSet<GarrPlotLocale> GarrPlotLocale { get; set; }
        public virtual DbSet<GarrSiteLevel> GarrSiteLevel { get; set; }
        public virtual DbSet<GarrSiteLevelPlotInst> GarrSiteLevelPlotInst { get; set; }
        public virtual DbSet<GemProperties> GemProperties { get; set; }
        public virtual DbSet<GlyphBindableSpell> GlyphBindableSpell { get; set; }
        public virtual DbSet<GlyphProperties> GlyphProperties { get; set; }
        public virtual DbSet<GlyphRequiredSpec> GlyphRequiredSpec { get; set; }
        public virtual DbSet<GuildColorBackground> GuildColorBackground { get; set; }
        public virtual DbSet<GuildColorBorder> GuildColorBorder { get; set; }
        public virtual DbSet<GuildColorEmblem> GuildColorEmblem { get; set; }
        public virtual DbSet<GuildPerkSpells> GuildPerkSpells { get; set; }
        public virtual DbSet<Heirloom> Heirloom { get; set; }
        public virtual DbSet<HeirloomLocale> HeirloomLocale { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<HotfixData> HotfixData { get; set; }
        public virtual DbSet<ImportPriceArmor> ImportPriceArmor { get; set; }
        public virtual DbSet<ImportPriceQuality> ImportPriceQuality { get; set; }
        public virtual DbSet<ImportPriceShield> ImportPriceShield { get; set; }
        public virtual DbSet<ImportPriceWeapon> ImportPriceWeapon { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemAppearance> ItemAppearance { get; set; }
        public virtual DbSet<ItemArmorQuality> ItemArmorQuality { get; set; }
        public virtual DbSet<ItemArmorShield> ItemArmorShield { get; set; }
        public virtual DbSet<ItemArmorTotal> ItemArmorTotal { get; set; }
        public virtual DbSet<ItemBagFamily> ItemBagFamily { get; set; }
        public virtual DbSet<ItemBagFamilyLocale> ItemBagFamilyLocale { get; set; }
        public virtual DbSet<ItemBonus> ItemBonus { get; set; }
        public virtual DbSet<ItemBonusListLevelDelta> ItemBonusListLevelDelta { get; set; }
        public virtual DbSet<ItemBonusTreeNode> ItemBonusTreeNode { get; set; }
        public virtual DbSet<ItemChildEquipment> ItemChildEquipment { get; set; }
        public virtual DbSet<ItemClass> ItemClass { get; set; }
        public virtual DbSet<ItemClassLocale> ItemClassLocale { get; set; }
        public virtual DbSet<ItemCurrencyCost> ItemCurrencyCost { get; set; }
        public virtual DbSet<ItemDamageAmmo> ItemDamageAmmo { get; set; }
        public virtual DbSet<ItemDamageOneHand> ItemDamageOneHand { get; set; }
        public virtual DbSet<ItemDamageOneHandCaster> ItemDamageOneHandCaster { get; set; }
        public virtual DbSet<ItemDamageTwoHand> ItemDamageTwoHand { get; set; }
        public virtual DbSet<ItemDamageTwoHandCaster> ItemDamageTwoHandCaster { get; set; }
        public virtual DbSet<ItemDisenchantLoot> ItemDisenchantLoot { get; set; }
        public virtual DbSet<ItemEffect> ItemEffect { get; set; }
        public virtual DbSet<ItemExtendedCost> ItemExtendedCost { get; set; }
        public virtual DbSet<ItemLevelSelector> ItemLevelSelector { get; set; }
        public virtual DbSet<ItemLevelSelectorQuality> ItemLevelSelectorQuality { get; set; }
        public virtual DbSet<ItemLevelSelectorQualitySet> ItemLevelSelectorQualitySet { get; set; }
        public virtual DbSet<ItemLimitCategory> ItemLimitCategory { get; set; }
        public virtual DbSet<ItemLimitCategoryCondition> ItemLimitCategoryCondition { get; set; }
        public virtual DbSet<ItemLimitCategoryLocale> ItemLimitCategoryLocale { get; set; }
        public virtual DbSet<ItemModifiedAppearance> ItemModifiedAppearance { get; set; }
        public virtual DbSet<ItemPriceBase> ItemPriceBase { get; set; }
        public virtual DbSet<ItemRandomProperties> ItemRandomProperties { get; set; }
        public virtual DbSet<ItemRandomPropertiesLocale> ItemRandomPropertiesLocale { get; set; }
        public virtual DbSet<ItemRandomSuffix> ItemRandomSuffix { get; set; }
        public virtual DbSet<ItemRandomSuffixLocale> ItemRandomSuffixLocale { get; set; }
        public virtual DbSet<ItemSearchName> ItemSearchName { get; set; }
        public virtual DbSet<ItemSearchNameLocale> ItemSearchNameLocale { get; set; }
        public virtual DbSet<ItemSet> ItemSet { get; set; }
        public virtual DbSet<ItemSetLocale> ItemSetLocale { get; set; }
        public virtual DbSet<ItemSetSpell> ItemSetSpell { get; set; }
        public virtual DbSet<ItemSparse> ItemSparse { get; set; }
        public virtual DbSet<ItemSparseLocale> ItemSparseLocale { get; set; }
        public virtual DbSet<ItemSpec> ItemSpec { get; set; }
        public virtual DbSet<ItemSpecOverride> ItemSpecOverride { get; set; }
        public virtual DbSet<ItemUpgrade> ItemUpgrade { get; set; }
        public virtual DbSet<ItemXBonusTree> ItemXBonusTree { get; set; }
        public virtual DbSet<Keychain> Keychain { get; set; }
        public virtual DbSet<LfgDungeons> LfgDungeons { get; set; }
        public virtual DbSet<LfgDungeonsLocale> LfgDungeonsLocale { get; set; }
        public virtual DbSet<Light> Light { get; set; }
        public virtual DbSet<LiquidType> LiquidType { get; set; }
        public virtual DbSet<Lock> Lock { get; set; }
        public virtual DbSet<MailTemplate> MailTemplate { get; set; }
        public virtual DbSet<MailTemplateLocale> MailTemplateLocale { get; set; }
        public virtual DbSet<Map> Map { get; set; }
        public virtual DbSet<MapDifficulty> MapDifficulty { get; set; }
        public virtual DbSet<MapDifficultyLocale> MapDifficultyLocale { get; set; }
        public virtual DbSet<MapLocale> MapLocale { get; set; }
        public virtual DbSet<ModifierTree> ModifierTree { get; set; }
        public virtual DbSet<Mount> Mount { get; set; }
        public virtual DbSet<MountCapability> MountCapability { get; set; }
        public virtual DbSet<MountLocale> MountLocale { get; set; }
        public virtual DbSet<MountTypeXCapability> MountTypeXCapability { get; set; }
        public virtual DbSet<MountXDisplay> MountXDisplay { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<NameGen> NameGen { get; set; }
        public virtual DbSet<NamesProfanity> NamesProfanity { get; set; }
        public virtual DbSet<NamesReserved> NamesReserved { get; set; }
        public virtual DbSet<NamesReservedLocale> NamesReservedLocale { get; set; }
        public virtual DbSet<OverrideSpellData> OverrideSpellData { get; set; }
        public virtual DbSet<Phase> Phase { get; set; }
        public virtual DbSet<PhaseXPhaseGroup> PhaseXPhaseGroup { get; set; }
        public virtual DbSet<PlayerCondition> PlayerCondition { get; set; }
        public virtual DbSet<PlayerConditionLocale> PlayerConditionLocale { get; set; }
        public virtual DbSet<PowerDisplay> PowerDisplay { get; set; }
        public virtual DbSet<PowerType> PowerType { get; set; }
        public virtual DbSet<PrestigeLevelInfo> PrestigeLevelInfo { get; set; }
        public virtual DbSet<PrestigeLevelInfoLocale> PrestigeLevelInfoLocale { get; set; }
        public virtual DbSet<PvpDifficulty> PvpDifficulty { get; set; }
        public virtual DbSet<PvpItem> PvpItem { get; set; }
        public virtual DbSet<PvpReward> PvpReward { get; set; }
        public virtual DbSet<PvpTalent> PvpTalent { get; set; }
        public virtual DbSet<PvpTalentLocale> PvpTalentLocale { get; set; }
        public virtual DbSet<PvpTalentUnlock> PvpTalentUnlock { get; set; }
        public virtual DbSet<QuestFactionReward> QuestFactionReward { get; set; }
        public virtual DbSet<QuestMoneyReward> QuestMoneyReward { get; set; }
        public virtual DbSet<QuestPackageItem> QuestPackageItem { get; set; }
        public virtual DbSet<QuestSort> QuestSort { get; set; }
        public virtual DbSet<QuestSortLocale> QuestSortLocale { get; set; }
        public virtual DbSet<QuestV2> QuestV2 { get; set; }
        public virtual DbSet<QuestXp> QuestXp { get; set; }
        public virtual DbSet<RandPropPoints> RandPropPoints { get; set; }
        public virtual DbSet<RewardPack> RewardPack { get; set; }
        public virtual DbSet<RewardPackXCurrencyType> RewardPackXCurrencyType { get; set; }
        public virtual DbSet<RewardPackXItem> RewardPackXItem { get; set; }
        public virtual DbSet<RulesetItemUpgrade> RulesetItemUpgrade { get; set; }
        public virtual DbSet<SandboxScaling> SandboxScaling { get; set; }
        public virtual DbSet<ScalingStatDistribution> ScalingStatDistribution { get; set; }
        public virtual DbSet<Scenario> Scenario { get; set; }
        public virtual DbSet<ScenarioLocale> ScenarioLocale { get; set; }
        public virtual DbSet<ScenarioStep> ScenarioStep { get; set; }
        public virtual DbSet<ScenarioStepLocale> ScenarioStepLocale { get; set; }
        public virtual DbSet<SceneScript> SceneScript { get; set; }
        public virtual DbSet<SceneScriptGlobalText> SceneScriptGlobalText { get; set; }
        public virtual DbSet<SceneScriptPackage> SceneScriptPackage { get; set; }
        public virtual DbSet<SceneScriptText> SceneScriptText { get; set; }
        public virtual DbSet<SkillLine> SkillLine { get; set; }
        public virtual DbSet<SkillLineAbility> SkillLineAbility { get; set; }
        public virtual DbSet<SkillLineLocale> SkillLineLocale { get; set; }
        public virtual DbSet<SkillRaceClassInfo> SkillRaceClassInfo { get; set; }
        public virtual DbSet<SoundKit> SoundKit { get; set; }
        public virtual DbSet<SpecializationSpells> SpecializationSpells { get; set; }
        public virtual DbSet<SpecializationSpellsLocale> SpecializationSpellsLocale { get; set; }
        public virtual DbSet<Spell> Spell { get; set; }
        public virtual DbSet<SpellAuraOptions> SpellAuraOptions { get; set; }
        public virtual DbSet<SpellAuraRestrictions> SpellAuraRestrictions { get; set; }
        public virtual DbSet<SpellCastingRequirements> SpellCastingRequirements { get; set; }
        public virtual DbSet<SpellCastTimes> SpellCastTimes { get; set; }
        public virtual DbSet<SpellCategories> SpellCategories { get; set; }
        public virtual DbSet<SpellCategory> SpellCategory { get; set; }
        public virtual DbSet<SpellCategoryLocale> SpellCategoryLocale { get; set; }
        public virtual DbSet<SpellClassOptions> SpellClassOptions { get; set; }
        public virtual DbSet<SpellCooldowns> SpellCooldowns { get; set; }
        public virtual DbSet<SpellDuration> SpellDuration { get; set; }
        public virtual DbSet<SpellEffect> SpellEffect { get; set; }
        public virtual DbSet<SpellEquippedItems> SpellEquippedItems { get; set; }
        public virtual DbSet<SpellFocusObject> SpellFocusObject { get; set; }
        public virtual DbSet<SpellFocusObjectLocale> SpellFocusObjectLocale { get; set; }
        public virtual DbSet<SpellInterrupts> SpellInterrupts { get; set; }
        public virtual DbSet<SpellItemEnchantment> SpellItemEnchantment { get; set; }
        public virtual DbSet<SpellItemEnchantmentCondition> SpellItemEnchantmentCondition { get; set; }
        public virtual DbSet<SpellItemEnchantmentLocale> SpellItemEnchantmentLocale { get; set; }
        public virtual DbSet<SpellLearnSpell> SpellLearnSpell { get; set; }
        public virtual DbSet<SpellLevels> SpellLevels { get; set; }
        public virtual DbSet<SpellLocale> SpellLocale { get; set; }
        public virtual DbSet<SpellMisc> SpellMisc { get; set; }
        public virtual DbSet<SpellPower> SpellPower { get; set; }
        public virtual DbSet<SpellPowerDifficulty> SpellPowerDifficulty { get; set; }
        public virtual DbSet<SpellProcsPerMinute> SpellProcsPerMinute { get; set; }
        public virtual DbSet<SpellProcsPerMinuteMod> SpellProcsPerMinuteMod { get; set; }
        public virtual DbSet<SpellRadius> SpellRadius { get; set; }
        public virtual DbSet<SpellRange> SpellRange { get; set; }
        public virtual DbSet<SpellRangeLocale> SpellRangeLocale { get; set; }
        public virtual DbSet<SpellReagents> SpellReagents { get; set; }
        public virtual DbSet<SpellScaling> SpellScaling { get; set; }
        public virtual DbSet<SpellShapeshift> SpellShapeshift { get; set; }
        public virtual DbSet<SpellShapeshiftForm> SpellShapeshiftForm { get; set; }
        public virtual DbSet<SpellShapeshiftFormLocale> SpellShapeshiftFormLocale { get; set; }
        public virtual DbSet<SpellTargetRestrictions> SpellTargetRestrictions { get; set; }
        public virtual DbSet<SpellTotems> SpellTotems { get; set; }
        public virtual DbSet<SpellXSpellVisual> SpellXSpellVisual { get; set; }
        public virtual DbSet<SummonProperties> SummonProperties { get; set; }
        public virtual DbSet<TactKey> TactKey { get; set; }
        public virtual DbSet<Talent> Talent { get; set; }
        public virtual DbSet<TalentLocale> TalentLocale { get; set; }
        public virtual DbSet<TaxiNodes> TaxiNodes { get; set; }
        public virtual DbSet<TaxiNodesLocale> TaxiNodesLocale { get; set; }
        public virtual DbSet<TaxiPath> TaxiPath { get; set; }
        public virtual DbSet<TaxiPathNode> TaxiPathNode { get; set; }
        public virtual DbSet<TotemCategory> TotemCategory { get; set; }
        public virtual DbSet<TotemCategoryLocale> TotemCategoryLocale { get; set; }
        public virtual DbSet<Toy> Toy { get; set; }
        public virtual DbSet<ToyLocale> ToyLocale { get; set; }
        public virtual DbSet<TransmogHoliday> TransmogHoliday { get; set; }
        public virtual DbSet<TransmogSet> TransmogSet { get; set; }
        public virtual DbSet<TransmogSetGroup> TransmogSetGroup { get; set; }
        public virtual DbSet<TransmogSetGroupLocale> TransmogSetGroupLocale { get; set; }
        public virtual DbSet<TransmogSetItem> TransmogSetItem { get; set; }
        public virtual DbSet<TransmogSetLocale> TransmogSetLocale { get; set; }
        public virtual DbSet<TransportAnimation> TransportAnimation { get; set; }
        public virtual DbSet<TransportRotation> TransportRotation { get; set; }
        public virtual DbSet<UnitPowerBar> UnitPowerBar { get; set; }
        public virtual DbSet<UnitPowerBarLocale> UnitPowerBarLocale { get; set; }
        public virtual DbSet<Updates> Updates { get; set; }
        public virtual DbSet<UpdatesInclude> UpdatesInclude { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleSeat> VehicleSeat { get; set; }
        public virtual DbSet<WmoAreaTable> WmoAreaTable { get; set; }
        public virtual DbSet<WmoAreaTableLocale> WmoAreaTableLocale { get; set; }
        public virtual DbSet<WorldEffect> WorldEffect { get; set; }
        public virtual DbSet<WorldMapArea> WorldMapArea { get; set; }
        public virtual DbSet<WorldMapOverlay> WorldMapOverlay { get; set; }
        public virtual DbSet<WorldMapTransforms> WorldMapTransforms { get; set; }
        public virtual DbSet<WorldSafeLocs> WorldSafeLocs { get; set; }
        public virtual DbSet<WorldSafeLocsLocale> WorldSafeLocsLocale { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-preview3-35497");

            modelBuilder.Entity<Achievement>(entity =>
            {
                entity.ToTable("achievement", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Category)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CriteriaTree)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Faction)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconFileId)
                    .HasColumnName("IconFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("InstanceID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinimumCriteria)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Points)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reward).IsUnicode(false);

                entity.Property(e => e.SharesCriteria)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Supercedes)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.UiOrder)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AchievementLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("achievement_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.RewardLang)
                    .HasColumnName("Reward_lang")
                    .IsUnicode(false);

                entity.Property(e => e.TitleLang)
                    .HasColumnName("Title_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AnimKit>(entity =>
            {
                entity.ToTable("anim_kit", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LowDefAnimKitId)
                    .HasColumnName("LowDefAnimKitID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OneShotDuration)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OneShotStopAnimKitId)
                    .HasColumnName("OneShotStopAnimKitID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AreaGroupMember>(entity =>
            {
                entity.ToTable("area_group_member", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaGroupId)
                    .HasColumnName("AreaGroupID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AreaID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AreaTable>(entity =>
            {
                entity.ToTable("area_table", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AmbienceId)
                    .HasColumnName("AmbienceID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AmbientMultiplier).HasDefaultValueSql("0");

                entity.Property(e => e.AreaBit)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaName).IsUnicode(false);

                entity.Property(e => e.ContinentId)
                    .HasColumnName("ContinentID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExplorationLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FactionGroupMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IntroSound)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LiquidTypeId1)
                    .HasColumnName("LiquidTypeID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LiquidTypeId2)
                    .HasColumnName("LiquidTypeID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LiquidTypeId3)
                    .HasColumnName("LiquidTypeID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LiquidTypeId4)
                    .HasColumnName("LiquidTypeID4")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MountFlags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentAreaId)
                    .HasColumnName("ParentAreaID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PvpCombatWorldStateId)
                    .HasColumnName("PvpCombatWorldStateID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundProviderPref)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundProviderPrefUnderwater)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UwAmbience)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UwIntroSound)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UwZoneMusic)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WildBattlePetLevelMax)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WildBattlePetLevelMin)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WindSettingsId)
                    .HasColumnName("WindSettingsID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZoneMusic)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZoneName).IsUnicode(false);
            });

            modelBuilder.Entity<AreaTableLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("area_table_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaNameLang)
                    .HasColumnName("AreaName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AreaTrigger>(entity =>
            {
                entity.ToTable("area_trigger", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaTriggerActionSetId)
                    .HasColumnName("AreaTriggerActionSetID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BoxHeight).HasDefaultValueSql("0");

                entity.Property(e => e.BoxLength).HasDefaultValueSql("0");

                entity.Property(e => e.BoxWidth).HasDefaultValueSql("0");

                entity.Property(e => e.BoxYaw).HasDefaultValueSql("0");

                entity.Property(e => e.ContinentId)
                    .HasColumnName("ContinentID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseGroupId)
                    .HasColumnName("PhaseGroupID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseId)
                    .HasColumnName("PhaseID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseUseFlags)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX).HasDefaultValueSql("0");

                entity.Property(e => e.PosY).HasDefaultValueSql("0");

                entity.Property(e => e.PosZ).HasDefaultValueSql("0");

                entity.Property(e => e.Radius).HasDefaultValueSql("0");

                entity.Property(e => e.ShapeId)
                    .HasColumnName("ShapeID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShapeType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArmorLocation>(entity =>
            {
                entity.ToTable("armor_location", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Chainmodifier).HasDefaultValueSql("0");

                entity.Property(e => e.Clothmodifier).HasDefaultValueSql("0");

                entity.Property(e => e.Leathermodifier).HasDefaultValueSql("0");

                entity.Property(e => e.Modifier).HasDefaultValueSql("0");

                entity.Property(e => e.Platemodifier).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Artifact>(entity =>
            {
                entity.ToTable("artifact", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactCategoryId)
                    .HasColumnName("ArtifactCategoryID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChrSpecializationId)
                    .HasColumnName("ChrSpecializationID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.SpellVisualKitId)
                    .HasColumnName("SpellVisualKitID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiBarBackgroundColor)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiBarOverlayColor)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiModelSceneId)
                    .HasColumnName("UiModelSceneID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiNameColor)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiTextureKitId)
                    .HasColumnName("UiTextureKitID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactAppearance>(entity =>
            {
                entity.ToTable("artifact_appearance", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactAppearanceSetId)
                    .HasColumnName("ArtifactAppearanceSetID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemAppearanceModifierId)
                    .HasColumnName("ItemAppearanceModifierID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OverrideShapeshiftDisplayId)
                    .HasColumnName("OverrideShapeshiftDisplayID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverrideShapeshiftFormId)
                    .HasColumnName("OverrideShapeshiftFormID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiAltItemAppearanceId)
                    .HasColumnName("UiAltItemAppearanceID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiCameraId)
                    .HasColumnName("UiCameraID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiItemAppearanceId)
                    .HasColumnName("UiItemAppearanceID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiModelOpacity).HasDefaultValueSql("0");

                entity.Property(e => e.UiModelSaturation).HasDefaultValueSql("0");

                entity.Property(e => e.UiSwatchColor)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnlockPlayerConditionId)
                    .HasColumnName("UnlockPlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactAppearanceLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("artifact_appearance_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactAppearanceSet>(entity =>
            {
                entity.ToTable("artifact_appearance_set", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AltHandUicameraId)
                    .HasColumnName("AltHandUICameraID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactId)
                    .HasColumnName("ArtifactID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DisplayIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ForgeAttachmentOverride)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.UiCameraId)
                    .HasColumnName("UiCameraID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactAppearanceSetLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("artifact_appearance_set_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactCategory>(entity =>
            {
                entity.ToTable("artifact_category", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XpMultCurrencyId)
                    .HasColumnName("XpMultCurrencyID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XpMultCurveId)
                    .HasColumnName("XpMultCurveID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("artifact_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactPower>(entity =>
            {
                entity.ToTable("artifact_power", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactId)
                    .HasColumnName("ArtifactID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Label)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPurchasableRank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX).HasDefaultValueSql("0");

                entity.Property(e => e.PosY).HasDefaultValueSql("0");

                entity.Property(e => e.Tier)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactPowerLink>(entity =>
            {
                entity.ToTable("artifact_power_link", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerA)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerB)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactPowerPicker>(entity =>
            {
                entity.ToTable("artifact_power_picker", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactPowerRank>(entity =>
            {
                entity.ToTable("artifact_power_rank", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactPowerId)
                    .HasColumnName("ArtifactPowerID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraPointsOverride).HasDefaultValueSql("0");

                entity.Property(e => e.ItemBonusListId)
                    .HasColumnName("ItemBonusListID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RankIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactQuestXp>(entity =>
            {
                entity.ToTable("artifact_quest_xp", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty10)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty6)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty7)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty8)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty9)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactTier>(entity =>
            {
                entity.ToTable("artifact_tier", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactTier1)
                    .HasColumnName("ArtifactTier")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KnowledgePlayerCondition)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxArtifactKnowledge)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxNumTraits)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinimumEmpowerKnowledge)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ArtifactUnlock>(entity =>
            {
                entity.ToTable("artifact_unlock", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactId)
                    .HasColumnName("ArtifactID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemBonusListId)
                    .HasColumnName("ItemBonusListID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerId)
                    .HasColumnName("PowerID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerRank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AuctionHouse>(entity =>
            {
                entity.ToTable("auction_house", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ConsignmentRate)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DepositRate)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FactionId)
                    .HasColumnName("FactionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AuctionHouseLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("auction_house_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BankBagSlotPrices>(entity =>
            {
                entity.ToTable("bank_bag_slot_prices", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cost)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BannedAddons>(entity =>
            {
                entity.ToTable("banned_addons", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version).IsUnicode(false);
            });

            modelBuilder.Entity<BarberShopStyle>(entity =>
            {
                entity.ToTable("barber_shop_style", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CostModifier).HasDefaultValueSql("0");

                entity.Property(e => e.Data)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DisplayName).IsUnicode(false);

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BarberShopStyleLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("barber_shop_style_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.DisplayNameLang)
                    .HasColumnName("DisplayName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlemasterList>(entity =>
            {
                entity.ToTable("battlemaster_list", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GameType).IsUnicode(false);

                entity.Property(e => e.GroupsAllowed)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HolidayWorldState)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconFileDataId)
                    .HasColumnName("IconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LongDescription).IsUnicode(false);

                entity.Property(e => e.MapId1)
                    .HasColumnName("MapID1")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId10)
                    .HasColumnName("MapID10")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId11)
                    .HasColumnName("MapID11")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId12)
                    .HasColumnName("MapID12")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId13)
                    .HasColumnName("MapID13")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId14)
                    .HasColumnName("MapID14")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId15)
                    .HasColumnName("MapID15")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId16)
                    .HasColumnName("MapID16")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId2)
                    .HasColumnName("MapID2")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId3)
                    .HasColumnName("MapID3")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId4)
                    .HasColumnName("MapID4")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId5)
                    .HasColumnName("MapID5")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId6)
                    .HasColumnName("MapID6")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId7)
                    .HasColumnName("MapID7")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId8)
                    .HasColumnName("MapID8")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId9)
                    .HasColumnName("MapID9")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxGroupSize)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPlayers)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinPlayers)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RatedPlayers)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredPlayerConditionId)
                    .HasColumnName("RequiredPlayerConditionID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShortDescription).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlemasterListLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("battlemaster_list_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GameTypeLang)
                    .HasColumnName("GameType_lang")
                    .IsUnicode(false);

                entity.Property(e => e.LongDescriptionLang)
                    .HasColumnName("LongDescription_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescriptionLang)
                    .HasColumnName("ShortDescription_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlePetBreedQuality>(entity =>
            {
                entity.ToTable("battle_pet_breed_quality", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QualityEnum)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StateMultiplier).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlePetBreedState>(entity =>
            {
                entity.ToTable("battle_pet_breed_state", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BattlePetBreedId)
                    .HasColumnName("BattlePetBreedID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BattlePetStateId)
                    .HasColumnName("BattlePetStateID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlePetSpecies>(entity =>
            {
                entity.ToTable("battle_pet_species", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CardUimodelSceneId)
                    .HasColumnName("CardUIModelSceneID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureId)
                    .HasColumnName("CreatureID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconFileDataId)
                    .HasColumnName("IconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LoadoutUimodelSceneId)
                    .HasColumnName("LoadoutUIModelSceneID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetTypeEnum)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SourceText).IsUnicode(false);

                entity.Property(e => e.SourceTypeEnum)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SummonSpellId)
                    .HasColumnName("SummonSpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlePetSpeciesLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("battle_pet_species_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.SourceTextLang)
                    .HasColumnName("SourceText_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BattlePetSpeciesState>(entity =>
            {
                entity.ToTable("battle_pet_species_state", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BattlePetSpeciesId)
                    .HasColumnName("BattlePetSpeciesID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BattlePetStateId)
                    .HasColumnName("BattlePetStateID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BroadcastText>(entity =>
            {
                entity.ToTable("broadcast_text", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("ConditionID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteDelay1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteDelay2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteDelay3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteId1)
                    .HasColumnName("EmoteID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteId2)
                    .HasColumnName("EmoteID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteId3)
                    .HasColumnName("EmoteID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmotesId)
                    .HasColumnName("EmotesID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundEntriesId1)
                    .HasColumnName("SoundEntriesID1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundEntriesId2)
                    .HasColumnName("SoundEntriesID2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Text).IsUnicode(false);

                entity.Property(e => e.Text1).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BroadcastTextLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("broadcast_text_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Text1Lang)
                    .HasColumnName("Text1_lang")
                    .IsUnicode(false);

                entity.Property(e => e.TextLang)
                    .HasColumnName("Text_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CfgRegions>(entity =>
            {
                entity.ToTable("cfg_regions", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChallengeOrigin)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Raidorigin)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegionGroupMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tag).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharacterFacialHairStyles>(entity =>
            {
                entity.ToTable("character_facial_hair_styles", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Geoset1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Geoset2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Geoset3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Geoset4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Geoset5)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaceId)
                    .HasColumnName("RaceID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SexId)
                    .HasColumnName("SexID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VariationId)
                    .HasColumnName("VariationID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharBaseSection>(entity =>
            {
                entity.ToTable("char_base_section", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LayoutResType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResolutionVariationEnum)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VariationEnum)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharSections>(entity =>
            {
                entity.ToTable("char_sections", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BaseSection)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ColorIndex)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaterialResourcesId1)
                    .HasColumnName("MaterialResourcesID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaterialResourcesId2)
                    .HasColumnName("MaterialResourcesID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaterialResourcesId3)
                    .HasColumnName("MaterialResourcesID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaceId)
                    .HasColumnName("RaceID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SexId)
                    .HasColumnName("SexID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VariationIndex)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharStartOutfit>(entity =>
            {
                entity.ToTable("char_start_outfit", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId1)
                    .HasColumnName("ItemID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId10)
                    .HasColumnName("ItemID10")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId11)
                    .HasColumnName("ItemID11")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId12)
                    .HasColumnName("ItemID12")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId13)
                    .HasColumnName("ItemID13")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId14)
                    .HasColumnName("ItemID14")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId15)
                    .HasColumnName("ItemID15")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId16)
                    .HasColumnName("ItemID16")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId17)
                    .HasColumnName("ItemID17")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId18)
                    .HasColumnName("ItemID18")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId19)
                    .HasColumnName("ItemID19")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId2)
                    .HasColumnName("ItemID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId20)
                    .HasColumnName("ItemID20")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId21)
                    .HasColumnName("ItemID21")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId22)
                    .HasColumnName("ItemID22")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId23)
                    .HasColumnName("ItemID23")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId24)
                    .HasColumnName("ItemID24")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId3)
                    .HasColumnName("ItemID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId4)
                    .HasColumnName("ItemID4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId5)
                    .HasColumnName("ItemID5")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId6)
                    .HasColumnName("ItemID6")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId7)
                    .HasColumnName("ItemID7")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId8)
                    .HasColumnName("ItemID8")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId9)
                    .HasColumnName("ItemID9")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OutfitId)
                    .HasColumnName("OutfitID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetDisplayId)
                    .HasColumnName("PetDisplayID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetFamilyId)
                    .HasColumnName("PetFamilyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaceId)
                    .HasColumnName("RaceID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SexId)
                    .HasColumnName("SexID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharTitles>(entity =>
            {
                entity.ToTable("char_titles", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaskId)
                    .HasColumnName("MaskID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Name1).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharTitlesLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("char_titles_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name1Lang)
                    .HasColumnName("Name1_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChatChannels>(entity =>
            {
                entity.ToTable("chat_channels", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FactionGroup)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Shortcut).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChatChannelsLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("chat_channels_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutLang)
                    .HasColumnName("Shortcut_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChrClasses>(entity =>
            {
                entity.ToTable("chr_classes", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttackPowerPerAgility)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttackPowerPerStrength)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CinematicSequenceId)
                    .HasColumnName("CinematicSequenceID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateScreenFileDataId)
                    .HasColumnName("CreateScreenFileDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultSpec)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayPower)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Filename).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconFileDataId)
                    .HasColumnName("IconFileDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LowResScreenFileDataId)
                    .HasColumnName("LowResScreenFileDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.NameFemale).IsUnicode(false);

                entity.Property(e => e.NameMale).IsUnicode(false);

                entity.Property(e => e.PetNameToken).IsUnicode(false);

                entity.Property(e => e.PrimaryStatPriority)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangedAttackPowerPerAgility)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SelectScreenFileDataId)
                    .HasColumnName("SelectScreenFileDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellClassSet)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartingLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChrClassesLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("chr_classes_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameFemaleLang)
                    .HasColumnName("NameFemale_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameMaleLang)
                    .HasColumnName("NameMale_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChrClassesXPowerTypes>(entity =>
            {
                entity.ToTable("chr_classes_x_power_types", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChrRaces>(entity =>
            {
                entity.ToTable("chr_races", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Alliance)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AlteredFormFinishVisualKitId1)
                    .HasColumnName("AlteredFormFinishVisualKitID1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AlteredFormFinishVisualKitId2)
                    .HasColumnName("AlteredFormFinishVisualKitID2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AlteredFormFinishVisualKitId3)
                    .HasColumnName("AlteredFormFinishVisualKitID3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AlteredFormStartVisualKitId1)
                    .HasColumnName("AlteredFormStartVisualKitID1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AlteredFormStartVisualKitId2)
                    .HasColumnName("AlteredFormStartVisualKitID2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AlteredFormStartVisualKitId3)
                    .HasColumnName("AlteredFormStartVisualKitID3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BaseLanguage)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CharComponentTexLayoutHiResId)
                    .HasColumnName("CharComponentTexLayoutHiResID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CharComponentTextureLayoutId)
                    .HasColumnName("CharComponentTextureLayoutID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CinematicSequenceId)
                    .HasColumnName("CinematicSequenceID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClientFileString).IsUnicode(false);

                entity.Property(e => e.ClientPrefix).IsUnicode(false);

                entity.Property(e => e.CreateScreenFileDataId)
                    .HasColumnName("CreateScreenFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultClassId)
                    .HasColumnName("DefaultClassID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayRaceId)
                    .HasColumnName("DisplayRaceID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FactionId)
                    .HasColumnName("FactionID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FemaleCustomizeOffset1).HasDefaultValueSql("0");

                entity.Property(e => e.FemaleCustomizeOffset2).HasDefaultValueSql("0");

                entity.Property(e => e.FemaleCustomizeOffset3).HasDefaultValueSql("0");

                entity.Property(e => e.FemaleDisplayId)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FemaleSkeletonFileDataId)
                    .HasColumnName("FemaleSkeletonFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HeritageArmorAchievementId)
                    .HasColumnName("HeritageArmorAchievementID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HighResFemaleDisplayId)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HighResMaleDisplayId)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LowResScreenFileDataId)
                    .HasColumnName("LowResScreenFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaleCustomizeOffset1).HasDefaultValueSql("0");

                entity.Property(e => e.MaleCustomizeOffset2).HasDefaultValueSql("0");

                entity.Property(e => e.MaleCustomizeOffset3).HasDefaultValueSql("0");

                entity.Property(e => e.MaleDisplayId)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaleSkeletonFileDataId)
                    .HasColumnName("MaleSkeletonFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.NameFemale).IsUnicode(false);

                entity.Property(e => e.NameFemaleLowercase).IsUnicode(false);

                entity.Property(e => e.NameLowercase).IsUnicode(false);

                entity.Property(e => e.NeutralRaceId)
                    .HasColumnName("NeutralRaceID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaceRelated)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResSicknessSpellId)
                    .HasColumnName("ResSicknessSpellID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SelectScreenFileDataId)
                    .HasColumnName("SelectScreenFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SplashSoundId)
                    .HasColumnName("SplashSoundID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartingLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiDisplayOrder)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnalteredVisualRaceId)
                    .HasColumnName("UnalteredVisualRaceID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChrRacesLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("chr_races_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameFemaleLang)
                    .HasColumnName("NameFemale_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameFemaleLowercaseLang)
                    .HasColumnName("NameFemaleLowercase_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLowercaseLang)
                    .HasColumnName("NameLowercase_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChrSpecialization>(entity =>
            {
                entity.ToTable("chr_specialization", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnimReplacements)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FemaleName).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MasterySpellId1)
                    .HasColumnName("MasterySpellID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MasterySpellId2)
                    .HasColumnName("MasterySpellID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetTalentType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrimaryStatPriority)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Role)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellIconFileId)
                    .HasColumnName("SpellIconFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChrSpecializationLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("chr_specialization_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.FemaleNameLang)
                    .HasColumnName("FemaleName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CinematicCamera>(entity =>
            {
                entity.ToTable("cinematic_camera", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileDataId)
                    .HasColumnName("FileDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OriginFacing).HasDefaultValueSql("0");

                entity.Property(e => e.OriginX).HasDefaultValueSql("0");

                entity.Property(e => e.OriginY).HasDefaultValueSql("0");

                entity.Property(e => e.OriginZ).HasDefaultValueSql("0");

                entity.Property(e => e.SoundId)
                    .HasColumnName("SoundID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CinematicSequences>(entity =>
            {
                entity.ToTable("cinematic_sequences", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Camera1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Camera2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Camera3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Camera4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Camera5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Camera6)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Camera7)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Camera8)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundId)
                    .HasColumnName("SoundID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ConversationLine>(entity =>
            {
                entity.ToTable("conversation_line", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AdditionalDuration)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnimKitId)
                    .HasColumnName("AnimKitID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BroadcastTextId)
                    .HasColumnName("BroadcastTextID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EndAnimation)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NextConversationLineId)
                    .HasColumnName("NextConversationLineID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpeechType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellVisualKitId)
                    .HasColumnName("SpellVisualKitID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartAnimation)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Creature>(entity =>
            {
                entity.ToTable("creature", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Classification)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayId1)
                    .HasColumnName("DisplayID1")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayId2)
                    .HasColumnName("DisplayID2")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayId3)
                    .HasColumnName("DisplayID3")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayId4)
                    .HasColumnName("DisplayID4")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayIdprobability1)
                    .HasColumnName("DisplayIDProbability1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayIdprobability2)
                    .HasColumnName("DisplayIDProbability2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayIdprobability3)
                    .HasColumnName("DisplayIDProbability3")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayIdprobability4)
                    .HasColumnName("DisplayIDProbability4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Family)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FemaleName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FemaleSubName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.InhabitType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId1)
                    .HasColumnName("ItemID1")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId2)
                    .HasColumnName("ItemID2")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId3)
                    .HasColumnName("ItemID3")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mount)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SubName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnType("mediumint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CreatureDifficulty>(entity =>
            {
                entity.ToTable("creature_difficulty", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureId)
                    .HasColumnName("CreatureID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Expansion)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FactionTemplateId)
                    .HasColumnName("FactionTemplateID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags6)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags7)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CreatureDisplayInfo>(entity =>
            {
                entity.ToTable("creature_display_info", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnimReplacementSetId)
                    .HasColumnName("AnimReplacementSetID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BloodId)
                    .HasColumnName("BloodID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureGeosetData)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureModelAlpha)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureModelScale).HasDefaultValueSql("0");

                entity.Property(e => e.ExtendedDisplayInfoId)
                    .HasColumnName("ExtendedDisplayInfoID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gender)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MountPoofSpellVisualKitId)
                    .HasColumnName("MountPoofSpellVisualKitID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NpcsoundId)
                    .HasColumnName("NPCSoundID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ObjectEffectPackageId)
                    .HasColumnName("ObjectEffectPackageID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParticleColorId)
                    .HasColumnName("ParticleColorID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetInstanceScale).HasDefaultValueSql("0");

                entity.Property(e => e.PlayerOverrideScale).HasDefaultValueSql("0");

                entity.Property(e => e.PortraitCreatureDisplayInfoId)
                    .HasColumnName("PortraitCreatureDisplayInfoID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PortraitTextureFileDataId)
                    .HasColumnName("PortraitTextureFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SizeClass)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundId)
                    .HasColumnName("SoundID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StateSpellVisualKitId)
                    .HasColumnName("StateSpellVisualKitID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextureVariationFileDataId1)
                    .HasColumnName("TextureVariationFileDataID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextureVariationFileDataId2)
                    .HasColumnName("TextureVariationFileDataID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextureVariationFileDataId3)
                    .HasColumnName("TextureVariationFileDataID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnarmedWeaponType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CreatureDisplayInfoExtra>(entity =>
            {
                entity.ToTable("creature_display_info_extra", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BakeMaterialResourcesId)
                    .HasColumnName("BakeMaterialResourcesID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomDisplayOption1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomDisplayOption2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomDisplayOption3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayClassId)
                    .HasColumnName("DisplayClassID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayRaceId)
                    .HasColumnName("DisplayRaceID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplaySexId)
                    .HasColumnName("DisplaySexID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FaceId)
                    .HasColumnName("FaceID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FacialHairId)
                    .HasColumnName("FacialHairID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HairColorId)
                    .HasColumnName("HairColorID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HairStyleId)
                    .HasColumnName("HairStyleID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdbakeMaterialResourcesId)
                    .HasColumnName("HDBakeMaterialResourcesID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkinId)
                    .HasColumnName("SkinID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CreatureFamily>(entity =>
            {
                entity.ToTable("creature_family", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconFileId)
                    .HasColumnName("IconFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxScale).HasDefaultValueSql("0");

                entity.Property(e => e.MaxScaleLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinScale).HasDefaultValueSql("0");

                entity.Property(e => e.MinScaleLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PetFoodMask)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetTalentType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillLine1)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillLine2)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CreatureFamilyLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("creature_family_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CreatureModelData>(entity =>
            {
                entity.ToTable("creature_model_data", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttachedEffectScale).HasDefaultValueSql("0");

                entity.Property(e => e.BloodId)
                    .HasColumnName("BloodID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CollisionHeight).HasDefaultValueSql("0");

                entity.Property(e => e.CollisionWidth).HasDefaultValueSql("0");

                entity.Property(e => e.CreatureGeosetDataId)
                    .HasColumnName("CreatureGeosetDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeathThudCameraEffectId)
                    .HasColumnName("DeathThudCameraEffectID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileDataId)
                    .HasColumnName("FileDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FoleyMaterialId)
                    .HasColumnName("FoleyMaterialID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FootprintParticleScale).HasDefaultValueSql("0");

                entity.Property(e => e.FootprintTextureId)
                    .HasColumnName("FootprintTextureID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FootprintTextureLength).HasDefaultValueSql("0");

                entity.Property(e => e.FootprintTextureWidth).HasDefaultValueSql("0");

                entity.Property(e => e.FootstepCameraEffectId)
                    .HasColumnName("FootstepCameraEffectID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GeoBox1).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBox2).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBox3).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBox4).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBox5).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBox6).HasDefaultValueSql("0");

                entity.Property(e => e.HoverHeight).HasDefaultValueSql("0");

                entity.Property(e => e.MissileCollisionPush).HasDefaultValueSql("0");

                entity.Property(e => e.MissileCollisionRadius).HasDefaultValueSql("0");

                entity.Property(e => e.MissileCollisionRaise).HasDefaultValueSql("0");

                entity.Property(e => e.ModelScale).HasDefaultValueSql("0");

                entity.Property(e => e.MountHeight).HasDefaultValueSql("0");

                entity.Property(e => e.OverrideLootEffectScale).HasDefaultValueSql("0");

                entity.Property(e => e.OverrideNameScale).HasDefaultValueSql("0");

                entity.Property(e => e.OverrideSelectionRadius).HasDefaultValueSql("0");

                entity.Property(e => e.SizeClass)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundId)
                    .HasColumnName("SoundID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TamedPetBaseScale).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WorldEffectScale).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CreatureType>(entity =>
            {
                entity.ToTable("creature_type", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CreatureTypeLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("creature_type_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Criteria>(entity =>
            {
                entity.ToTable("criteria", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Asset)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EligibilityWorldStateId)
                    .HasColumnName("EligibilityWorldStateID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EligibilityWorldStateValue)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FailAsset)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FailEvent)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifierTreeId)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartAsset)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartEvent)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartTimer)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CriteriaTree>(entity =>
            {
                entity.ToTable("criteria_tree", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CriteriaId)
                    .HasColumnName("CriteriaID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operator)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Parent)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CriteriaTreeLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("criteria_tree_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CurrencyTypes>(entity =>
            {
                entity.ToTable("currency_types", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InventoryIconFileId)
                    .HasColumnName("InventoryIconFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxEarnablePerWeek)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxQty)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Quality)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellCategory)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellWeight)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CurrencyTypesLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("currency_types_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Curve>(entity =>
            {
                entity.ToTable("curve", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CurvePoint>(entity =>
            {
                entity.ToTable("curve_point", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurveId)
                    .HasColumnName("CurveID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX).HasDefaultValueSql("0");

                entity.Property(e => e.PosY).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DestructibleModelData>(entity =>
            {
                entity.ToTable("destructible_model_data", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DoNotHighlight)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EjectDirection)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HealEffect)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HealEffectSpeed)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State0AmbientDoodadSet)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State0ImpactEffectDoodadSet)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State0NameSet)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State0Wmo)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State1AmbientDoodadSet)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State1DestructionDoodadSet)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State1ImpactEffectDoodadSet)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State1NameSet)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State1Wmo)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State2AmbientDoodadSet)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State2DestructionDoodadSet)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State2ImpactEffectDoodadSet)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State2NameSet)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State2Wmo)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State3AmbientDoodadSet)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State3InitDoodadSet)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State3NameSet)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State3Wmo)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Difficulty>(entity =>
            {
                entity.ToTable("difficulty", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FallbackDifficultyId)
                    .HasColumnName("FallbackDifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupSizeDmgCurveId)
                    .HasColumnName("GroupSizeDmgCurveID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupSizeHealthCurveId)
                    .HasColumnName("GroupSizeHealthCurveID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupSizeSpellPointsCurveId)
                    .HasColumnName("GroupSizeSpellPointsCurveID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemContext)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPlayers)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinPlayers)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OldEnumValue)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ToggleDifficultyId)
                    .HasColumnName("ToggleDifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DifficultyLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("difficulty_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DungeonEncounter>(entity =>
            {
                entity.ToTable("dungeon_encounter", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bit)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureDisplayId)
                    .HasColumnName("CreatureDisplayID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellIconFileId)
                    .HasColumnName("SpellIconFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DungeonEncounterLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("dungeon_encounter_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DurabilityCosts>(entity =>
            {
                entity.ToTable("durability_costs", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArmorSubClassCost1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArmorSubClassCost2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArmorSubClassCost3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArmorSubClassCost4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArmorSubClassCost5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArmorSubClassCost6)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArmorSubClassCost7)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArmorSubClassCost8)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost10)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost11)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost12)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost13)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost14)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost15)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost16)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost17)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost18)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost19)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost20)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost21)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost6)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost7)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost8)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubClassCost9)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DurabilityQuality>(entity =>
            {
                entity.ToTable("durability_quality", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Emotes>(entity =>
            {
                entity.ToTable("emotes", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnimId)
                    .HasColumnName("AnimID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassMask)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteSlashCommand).IsUnicode(false);

                entity.Property(e => e.EmoteSpecProc)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteSpecProcParam)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventSoundId)
                    .HasColumnName("EventSoundID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellVisualKitId)
                    .HasColumnName("SpellVisualKitID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EmotesText>(entity =>
            {
                entity.ToTable("emotes_text", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmoteId)
                    .HasColumnName("EmoteID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EmotesTextSound>(entity =>
            {
                entity.ToTable("emotes_text_sound", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmotesTextId)
                    .HasColumnName("EmotesTextID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaceId)
                    .HasColumnName("RaceID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SexId)
                    .HasColumnName("SexID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundId)
                    .HasColumnName("SoundID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Faction>(entity =>
            {
                entity.ToTable("faction", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Expansion)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FriendshipRepId)
                    .HasColumnName("FriendshipRepID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ParagonFactionId)
                    .HasColumnName("ParagonFactionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentFactionCap1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentFactionCap2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentFactionId)
                    .HasColumnName("ParentFactionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentFactionMod1).HasDefaultValueSql("0");

                entity.Property(e => e.ParentFactionMod2).HasDefaultValueSql("0");

                entity.Property(e => e.ReputationBase1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationBase2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationBase3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationBase4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationClassMask1)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationClassMask2)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationClassMask3)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationClassMask4)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationFlags1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationFlags2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationFlags3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationFlags4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationIndex)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationMax1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationMax2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationMax3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationMax4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationRaceMask1)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationRaceMask2)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationRaceMask3)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationRaceMask4)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<FactionLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("faction_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<FactionTemplate>(entity =>
            {
                entity.ToTable("faction_template", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enemies1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enemies2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enemies3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enemies4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnemyGroup)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Faction)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FactionGroup)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Friend1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Friend2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Friend3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Friend4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FriendGroup)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GameobjectDisplayInfo>(entity =>
            {
                entity.ToTable("gameobject_display_info", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileDataId)
                    .HasColumnName("FileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GeoBoxMaxX).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBoxMaxY).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBoxMaxZ).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBoxMinX).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBoxMinY).HasDefaultValueSql("0");

                entity.Property(e => e.GeoBoxMinZ).HasDefaultValueSql("0");

                entity.Property(e => e.ObjectEffectPackageId)
                    .HasColumnName("ObjectEffectPackageID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverrideLootEffectScale).HasDefaultValueSql("0");

                entity.Property(e => e.OverrideNameScale).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Gameobjects>(entity =>
            {
                entity.ToTable("gameobjects", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayId)
                    .HasColumnName("DisplayID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OwnerID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseGroupId)
                    .HasColumnName("PhaseGroupID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseId)
                    .HasColumnName("PhaseID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseUseFlags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX).HasDefaultValueSql("0");

                entity.Property(e => e.PosY).HasDefaultValueSql("0");

                entity.Property(e => e.PosZ).HasDefaultValueSql("0");

                entity.Property(e => e.PropValue1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PropValue2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PropValue3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PropValue4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PropValue5)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PropValue6)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PropValue7)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PropValue8)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rot1).HasDefaultValueSql("0");

                entity.Property(e => e.Rot2).HasDefaultValueSql("0");

                entity.Property(e => e.Rot3).HasDefaultValueSql("0");

                entity.Property(e => e.Rot4).HasDefaultValueSql("0");

                entity.Property(e => e.Scale).HasDefaultValueSql("0");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GameobjectsLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("gameobjects_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrAbility>(entity =>
            {
                entity.ToTable("garr_ability", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FactionChangeGarrAbilityId)
                    .HasColumnName("FactionChangeGarrAbilityID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrAbilityCategoryId)
                    .HasColumnName("GarrAbilityCategoryID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrFollowerTypeId)
                    .HasColumnName("GarrFollowerTypeID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconFileDataId)
                    .HasColumnName("IconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrAbilityLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("garr_ability_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrBuilding>(entity =>
            {
                entity.ToTable("garr_building", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceGameObjectId)
                    .HasColumnName("AllianceGameObjectID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceName).IsUnicode(false);

                entity.Property(e => e.AllianceSceneScriptPackageId)
                    .HasColumnName("AllianceSceneScriptPackageID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceUiTextureKitId)
                    .HasColumnName("AllianceUiTextureKitID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BonusGarrAbilityId)
                    .HasColumnName("BonusGarrAbilityID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BuildSeconds)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BuildingType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyQty)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyTypeId)
                    .HasColumnName("CurrencyTypeID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrAbilityId)
                    .HasColumnName("GarrAbilityID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrSiteId)
                    .HasColumnName("GarrSiteID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrTypeId)
                    .HasColumnName("GarrTypeID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GoldCost)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeGameObjectId)
                    .HasColumnName("HordeGameObjectID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeName).IsUnicode(false);

                entity.Property(e => e.HordeSceneScriptPackageId)
                    .HasColumnName("HordeSceneScriptPackageID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeUiTextureKitId)
                    .HasColumnName("HordeUiTextureKitID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconFileDataId)
                    .HasColumnName("IconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxAssignments)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShipmentCapacity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tooltip).IsUnicode(false);

                entity.Property(e => e.UpgradeLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrBuildingLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("garr_building_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AllianceNameLang)
                    .HasColumnName("AllianceName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.HordeNameLang)
                    .HasColumnName("HordeName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.TooltipLang)
                    .HasColumnName("Tooltip_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrBuildingPlotInst>(entity =>
            {
                entity.ToTable("garr_building_plot_inst", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrBuildingId)
                    .HasColumnName("GarrBuildingID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrSiteLevelPlotInstId)
                    .HasColumnName("GarrSiteLevelPlotInstID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapOffsetX).HasDefaultValueSql("0");

                entity.Property(e => e.MapOffsetY).HasDefaultValueSql("0");

                entity.Property(e => e.UiTextureAtlasMemberId)
                    .HasColumnName("UiTextureAtlasMemberID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrClassSpec>(entity =>
            {
                entity.ToTable("garr_class_spec", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassSpec).IsUnicode(false);

                entity.Property(e => e.ClassSpecFemale).IsUnicode(false);

                entity.Property(e => e.ClassSpecMale).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FollowerClassLimit)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrFollItemSetId)
                    .HasColumnName("GarrFollItemSetID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiTextureAtlasMemberId)
                    .HasColumnName("UiTextureAtlasMemberID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrClassSpecLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("garr_class_spec_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClassSpecFemaleLang)
                    .HasColumnName("ClassSpecFemale_lang")
                    .IsUnicode(false);

                entity.Property(e => e.ClassSpecLang)
                    .HasColumnName("ClassSpec_lang")
                    .IsUnicode(false);

                entity.Property(e => e.ClassSpecMaleLang)
                    .HasColumnName("ClassSpecMale_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrFollower>(entity =>
            {
                entity.ToTable("garr_follower", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceCreatureId)
                    .HasColumnName("AllianceCreatureID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceFlavorGarrStringId)
                    .HasColumnName("AllianceFlavorGarrStringID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceGarrClassSpecId)
                    .HasColumnName("AllianceGarrClassSpecID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceGarrFollItemSetId)
                    .HasColumnName("AllianceGarrFollItemSetID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceGarrFollRaceId)
                    .HasColumnName("AllianceGarrFollRaceID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceIconFileDataId)
                    .HasColumnName("AllianceIconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceSourceText).IsUnicode(false);

                entity.Property(e => e.AllianceSourceTypeEnum)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceUitextureKitId)
                    .HasColumnName("AllianceUITextureKitID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllySlottingBroadcastTextId)
                    .HasColumnName("AllySlottingBroadcastTextID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChrClassId)
                    .HasColumnName("ChrClassID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FollowerLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrFollowerTypeId)
                    .HasColumnName("GarrFollowerTypeID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrTypeId)
                    .HasColumnName("GarrTypeID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gender)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeCreatureId)
                    .HasColumnName("HordeCreatureID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeFlavorGarrStringId)
                    .HasColumnName("HordeFlavorGarrStringID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeGarrClassSpecId)
                    .HasColumnName("HordeGarrClassSpecID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeGarrFollItemSetId)
                    .HasColumnName("HordeGarrFollItemSetID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeGarrFollRaceId)
                    .HasColumnName("HordeGarrFollRaceID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeIconFileDataId)
                    .HasColumnName("HordeIconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeSlottingBroadcastTextId)
                    .HasColumnName("HordeSlottingBroadcastTextID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeSourceText).IsUnicode(false);

                entity.Property(e => e.HordeSourceTypeEnum)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeUitextureKitId)
                    .HasColumnName("HordeUITextureKitID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevelArmor)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevelWeapon)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quality)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TitleName).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Vitality)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrFollowerLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("garr_follower_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AllianceSourceTextLang)
                    .HasColumnName("AllianceSourceText_lang")
                    .IsUnicode(false);

                entity.Property(e => e.HordeSourceTextLang)
                    .HasColumnName("HordeSourceText_lang")
                    .IsUnicode(false);

                entity.Property(e => e.TitleNameLang)
                    .HasColumnName("TitleName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrFollowerXAbility>(entity =>
            {
                entity.ToTable("garr_follower_x_ability", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FactionIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrAbilityId)
                    .HasColumnName("GarrAbilityID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrFollowerId)
                    .HasColumnName("GarrFollowerID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrPlot>(entity =>
            {
                entity.ToTable("garr_plot", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllianceConstructObjId)
                    .HasColumnName("AllianceConstructObjID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HordeConstructObjId)
                    .HasColumnName("HordeConstructObjID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PlotType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiCategoryId)
                    .HasColumnName("UiCategoryID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeRequirement1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeRequirement2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrPlotBuilding>(entity =>
            {
                entity.ToTable("garr_plot_building", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrBuildingId)
                    .HasColumnName("GarrBuildingID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrPlotId)
                    .HasColumnName("GarrPlotID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrPlotInstance>(entity =>
            {
                entity.ToTable("garr_plot_instance", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrPlotId)
                    .HasColumnName("GarrPlotID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrPlotLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("garr_plot_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrSiteLevel>(entity =>
            {
                entity.ToTable("garr_site_level", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrSiteId)
                    .HasColumnName("GarrSiteID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxBuildingLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TownHallUiPosX).HasDefaultValueSql("0");

                entity.Property(e => e.TownHallUiPosY).HasDefaultValueSql("0");

                entity.Property(e => e.UiTextureKitId)
                    .HasColumnName("UiTextureKitID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeCost)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeGoldCost)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeMovieId)
                    .HasColumnName("UpgradeMovieID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GarrSiteLevelPlotInst>(entity =>
            {
                entity.ToTable("garr_site_level_plot_inst", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrPlotInstanceId)
                    .HasColumnName("GarrPlotInstanceID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GarrSiteLevelId)
                    .HasColumnName("GarrSiteLevelID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiMarkerPosX).HasDefaultValueSql("0");

                entity.Property(e => e.UiMarkerPosY).HasDefaultValueSql("0");

                entity.Property(e => e.UiMarkerSize)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GemProperties>(entity =>
            {
                entity.ToTable("gem_properties", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnchantId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GlyphBindableSpell>(entity =>
            {
                entity.ToTable("glyph_bindable_spell", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GlyphPropertiesId)
                    .HasColumnName("GlyphPropertiesID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GlyphProperties>(entity =>
            {
                entity.ToTable("glyph_properties", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GlyphExclusiveCategoryId)
                    .HasColumnName("GlyphExclusiveCategoryID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GlyphType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellIconId)
                    .HasColumnName("SpellIconID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GlyphRequiredSpec>(entity =>
            {
                entity.ToTable("glyph_required_spec", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChrSpecializationId)
                    .HasColumnName("ChrSpecializationID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GlyphPropertiesId)
                    .HasColumnName("GlyphPropertiesID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildColorBackground>(entity =>
            {
                entity.ToTable("guild_color_background", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Blue)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Green)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Red)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildColorBorder>(entity =>
            {
                entity.ToTable("guild_color_border", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Blue)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Green)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Red)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildColorEmblem>(entity =>
            {
                entity.ToTable("guild_color_emblem", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Blue)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Green)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Red)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GuildPerkSpells>(entity =>
            {
                entity.ToTable("guild_perk_spells", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Heirloom>(entity =>
            {
                entity.ToTable("heirloom", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LegacyItemId)
                    .HasColumnName("LegacyItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LegacyUpgradedItemId)
                    .HasColumnName("LegacyUpgradedItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SourceText).IsUnicode(false);

                entity.Property(e => e.SourceTypeEnum)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StaticUpgradedItemId)
                    .HasColumnName("StaticUpgradedItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeItemBonusListId1)
                    .HasColumnName("UpgradeItemBonusListID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeItemBonusListId2)
                    .HasColumnName("UpgradeItemBonusListID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeItemBonusListId3)
                    .HasColumnName("UpgradeItemBonusListID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeItemId1)
                    .HasColumnName("UpgradeItemID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeItemId2)
                    .HasColumnName("UpgradeItemID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpgradeItemId3)
                    .HasColumnName("UpgradeItemID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HeirloomLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("heirloom_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SourceTextLang)
                    .HasColumnName("SourceText_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.ToTable("holidays", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFilterType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags10)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags7)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags8)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalendarFlags9)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date10)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date11)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date12)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date13)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date14)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date15)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date16)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date6)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date7)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date8)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Date9)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration10)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration6)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration7)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration8)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration9)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HolidayDescriptionId)
                    .HasColumnName("HolidayDescriptionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HolidayNameId)
                    .HasColumnName("HolidayNameID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Looping)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Priority)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Region)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextureFileDataId1)
                    .HasColumnName("TextureFileDataID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextureFileDataId2)
                    .HasColumnName("TextureFileDataID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextureFileDataId3)
                    .HasColumnName("TextureFileDataID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HotfixData>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TableHash, e.RecordId });

                entity.ToTable("hotfix_data", "hotfixes");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.TableHash).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RecordId).HasColumnType("int(11)");

                entity.Property(e => e.Deleted)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImportPriceArmor>(entity =>
            {
                entity.ToTable("import_price_armor", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChainModifier).HasDefaultValueSql("0");

                entity.Property(e => e.ClothModifier).HasDefaultValueSql("0");

                entity.Property(e => e.LeatherModifier).HasDefaultValueSql("0");

                entity.Property(e => e.PlateModifier).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImportPriceQuality>(entity =>
            {
                entity.ToTable("import_price_quality", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImportPriceShield>(entity =>
            {
                entity.ToTable("import_price_shield", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImportPriceWeapon>(entity =>
            {
                entity.ToTable("import_price_weapon", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("item", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconFileDataId)
                    .HasColumnName("IconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InventoryType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemGroupSoundsId)
                    .HasColumnName("ItemGroupSoundsID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Material)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SheatheType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundOverrideSubclassId)
                    .HasColumnName("SoundOverrideSubclassID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubclassId)
                    .HasColumnName("SubclassID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemAppearance>(entity =>
            {
                entity.ToTable("item_appearance", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultIconFileDataId)
                    .HasColumnName("DefaultIconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemDisplayInfoId)
                    .HasColumnName("ItemDisplayInfoID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiOrder)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemArmorQuality>(entity =>
            {
                entity.ToTable("item_armor_quality", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Qualitymod1).HasDefaultValueSql("0");

                entity.Property(e => e.Qualitymod2).HasDefaultValueSql("0");

                entity.Property(e => e.Qualitymod3).HasDefaultValueSql("0");

                entity.Property(e => e.Qualitymod4).HasDefaultValueSql("0");

                entity.Property(e => e.Qualitymod5).HasDefaultValueSql("0");

                entity.Property(e => e.Qualitymod6).HasDefaultValueSql("0");

                entity.Property(e => e.Qualitymod7).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemArmorShield>(entity =>
            {
                entity.ToTable("item_armor_shield", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quality1).HasDefaultValueSql("0");

                entity.Property(e => e.Quality2).HasDefaultValueSql("0");

                entity.Property(e => e.Quality3).HasDefaultValueSql("0");

                entity.Property(e => e.Quality4).HasDefaultValueSql("0");

                entity.Property(e => e.Quality5).HasDefaultValueSql("0");

                entity.Property(e => e.Quality6).HasDefaultValueSql("0");

                entity.Property(e => e.Quality7).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemArmorTotal>(entity =>
            {
                entity.ToTable("item_armor_total", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cloth).HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Leather).HasDefaultValueSql("0");

                entity.Property(e => e.Mail).HasDefaultValueSql("0");

                entity.Property(e => e.Plate).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemBagFamily>(entity =>
            {
                entity.ToTable("item_bag_family", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemBagFamilyLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("item_bag_family_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemBonus>(entity =>
            {
                entity.ToTable("item_bonus", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentItemBonusListId)
                    .HasColumnName("ParentItemBonusListID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemBonusListLevelDelta>(entity =>
            {
                entity.ToTable("item_bonus_list_level_delta", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevelDelta)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemBonusTreeNode>(entity =>
            {
                entity.ToTable("item_bonus_tree_node", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChildItemBonusListId)
                    .HasColumnName("ChildItemBonusListID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChildItemBonusTreeId)
                    .HasColumnName("ChildItemBonusTreeID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChildItemLevelSelectorId)
                    .HasColumnName("ChildItemLevelSelectorID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemContext)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentItemBonusTreeId)
                    .HasColumnName("ParentItemBonusTreeID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemChildEquipment>(entity =>
            {
                entity.ToTable("item_child_equipment", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChildItemEquipSlot)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChildItemId)
                    .HasColumnName("ChildItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentItemId)
                    .HasColumnName("ParentItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemClass>(entity =>
            {
                entity.ToTable("item_class", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassName).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PriceModifier).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemClassLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("item_class_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClassNameLang)
                    .HasColumnName("ClassName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemCurrencyCost>(entity =>
            {
                entity.ToTable("item_currency_cost", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemDamageAmmo>(entity =>
            {
                entity.ToTable("item_damage_ammo", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quality1).HasDefaultValueSql("0");

                entity.Property(e => e.Quality2).HasDefaultValueSql("0");

                entity.Property(e => e.Quality3).HasDefaultValueSql("0");

                entity.Property(e => e.Quality4).HasDefaultValueSql("0");

                entity.Property(e => e.Quality5).HasDefaultValueSql("0");

                entity.Property(e => e.Quality6).HasDefaultValueSql("0");

                entity.Property(e => e.Quality7).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemDamageOneHand>(entity =>
            {
                entity.ToTable("item_damage_one_hand", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quality1).HasDefaultValueSql("0");

                entity.Property(e => e.Quality2).HasDefaultValueSql("0");

                entity.Property(e => e.Quality3).HasDefaultValueSql("0");

                entity.Property(e => e.Quality4).HasDefaultValueSql("0");

                entity.Property(e => e.Quality5).HasDefaultValueSql("0");

                entity.Property(e => e.Quality6).HasDefaultValueSql("0");

                entity.Property(e => e.Quality7).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemDamageOneHandCaster>(entity =>
            {
                entity.ToTable("item_damage_one_hand_caster", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quality1).HasDefaultValueSql("0");

                entity.Property(e => e.Quality2).HasDefaultValueSql("0");

                entity.Property(e => e.Quality3).HasDefaultValueSql("0");

                entity.Property(e => e.Quality4).HasDefaultValueSql("0");

                entity.Property(e => e.Quality5).HasDefaultValueSql("0");

                entity.Property(e => e.Quality6).HasDefaultValueSql("0");

                entity.Property(e => e.Quality7).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemDamageTwoHand>(entity =>
            {
                entity.ToTable("item_damage_two_hand", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quality1).HasDefaultValueSql("0");

                entity.Property(e => e.Quality2).HasDefaultValueSql("0");

                entity.Property(e => e.Quality3).HasDefaultValueSql("0");

                entity.Property(e => e.Quality4).HasDefaultValueSql("0");

                entity.Property(e => e.Quality5).HasDefaultValueSql("0");

                entity.Property(e => e.Quality6).HasDefaultValueSql("0");

                entity.Property(e => e.Quality7).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemDamageTwoHandCaster>(entity =>
            {
                entity.ToTable("item_damage_two_hand_caster", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quality1).HasDefaultValueSql("0");

                entity.Property(e => e.Quality2).HasDefaultValueSql("0");

                entity.Property(e => e.Quality3).HasDefaultValueSql("0");

                entity.Property(e => e.Quality4).HasDefaultValueSql("0");

                entity.Property(e => e.Quality5).HasDefaultValueSql("0");

                entity.Property(e => e.Quality6).HasDefaultValueSql("0");

                entity.Property(e => e.Quality7).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemDisenchantLoot>(entity =>
            {
                entity.ToTable("item_disenchant_loot", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpansionId)
                    .HasColumnName("ExpansionID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quality)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillRequired)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subclass)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemEffect>(entity =>
            {
                entity.ToTable("item_effect", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryCoolDownMsec)
                    .HasColumnName("CategoryCoolDownMSec")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Charges)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChrSpecializationId)
                    .HasColumnName("ChrSpecializationID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CoolDownMsec)
                    .HasColumnName("CoolDownMSec")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LegacySlotIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentItemId)
                    .HasColumnName("ParentItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellCategoryId)
                    .HasColumnName("SpellCategoryID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TriggerType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemExtendedCost>(entity =>
            {
                entity.ToTable("item_extended_cost", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArenaBracket)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyCount1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyCount2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyCount3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyCount4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyCount5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyId1)
                    .HasColumnName("CurrencyID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyId2)
                    .HasColumnName("CurrencyID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyId3)
                    .HasColumnName("CurrencyID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyId4)
                    .HasColumnName("CurrencyID4")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyId5)
                    .HasColumnName("CurrencyID5")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId1)
                    .HasColumnName("ItemID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId2)
                    .HasColumnName("ItemID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId3)
                    .HasColumnName("ItemID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId4)
                    .HasColumnName("ItemID4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId5)
                    .HasColumnName("ItemID5")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinFactionId)
                    .HasColumnName("MinFactionID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinReputation)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredAchievement)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredArenaRating)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemLevelSelector>(entity =>
            {
                entity.ToTable("item_level_selector", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevelSelectorQualitySetId)
                    .HasColumnName("ItemLevelSelectorQualitySetID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemLevelSelectorQuality>(entity =>
            {
                entity.ToTable("item_level_selector_quality", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentIlsqualitySetId)
                    .HasColumnName("ParentILSQualitySetID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quality)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QualityItemBonusListId)
                    .HasColumnName("QualityItemBonusListID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemLevelSelectorQualitySet>(entity =>
            {
                entity.ToTable("item_level_selector_quality_set", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IlvlEpic)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IlvlRare)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemLimitCategory>(entity =>
            {
                entity.ToTable("item_limit_category", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemLimitCategoryCondition>(entity =>
            {
                entity.ToTable("item_limit_category_condition", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AddQuantity)
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentItemLimitCategoryId)
                    .HasColumnName("ParentItemLimitCategoryID")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemLimitCategoryLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("item_limit_category_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemModifiedAppearance>(entity =>
            {
                entity.ToTable("item_modified_appearance", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemAppearanceId)
                    .HasColumnName("ItemAppearanceID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemAppearanceModifierId)
                    .HasColumnName("ItemAppearanceModifierID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransmogSourceTypeEnum)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemPriceBase>(entity =>
            {
                entity.ToTable("item_price_base", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Armor).HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Weapon).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemRandomProperties>(entity =>
            {
                entity.ToTable("item_random_properties", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemRandomPropertiesLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("item_random_properties_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemRandomSuffix>(entity =>
            {
                entity.ToTable("item_random_suffix", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllocationPct1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllocationPct2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllocationPct3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllocationPct4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllocationPct5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enchantment5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemRandomSuffixLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("item_random_suffix_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSearchName>(entity =>
            {
                entity.ToTable("item_search_name", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllowableClass)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllowableRace)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Display).IsUnicode(false);

                entity.Property(e => e.ExpansionId)
                    .HasColumnName("ExpansionID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinFactionId)
                    .HasColumnName("MinFactionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinReputation)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverallQualityId)
                    .HasColumnName("OverallQualityID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredAbility)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredSkill)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredSkillRank)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSearchNameLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("item_search_name_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayLang)
                    .HasColumnName("Display_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSet>(entity =>
            {
                entity.ToTable("item_set", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId1)
                    .HasColumnName("ItemID1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId10)
                    .HasColumnName("ItemID10")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId11)
                    .HasColumnName("ItemID11")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId12)
                    .HasColumnName("ItemID12")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId13)
                    .HasColumnName("ItemID13")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId14)
                    .HasColumnName("ItemID14")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId15)
                    .HasColumnName("ItemID15")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId16)
                    .HasColumnName("ItemID16")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId17)
                    .HasColumnName("ItemID17")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId2)
                    .HasColumnName("ItemID2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId3)
                    .HasColumnName("ItemID3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId4)
                    .HasColumnName("ItemID4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId5)
                    .HasColumnName("ItemID5")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId6)
                    .HasColumnName("ItemID6")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId7)
                    .HasColumnName("ItemID7")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId8)
                    .HasColumnName("ItemID8")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId9)
                    .HasColumnName("ItemID9")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RequiredSkill)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredSkillRank)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SetFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSetLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("item_set_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSetSpell>(entity =>
            {
                entity.ToTable("item_set_spell", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChrSpecId)
                    .HasColumnName("ChrSpecID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemSetId)
                    .HasColumnName("ItemSetID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Threshold)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSparse>(entity =>
            {
                entity.ToTable("item_sparse", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllowableClass)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllowableRace)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactId)
                    .HasColumnName("ArtifactID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BagFamily)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bonding)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BuyPrice)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContainerSlots)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DamageDamageType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Display).IsUnicode(false);

                entity.Property(e => e.Display1).IsUnicode(false);

                entity.Property(e => e.Display2).IsUnicode(false);

                entity.Property(e => e.Display3).IsUnicode(false);

                entity.Property(e => e.DmgVariance).HasDefaultValueSql("0");

                entity.Property(e => e.DurationInInventory)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpansionId)
                    .HasColumnName("ExpansionID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GemProperties)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceBound)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InventoryType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemDelay)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemNameDescriptionId)
                    .HasColumnName("ItemNameDescriptionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemRandomSuffixGroupId)
                    .HasColumnName("ItemRandomSuffixGroupID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemRange).HasDefaultValueSql("0");

                entity.Property(e => e.ItemSet)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue1)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue10)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue2)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue3)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue4)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue5)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue6)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue7)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue8)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatValue9)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LimitCategory)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockId)
                    .HasColumnName("LockID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Material)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinFactionId)
                    .HasColumnName("MinFactionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinReputation)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverallQualityId)
                    .HasColumnName("OverallQualityID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PageId)
                    .HasColumnName("PageID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PageMaterialId)
                    .HasColumnName("PageMaterialID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PriceRandomValue).HasDefaultValueSql("0");

                entity.Property(e => e.PriceVariance).HasDefaultValueSql("0");

                entity.Property(e => e.QualityModifier).HasDefaultValueSql("0");

                entity.Property(e => e.RandomSelect)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredAbility)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredHoliday)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredPvpmedal)
                    .HasColumnName("RequiredPVPMedal")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredPvprank)
                    .HasColumnName("RequiredPVPRank")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredSkill)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredSkillRank)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredTransmogHoliday)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScalingStatDistributionId)
                    .HasColumnName("ScalingStatDistributionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SellPrice)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SheatheType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SocketMatchEnchantmentId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SocketType1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SocketType2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SocketType3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellWeight)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellWeightCategory)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stackable)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartQuestId)
                    .HasColumnName("StartQuestID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat1)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat10)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat2)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat3)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat4)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat5)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat6)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat7)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat8)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatModifierBonusStat9)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor10)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor5)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor6)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor7)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor8)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentEditor9)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket1).HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket10).HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket2).HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket3).HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket4).HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket5).HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket6).HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket7).HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket8).HasDefaultValueSql("0");

                entity.Property(e => e.StatPercentageOfSocket9).HasDefaultValueSql("0");

                entity.Property(e => e.TotemCategoryId)
                    .HasColumnName("TotemCategoryID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VendorStackCount)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZoneBound)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSparseLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("item_sparse_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.Display1Lang)
                    .HasColumnName("Display1_lang")
                    .IsUnicode(false);

                entity.Property(e => e.Display2Lang)
                    .HasColumnName("Display2_lang")
                    .IsUnicode(false);

                entity.Property(e => e.Display3Lang)
                    .HasColumnName("Display3_lang")
                    .IsUnicode(false);

                entity.Property(e => e.DisplayLang)
                    .HasColumnName("Display_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSpec>(entity =>
            {
                entity.ToTable("item_spec", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrimaryStat)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryStat)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpecializationId)
                    .HasColumnName("SpecializationID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemSpecOverride>(entity =>
            {
                entity.ToTable("item_spec_override", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpecId)
                    .HasColumnName("SpecID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemUpgrade>(entity =>
            {
                entity.ToTable("item_upgrade", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyAmount)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyType)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevelIncrement)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemUpgradePathId)
                    .HasColumnName("ItemUpgradePathID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrerequisiteId)
                    .HasColumnName("PrerequisiteID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemXBonusTree>(entity =>
            {
                entity.ToTable("item_x_bonus_tree", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemBonusTreeId)
                    .HasColumnName("ItemBonusTreeID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Keychain>(entity =>
            {
                entity.ToTable("keychain", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key10)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key11)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key12)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key13)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key14)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key15)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key16)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key17)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key18)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key19)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key20)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key21)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key22)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key23)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key24)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key25)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key26)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key27)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key28)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key29)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key30)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key31)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key32)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key7)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key8)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key9)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LfgDungeons>(entity =>
            {
                entity.ToTable("lfg_dungeons", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BonusReputationAmount)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CountDamage)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CountHealer)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CountTank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpansionLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Faction)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinalEncounterId)
                    .HasColumnName("FinalEncounterID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconTextureFileId)
                    .HasColumnName("IconTextureFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MentorCharLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MentorItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinCountDamage)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinCountHealer)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinCountTank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinGear).HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PopupBgTextureFileId)
                    .HasColumnName("PopupBgTextureFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RandomId)
                    .HasColumnName("RandomID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredPlayerConditionId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RewardsBgTextureFileId)
                    .HasColumnName("RewardsBgTextureFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScenarioId)
                    .HasColumnName("ScenarioID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subtype)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetLevelMax)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetLevelMin)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LfgDungeonsLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("lfg_dungeons_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Light>(entity =>
            {
                entity.ToTable("light", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContinentId)
                    .HasColumnName("ContinentID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GameCoordsX).HasDefaultValueSql("0");

                entity.Property(e => e.GameCoordsY).HasDefaultValueSql("0");

                entity.Property(e => e.GameCoordsZ).HasDefaultValueSql("0");

                entity.Property(e => e.GameFalloffEnd).HasDefaultValueSql("0");

                entity.Property(e => e.GameFalloffStart).HasDefaultValueSql("0");

                entity.Property(e => e.LightParamsId1)
                    .HasColumnName("LightParamsID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightParamsId2)
                    .HasColumnName("LightParamsID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightParamsId3)
                    .HasColumnName("LightParamsID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightParamsId4)
                    .HasColumnName("LightParamsID4")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightParamsId5)
                    .HasColumnName("LightParamsID5")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightParamsId6)
                    .HasColumnName("LightParamsID6")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightParamsId7)
                    .HasColumnName("LightParamsID7")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightParamsId8)
                    .HasColumnName("LightParamsID8")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LiquidType>(entity =>
            {
                entity.ToTable("liquid_type", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AmbDarkenIntensity).HasDefaultValueSql("0");

                entity.Property(e => e.Color1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Color2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DirDarkenIntensity).HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Float1).HasDefaultValueSql("0");

                entity.Property(e => e.Float10).HasDefaultValueSql("0");

                entity.Property(e => e.Float11).HasDefaultValueSql("0");

                entity.Property(e => e.Float12).HasDefaultValueSql("0");

                entity.Property(e => e.Float13).HasDefaultValueSql("0");

                entity.Property(e => e.Float14).HasDefaultValueSql("0");

                entity.Property(e => e.Float15).HasDefaultValueSql("0");

                entity.Property(e => e.Float16).HasDefaultValueSql("0");

                entity.Property(e => e.Float17).HasDefaultValueSql("0");

                entity.Property(e => e.Float18).HasDefaultValueSql("0");

                entity.Property(e => e.Float2).HasDefaultValueSql("0");

                entity.Property(e => e.Float3).HasDefaultValueSql("0");

                entity.Property(e => e.Float4).HasDefaultValueSql("0");

                entity.Property(e => e.Float5).HasDefaultValueSql("0");

                entity.Property(e => e.Float6).HasDefaultValueSql("0");

                entity.Property(e => e.Float7).HasDefaultValueSql("0");

                entity.Property(e => e.Float8).HasDefaultValueSql("0");

                entity.Property(e => e.Float9).HasDefaultValueSql("0");

                entity.Property(e => e.FogDarkenIntensity).HasDefaultValueSql("0");

                entity.Property(e => e.FrameCountTexture1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FrameCountTexture2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FrameCountTexture3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FrameCountTexture4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FrameCountTexture5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FrameCountTexture6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Int1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Int2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Int3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Int4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightId)
                    .HasColumnName("LightID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDarkenDepth).HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ParticleMovement)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParticleScale).HasDefaultValueSql("0");

                entity.Property(e => e.ParticleTexSlots)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundBank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundId)
                    .HasColumnName("SoundID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Texture1).IsUnicode(false);

                entity.Property(e => e.Texture2).IsUnicode(false);

                entity.Property(e => e.Texture3).IsUnicode(false);

                entity.Property(e => e.Texture4).IsUnicode(false);

                entity.Property(e => e.Texture5).IsUnicode(false);

                entity.Property(e => e.Texture6).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Lock>(entity =>
            {
                entity.ToTable("lock", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action7)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action8)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Index1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Index2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Index3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Index4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Index5)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Index6)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Index7)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Index8)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skill1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skill2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skill3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skill4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skill5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skill6)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skill7)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skill8)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type7)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type8)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MailTemplate>(entity =>
            {
                entity.ToTable("mail_template", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MailTemplateLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("mail_template_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BodyLang)
                    .HasColumnName("Body_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Map>(entity =>
            {
                entity.ToTable("map", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaTableId)
                    .HasColumnName("AreaTableID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CorpseMapId)
                    .HasColumnName("CorpseMapID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CorpseX).HasDefaultValueSql("0");

                entity.Property(e => e.CorpseY).HasDefaultValueSql("0");

                entity.Property(e => e.CosmeticParentMapId)
                    .HasColumnName("CosmeticParentMapID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Directory).IsUnicode(false);

                entity.Property(e => e.ExpansionId)
                    .HasColumnName("ExpansionID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LoadingScreenId)
                    .HasColumnName("LoadingScreenID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapDescription0).IsUnicode(false);

                entity.Property(e => e.MapDescription1).IsUnicode(false);

                entity.Property(e => e.MapName).IsUnicode(false);

                entity.Property(e => e.MapType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPlayers)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinimapIconScale).HasDefaultValueSql("0");

                entity.Property(e => e.ParentMapId)
                    .HasColumnName("ParentMapID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PvpLongDescription).IsUnicode(false);

                entity.Property(e => e.PvpShortDescription).IsUnicode(false);

                entity.Property(e => e.TimeOfDayOverride)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeOffset)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WindSettingsId)
                    .HasColumnName("WindSettingsID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MapDifficulty>(entity =>
            {
                entity.ToTable("map_difficulty", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemContext)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemContextPickerId)
                    .HasColumnName("ItemContextPickerID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockId)
                    .HasColumnName("LockID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPlayers)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.ResetInterval)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MapDifficultyLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("map_difficulty_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MessageLang)
                    .HasColumnName("Message_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MapLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("map_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MapDescription0Lang)
                    .HasColumnName("MapDescription0_lang")
                    .IsUnicode(false);

                entity.Property(e => e.MapDescription1Lang)
                    .HasColumnName("MapDescription1_lang")
                    .IsUnicode(false);

                entity.Property(e => e.MapNameLang)
                    .HasColumnName("MapName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.PvpLongDescriptionLang)
                    .HasColumnName("PvpLongDescription_lang")
                    .IsUnicode(false);

                entity.Property(e => e.PvpShortDescriptionLang)
                    .HasColumnName("PvpShortDescription_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ModifierTree>(entity =>
            {
                entity.ToTable("modifier_tree", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Amount)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Asset)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operator)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Parent)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAsset)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TertiaryAsset)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Mount>(entity =>
            {
                entity.ToTable("mount", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MountFlyRideHeight).HasDefaultValueSql("0");

                entity.Property(e => e.MountTypeId)
                    .HasColumnName("MountTypeID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SourceSpellId)
                    .HasColumnName("SourceSpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SourceText).IsUnicode(false);

                entity.Property(e => e.SourceTypeEnum)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiModelSceneId)
                    .HasColumnName("UiModelSceneID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MountCapability>(entity =>
            {
                entity.ToTable("mount_capability", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModSpellAuraId)
                    .HasColumnName("ModSpellAuraID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReqAreaId)
                    .HasColumnName("ReqAreaID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReqMapId)
                    .HasColumnName("ReqMapID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReqRidingSkill)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReqSpellAuraId)
                    .HasColumnName("ReqSpellAuraID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReqSpellKnownId)
                    .HasColumnName("ReqSpellKnownID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MountLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("mount_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.SourceTextLang)
                    .HasColumnName("SourceText_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MountTypeXCapability>(entity =>
            {
                entity.ToTable("mount_type_x_capability", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MountCapabilityId)
                    .HasColumnName("MountCapabilityID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MountTypeId)
                    .HasColumnName("MountTypeID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MountXDisplay>(entity =>
            {
                entity.ToTable("mount_x_display", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureDisplayInfoId)
                    .HasColumnName("CreatureDisplayInfoID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MountId)
                    .HasColumnName("MountID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movie", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudioFileDataId)
                    .HasColumnName("AudioFileDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KeyId)
                    .HasColumnName("KeyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubtitleFileDataId)
                    .HasColumnName("SubtitleFileDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volume)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NameGen>(entity =>
            {
                entity.ToTable("name_gen", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RaceId)
                    .HasColumnName("RaceID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NamesProfanity>(entity =>
            {
                entity.ToTable("names_profanity", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Language)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NamesReserved>(entity =>
            {
                entity.ToTable("names_reserved", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NamesReservedLocale>(entity =>
            {
                entity.ToTable("names_reserved_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocaleMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<OverrideSpellData>(entity =>
            {
                entity.ToTable("override_spell_data", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerActionBarFileDataId)
                    .HasColumnName("PlayerActionBarFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells10)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells5)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells6)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells7)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells8)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spells9)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.ToTable("phase", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PhaseXPhaseGroup>(entity =>
            {
                entity.ToTable("phase_x_phase_group", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseGroupId)
                    .HasColumnName("PhaseGroupID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseId)
                    .HasColumnName("PhaseID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PlayerCondition>(entity =>
            {
                entity.ToTable("player_condition", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Achievement1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Achievement2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Achievement3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Achievement4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AchievementLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId1)
                    .HasColumnName("AreaID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId2)
                    .HasColumnName("AreaID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId3)
                    .HasColumnName("AreaID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId4)
                    .HasColumnName("AreaID4")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraSpellId1)
                    .HasColumnName("AuraSpellID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraSpellId2)
                    .HasColumnName("AuraSpellID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraSpellId3)
                    .HasColumnName("AuraSpellID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraSpellId4)
                    .HasColumnName("AuraSpellID4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraSpellLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraStacks1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraStacks2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraStacks3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraStacks4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChrSpecializationIndex)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChrSpecializationRole)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassMask)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrQuestId1)
                    .HasColumnName("CurrQuestID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrQuestId2)
                    .HasColumnName("CurrQuestID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrQuestId3)
                    .HasColumnName("CurrQuestID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrQuestId4)
                    .HasColumnName("CurrQuestID4")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrQuestLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyCount1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyCount2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyCount3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyCount4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyId1)
                    .HasColumnName("CurrencyID1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyId2)
                    .HasColumnName("CurrencyID2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyId3)
                    .HasColumnName("CurrencyID3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyId4)
                    .HasColumnName("CurrencyID4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrentCompletedQuestId1)
                    .HasColumnName("CurrentCompletedQuestID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrentCompletedQuestId2)
                    .HasColumnName("CurrentCompletedQuestID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrentCompletedQuestId3)
                    .HasColumnName("CurrentCompletedQuestID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrentCompletedQuestId4)
                    .HasColumnName("CurrentCompletedQuestID4")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrentCompletedQuestLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrentPvpFaction)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Explored1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Explored2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FailureDescription).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gender)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCount4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemFlags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId1)
                    .HasColumnName("ItemID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId2)
                    .HasColumnName("ItemID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId3)
                    .HasColumnName("ItemID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId4)
                    .HasColumnName("ItemID4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgCompare1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgCompare2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgCompare3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgCompare4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgStatus1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgStatus2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgStatus3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgStatus4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgValue1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgValue2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgValue3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LfgValue4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LifetimeMaxPvprank)
                    .HasColumnName("LifetimeMaxPVPRank")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxAvgEquippedItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxAvgItemLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxExpansionLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxExpansionTier)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxFactionId)
                    .HasColumnName("MaxFactionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxGuildLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLanguage)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPvprank)
                    .HasColumnName("MaxPVPRank")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxReputation)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxSkill1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxSkill2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxSkill3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxSkill4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinAvgEquippedItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinAvgItemLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinExpansionLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinExpansionTier)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinFactionId1)
                    .HasColumnName("MinFactionID1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinFactionId2)
                    .HasColumnName("MinFactionID2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinFactionId3)
                    .HasColumnName("MinFactionID3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinGuildLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLanguage)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinPvprank)
                    .HasColumnName("MinPVPRank")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinReputation1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinReputation2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinReputation3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinSkill1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinSkill2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinSkill3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinSkill4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifierTreeId)
                    .HasColumnName("ModifierTreeID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MovementFlags1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MovementFlags2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NativeGender)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PartyStatus)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseGroupId)
                    .HasColumnName("PhaseGroupID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseId)
                    .HasColumnName("PhaseID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhaseUseFlags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerTypeComp)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerTypeValue)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevQuestId1)
                    .HasColumnName("PrevQuestID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevQuestId2)
                    .HasColumnName("PrevQuestID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevQuestId3)
                    .HasColumnName("PrevQuestID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevQuestId4)
                    .HasColumnName("PrevQuestID4")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrevQuestLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PvpMedal)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestKillId)
                    .HasColumnName("QuestKillID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestKillLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestKillMonster1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestKillMonster2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestKillMonster3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestKillMonster4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestKillMonster5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestKillMonster6)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReputationLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillId1)
                    .HasColumnName("SkillID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillId2)
                    .HasColumnName("SkillID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillId3)
                    .HasColumnName("SkillID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillId4)
                    .HasColumnName("SkillID4")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId1)
                    .HasColumnName("SpellID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId2)
                    .HasColumnName("SpellID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId3)
                    .HasColumnName("SpellID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId4)
                    .HasColumnName("SpellID4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellLogic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeaponSubclassMask)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeatherId)
                    .HasColumnName("WeatherID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WorldStateExpressionId)
                    .HasColumnName("WorldStateExpressionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PlayerConditionLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("player_condition_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FailureDescriptionLang)
                    .HasColumnName("FailureDescription_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PowerDisplay>(entity =>
            {
                entity.ToTable("power_display", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActualType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Blue)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GlobalStringBaseTag).IsUnicode(false);

                entity.Property(e => e.Green)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Red)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PowerType>(entity =>
            {
                entity.ToTable("power_type", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CenterPower)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CostGlobalStringTag).IsUnicode(false);

                entity.Property(e => e.DefaultPower)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayModifier)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxBasePower)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinPower)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NameGlobalStringTag).IsUnicode(false);

                entity.Property(e => e.PowerTypeEnum)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegenCombat).HasDefaultValueSql("0");

                entity.Property(e => e.RegenInterruptTimeMs)
                    .HasColumnName("RegenInterruptTimeMS")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegenPeace).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PrestigeLevelInfo>(entity =>
            {
                entity.ToTable("prestige_level_info", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BadgeTextureFileDataId)
                    .HasColumnName("BadgeTextureFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PrestigeLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PrestigeLevelInfoLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("prestige_level_info_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PvpDifficulty>(entity =>
            {
                entity.ToTable("pvp_difficulty", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PvpItem>(entity =>
            {
                entity.ToTable("pvp_item", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevelDelta)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PvpReward>(entity =>
            {
                entity.ToTable("pvp_reward", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HonorLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrestigeLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RewardPackId)
                    .HasColumnName("RewardPackID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PvpTalent>(entity =>
            {
                entity.ToTable("pvp_talent", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActionBarSpellId)
                    .HasColumnName("ActionBarSpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ColumnIndex)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverridesSpellId)
                    .HasColumnName("OverridesSpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Role)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpecId)
                    .HasColumnName("SpecID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TierId)
                    .HasColumnName("TierID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PvpTalentLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("pvp_talent_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PvpTalentUnlock>(entity =>
            {
                entity.ToTable("pvp_talent_unlock", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ColumnIndex)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HonorLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TierId)
                    .HasColumnName("TierID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<QuestFactionReward>(entity =>
            {
                entity.ToTable("quest_faction_reward", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty1)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty10)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty2)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty3)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty4)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty5)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty6)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty7)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty8)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty9)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<QuestMoneyReward>(entity =>
            {
                entity.ToTable("quest_money_reward", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty10)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty6)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty7)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty8)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty9)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<QuestPackageItem>(entity =>
            {
                entity.ToTable("quest_package_item", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemQuantity)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PackageId)
                    .HasColumnName("PackageID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<QuestSort>(entity =>
            {
                entity.ToTable("quest_sort", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SortName).IsUnicode(false);

                entity.Property(e => e.UiOrderIndex)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<QuestSortLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("quest_sort_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SortNameLang)
                    .HasColumnName("SortName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<QuestV2>(entity =>
            {
                entity.ToTable("quest_v2", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UniqueBitFlag)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<QuestXp>(entity =>
            {
                entity.ToTable("quest_xp", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty10)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty6)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty7)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty8)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Difficulty9)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RandPropPoints>(entity =>
            {
                entity.ToTable("rand_prop_points", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Epic1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Epic2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Epic3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Epic4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Epic5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Good1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Good2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Good3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Good4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Good5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Superior1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Superior2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Superior3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Superior4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Superior5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RewardPack>(entity =>
            {
                entity.ToTable("reward_pack", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactXpcategoryId)
                    .HasColumnName("ArtifactXPCategoryID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactXpdifficulty)
                    .HasColumnName("ArtifactXPDifficulty")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArtifactXpmultiplier)
                    .HasColumnName("ArtifactXPMultiplier")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CharTitleId)
                    .HasColumnName("CharTitleID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TreasurePickerId)
                    .HasColumnName("TreasurePickerID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RewardPackXCurrencyType>(entity =>
            {
                entity.ToTable("reward_pack_x_currency_type", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CurrencyTypeId)
                    .HasColumnName("CurrencyTypeID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RewardPackId)
                    .HasColumnName("RewardPackID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RewardPackXItem>(entity =>
            {
                entity.ToTable("reward_pack_x_item", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemQuantity)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RewardPackId)
                    .HasColumnName("RewardPackID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RulesetItemUpgrade>(entity =>
            {
                entity.ToTable("ruleset_item_upgrade", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemUpgradeId)
                    .HasColumnName("ItemUpgradeID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SandboxScaling>(entity =>
            {
                entity.ToTable("sandbox_scaling", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ScalingStatDistribution>(entity =>
            {
                entity.ToTable("scaling_stat_distribution", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerLevelToItemLevelCurveId)
                    .HasColumnName("PlayerLevelToItemLevelCurveID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Scenario>(entity =>
            {
                entity.ToTable("scenario", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaTableId)
                    .HasColumnName("AreaTableID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ScenarioLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("scenario_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ScenarioStep>(entity =>
            {
                entity.ToTable("scenario_step", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Criteriatreeid)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RelatedStep)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RewardQuestId)
                    .HasColumnName("RewardQuestID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScenarioId)
                    .HasColumnName("ScenarioID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Supersedes)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ScenarioStepLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("scenario_step_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.TitleLang)
                    .HasColumnName("Title_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SceneScript>(entity =>
            {
                entity.ToTable("scene_script", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FirstSceneScriptId)
                    .HasColumnName("FirstSceneScriptID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NextSceneScriptId)
                    .HasColumnName("NextSceneScriptID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SceneScriptGlobalText>(entity =>
            {
                entity.ToTable("scene_script_global_text", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Script).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SceneScriptPackage>(entity =>
            {
                entity.ToTable("scene_script_package", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SceneScriptText>(entity =>
            {
                entity.ToTable("scene_script_text", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Script).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SkillLine>(entity =>
            {
                entity.ToTable("skill_line", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AlternateVerb).IsUnicode(false);

                entity.Property(e => e.CanLink)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DisplayName).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentSkillLineId)
                    .HasColumnName("ParentSkillLineID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellIconFileId)
                    .HasColumnName("SpellIconFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SkillLineAbility>(entity =>
            {
                entity.ToTable("skill_line_ability", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AcquireMethod)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassMask)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinSkillLineRank)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NumSkillUps)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillLine)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spell)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SupercedesSpell)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TradeSkillCategoryId)
                    .HasColumnName("TradeSkillCategoryID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TrivialSkillLineRankHigh)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TrivialSkillLineRankLow)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UniqueBit)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SkillLineLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("skill_line_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateVerbLang)
                    .HasColumnName("AlternateVerb_lang")
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.DisplayNameLang)
                    .HasColumnName("DisplayName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SkillRaceClassInfo>(entity =>
            {
                entity.ToTable("skill_race_class_info", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Availability)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassMask)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillId)
                    .HasColumnName("SkillID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkillTierId)
                    .HasColumnName("SkillTierID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SoundKit>(entity =>
            {
                entity.ToTable("sound_kit", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BusOverwriteId)
                    .HasColumnName("BusOverwriteID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DialogType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DistanceCutoff).HasDefaultValueSql("0");

                entity.Property(e => e.Eaxdef)
                    .HasColumnName("EAXDef")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxInstances)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinDistance).HasDefaultValueSql("0");

                entity.Property(e => e.PitchAdjust).HasDefaultValueSql("0");

                entity.Property(e => e.PitchVariationMinus).HasDefaultValueSql("0");

                entity.Property(e => e.PitchVariationPlus).HasDefaultValueSql("0");

                entity.Property(e => e.SoundEntriesAdvancedId)
                    .HasColumnName("SoundEntriesAdvancedID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VolumeFloat).HasDefaultValueSql("0");

                entity.Property(e => e.VolumeVariationMinus).HasDefaultValueSql("0");

                entity.Property(e => e.VolumeVariationPlus).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpecializationSpells>(entity =>
            {
                entity.ToTable("specialization_spells", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverridesSpellId)
                    .HasColumnName("OverridesSpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpecId)
                    .HasColumnName("SpecID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpecializationSpellsLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("specialization_spells_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Spell>(entity =>
            {
                entity.ToTable("spell", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraDescription).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.NameSubtext).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellAuraOptions>(entity =>
            {
                entity.ToTable("spell_aura_options", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CumulativeAura)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProcCategoryRecovery)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProcChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProcCharges)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProcTypeMask)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellProcsPerMinuteId)
                    .HasColumnName("SpellProcsPerMinuteID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellAuraRestrictions>(entity =>
            {
                entity.ToTable("spell_aura_restrictions", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CasterAuraSpell)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CasterAuraState)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExcludeCasterAuraSpell)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExcludeCasterAuraState)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExcludeTargetAuraSpell)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExcludeTargetAuraState)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetAuraSpell)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetAuraState)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellCastingRequirements>(entity =>
            {
                entity.ToTable("spell_casting_requirements", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FacingCasterFlags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinFactionId)
                    .HasColumnName("MinFactionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinReputation)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredAreasId)
                    .HasColumnName("RequiredAreasID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredAuraVision)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiresSpellFocus)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellCastTimes>(entity =>
            {
                entity.ToTable("spell_cast_times", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Base)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Minimum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PerLevel)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellCategories>(entity =>
            {
                entity.ToTable("spell_categories", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Category)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeCategory)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefenseType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DispelType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mechanic)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PreventionType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartRecoveryCategory)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellCategory>(entity =>
            {
                entity.ToTable("spell_category", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeRecoveryTime)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxCharges)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.TypeMask)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsesPerWeek)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellCategoryLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("spell_category_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellClassOptions>(entity =>
            {
                entity.ToTable("spell_class_options", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModalNextSpell)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellClassMask1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellClassMask2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellClassMask3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellClassMask4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellClassSet)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellCooldowns>(entity =>
            {
                entity.ToTable("spell_cooldowns", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryRecoveryTime)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecoveryTime)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartRecoveryTime)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellDuration>(entity =>
            {
                entity.ToTable("spell_duration", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DurationPerLevel)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDuration)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellEffect>(entity =>
            {
                entity.ToTable("spell_effect", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BonusCoefficientFromAp)
                    .HasColumnName("BonusCoefficientFromAP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coefficient).HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Effect)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectAmplitude).HasDefaultValueSql("0");

                entity.Property(e => e.EffectAttributes)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectAura)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectAuraPeriod)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectBasePoints)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectBonusCoefficient).HasDefaultValueSql("0");

                entity.Property(e => e.EffectChainAmplitude).HasDefaultValueSql("0");

                entity.Property(e => e.EffectChainTargets)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectDieSides)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectIndex)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectItemType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectMechanic)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectMiscValue1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectMiscValue2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectPointsPerResource).HasDefaultValueSql("0");

                entity.Property(e => e.EffectPosFacing).HasDefaultValueSql("0");

                entity.Property(e => e.EffectRadiusIndex1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectRadiusIndex2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectRealPointsPerLevel).HasDefaultValueSql("0");

                entity.Property(e => e.EffectSpellClassMask1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectSpellClassMask2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectSpellClassMask3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectSpellClassMask4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectTriggerSpell)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupSizeBasePointsCoefficient).HasDefaultValueSql("0");

                entity.Property(e => e.ImplicitTarget1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImplicitTarget2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PvpMultiplier).HasDefaultValueSql("0");

                entity.Property(e => e.ResourceCoefficient).HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Variance).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellEquippedItems>(entity =>
            {
                entity.ToTable("spell_equipped_items", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EquippedItemClass)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EquippedItemInvTypes)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EquippedItemSubclass)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellFocusObject>(entity =>
            {
                entity.ToTable("spell_focus_object", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellFocusObjectLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("spell_focus_object_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellInterrupts>(entity =>
            {
                entity.ToTable("spell_interrupts", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraInterruptFlags1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuraInterruptFlags2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChannelInterruptFlags1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChannelInterruptFlags2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InterruptFlags)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellItemEnchantment>(entity =>
            {
                entity.ToTable("spell_item_enchantment", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Charges)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("ConditionID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Effect1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Effect2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Effect3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectArg1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectArg2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectArg3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectPointsMin1)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectPointsMin2)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectPointsMin3)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffectScalingPoints1).HasDefaultValueSql("0");

                entity.Property(e => e.EffectScalingPoints2).HasDefaultValueSql("0");

                entity.Property(e => e.EffectScalingPoints3).HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconFileDataId)
                    .HasColumnName("IconFileDataID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemVisual)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RequiredSkillId)
                    .HasColumnName("RequiredSkillID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredSkillRank)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScalingClass)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScalingClassRestricted)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransmogCost)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransmogPlayerConditionId)
                    .HasColumnName("TransmogPlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellItemEnchantmentCondition>(entity =>
            {
                entity.ToTable("spell_item_enchantment_condition", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Logic1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Logic2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Logic3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Logic4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Logic5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperand1)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperand2)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperand3)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperand4)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperand5)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperandType1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperandType2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperandType3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperandType4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtOperandType5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operator1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operator2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operator3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operator4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operator5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperand1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperand2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperand3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperand4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperand5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperandType1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperandType2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperandType3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperandType4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtOperandType5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellItemEnchantmentLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("spell_item_enchantment_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellLearnSpell>(entity =>
            {
                entity.ToTable("spell_learn_spell", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LearnSpellId)
                    .HasColumnName("LearnSpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverridesSpellId)
                    .HasColumnName("OverridesSpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellLevels>(entity =>
            {
                entity.ToTable("spell_levels", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BaseLevel)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPassiveAuraLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellLevel)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("spell_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AuraDescriptionLang)
                    .HasColumnName("AuraDescription_lang")
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameSubtextLang)
                    .HasColumnName("NameSubtext_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellMisc>(entity =>
            {
                entity.ToTable("spell_misc", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActiveIconFileDataId)
                    .HasColumnName("ActiveIconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes10)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes11)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes12)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes13)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes14)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes5)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes6)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes7)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes8)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attributes9)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CastingTimeIndex)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DurationIndex)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LaunchDelay).HasDefaultValueSql("0");

                entity.Property(e => e.RangeIndex)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SchoolMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Speed).HasDefaultValueSql("0");

                entity.Property(e => e.SpellIconFileDataId)
                    .HasColumnName("SpellIconFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellPower>(entity =>
            {
                entity.ToTable("spell_power", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AltPowerBarId)
                    .HasColumnName("AltPowerBarID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManaCost)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManaCostPerLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManaPerSecond)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OptionalCost)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerCostMaxPct).HasDefaultValueSql("0");

                entity.Property(e => e.PowerCostPct).HasDefaultValueSql("0");

                entity.Property(e => e.PowerDisplayId)
                    .HasColumnName("PowerDisplayID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerPctPerSecond).HasDefaultValueSql("0");

                entity.Property(e => e.PowerType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredAuraSpellId)
                    .HasColumnName("RequiredAuraSpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellPowerDifficulty>(entity =>
            {
                entity.ToTable("spell_power_difficulty", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellProcsPerMinute>(entity =>
            {
                entity.ToTable("spell_procs_per_minute", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BaseProcRate).HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellProcsPerMinuteMod>(entity =>
            {
                entity.ToTable("spell_procs_per_minute_mod", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coeff).HasDefaultValueSql("0");

                entity.Property(e => e.Param)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellProcsPerMinuteId)
                    .HasColumnName("SpellProcsPerMinuteID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellRadius>(entity =>
            {
                entity.ToTable("spell_radius", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Radius).HasDefaultValueSql("0");

                entity.Property(e => e.RadiusMax).HasDefaultValueSql("0");

                entity.Property(e => e.RadiusMin).HasDefaultValueSql("0");

                entity.Property(e => e.RadiusPerLevel).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellRange>(entity =>
            {
                entity.ToTable("spell_range", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayName).IsUnicode(false);

                entity.Property(e => e.DisplayNameShort).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RangeMax1).HasDefaultValueSql("0");

                entity.Property(e => e.RangeMax2).HasDefaultValueSql("0");

                entity.Property(e => e.RangeMin1).HasDefaultValueSql("0");

                entity.Property(e => e.RangeMin2).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellRangeLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("spell_range_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayNameLang)
                    .HasColumnName("DisplayName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.DisplayNameShortLang)
                    .HasColumnName("DisplayNameShort_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellReagents>(entity =>
            {
                entity.ToTable("spell_reagents", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reagent1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reagent2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reagent3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reagent4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reagent5)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reagent6)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reagent7)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reagent8)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReagentCount1)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReagentCount2)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReagentCount3)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReagentCount4)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReagentCount5)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReagentCount6)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReagentCount7)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReagentCount8)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellScaling>(entity =>
            {
                entity.ToTable("spell_scaling", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Class)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxScalingLevel)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinScalingLevel)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScalesFromItemLevel)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellShapeshift>(entity =>
            {
                entity.ToTable("spell_shapeshift", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShapeshiftExclude1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShapeshiftExclude2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShapeshiftMask1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShapeshiftMask2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StanceBarOrder)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellShapeshiftForm>(entity =>
            {
                entity.ToTable("spell_shapeshift_form", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttackIconFileId)
                    .HasColumnName("AttackIconFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BonusActionBar)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CombatRoundTime)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureDisplayId1)
                    .HasColumnName("CreatureDisplayID1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureDisplayId2)
                    .HasColumnName("CreatureDisplayID2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureDisplayId3)
                    .HasColumnName("CreatureDisplayID3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureDisplayId4)
                    .HasColumnName("CreatureDisplayID4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatureType)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DamageVariance).HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MountTypeId)
                    .HasColumnName("MountTypeID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PresetSpellId1)
                    .HasColumnName("PresetSpellID1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetSpellId2)
                    .HasColumnName("PresetSpellID2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetSpellId3)
                    .HasColumnName("PresetSpellID3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetSpellId4)
                    .HasColumnName("PresetSpellID4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetSpellId5)
                    .HasColumnName("PresetSpellID5")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetSpellId6)
                    .HasColumnName("PresetSpellID6")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetSpellId7)
                    .HasColumnName("PresetSpellID7")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetSpellId8)
                    .HasColumnName("PresetSpellID8")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellShapeshiftFormLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("spell_shapeshift_form_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellTargetRestrictions>(entity =>
            {
                entity.ToTable("spell_target_restrictions", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ConeDegrees).HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxTargetLevel)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxTargets)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetCreatureType)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Targets)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Width).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellTotems>(entity =>
            {
                entity.ToTable("spell_totems", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredTotemCategoryId1)
                    .HasColumnName("RequiredTotemCategoryID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredTotemCategoryId2)
                    .HasColumnName("RequiredTotemCategoryID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Totem1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Totem2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SpellXSpellVisual>(entity =>
            {
                entity.ToTable("spell_x_spell_visual", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActiveIconFileId)
                    .HasColumnName("ActiveIconFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CasterPlayerConditionId)
                    .HasColumnName("CasterPlayerConditionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CasterUnitConditionId)
                    .HasColumnName("CasterUnitConditionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DifficultyId)
                    .HasColumnName("DifficultyID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Priority)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Probability).HasDefaultValueSql("0");

                entity.Property(e => e.SpellIconFileId)
                    .HasColumnName("SpellIconFileID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellVisualId)
                    .HasColumnName("SpellVisualID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ViewerPlayerConditionId)
                    .HasColumnName("ViewerPlayerConditionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ViewerUnitConditionId)
                    .HasColumnName("ViewerUnitConditionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SummonProperties>(entity =>
            {
                entity.ToTable("summon_properties", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Control)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Faction)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Slot)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TactKey>(entity =>
            {
                entity.ToTable("tact_key", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key10)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key11)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key12)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key13)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key14)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key15)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key16)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key7)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key8)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key9)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Talent>(entity =>
            {
                entity.ToTable("talent", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryMask1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryMask2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ColumnIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverridesSpellId)
                    .HasColumnName("OverridesSpellID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpecId)
                    .HasColumnName("SpecID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TierId)
                    .HasColumnName("TierID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TalentLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("talent_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLang)
                    .HasColumnName("Description_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaxiNodes>(entity =>
            {
                entity.ToTable("taxi_nodes", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CharacterBitNumber)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("ConditionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContinentId)
                    .HasColumnName("ContinentID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Facing).HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FlightMapOffsetX).HasDefaultValueSql("0");

                entity.Property(e => e.FlightMapOffsetY).HasDefaultValueSql("0");

                entity.Property(e => e.MapOffsetX).HasDefaultValueSql("0");

                entity.Property(e => e.MapOffsetY).HasDefaultValueSql("0");

                entity.Property(e => e.MountCreatureId1)
                    .HasColumnName("MountCreatureID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MountCreatureId2)
                    .HasColumnName("MountCreatureID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PosX).HasDefaultValueSql("0");

                entity.Property(e => e.PosY).HasDefaultValueSql("0");

                entity.Property(e => e.PosZ).HasDefaultValueSql("0");

                entity.Property(e => e.SpecialIconConditionId)
                    .HasColumnName("SpecialIconConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiTextureKitId)
                    .HasColumnName("UiTextureKitID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaxiNodesLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("taxi_nodes_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaxiPath>(entity =>
            {
                entity.ToTable("taxi_path", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cost)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FromTaxiNode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ToTaxiNode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaxiPathNode>(entity =>
            {
                entity.ToTable("taxi_path_node", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArrivalEventId)
                    .HasColumnName("ArrivalEventID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContinentId)
                    .HasColumnName("ContinentID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DepartureEventId)
                    .HasColumnName("DepartureEventID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocX).HasDefaultValueSql("0");

                entity.Property(e => e.LocY).HasDefaultValueSql("0");

                entity.Property(e => e.LocZ).HasDefaultValueSql("0");

                entity.Property(e => e.NodeIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PathId)
                    .HasColumnName("PathID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TotemCategory>(entity =>
            {
                entity.ToTable("totem_category", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.TotemCategoryMask)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotemCategoryType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TotemCategoryLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("totem_category_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Toy>(entity =>
            {
                entity.ToTable("toy", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SourceText).IsUnicode(false);

                entity.Property(e => e.SourceTypeEnum)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ToyLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("toy_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SourceTextLang)
                    .HasColumnName("SourceText_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TransmogHoliday>(entity =>
            {
                entity.ToTable("transmog_holiday", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredTransmogHoliday)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TransmogSet>(entity =>
            {
                entity.ToTable("transmog_set", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassMask)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpansionId)
                    .HasColumnName("ExpansionID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemNameDescriptionId)
                    .HasColumnName("ItemNameDescriptionID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ParentTransmogSetId)
                    .HasColumnName("ParentTransmogSetID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TrackingQuestId)
                    .HasColumnName("TrackingQuestID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransmogSetGroupId)
                    .HasColumnName("TransmogSetGroupID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiOrder)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TransmogSetGroup>(entity =>
            {
                entity.ToTable("transmog_set_group", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TransmogSetGroupLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("transmog_set_group_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TransmogSetItem>(entity =>
            {
                entity.ToTable("transmog_set_item", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemModifiedAppearanceId)
                    .HasColumnName("ItemModifiedAppearanceID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransmogSetId)
                    .HasColumnName("TransmogSetID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TransmogSetLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("transmog_set_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TransportAnimation>(entity =>
            {
                entity.ToTable("transport_animation", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX).HasDefaultValueSql("0");

                entity.Property(e => e.PosY).HasDefaultValueSql("0");

                entity.Property(e => e.PosZ).HasDefaultValueSql("0");

                entity.Property(e => e.SequenceId)
                    .HasColumnName("SequenceID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeIndex)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransportId)
                    .HasColumnName("TransportID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TransportRotation>(entity =>
            {
                entity.ToTable("transport_rotation", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GameObjectsId)
                    .HasColumnName("GameObjectsID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rot1).HasDefaultValueSql("0");

                entity.Property(e => e.Rot2).HasDefaultValueSql("0");

                entity.Property(e => e.Rot3).HasDefaultValueSql("0");

                entity.Property(e => e.Rot4).HasDefaultValueSql("0");

                entity.Property(e => e.TimeIndex)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UnitPowerBar>(entity =>
            {
                entity.ToTable("unit_power_bar", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BarType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CenterPower)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Color1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Color2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Color3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Color4)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Color5)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Color6)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cost).IsUnicode(false);

                entity.Property(e => e.EndInset).HasDefaultValueSql("0");

                entity.Property(e => e.FileDataId1)
                    .HasColumnName("FileDataID1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileDataId2)
                    .HasColumnName("FileDataID2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileDataId3)
                    .HasColumnName("FileDataID3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileDataId4)
                    .HasColumnName("FileDataID4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileDataId5)
                    .HasColumnName("FileDataID5")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileDataId6)
                    .HasColumnName("FileDataID6")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPower)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinPower)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OutOfError).IsUnicode(false);

                entity.Property(e => e.RegenerationCombat).HasDefaultValueSql("0");

                entity.Property(e => e.RegenerationPeace).HasDefaultValueSql("0");

                entity.Property(e => e.StartInset).HasDefaultValueSql("0");

                entity.Property(e => e.StartPower)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ToolTip).IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UnitPowerBarLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("unit_power_bar_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CostLang)
                    .HasColumnName("Cost_lang")
                    .IsUnicode(false);

                entity.Property(e => e.NameLang)
                    .HasColumnName("Name_lang")
                    .IsUnicode(false);

                entity.Property(e => e.OutOfErrorLang)
                    .HasColumnName("OutOfError_lang")
                    .IsUnicode(false);

                entity.Property(e => e.ToolTipLang)
                    .HasColumnName("ToolTip_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Updates>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("updates", "hotfixes");

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

                entity.ToTable("updates_include", "hotfixes");

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

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("vehicle", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CameraFadeDistScalarMax).HasDefaultValueSql("0");

                entity.Property(e => e.CameraFadeDistScalarMin).HasDefaultValueSql("0");

                entity.Property(e => e.CameraPitchOffset).HasDefaultValueSql("0");

                entity.Property(e => e.CameraYawOffset).HasDefaultValueSql("0");

                entity.Property(e => e.FacingLimitLeft).HasDefaultValueSql("0");

                entity.Property(e => e.FacingLimitRight).HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FlagsB)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MissileTargetingId)
                    .HasColumnName("MissileTargetingID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MouseLookOffsetPitch).HasDefaultValueSql("0");

                entity.Property(e => e.PitchMax).HasDefaultValueSql("0");

                entity.Property(e => e.PitchMin).HasDefaultValueSql("0");

                entity.Property(e => e.PitchSpeed).HasDefaultValueSql("0");

                entity.Property(e => e.PowerDisplayId1)
                    .HasColumnName("PowerDisplayID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerDisplayId2)
                    .HasColumnName("PowerDisplayID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PowerDisplayId3)
                    .HasColumnName("PowerDisplayID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeatId1)
                    .HasColumnName("SeatID1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeatId2)
                    .HasColumnName("SeatID2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeatId3)
                    .HasColumnName("SeatID3")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeatId4)
                    .HasColumnName("SeatID4")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeatId5)
                    .HasColumnName("SeatID5")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeatId6)
                    .HasColumnName("SeatID6")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeatId7)
                    .HasColumnName("SeatID7")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeatId8)
                    .HasColumnName("SeatID8")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TurnSpeed).HasDefaultValueSql("0");

                entity.Property(e => e.UiLocomotionType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleUiindicatorId)
                    .HasColumnName("VehicleUIIndicatorID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<VehicleSeat>(entity =>
            {
                entity.ToTable("vehicle_seat", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttachmentId)
                    .HasColumnName("AttachmentID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttachmentOffsetX).HasDefaultValueSql("0");

                entity.Property(e => e.AttachmentOffsetY).HasDefaultValueSql("0");

                entity.Property(e => e.AttachmentOffsetZ).HasDefaultValueSql("0");

                entity.Property(e => e.CameraEnteringDelay).HasDefaultValueSql("0");

                entity.Property(e => e.CameraEnteringDuration).HasDefaultValueSql("0");

                entity.Property(e => e.CameraEnteringZoom).HasDefaultValueSql("0");

                entity.Property(e => e.CameraExitingDelay).HasDefaultValueSql("0");

                entity.Property(e => e.CameraExitingDuration).HasDefaultValueSql("0");

                entity.Property(e => e.CameraFacingChaseRate).HasDefaultValueSql("0");

                entity.Property(e => e.CameraModeId)
                    .HasColumnName("CameraModeID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CameraOffsetX).HasDefaultValueSql("0");

                entity.Property(e => e.CameraOffsetY).HasDefaultValueSql("0");

                entity.Property(e => e.CameraOffsetZ).HasDefaultValueSql("0");

                entity.Property(e => e.CameraPosChaseRate).HasDefaultValueSql("0");

                entity.Property(e => e.CameraSeatZoomMax).HasDefaultValueSql("0");

                entity.Property(e => e.CameraSeatZoomMin).HasDefaultValueSql("0");

                entity.Property(e => e.EnterAnimKitId)
                    .HasColumnName("EnterAnimKitID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnterAnimLoop)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnterAnimStart)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnterGravity).HasDefaultValueSql("0");

                entity.Property(e => e.EnterMaxArcHeight).HasDefaultValueSql("0");

                entity.Property(e => e.EnterMaxDuration).HasDefaultValueSql("0");

                entity.Property(e => e.EnterMinArcHeight).HasDefaultValueSql("0");

                entity.Property(e => e.EnterMinDuration).HasDefaultValueSql("0");

                entity.Property(e => e.EnterPreDelay).HasDefaultValueSql("0");

                entity.Property(e => e.EnterSpeed).HasDefaultValueSql("0");

                entity.Property(e => e.EnterUisoundId)
                    .HasColumnName("EnterUISoundID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExitAnimEnd)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExitAnimKitId)
                    .HasColumnName("ExitAnimKitID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExitAnimLoop)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExitAnimStart)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExitGravity).HasDefaultValueSql("0");

                entity.Property(e => e.ExitMaxArcHeight).HasDefaultValueSql("0");

                entity.Property(e => e.ExitMaxDuration).HasDefaultValueSql("0");

                entity.Property(e => e.ExitMinArcHeight).HasDefaultValueSql("0");

                entity.Property(e => e.ExitMinDuration).HasDefaultValueSql("0");

                entity.Property(e => e.ExitPreDelay).HasDefaultValueSql("0");

                entity.Property(e => e.ExitSpeed).HasDefaultValueSql("0");

                entity.Property(e => e.ExitUisoundId)
                    .HasColumnName("ExitUISoundID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FlagsB)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FlagsC)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PassengerAttachmentId)
                    .HasColumnName("PassengerAttachmentID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PassengerPitch).HasDefaultValueSql("0");

                entity.Property(e => e.PassengerRoll).HasDefaultValueSql("0");

                entity.Property(e => e.PassengerYaw).HasDefaultValueSql("0");

                entity.Property(e => e.RideAnimKitId)
                    .HasColumnName("RideAnimKitID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RideAnimLoop)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RideAnimStart)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RideUpperAnimLoop)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RideUpperAnimStart)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UiSkinFileDataId)
                    .HasColumnName("UiSkinFileDataID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleAbilityDisplay)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleEnterAnim)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleEnterAnimBone)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleEnterAnimDelay).HasDefaultValueSql("0");

                entity.Property(e => e.VehicleEnterAnimKitId)
                    .HasColumnName("VehicleEnterAnimKitID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleExitAnim)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleExitAnimBone)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleExitAnimDelay).HasDefaultValueSql("0");

                entity.Property(e => e.VehicleExitAnimKitId)
                    .HasColumnName("VehicleExitAnimKitID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleRideAnimKitId)
                    .HasColumnName("VehicleRideAnimKitID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleRideAnimLoop)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleRideAnimLoopBone)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WmoAreaTable>(entity =>
            {
                entity.ToTable("wmo_area_table", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AmbienceId)
                    .HasColumnName("AmbienceID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaName).IsUnicode(false);

                entity.Property(e => e.AreaTableId)
                    .HasColumnName("AreaTableID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IntroSound)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NameSetId)
                    .HasColumnName("NameSetID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundProviderPref)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoundProviderPrefUnderwater)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UwAmbience)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UwIntroSound)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UwZoneMusic)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WmoGroupId)
                    .HasColumnName("WmoGroupID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WmoId)
                    .HasColumnName("WmoID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZoneMusic)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WmoAreaTableLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("wmo_area_table_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaNameLang)
                    .HasColumnName("AreaName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WorldEffect>(entity =>
            {
                entity.ToTable("world_effect", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CombatConditionId)
                    .HasColumnName("CombatConditionID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QuestFeedbackEffectId)
                    .HasColumnName("QuestFeedbackEffectID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetAsset)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WhenToDisplay)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WorldMapArea>(entity =>
            {
                entity.ToTable("world_map_area", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AreaID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaName).IsUnicode(false);

                entity.Property(e => e.BountyDisplayLocation)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BountySetId)
                    .HasColumnName("BountySetID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultDungeonFloor)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayMapId)
                    .HasColumnName("DisplayMapID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelRangeMax)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelRangeMin)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocBottom).HasDefaultValueSql("0");

                entity.Property(e => e.LocLeft).HasDefaultValueSql("0");

                entity.Property(e => e.LocRight).HasDefaultValueSql("0");

                entity.Property(e => e.LocTop).HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentWorldMapId)
                    .HasColumnName("ParentWorldMapID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VisibilityPlayerConditionId)
                    .HasColumnName("VisibilityPlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WorldMapOverlay>(entity =>
            {
                entity.ToTable("world_map_overlay", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId1)
                    .HasColumnName("AreaID1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId2)
                    .HasColumnName("AreaID2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId3)
                    .HasColumnName("AreaID3")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId4)
                    .HasColumnName("AreaID4")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HitRectBottom)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HitRectLeft)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HitRectRight)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HitRectTop)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapAreaId)
                    .HasColumnName("MapAreaID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OffsetX)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OffsetY)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextureHeight)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TextureName).IsUnicode(false);

                entity.Property(e => e.TextureWidth)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WorldMapTransforms>(entity =>
            {
                entity.ToTable("world_map_transforms", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AreaID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewAreaId)
                    .HasColumnName("NewAreaID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewDungeonMapId)
                    .HasColumnName("NewDungeonMapID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewMapId)
                    .HasColumnName("NewMapID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegionMaxX).HasDefaultValueSql("0");

                entity.Property(e => e.RegionMaxY).HasDefaultValueSql("0");

                entity.Property(e => e.RegionMaxZ).HasDefaultValueSql("0");

                entity.Property(e => e.RegionMinX).HasDefaultValueSql("0");

                entity.Property(e => e.RegionMinY).HasDefaultValueSql("0");

                entity.Property(e => e.RegionMinZ).HasDefaultValueSql("0");

                entity.Property(e => e.RegionOffsetX).HasDefaultValueSql("0");

                entity.Property(e => e.RegionOffsetY).HasDefaultValueSql("0");

                entity.Property(e => e.RegionScale).HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WorldSafeLocs>(entity =>
            {
                entity.ToTable("world_safe_locs", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaName).IsUnicode(false);

                entity.Property(e => e.Facing).HasDefaultValueSql("0");

                entity.Property(e => e.LocX).HasDefaultValueSql("0");

                entity.Property(e => e.LocY).HasDefaultValueSql("0");

                entity.Property(e => e.LocZ).HasDefaultValueSql("0");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WorldSafeLocsLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale });

                entity.ToTable("world_safe_locs_locale", "hotfixes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaNameLang)
                    .HasColumnName("AreaName_lang")
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");
            });
        }
    }
}
