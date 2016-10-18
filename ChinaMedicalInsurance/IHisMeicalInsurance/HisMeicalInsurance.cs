using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HisMeicalInsurance
{
    /// <summary>
    /// HIS与医保DLL对接的接口，这是HIS与医保DLL之间的桥梁，本接口必需在HIS中实现（可用反射）
    /// </summary>
    public interface HisMeicalInsurance
    {
        /// <summary>
        /// 调用接口方法
        /// </summary> 
        /// <param name="parmeter">HIS与医保DLL数据互通的桥梁，可自行协订HIS与医保DLL传递的参数</param>
        /// <returns></returns>
        short Invoke(dynamic parmeter);
    }
}
