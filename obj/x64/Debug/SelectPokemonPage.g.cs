﻿#pragma checksum "C:\Users\agust\Desktop\UCLM\3 CURSO\SEGUNDO CUATRIMESTRE\IPO2\LABORATORIO\POKEMON_PERSONAL\git\ipo2-pokedex\SelectPokemonPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40DD633A657A862715A959ADB672E1F9E44C03FB9DC9CC7313290464B6E5D769"
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
    partial class SelectPokemonPage : 
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
            case 2: // SelectPokemonPage.xaml line 19
                {
                    this.tbplayer1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // SelectPokemonPage.xaml line 28
                {
                    this.gvPokemonsPlayer1 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.gvPokemonsPlayer1).SelectionChanged += this.pokemon1Selected;
                }
                break;
            case 4: // SelectPokemonPage.xaml line 29
                {
                    this.gvPokemonsPlayer2 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.gvPokemonsPlayer2).SelectionChanged += this.pokemon2Selected;
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

