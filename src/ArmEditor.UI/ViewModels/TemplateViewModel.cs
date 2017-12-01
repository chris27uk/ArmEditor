using ArmEditor;
using System.Collections.Generic;
using System;

namespace ArmEditor.UI.ViewModels
{
    public class TemplateViewModel
    {
        public TemplateViewModel()
        {
            this.Components = new[] 
            {
                new NodeWithChildrenViewModel("Parameters")
                {
                    Children =
                    {
                        new NodeWithChildrenViewModel("Parameter Name")
                    }
                },
                new NodeWithChildrenViewModel("Resources")
                {
                    Children =
                    {
                        new NodeWithChildrenViewModel("Dashboard Name")
                    }
                },
                new NodeWithChildrenViewModel("Variables")
                {
                    Children =
                    {
                        new NodeWithChildrenViewModel("Variable Name")
                    }
                }
            };
        }

        public IEnumerable<ITemplateComponent> Components { get; }
    }
}
