using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AXMLCodeGenerator
{
    class AndroidControl
    {
        public string Type { get; set; }
        public Dictionary<string, string> Attributes { get; set; }

        public AndroidControl()
        {
            Attributes = new Dictionary<string, string>();
        }
    }
}
