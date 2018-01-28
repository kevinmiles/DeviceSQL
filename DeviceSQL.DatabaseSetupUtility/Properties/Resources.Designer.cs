﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeviceSQL.DatabaseSetupUtility.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DeviceSQL.DatabaseSetupUtility.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] DeviceSQL {
            get {
                object obj = ResourceManager.GetObject("DeviceSQL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to USE master
        ///GO
        ///sp_configure &apos;show advanced options&apos;, 1;
        ///GO
        ///RECONFIGURE;
        ///GO
        ///sp_configure &apos;clr enabled&apos;, 1;
        ///GO
        ///RECONFIGURE;
        ///GO
        ///CREATE ASYMMETRIC KEY [DeviceSqlKey] FROM EXECUTABLE FILE = &apos;##_ASYMMETRIC_KEY_EXECUTABLE_FILE#&apos;
        ///CREATE LOGIN [DeviceSqlClrLogin] FROM ASYMMETRIC KEY [DeviceSqlKey]
        ///GRANT UNSAFE ASSEMBLY TO [DeviceSqlClrLogin].
        /// </summary>
        internal static string DeviceSQL_Install_Script_01 {
            get {
                return ResourceManager.GetString("DeviceSQL_Install_Script_01", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE DATABASE [DeviceSQL] 
        ///
        ///GO 
        ///USE [DeviceSQL] 
        ///
        ///PRINT N&apos;Creating [ChannelManager]...&apos;;
        ///
        ///
        ///GO
        ///CREATE SCHEMA [ChannelManager]
        ///    AUTHORIZATION [dbo];
        ///
        ///
        ///GO
        ///PRINT N&apos;Creating [DeviceManager]...&apos;;
        ///
        ///
        ///GO
        ///CREATE SCHEMA [DeviceManager]
        ///    AUTHORIZATION [dbo];
        ///
        ///
        ///GO
        ///PRINT N&apos;Creating [MODBUSMaster]...&apos;;
        ///
        ///
        ///GO
        ///CREATE SCHEMA [MODBUSMaster]
        ///    AUTHORIZATION [dbo];
        ///
        ///
        ///GO
        ///PRINT N&apos;Creating [ROCMaster]...&apos;;
        ///
        ///
        ///GO
        ///CREATE SCHEMA [ROCMaster]
        ///    AUTHORIZATION [dbo];
        ///
        ///
        ///GO
        ///PRINT N&apos;Creating [Watchdog]...&apos;;
        ///
        ///
        ///GO
        ///CREATE SCHEMA [Wat [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DeviceSQL_Install_Script_02 {
            get {
                return ResourceManager.GetString("DeviceSQL_Install_Script_02", resourceCulture);
            }
        }
    }
}