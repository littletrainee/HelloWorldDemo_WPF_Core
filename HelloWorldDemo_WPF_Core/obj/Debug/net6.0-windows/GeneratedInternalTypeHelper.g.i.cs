﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace XamlGeneratedNamespace {
    
    
    /// <summary>
    /// GeneratedInternalTypeHelper
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class GeneratedInternalTypeHelper : System.Windows.Markup.InternalTypeHelper {
        
        /// <summary>
        /// CreateInstance
        /// </summary>
        protected override object CreateInstance(System.Type type, System.Globalization.CultureInfo culture) {
            return System.Activator.CreateInstance(type, ((System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic) 
                            | (System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.CreateInstance)), null, null, culture);
        }
        
        /// <summary>
        /// GetPropertyValue
        /// </summary>
        protected override object GetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, System.Globalization.CultureInfo culture) {
            return propertyInfo.GetValue(target, System.Reflection.BindingFlags.Default, null, null, culture);
        }
        
        /// <summary>
        /// SetPropertyValue
        /// </summary>
        protected override void SetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, object value, System.Globalization.CultureInfo culture) {
            propertyInfo.SetValue(target, value, System.Reflection.BindingFlags.Default, null, null, culture);
        }
        
        /// <summary>
        /// CreateDelegate
        /// </summary>
        protected override System.Delegate CreateDelegate(System.Type delegateType, object target, string handler) {
            return ((System.Delegate)(target.GetType().InvokeMember("_CreateDelegate", (System.Reflection.BindingFlags.InvokeMethod 
                            | (System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)), null, target, new object[] {
                        delegateType,
                        handler}, null)));
        }
        
        /// <summary>
        /// AddEventHandler
        /// </summary>
        protected override void AddEventHandler(System.Reflection.EventInfo eventInfo, object target, System.Delegate handler) {
            eventInfo.AddEventHandler(target, handler);
        }
    }
}

