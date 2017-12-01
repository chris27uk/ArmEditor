using System.Collections.Generic;

namespace ArmEditor.UI.ViewModels
{
    public class NodeWithChildrenViewModel : ITemplateComponent
    {
        public NodeWithChildrenViewModel() { }

        public NodeWithChildrenViewModel(string name) : this(name, new List<ITemplateComponent>())
        {
        }

        public NodeWithChildrenViewModel(string name, List<ITemplateComponent> children)
        {
            this.Name = name;
            this.Children = children;
        }

        public List<ITemplateComponent> Children
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }
    }
}
