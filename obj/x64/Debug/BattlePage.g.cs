﻿#pragma checksum "C:\Users\Usuario\Desktop\Universidad\CURSOS\3º CURSO\2º Cuatrimestre\Interacción Persona-Ordenador 2 (IPO 2)\Laboratorio\2º Entrega\BattlePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "29D0EEE0A5EF95549F5371FE39CDDB3DBE2E369C828B1A7393679FEE32A1DD18"
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
    partial class BattlePage : 
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
            case 2: // BattlePage.xaml line 31
                {
                    this.p1actions = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // BattlePage.xaml line 58
                {
                    this.p2actions = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // BattlePage.xaml line 84
                {
                    this.message = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // BattlePage.xaml line 76
                {
                    this.p2strong = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.p2strong).Click += this.p2StrongAttack;
                }
                break;
            case 6: // BattlePage.xaml line 77
                {
                    this.p2weak = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.p2weak).Click += this.p2WeakAttack;
                }
                break;
            case 7: // BattlePage.xaml line 78
                {
                    this.p2flee = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.p2flee).Click += this.p2Flee;
                }
                break;
            case 8: // BattlePage.xaml line 79
                {
                    this.p2name = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // BattlePage.xaml line 80
                {
                    this.p2ultrabeast = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.p2ultrabeast).Click += this.p2doultrabeast;
                }
                break;
            case 10: // BattlePage.xaml line 49
                {
                    this.p1strong = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.p1strong).Click += this.p1StrongAttack;
                }
                break;
            case 11: // BattlePage.xaml line 50
                {
                    this.p1weak = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.p1weak).Click += this.p1WeakAttack;
                }
                break;
            case 12: // BattlePage.xaml line 51
                {
                    this.p1flee = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.p1flee).Click += this.p1Flee;
                }
                break;
            case 13: // BattlePage.xaml line 52
                {
                    this.p1ultrabeast = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.p1ultrabeast).Click += this.p1doultrabeast;
                }
                break;
            case 14: // BattlePage.xaml line 53
                {
                    this.p1name = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // BattlePage.xaml line 27
                {
                    this.pokemon2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 16: // BattlePage.xaml line 24
                {
                    this.pokemon1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
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

