using LOLHelper.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using LOLHelper.Entity;
using Flurl.Http.Configuration;

namespace LOLHelper.Common
{

    public class LCUApi
    {

        public static string GetAuthVal()
        {
            return $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"riot:{Global.lcuToken.RemotingAuthToken}"))}";
        }
        /// <summary>
        /// 获取LCU的请求地址
        /// </summary>
        /// <returns>请求地址</returns>
        public static string GetBaseUrl()
        {
            return $"https://riot:{Global.lcuToken.RemotingAuthToken}@127.0.0.1:{Global.lcuToken.AppPort}/";
        }

        /// <summary>
        /// 获取当前登录用户的详细信息
        /// </summary>
        /// <returns>用户信息</returns>
        public static async Task<Summoner> GetLoginInfo()
        {
            return await $"{GetBaseUrl()}lol-summoner/v1/current-summoner"
                .WithHeader("Authorization", GetAuthVal())
                .GetJsonAsync<Summoner>();
        }

        /// <summary>
        /// 获取当前对局聊天组
        /// </summary>
        /// <returns></returns>
        public static async Task<string> GetCurrConversationID()
        {

            return await $"{GetBaseUrl()}lol-chat/v1/conversations"
                .WithHeader("Authorization", GetAuthVal())
                .GetStringAsync();
        }

        /// <summary>
        /// 往游戏聊天窗口发送信息
        /// </summary>
        /// <param name="conversationID">聊天室ID</param>
        /// <param name="msg">消息内容</param>
        public static void SendConversationMsg(string conversationID, string msg)
        {
            $"{GetBaseUrl()}lol-chat/v1/conversations/{conversationID}/messages"
                .WithHeader("Authorization", GetAuthVal())
                .PostJsonAsync(new { body = msg, type = "chat" }).Wait();
        }

        /// <summary>
        /// 接受游戏对局
        /// </summary>
        public static void AcceptGame()
        {
            $"{GetBaseUrl()}lol-matchmaking/v1/ready-check/accept".WithHeader("Authorization", GetAuthVal())
                .PostJsonAsync(new { }).Wait();
        }


    }
}
