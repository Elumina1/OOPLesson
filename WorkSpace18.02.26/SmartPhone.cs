using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace18._02._26
{
    /// <summary>
    /// мобильный телефон
    /// </summary>
    public class SmartPhone : Product
    {
        public string Color { get; set; }
        public int Memory { get; set; }
        public int MPCamera { get; set; }
        public string OperatingSystem { get; set; }
        public string CPU { get; set; }
    }
}
