using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalInsuranceBase
{
    /// <summary>
    /// 医保接口总异常
    /// </summary>
    public class MedicalInsuranceException : Exception
    {
        /// <summary>
        /// 医保接口总异常构造
        /// </summary>
        /// <param name="message">异常信息</param>
        public MedicalInsuranceException(string message) : base(message)
        {
          
        }
    }
}
