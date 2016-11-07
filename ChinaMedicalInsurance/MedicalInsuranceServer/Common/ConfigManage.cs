using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace MedicalInsuranceServer.Common
{
    /// <summary>
    /// 配置文件管理
    /// </summary>
    class ConfigManage
    {
        /// <summary>
        /// 写配置文件
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        internal static void WriteConfig(string name, string value)
        {

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[name] == null)
            {
                config.AppSettings.Settings.Add(name, value);
            }
            else
            {
                config.AppSettings.Settings[name].Value = value;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");//重新加载新的配置文件   

        }
        /// <summary>
        /// 读配置文件
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static string ReateConfig(string name)
        {
           return  ConfigurationManager.AppSettings[name];
        }
    }
}
