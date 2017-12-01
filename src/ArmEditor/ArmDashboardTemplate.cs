using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ArmEditor
{
    public class ArmDashboardTemplate
    {
        private readonly string content;

        public static ArmDashboardTemplate FromNew()
        {
            return FromFile("starttemplate.json");
        }

        public static ArmDashboardTemplate FromFile(string dialogFileName)
        {
            string content = File.ReadAllText(dialogFileName);
            return new ArmDashboardTemplate(content);
        }

        private ArmDashboardTemplate(string content)
        {
            this.Children = new List<ArmDashboardComponent>();
            dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
            dynamic realObj = JObject.FromObject(obj)?.resources?.First ??
                              JObject.FromObject(obj);

            foreach (var node in realObj.properties.lenses)
            {
                foreach (var part in ((JObject) node.Value.parts))
                {
                    dynamic dynPart = (JObject)part.Value;
                    string title = dynPart.metadata.settings != null
                        ? dynPart.metadata.settings.content.dashboardPartTitle
                        : "";
                    Children.Add(new ArmDashboardComponent(title, (JObject)part.Value));
                }
            }
            this.content = content;
        }

        public void AddDashboardComponent(ArmDashboardComponent component)
        {
            this.Children.Add(component);
        }

        public List<ArmDashboardComponent> Children { get; set; }

        public override string ToString()
        {
            dynamic obj = JsonConvert.DeserializeObject(this.content);
            var children = this.Children.Select(c => c.ToJson()).ToArray();
            var doc = JObject.FromObject(obj);
            var realObj = doc.resources?.First ?? doc;
            realObj.properties.lenses = new JArray(children);
            return ((JObject)doc).ToString(Formatting.Indented);
        }
    }
}
