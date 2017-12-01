using System.Collections.Generic;

namespace ArmEditor
{
    public interface ITemplateComponent
    {
        string Name { get; }
        List<ITemplateComponent> Children { get; }
    }
}
