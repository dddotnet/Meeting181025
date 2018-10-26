using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserDemo.Services
{
    public class ValuesService
    {
        private readonly IUltraAwesomeClass uac;
        private readonly IUltraAwesomeClass uac2;

        public ValuesService(IUltraAwesomeClass uac, IUltraAwesomeClass uac2)
        {
            this.uac = uac;
            this.uac2 = uac2;
        }

        public string[] GetValues()
        {
            var blubb = AwesomeClass.MyProperty1;
            return new string[] {
                "value1",
                "value2",
                blubb,
                this.uac.MyProperty1,
                this.uac2.MyProperty2 };
        }
    }
}
