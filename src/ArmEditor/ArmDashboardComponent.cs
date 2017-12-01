using Newtonsoft.Json.Linq;

namespace ArmEditor
{
    public class ArmDashboardComponent
    {
        private JObject json;

        public ArmDashboardComponent(string title, JObject json)
        {
            this.json = json; 
            this.Title = string.IsNullOrEmpty(title) ? "System Generated" : title;
        }

        public string Title { get; }

        public JObject ToJson()
        {
            return this.json;
        }
    }
}
