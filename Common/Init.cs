using Flurl.Http;
using LOLHelper.Common.Flurl;
using LOLHelper.Const;
using LOLHelper.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace LOLHelper.Common
{
    public class Init
    {
        /// <summary>
        /// 初始化数据
        /// </summary>
        public static void Load()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += (s, e1) =>
            {
                if (ThreadUtil.ExistProcesses(Global.LOL_NAME))
                {
                    StartLOL();
                }
                else
                {
                    EndLOL();
                    Global.debugForm.Log("未检测到活动的LOL进程");
                }

            };
            timer.Start();


        }
        /// <summary>
        /// LOL开始运行
        /// </summary>
        private static void StartLOL()
        {
            // 当前处于开启状态，不在进行初始化
            if (Global.IS_OPEN)
            {
                return;
            }
            Global.IS_OPEN = true;
            string commandLine = ThreadUtil.GetCommandLines(Global.LOL_NAME);

            LCUToken lcuToken = new LCUToken();

            int appPort = Convert.ToInt32(new Regex("--app-port=([0-9]*)").Match(commandLine).Groups[1].Value);
            lcuToken.AppPort = appPort;

            string remotingAuthToken = new Regex(@"--remoting-auth-token=([\w-]*)").Match(commandLine).Groups[1].Value;
            lcuToken.RemotingAuthToken = remotingAuthToken;

            int riotClientPort = Convert.ToInt32(new Regex("--riotclient-app-port=([0-9]*)").Match(commandLine).Groups[1].Value);
            lcuToken.RiotClientPort = riotClientPort;

            string riotClientAuthToken = new Regex(@"--riotclient-auth-token==([\w-]*)").Match(commandLine).Groups[1].Value;
            lcuToken.RiotClientAuthToken = riotClientAuthToken;

            Global.lcuToken = lcuToken;

            Global.debugForm.Log($"检测到LOL运行中: AppPort: {appPort}、RemotingAuthToken: {remotingAuthToken}");

            // 初始化Flurl忽略证书安全
            FlurlHttp.ConfigureClient($"https://127.0.0.1:{Global.lcuToken.AppPort}/", cli =>
            {
                cli.Settings.HttpClientFactory = new UntrustedCertClientFactory();
            });


            // 获取当前登录用户信息
            Task<Summoner> task  = LCUApi.GetLoginInfo();
            Global.debugForm.Log($"当前登录用户：{task.Result.displayName}");

            // 初始化WebSocket链接 监听客户端状态
            LCUSocket.Connect();

        }
        /// <summary>
        /// LOL停止运行
        /// </summary>
        private static void EndLOL()
        {
            Global.IS_OPEN = false;
        }
    }
}
