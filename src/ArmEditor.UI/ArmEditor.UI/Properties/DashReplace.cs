using System;
using System.Text;
using System.Text.RegularExpressions;
using DashSub.Properties;

namespace DashSub
{
    public static class DashReplace
    {
        public static string ParameteriseText(string text)
        {
            text = ReplaceValue(text, @".*""SubscriptionId"":.*", @"""SubscriptionId"": ""[parameters('subscriptionId')]"",");
            text = ReplaceValue(text, @".*""ResourceGroup"":.*", @"""ResourceGroup"": ""[parameters('resourceGroupName')]"",");
            text = ReplaceValue(text, @".*""Name"":.*", @"""Name"": ""[parameters('appInsightsName')]""");

            text = ReplaceValue(text, @".*""value"": ""\/subscriptions\/.*", @"""value"": ""/subscriptions/[parameters('subscriptionId')]/resourceGroups/dashboards/providers/Microsoft.Portal/dashboards/[parameters('dashboardId')]""");

            text = ReplaceValue(text, @".*""dashboardPartSubTitle"":.*",
                @"""dashboardPartSubTitle"": ""[parameters('appInsightsName')]""");

            text = ReplaceValue(text, @".*""PartSubTitle"",\s*""value"".*",
                @"""name"": ""PartSubTitle"",
                      ""value"": ""[parameters('appinsightsName')]""");

            var metadata = @"""metadata"": {}," + Environment.NewLine + @"apiVersion"": ""2015-08-01-preview"","
                           + Environment.NewLine + @"""name"": ""[parameters('dashboardName')]"",";

            text = ReplaceValue(text, @".*""id"": ""\/subscriptions\/.*\s*""name"".*", metadata);

            text = ReplaceValue(text, @".*""hidden-title"":.*", @"""hidden-title"": ""[parameters('dashboardDisplayName')]""");
            
            var sb = new StringBuilder(text);

            sb.Insert(0, Resources.TopSection);

            return sb.ToString();
        }

        private static string ReplaceValue(string text, string pattern, string replacement)
        {
            var rgx = new Regex(pattern);
            return rgx.Replace(text, replacement);
        }


    }
}
