using System;
using System.Collections.Generic;
using System.Drawing;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace ipo2_pokedex
{
    public sealed partial class TemplatePokemon : UserControl
    {
        public TemplatePokemon(Pokemon pokemon)
        {
            this.InitializeComponent();

            this.id.Text = pokemon.id.ToString();
            this.name.Text = pokemon.name;
            this.type.Text = pokemon.type;
            this.Image.Source = new BitmapImage(new Uri(pokemon.image));
            if (pokemon.captured)
            {
                this.pokeball.Visibility = Visibility.Visible;
            }



        }


     
        private void Grid_PointerEntered(object sender, PointerRoutedEventArgs e)
        {

            //string hexColor = "#FF0000"; 
            //Color color = (Color)ColorConverter.ConvertFromString(hexColor);
            //SolidColorBrush backgroundBrush = new SolidColorBrush(color);
            //Window.Current.Content.Background = backgroundBrush;

        }
    }
}
