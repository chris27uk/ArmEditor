using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArmEditor.UI.Properties;
using DashSub;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ArmEditor.UI
{
    public partial class AddDashboardComponent : Form
    {
        public AddDashboardComponent()
        {
            InitializeComponent();
        }

        public ArmDashboardComponent Component => new ArmDashboardComponent(textBoxTitle.Text, CreateJson());

        private JObject CreateJson()
        {
            var replace1 = Regex.Replace(Resources.ComponentJson, "##Query", textBoxQuery.Text);
            var replace2 = Regex.Replace( replace1, "##title", textBoxTitle.Text);
            return JObject.Parse(Regex.Replace(replace2, "##subtitle", ""));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //DashReplace.ParameteriseText()
        }
    }
}
