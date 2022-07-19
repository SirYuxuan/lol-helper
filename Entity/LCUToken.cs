using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLHelper.Entity
{
    public class LCUToken
    {
        public int AppPort
        {
            get; set;
        }

        public string? RemotingAuthToken
        {
            get; set;
        }

        public int RiotClientPort
        {
            get; set;
        }

        public string? RiotClientAuthToken
        {
            get;
            set;
        }
    }
}
