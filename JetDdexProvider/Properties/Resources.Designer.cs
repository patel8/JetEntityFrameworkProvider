﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JetDdexProvider.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JetDdexProvider.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Jet.
        /// </summary>
        internal static string DataView_Jet {
            get {
                return ResourceManager.GetString("DataView_Jet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tables.
        /// </summary>
        internal static string Node_Tables {
            get {
                return ResourceManager.GetString("Node_Tables", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Views.
        /// </summary>
        internal static string Node_Views {
            get {
                return ResourceManager.GetString("Node_Views", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is the Jet DDEX provider that uses the JetEntityFrameworkProvider to connect to Jet single file databases..
        /// </summary>
        internal static string Provider_Description {
            get {
                return ResourceManager.GetString("Provider_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jet DDEX provider for JetEntityFrameworkProvider.
        /// </summary>
        internal static string Provider_DisplayName {
            get {
                return ResourceManager.GetString("Provider_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JetEntityFrameworkProvider (DDEX).
        /// </summary>
        internal static string Provider_ShortDisplayName {
            get {
                return ResourceManager.GetString("Provider_ShortDisplayName", resourceCulture);
            }
        }
    }
}
