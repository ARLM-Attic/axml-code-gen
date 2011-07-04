using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AXMLCodeGenerator_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string axmlContent = File.ReadAllText("Login.axml");
            AXMLCodeGenerator.ControlParser cParser = new AXMLCodeGenerator.ControlParser();

            string designerclass = cParser.GenerateClass("Login", "Activity1", "Test", axmlContent);
        }
    }
}
