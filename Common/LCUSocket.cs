using LOLHelper.Const;
using LOLHelper.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace LOLHelper.Common
{
    public class LCUSocket
    {

        public static async void Connect()
        {
            var client = new ClientWebSocket();
            client.Options.RemoteCertificateValidationCallback = delegate { return true; };
            client.Options.SetRequestHeader("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"riot:{Global.lcuToken.RemotingAuthToken}"))}");
            Uri uri = new Uri($"wss://127.0.0.1:{Global.lcuToken.AppPort}");
            CancellationTokenSource t = new CancellationTokenSource();
            await client.ConnectAsync(uri, t.Token);
            if (client.State == WebSocketState.Open)
            {
                Global.debugForm.Log("WebSocket连接建立完成");
            }
            // 发送消息订阅客户端事件

            await client.SendAsync(Encoding.UTF8.GetBytes("[5, \"OnJsonApiEvent\"]"), WebSocketMessageType.Text, true, t.Token);
            while (true)
            {
                //全部消息容器
                List<byte> bs = new List<byte>();
                //缓冲区
                var buffer = new byte[1024 * 4];

                WebSocketReceiveResult result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), new CancellationToken());

                //是否关闭
                while (!result.CloseStatus.HasValue)
                {
                    //文本消息
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        bs.AddRange(buffer.Take(result.Count));

                        //消息是否已接收完全
                        if (result.EndOfMessage)
                        {
                            //发送过来的消息
                            string userMsg = Encoding.UTF8.GetString(bs.ToArray(), 0, bs.Count);

                            if (!String.IsNullOrEmpty(userMsg)) 
                            {
                                List<object> list = JsonConvert.DeserializeObject<List<object>>(userMsg);
                                JObject token = (JObject)list[2];
                                string eventUri = token["uri"].ToString();
                                switch (eventUri)
                                {
                                    case LCUEvent.GameFlowChangedEvt:
                                        string gameflow = token["data"].ToString();
                                        Global.debugForm.Log("游戏流程变动"+ gameflow);
                                        switch (gameflow) 
                                        {
                                            case "ReadyCheck":
                                                LCUApi.AcceptGame();
                                                Global.debugForm.Log("找到对局，已自动接受");
                                                break;
                                        }
                                        break;
                                    case LCUEvent.ChampSelectUpdateSessionEvt:
                                        。ChampionSelect championSelect = JsonConvert.DeserializeObject<ChampionSelect>(token.ToString());
                                        if (championSelect.eventType.Equals("Update")) 
                                        {
                                          Task<string> task =  LCUApi.GetCurrConversationID();
                                            var convId = task.Result.ToString();
                                            List<object> convList = JsonConvert.DeserializeObject<List<object>>(convId);
                                            if(convList.Count != 0)
                                            {
                                                JObject cId = (JObject)convList[0];
                                                string id = cId["id"].ToString();
                                                LCUApi.SendConversationMsg(id,"欢迎使用雨轩LOL小助手，您当前选择的英雄ID:" + championSelect.data.actions[0][0].championId);
                                                Global.debugForm.Log("英雄选择变动：" + (championSelect.data.actions[0][0].completed ? "锁定" : "未锁定") + championSelect.data.actions[0][0].championId);
                                            }
                                           
                                            
                                        }
                                        if (championSelect.eventType.Equals("Delete")) 
                                        {
                                            Global.debugForm.Log("退出角色选择");
                                        }
                                        break;
                                 
                                }

                            }
                            //清空消息容器
                            bs = new List<byte>();
                        }
                    }
                    //继续监听Socket信息
                    if(client.State == WebSocketState.Open) 
                    {
                        result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    }
                    
                }

            }
        }
    }
}
