﻿#pragma checksum "C:\Users\Usuario\Source\Repos\ipo2-pokedex\MoreInformation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41C99635E60A3FE5BCBD2135933A9A837A01269ADE63DF769A28EF0D45382906"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ipo2_pokedex
{
    partial class MoreInformation : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MoreInformation.xaml line 20
                {
                    this.DesaText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // MoreInformation.xaml line 21
                {
                    this.btnDesarrolladores = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4: // MoreInformation.xaml line 22
                {
                    this.btnFAQ = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnFAQ).Click += this.Button_Click;
                }
                break;
            case 5: // MoreInformation.xaml line 26
                {
                    this.GitAgustin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.GitAgustin).Click += this.Button_Click_1;
                }
                break;
            case 6: // MoreInformation.xaml line 30
                {
                    this.GitRoberto = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.GitRoberto).Click += this.Button_Click_2;
                }
                break;
            case 7: // MoreInformation.xaml line 35
                {
                    this.GitMiriam = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.GitMiriam).Click += this.Button_Click_3;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

