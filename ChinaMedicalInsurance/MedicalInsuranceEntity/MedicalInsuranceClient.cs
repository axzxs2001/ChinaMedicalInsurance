using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Configuration;
namespace MedicalInsuranceBase
{
    /// <summary>
    /// 客户端
    /// </summary>
    public class MedicalInsuranceClient
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
        /// 取配置文件
        /// </summary>
        public MedicalInsuranceClient()
        {
            _ip = ConfigurationManager.AppSettings["ip"];
            int.TryParse(ConfigurationManager.AppSettings["port"], out _port);
        }
        /// <summary>
        /// 处理发送和接收接实体
        /// </summary>
        /// <param name="entity">传送实体</param>
        /// <returns></returns>
        public MedicalInsuranceEntity Handle(MedicalInsuranceEntity entity)
        {
            var client = new TcpClient(_ip, _port);  
            var stream = client.GetStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, entity);    
            var backEntity = formatter.Deserialize(stream) as MedicalInsuranceEntity;
            return backEntity;
        }       

    }
}
