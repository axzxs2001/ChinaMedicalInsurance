using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalInsuranceDll_Entity
{
    [Serializable]
    public class ClinicRegisterBack : MedicalInsuranceBase.MedicalInsuranceEntity
    {
        public override string EntityType
        {
            get
            {
                return "挂号返回";
            }
        }

        public string RegisterID
        { get; set; }
    }
}
