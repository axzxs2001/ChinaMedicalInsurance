using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;


namespace HisMeicalInsurance
{
    /// <summary>
    /// 动态参数
    /// </summary>
    public class DynamicParameter : DynamicObject
    {
        Dictionary<string, dynamic> dic;
        public DynamicParameter()
        {
            dic = new Dictionary<string, dynamic>();
        }

        /// <summary>
        /// 获取值
        /// </summary>
        /// <param name="binder"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public override bool TryGetMember(GetMemberBinder binder, out dynamic result)
        {
            var name = binder.Name;
            if (dic.ContainsKey(name))
            {
                result = dic[name];
            }
            else
            {
                result = null;
            }
            return true;

        }
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="binder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool TrySetMember(SetMemberBinder binder, dynamic value)
        {
            var name = binder.Name;
            if (dic.Keys.Contains(name))
            {
                dic[name] = value;
            }
            else
            {
                dic.Add(name, value);
            }
            return true;
        }
    }
}
