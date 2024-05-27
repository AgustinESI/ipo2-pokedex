using System;
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
    public sealed partial class ViewPokemonPage : Page
    {
        public ViewPokemonPage()
        {
            this.InitializeComponent();

       

         
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) // Terminado
        {
            // Metodo que sirve para heredar atributos de la page anterior
            base.OnNavigatedTo(e);
            var Padre = (PokemonDetailPage)e.Parameter;
            Pokemon pokemon = Padre.poke;

            if (this.Charizard.Name == pokemon.name)
            {
                this.Charizard.Visibility = Visibility.Visible;
            }

            if (this.Piplup.Name == pokemon.name)
            {
                this.Piplup.Visibility = Visibility.Visible;
            }

            if (this.Snorlax.Name == pokemon.name)
            {
                this.Snorlax.Visibility = Visibility.Visible;
            }

            if (this.Articuno.Name == pokemon.name)
            {
                this.Articuno.Visibility = Visibility.Visible;
            }

            if (this.Pikachu.Name == pokemon.name)
            {
                this.Pikachu.Visibility = Visibility.Visible;
            }

            if (this.Dragonite.Name == pokemon.name)
            {
                this.Dragonite.Visibility = Visibility.Visible;
            }

            if (this.Gengar.Name == pokemon.name)
            {
                this.Gengar.Visibility = Visibility.Visible;
            }

            if (this.Grookey.Name == pokemon.name)
            {
                this.Grookey.Visibility = Visibility.Visible;
            }

            if (this.Lapras.Name == pokemon.name)
            {
                this.Lapras.Visibility = Visibility.Visible;
            }

            if (this.Scizor.Name == pokemon.name)
            {
                this.Scizor.Visibility = Visibility.Visible;
            }

            if (this.Toxicroak.Name == pokemon.name)
            {
                this.Toxicroak.Visibility = Visibility.Visible;
            }

            if (this.Squirtle.Name == pokemon.name)
            {
                this.Squirtle.Visibility = Visibility.Visible;
            }

            if(this.Chandelure.Name == pokemon.name)
            {
                this.Chandelure.Visibility = Visibility.Visible;
            }

        }

    }
}
