﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NegoShoePH.Data.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=ffdfa40e-f8a0-463e-8261-a73600cf33c0.sqlserver.sequelizer.com;Database=dbf" +
            "fdfa40ef8a0463e8261a73600cf33c0;User ID=ksaizignkybiwsan;Password=Xa3ewN3VujdtXc" +
            "rpPHEGgAEMRr8NeHKAXh3civBTXm8Uq4RxNVMsmzzwBouePnQT;")]
        public string NegoShoeInventoryConnectionString {
            get {
                return ((string)(this["NegoShoeInventoryConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ffdfa40e-f8a0-463e-8261-a73600cf33c0.sqlserver.sequelizer.com;Persist" +
            " Security Info=True;User ID=ksaizignkybiwsan;Password=Xa3ewN3VujdtXcrpPHEGgAEMRr" +
            "8NeHKAXh3civBTXm8Uq4RxNVMsmzzwBouePnQT")]
        public string DataSourceConnectionString {
            get {
                return ((string)(this["DataSourceConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQL2012;Initial Catalog=NegoShoeInventory;Integrated Security=True")]
        public string NegoShoeInventoryConnectionString1 {
            get {
                return ((string)(this["NegoShoeInventoryConnectionString1"]));
            }
        }
    }
}
