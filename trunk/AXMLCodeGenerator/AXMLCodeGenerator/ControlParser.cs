using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AXMLCodeGenerator.Properties;
using System.Xml;

namespace AXMLCodeGenerator
{
    public class ControlParser
    {
        /// <summary>
        /// Generates a new partial C# class. Every control from the axml
        /// will be accessable over this class.
        /// </summary>
        /// <param name="ViewName">Name of the View</param>
        /// <param name="ActivityName">Activity name (for partial usage)</param>
        /// <param name="NameSpace">Namespace of the class</param>
        /// <param name="aXMLContent">Content of the axml File</param>
        /// <returns>Designer Class for Mono for Android</returns>
        public string GenerateClass(string ViewName, string ActivityName, string NameSpace, string aXMLContent)
        {
            //Will be used to replace all the patterns
            StringBuilder designerClass = new StringBuilder(Resources.template_cs);

            //Generate Keys and Values
            Dictionary<string, string> varList = CreateControlList(aXMLContent);

            //Replacement
            designerClass.Replace("%NameSpace%", NameSpace);
            designerClass.Replace("%ActivityName%", ActivityName);
            designerClass.Replace("%ViewName%", ViewName);
            designerClass.Replace("%controlVars%", CreateVariableDefinitionList(varList));
            designerClass.Replace("%VarsInitial%", CreateVariableInitList(varList));

            return designerClass.ToString();
        }

        /// <summary>
        /// Creates a directionary of controls
        /// </summary>
        /// <param name="axml">Content of the axml File</param>
        /// <returns>Dictionary with controls and types</returns>
        private Dictionary<string, string> CreateControlList(string axml)
        {
            Dictionary<string, string> controlList = new Dictionary<string, string>();
            XmlDocument xdoc = new XmlDocument();

            xdoc.LoadXml(axml);

            foreach (XmlElement xE in xdoc.ChildNodes[1].ChildNodes)
            {
                if (xE.HasAttribute("android:id"))
                {
                    controlList.Add(xE.Attributes["android:id"].Value.Replace("@+id/", ""), xE.Name);
                }
            }

            return controlList;
        }

        private string CreateVariableDefinitionList(Dictionary<string, string> controlDir)
        {
            StringBuilder defList = new StringBuilder();

            foreach (KeyValuePair<string, string> varDef in controlDir)
            {
                defList.AppendLine("private " + varDef.Value + " " + varDef.Key + ";");
            }

            return defList.ToString();
        }

        private string CreateVariableInitList(Dictionary<string, string> controlDir)
        {
            StringBuilder initList = new StringBuilder();

            foreach (KeyValuePair<string, string> varDef in controlDir)
            {
                initList.AppendLine(varDef.Key + " = FindViewById<" + varDef.Value + ">(Resource.Id." + varDef.Key + ");");
            }

            return initList.ToString();
        }
    }
}
