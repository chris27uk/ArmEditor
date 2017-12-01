using ArmEditor.Properties;

namespace DashSub
{
    public static class ParamReplace
    {
        public static string GetParameters(string dashboardName)
        {
            return Resources.Parameters.Replace("##NAME", dashboardName);
        }
    }
}
