using System;

namespace UserDemo
{
    public class UltraAwesomeClass : IUltraAwesomeClass
    {
        public string MyProperty1 { get; set; } = "Ultratest1";
        public string MyProperty2 { get; set; } = Guid.NewGuid().ToString();
    }
}
