﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArmEditor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ArmEditor.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;https://schema.management.azure.com/schemas/2015-01-01/deploymentParameters.json#&quot;,
        ///  &quot;contentVersion&quot;: &quot;1.0.0.0&quot;,
        ///  &quot;parameters&quot;: {
        ///    &quot;resourceGroupName&quot;: {
        ///      &quot;value&quot;: &quot;#{ResourceGroup.Name}&quot;
        ///    },
        ///    &quot;subscriptionId&quot;: {
        ///      &quot;value&quot;: &quot;#{AzureSubscriptionId}&quot;
        ///    },
        ///    &quot;appInsightsName&quot;: {
        ///      &quot;value&quot;: &quot;#{ApplicationInsights.Name}&quot;
        ///    },
        ///    &quot;dashboardId&quot;: {
        ///      &quot;value&quot;: &quot;##NAME#{EnvironmentTypeShort}#{EnvironmentNumber}&quot;
        ///    },
        ///    &quot;dashboardName&quot;: {
        ///      &quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Parameters {
            get {
                return ResourceManager.GetString("Parameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#&quot;,
        ///  &quot;contentVersion&quot;: &quot;1.0.0.0&quot;,
        ///  &quot;parameters&quot;: {
        ///    &quot;appInsightsName&quot;: {
        ///      &quot;type&quot;: &quot;string&quot;
        ///    },
        ///    &quot;dashboardId&quot;: {
        ///      &quot;type&quot;: &quot;string&quot;
        ///    },
        ///    &quot;dashboardName&quot;: {
        ///      &quot;type&quot;: &quot;string&quot;
        ///    },
        ///    &quot;dashboardDisplayName&quot;: {
        ///      &quot;type&quot;: &quot;string&quot;
        ///    },
        ///    &quot;resourceGroupName&quot;: {
        ///      &quot;type&quot;: &quot;string&quot;
        ///    },
        ///    &quot;subscriptionId&quot;: {
        ///      &quot;type&quot;: &quot;string&quot;
        ///    }
        ///  },
        ///  &quot;varia [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TopSection {
            get {
                return ResourceManager.GetString("TopSection", resourceCulture);
            }
        }
    }
}
