﻿using System.Collections.Concurrent;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Linq;
using System.Collections.Generic;
using OPUPMS.Infrastructure.Common.Operator;

namespace OPUPMS.Restaurant.Web
{
    [HubName("systemHub")]
    public class MyHub : Hub
    {
        private static Dictionary<string, string> OnLineUsers = new Dictionary<string, string>();

        [HubMethodName("notifyResServiceRefersh")]
        /// <summary>
        /// 根据操作结果通知所有用户刷新餐厅实时状态数据
        /// </summary>
        /// <returns></returns>
        public async Task NotifyResServiceRefersh(bool result)
        {
            await Clients.All.callResServiceRefersh(result);
        }

        [HubMethodName("test")]
        public async Task Test(string message)
        {
            //await Clients.All.test("测试所有用户");
            var operatorUser = OperatorProvider.Provider.GetCurrent();
            await Clients.Group(operatorUser.DepartmentId).test("测试组的用户");
        }

        [HubMethodName("userLoginOut")]
        public async Task UserLoginOut()
        {
            var operatorUser = OperatorProvider.Provider.GetCurrent();
            await Groups.Remove(GetClientId(), operatorUser.DepartmentId);
        }

        [HubMethodName("userConnected")]
        public async Task UserConnected()
        {
            var operatorUser = OperatorProvider.Provider.GetCurrent();
            await Groups.Add(GetClientId(), operatorUser.DepartmentId);
        }


        //public override System.Threading.Tasks.Task OnConnected()
        //{
        //    string clientName = Context.QueryString["clientName"].ToString();
        //    OnLineUsers.AddOrUpdate(Context.ConnectionId, clientName, (key, value) => clientName);
        //    Clients.All.userChange(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), string.Format("{0} 加入了。", clientName), OnLineUsers.ToArray());
        //    return base.OnConnected();
        //}

        //public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        //{
        //    string clientName = Context.QueryString["clientName"].ToString();
        //    Clients.All.userChange(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), string.Format("{0} 离开了。", clientName), OnLineUsers.ToArray());
        //    OnLineUsers.TryRemove(Context.ConnectionId, out clientName);
        //    return base.OnDisconnected(stopCalled);
        //}

        //public override Task OnConnected()
        //{
        //    string clientId = GetClientId();

        //    if (Users.IndexOf(clientId) == -1)
        //    {
        //        Users.Add(clientId);
        //    }
        //    return base.OnConnected();
        //}

        private string GetClientId()
        {
            string clientId = "";
            
            if (Context.QueryString["clientId"] != null)
            {
                // clientId passed from application 
                clientId = this.Context.QueryString["clientId"];
            }

            if (string.IsNullOrEmpty(clientId.Trim()))
            {
                clientId = Context.ConnectionId;
            }

            return clientId;
        }
    }
}