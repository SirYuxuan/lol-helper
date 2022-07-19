using LOLHelper.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLHelper.Const
{
    internal class Global
    {
        // 是否开启Debug模式
        public const bool DEBUG = true;

        // LOL进程名
        public const string LOL_NAME = "LeagueClientUx";

        // 当前LOL进程是否启动
        public static bool IS_OPEN = false;

        // 当前LOL客户端的信息
        public static LCUToken? lcuToken;

        // 调试窗口对象
        public static Debug.Debug? debugForm;
    }
}
