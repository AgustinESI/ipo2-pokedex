﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ipo2_pokedex
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class SelectBattlePage : Page
    {
        public int option = 0;
        private bool isVoiceReaderActive = false;
        private VoiceReader voiceReader;

        public SelectBattlePage()
        {
            this.InitializeComponent();
            voiceReader = new VoiceReader();
        }

        private void onevsone_Click(object sender, RoutedEventArgs e)
        {
            this.option = 1;
            Frame.Navigate(typeof(SelectPokemonPage), this);
            var button = sender as Button;
            if (button != null)
            {
                string texto = "Uno Versus Uno";
                voiceReader.LeerTexto(texto);
            }
        }

        private void onevsia_Click(object sender, RoutedEventArgs e)
        {
            this.option = 2;
            Frame.Navigate(typeof(SelectPokemonPage), this);
            var button = sender as Button;
            if (button != null)
            {
                string texto = "Uno Versus IA";
                voiceReader.LeerTexto(texto);
            }
        }
    }
}
