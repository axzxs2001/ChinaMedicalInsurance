using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalInsuranceTest
{


    [Serializable]
    public class Entity1 : MedicalInsuranceBase.MedicalInsuranceEntity
    {
        public override string EntityType
        {
            get
            {
                return "挂号";
            }
        }

        public int ID
        { get; set; }

        public string Name
        { get; set; }
    }
}
