using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ipo2_pokedex
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    /// 
    public sealed partial class PokemonDetailPage : Page
    {
        public Pokemon poke;
        private bool isVoiceReaderActive = false;
        private VoiceReader voiceReader;
        public PokemonDetailPage()
        {
            this.InitializeComponent();
            voiceReader = new VoiceReader();
        }



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Verificar si se pasó un objeto Pokemon como parámetro
            if (e.Parameter is Pokemon pokemon)
            {
                this.poke = pokemon;
                this.name.Text = pokemon.name;
                this.image.Source = new BitmapImage(new Uri(pokemon.image));
                this.specie.Text = pokemon.specie;
                this.description.Text = pokemon.description;
                this.id.Text = pokemon.id;
                this.width.Text = "WT: " + pokemon.weight;
                this.heigth.Text = "HT: " + pokemon.height;
                voiceReader.LeerTexto(pokemon.name);
                ;

                if (pokemon.captured)
                {
                    this.pokeball.Opacity = 100;
                }

                string[] types = pokemon.type.Split(',');

                if (types.Length == 2)
                {
                    this.type1.Source = this.getPokemonType(types[0]);
                    this.type2.Source = this.getPokemonType(types[1]);
                }
                else
                {
                    this.type1.Source = this.getPokemonType(types[0]);
                }

            }
        }

        private ImageSource getPokemonType(string v)
        {

            ImageSource imag = null;

            switch (v)
            {
                case "Bug":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/6/6e/latest/20191113212836/Tipo_bicho.png/120px-Tipo_bicho.png"));
                    break;
                case "Dark":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/5/5a/latest/20191113212950/Tipo_siniestro.png/120px-Tipo_siniestro.png"));
                    break;
                case "Dragon":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/c/cb/latest/20191113212836/Tipo_drag%C3%B3n.png/120px-Tipo_drag%C3%B3n.png"));
                    break;
                case "Electric":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/5/5d/latest/20191113212836/Tipo_el%C3%A9ctrico.png/120px-Tipo_el%C3%A9ctrico.png"));
                    break;
                case "Fighting":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/f/f9/latest/20191221233728/Tipo_lucha.png/120px-Tipo_lucha.png"));
                    break;
                case "Fairy":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/5/59/latest/20191113212837/Tipo_hada.png/120px-Tipo_hada.png"));
                    break;
                case "Fire":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/a/a7/latest/20191113212837/Tipo_fuego.png/120px-Tipo_fuego.png"));
                    break;
                case "Flying":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/9/9d/latest/20191113212951/Tipo_volador.png/120px-Tipo_volador.png"));
                    break;
                case "Ghost":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/5/5f/latest/20191113212837/Tipo_fantasma.png/120px-Tipo_fantasma.png"));
                    break;
                case "Grass":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/c/ca/latest/20191113212949/Tipo_planta.png/120px-Tipo_planta.png"));
                    break;
                case "Ground":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/7/7d/latest/20191113212951/Tipo_tierra.png/120px-Tipo_tierra.png"));
                    break;
                case "Ice":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/1/13/latest/20191113212837/Tipo_hielo.png/120px-Tipo_hielo.png"));
                    break;
                case "Normal":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/c/c4/latest/20191221233818/Tipo_normal.png/120px-Tipo_normal.png"));
                    break;
                case "Poison":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/9/92/latest/20191113212951/Tipo_veneno.png/120px-Tipo_veneno.png"));
                    break;
                case "Psychic":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/f/f5/latest/20191113212950/Tipo_ps%C3%ADquico.png/120px-Tipo_ps%C3%ADquico.png"));
                    break;
                case "Rock":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/0/05/latest/20191113212950/Tipo_roca.png/120px-Tipo_roca.png"));
                    break;
                case "Steel":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/e/e1/latest/20191113212835/Tipo_acero.png/120px-Tipo_acero.png"));
                    break;
                case "Water":
                    imag = new BitmapImage(new Uri("https://images.wikidexcdn.net/mwuploads/wikidex/thumb/6/64/latest/20191113212835/Tipo_agua.png/120px-Tipo_agua.png"));
                    break;
            }
            return imag;
        }

        private void width_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void viewPokemon(object sender, PointerRoutedEventArgs e)
        {
            Frame PokemonDetailPage = (Frame)this.Parent;
            PokemonDetailPage.Navigate(typeof(ViewPokemonPage), this);
            string texto = "Ver Pokemon";
            voiceReader.LeerTexto(texto);
        }
    }
}
