using MedicalInsuranceBase;
using MedicalInsuranceDll_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalInsuranceDll_Test
{
    public class TestDllOperation : IDllOperation
    {
        public MedicalInsuranceEntity Operation(MedicalInsuranceEntity entity)
        {
            switch (entity.EntityType)
            {              
                case "挂号":
                    return ClinicRegisterOperation(entity);
                default:
                    return new NullEntity();
            }
        }
        /// <summary>
        /// 这里调用医保接口的挂号函数，需要的参数从entity中取，返的参数实例化一个新对象传回去
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public MedicalInsuranceEntity ClinicRegisterOperation(MedicalInsuranceEntity entity)
        {            
            return new ClinicRegisterBack() { RegisterID = "111111" };
        }
    }
}
