﻿#pragma checksum "C:\Users\yukse.DESKTOP-46EUPBS\source\repos\Otobüs Bİleti Alim Satim Otomasyonu\Otobüs Bİleti Alim Satim Otomasyonu\Secimekrani.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5ED86AA809A82C540B9C6D98FFC0375D321F4CDA483D87A2C1FCF64F0672E311"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otobüs_Bİleti_Alim_Satim_Otomasyonu
{
    partial class Secimekrani : 
        global::Microsoft.UI.Xaml.Window, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Secimekrani.xaml line 57
                {
                    this.bltgunc = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.bltgunc).Click += this.bltgunc_Click;
                }
                break;
            case 3: // Secimekrani.xaml line 68
                {
                    this.bltgor = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.bltgor).Click += this.Button_Click;
                }
                break;
            case 4: // Secimekrani.xaml line 31
                {
                    this.bltalbtn = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.bltalbtn).Click += this.bltalbtn_Click;
                }
                break;
            case 5: // Secimekrani.xaml line 42
                {
                    this.bltiptal = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.bltiptal).Click += this.bltiptal_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
