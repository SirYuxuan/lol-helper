using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLHelper.Entity
{
    public class RerollPoints
    {
        /// <summary>
        /// 
        /// </summary>
        public long currentPoints { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long maxRolls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long numberOfRolls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long pointsCostToRoll { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long pointsToReroll { get; set; }
    }
    public class Summoner
    {
        /// <summary>
        /// 
        /// </summary>
        public long accountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string displayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string internalName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nameChangeFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long percentCompleteForNextLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string privacy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long profileIconId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string puuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public RerollPoints rerollPoints { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long summonerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long summonerLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unnamed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long xpSinceLastLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long xpUntilNextLevel { get; set; }
    }
}
