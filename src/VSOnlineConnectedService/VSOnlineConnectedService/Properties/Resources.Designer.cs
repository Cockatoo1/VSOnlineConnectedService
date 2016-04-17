﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VSOnlineConnectedService.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VSOnlineConnectedService.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scaffolding code will provide a prompt for non-default credentials to be specified at runtime to authenticate to VSOnline..
        /// </summary>
        public static string Auth_BasicAuthDescription {
            get {
                return ResourceManager.GetString("Auth_BasicAuthDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Basic Authentication.
        /// </summary>
        public static string Auth_BasicAuthTitle {
            get {
                return ResourceManager.GetString("Auth_BasicAuthTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scaffolding code will use the runtime caller&apos;s Windows credentials to authenticate to VSOnline..
        /// </summary>
        public static string Auth_IntegratedAuthDescription {
            get {
                return ResourceManager.GetString("Auth_IntegratedAuthDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integrated Authentication.
        /// </summary>
        public static string Auth_IntegratedAuthTitle {
            get {
                return ResourceManager.GetString("Auth_IntegratedAuthTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Used when running in headless scenarios, where you need a username/password in the app as there&apos;s no user interaction.
        /// </summary>
        public static string Auth_ServiceAccountDescription {
            get {
                return ResourceManager.GetString("Auth_ServiceAccountDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service Account w/Username and Password.
        /// </summary>
        public static string Auth_ServiceAccountTitle {
            get {
                return ResourceManager.GetString("Auth_ServiceAccountTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://github.com/SteveLasker/VSOnlineConnectedService/blob/master/Docs/GettingStarted/GettingStarted.md.
        /// </summary>
        public static string GettingStartedURL {
            get {
                return ResourceManager.GetString("GettingStartedURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How will your app authenticate to Visual Studio Online at runtime?.
        /// </summary>
        public static string RuntimeAuthPageDescription {
            get {
                return ResourceManager.GetString("RuntimeAuthPageDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Visual Studio Online.
        /// </summary>
        public static string RuntimeAuthPageTitle {
            get {
                return ResourceManager.GetString("RuntimeAuthPageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runtime Auth.
        /// </summary>
        public static string RunttimeAuthPageLegend {
            get {
                return ResourceManager.GetString("RunttimeAuthPageLegend", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the Server.
        /// </summary>
        public static string TeamProjectPageDescription {
            get {
                return ResourceManager.GetString("TeamProjectPageDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection.
        /// </summary>
        public static string TeamProjectPageLegend {
            get {
                return ResourceManager.GetString("TeamProjectPageLegend", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Visual Studio Online.
        /// </summary>
        public static string TeamProjectPageTitle {
            get {
                return ResourceManager.GetString("TeamProjectPageTitle", resourceCulture);
            }
        }
    }
}
