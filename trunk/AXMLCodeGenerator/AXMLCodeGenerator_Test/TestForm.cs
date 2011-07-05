using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AXMLCodeGenerator_Test
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AXMLCodeGenerator.ControlParser cParser = new AXMLCodeGenerator.ControlParser();
            this.tbCSharp.Text = cParser.GenerateClass(this.tbViewName.Text, this.tbActivityName.Text, this.tbNamespace.Text, this.tbAXML.Text);
        }
    }
}
