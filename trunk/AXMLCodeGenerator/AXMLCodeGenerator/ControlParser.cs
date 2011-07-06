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
            List<AndroidControl> varList = CreateControlList(aXMLContent);

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
        private List<AndroidControl> CreateControlList(string axml)
        {
            List<AndroidControl> controlList = new List<AndroidControl>();
            XmlDocument xdoc = new XmlDocument();

            xdoc.LoadXml(axml);

            //Iterate over every Control in the First View -> Make fully rekursiv!
            foreach (XmlElement xE in xdoc.ChildNodes[1].ChildNodes)
            {
                AndroidControl andContr = new AndroidControl();
                andContr.Type = xE.Name;

                foreach (XmlAttribute xA in xE.Attributes)
                {
                    andContr.Attributes.Add(xA.Name, xA.Value);
                }

                controlList.Add(andContr);
            }

            return controlList;
        }

        /// <summary>
        /// Creates a definition list of all controls (with an ID)
        /// </summary>
        /// <param name="controlDir">List of controls</param>
        /// <returns>C# List of Controls</returns>
        private string CreateVariableDefinitionList(List<AndroidControl> controlDir)
        {
            StringBuilder defList = new StringBuilder();

            foreach (AndroidControl aCont in controlDir)
            {
                defList.AppendLine("private " + aCont.Type + " " + aCont.Attributes["android:id"].Replace("@+id/", "") + ";");
            }

            return defList.ToString();
        }

        /// <summary>
        /// Creates a list of intiialised vars
        /// </summary>
        /// <param name="controlDir">List of controls</param>
        /// <returns>C# initialisation list</returns>
        private string CreateVariableInitList(List<AndroidControl> controlDir)
        {
            StringBuilder initList = new StringBuilder();

            foreach (AndroidControl aCont in controlDir)
            {
                initList.AppendLine(aCont.Attributes["android:id"].Replace("@+id/", "") + " = FindViewById<" + aCont.Type + ">(Resource.Id." + aCont.Attributes["android:id"].Replace("@+id/", "") + ");");
            }

            return initList.ToString();
        }
    }
}
