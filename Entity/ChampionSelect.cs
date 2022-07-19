namespace LOLHelper.Entity
{
    public class ActionsItemItem
    {
        /// <summary>
        /// 
        /// </summary>
        public long actorCellId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long championId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool completed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isAllyAction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isInProgress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long pickTurn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
    }

    public class Bans
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> myTeamBans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long numBans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> theirTeamBans { get; set; }
    }

    public class ChatDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public string chatRoomName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string chatRoomPassword { get; set; }
    }

    public class EntitledFeatureState
    {
        /// <summary>
        /// 
        /// </summary>
        public long additionalRerolls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> unlockedSkinIds { get; set; }
    }

    public class MyTeamItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string assignedPosition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long cellId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long championId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long championPicklongent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string entitledFeatureType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long selectedSkinId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long spell1Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long spell2Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long summonerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long team { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long wardSkinId { get; set; }
    }

    public class Timer
    {
        /// <summary>
        /// 
        /// </summary>
        public long adjustedTimeLeftInPhase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long longernalNowInEpochMs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isInfinite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string phase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long totalTimeInPhase { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public List<List<ActionsItemItem>> actions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowBattleBoost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowDuplicatePicks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowLockedEvents { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowRerolling { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowSkinSelection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Bans bans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> benchChampionIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string benchEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long boostableSkinCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ChatDetails chatDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long counter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public EntitledFeatureState entitledFeatureState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long gameId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hasSimultaneousBans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hasSimultaneousPicks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isCustomGame { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isSpectating { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long localPlayerCellId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long lockedEventIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MyTeamItem> myTeam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long recoveryCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long rerollsRemaining { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string skipChampionSelect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> theirTeam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Timer timer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> trades { get; set; }
    }

    public class ChampionSelect
    {
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string eventType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uri { get; set; }
    }

}
