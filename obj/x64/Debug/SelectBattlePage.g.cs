﻿#pragma checksum "C:\Users\Usuario\Desktop\Universidad\CURSOS\3º CURSO\2º Cuatrimestre\Interacción Persona-Ordenador 2 (IPO 2)\Laboratorio\2º Entrega\SelectBattlePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B63D393501EE99AD59BAD1DA4F28B0323A0F7E324FD1C41AEEBB651AEC93EED"
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
    partial class SelectBattlePage : 
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
            case 2: // SelectBattlePage.xaml line 10
                {
                    this.gsepectabattle = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // SelectBattlePage.xaml line 15
                {
                    this.onevsone = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.onevsone).Click += this.onevsone_Click;
                }
                break;
            case 4: // SelectBattlePage.xaml line 16
                {
                    this.onevsia = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.onevsia).Click += this.onevsia_Click;
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

