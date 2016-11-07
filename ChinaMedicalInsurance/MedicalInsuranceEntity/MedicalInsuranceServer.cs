using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Configuration;
using System.Net;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
namespace MedicalInsuranceBase
{
    /// <summary>
    /// 服务端
    /// </summary>
    public class MedicalInsuranceServer
    {
        /// <summary>
        /// IP地址
        /// </summary>
        string _ip;
        /// <summary>
        /// 端口号
        /// </summary>
        int _port;
        /// <summary>
        /// TCP/IP监听
        /// </summary>
        TcpListener _listener;
        public MedicalInsuranceServer()
        {
            _ip = ConfigurationManager.AppSettings["ip"];
            int.TryParse(ConfigurationManager.AppSettings["port"], out _port);
        }
        /// <summary>
        /// 开始监听
        /// </summary>
        public void Start()
        {
            _listener = new TcpListener(IPAddress.Parse(_ip), _port);
            _listener.Start();
            var thread = new Thread(AcceptClient);
            thread.Start(_listener);
        }
        /// <summary>
        /// 停止监听
        /// </summary>
        public void Stop()
        {
            _listener.Stop();
        }
        /// <summary>
        /// 循环接收客户端连接
        /// </summary>
        /// <param name="obj"></param>
        void AcceptClient(object obj)
        {
            var listener =obj as TcpListener;
            while (true)
            {
                var client = listener.AcceptTcpClient();
                var thread = new Thread(Handle);
                thread.Start(client);
            }
        }
        /// <summary>
        /// 处理收发交易
        /// </summary>
        /// <param name="obj">客户端连接</param>
        void Handle(object obj)
        {
            var client = obj as TcpClient;
            var stream = client.GetStream();
            var formatter = new BinaryFormatter();
            var entity = formatter.Deserialize(stream) as MedicalInsuranceEntity;

            if (AcceptEntity != null)
            {
                var backEntity = AcceptEntity(entity);
                formatter.Serialize(stream,backEntity);
            }else
            {              
                throw new MedicalInsuranceException("SendEvent为空");
            }
        }
        /// <summary>
        /// 接收到实体类事件
        /// </summary>
        public event AcceptEntityHandler AcceptEntity;


    }

   
}
