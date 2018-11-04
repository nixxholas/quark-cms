using System.Collections.Generic;

namespace Delta.Trinity.Characters
{
    public partial class Characters
    {
        public Characters()
        {
            CharacterGarrisonFollowers = new HashSet<CharacterGarrisonFollowers>();
        }

        public long Guid { get; set; }
        public int Account { get; set; }
        public string Name { get; set; }
        public byte Slot { get; set; }
        public byte Race { get; set; }
        public byte Class { get; set; }
        public byte Gender { get; set; }
        public byte Level { get; set; }
        public int Xp { get; set; }
        public long Money { get; set; }
        public byte Skin { get; set; }
        public byte Face { get; set; }
        public byte HairStyle { get; set; }
        public byte HairColor { get; set; }
        public byte FacialStyle { get; set; }
        public byte CustomDisplay1 { get; set; }
        public byte CustomDisplay2 { get; set; }
        public byte CustomDisplay3 { get; set; }
        public byte InventorySlots { get; set; }
        public byte BankSlots { get; set; }
        public byte RestState { get; set; }
        public int PlayerFlags { get; set; }
        public int PlayerFlagsEx { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public short Map { get; set; }
        public int InstanceId { get; set; }
        public byte DungeonDifficulty { get; set; }
        public byte RaidDifficulty { get; set; }
        public byte LegacyRaidDifficulty { get; set; }
        public float Orientation { get; set; }
        public string Taximask { get; set; }
        public byte Online { get; set; }
        public byte Cinematic { get; set; }
        public int Totaltime { get; set; }
        public int Leveltime { get; set; }
        public int LogoutTime { get; set; }
        public byte IsLogoutResting { get; set; }
        public float RestBonus { get; set; }
        public int ResettalentsCost { get; set; }
        public int ResettalentsTime { get; set; }
        public int PrimarySpecialization { get; set; }
        public float TransX { get; set; }
        public float TransY { get; set; }
        public float TransZ { get; set; }
        public float TransO { get; set; }
        public long Transguid { get; set; }
        public short ExtraFlags { get; set; }
        public byte StableSlots { get; set; }
        public short AtLogin { get; set; }
        public short Zone { get; set; }
        public int DeathExpireTime { get; set; }
        public string TaxiPath { get; set; }
        public int TotalKills { get; set; }
        public short TodayKills { get; set; }
        public short YesterdayKills { get; set; }
        public int ChosenTitle { get; set; }
        public int WatchedFaction { get; set; }
        public byte Drunk { get; set; }
        public int Health { get; set; }
        public int Power1 { get; set; }
        public int Power2 { get; set; }
        public int Power3 { get; set; }
        public int Power4 { get; set; }
        public int Power5 { get; set; }
        public int Power6 { get; set; }
        public int Latency { get; set; }
        public byte ActiveTalentGroup { get; set; }
        public int LootSpecId { get; set; }
        public string ExploredZones { get; set; }
        public string EquipmentCache { get; set; }
        public string KnownTitles { get; set; }
        public byte ActionBars { get; set; }
        public byte GrantableLevels { get; set; }
        public int? DeleteInfosAccount { get; set; }
        public string DeleteInfosName { get; set; }
        public int? DeleteDate { get; set; }
        public int Honor { get; set; }
        public int HonorLevel { get; set; }
        public int PrestigeLevel { get; set; }
        public byte HonorRestState { get; set; }
        public float HonorRestBonus { get; set; }
        public int LastLoginBuild { get; set; }

        public virtual ICollection<CharacterGarrisonFollowers> CharacterGarrisonFollowers { get; set; }
    }
}
