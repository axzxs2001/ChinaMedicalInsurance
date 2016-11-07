using MedicalInsuranceBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MedicalInsuranceServer.Common
{
    class CommonHandle
    {
        /// <summary>
        /// 反射得到实现IDllOperation的类型
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        internal static IDllOperation GetDllOperation(string dir)
        {
            foreach (var file in System.IO.Directory.GetFiles(dir))
            {
                if (Path.GetExtension(file).ToUpper() == ".DLL")
                {
                    //加载程序集
                    var assembly = Assembly.LoadFile(file);
                    foreach (var type in assembly.GetTypes())
                    {
                        //判断是从IDllOperation继承的子类
                        if (!type.IsInterface && !type.IsAbstract && type.GetInterface("IDllOperation") != null)
                        {
                            return Activator.CreateInstance(type) as IDllOperation;
                        }
                    }
                }
            }
            foreach (var subdir in System.IO.Directory.GetDirectories(dir))
            {
                return GetDllOperation(subdir);
            }
            return null;
        }
    }
}
