﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
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
    public sealed partial class MoreInformation : Page
    {
        public MoreInformation()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Doubts), this);
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("https://github.com/AgustinESI");
            await Launcher.LaunchUriAsync(uri);
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("https://github.com/RobertOrt1");
            await Launcher.LaunchUriAsync(uri);
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("https://github.com/Miriamltn");
            await Launcher.LaunchUriAsync(uri);
        }
        
    }
}
