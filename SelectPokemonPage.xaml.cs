using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ipo2_pokedex
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class SelectPokemonPage : Page
    {


        List<Pokemon> Pokemons { get; set; }
        List<Pokemon> PokemonsAux1 { get; set; } = new List<Pokemon>();
        List<Pokemon> PokemonsAux2 { get; set; } = new List<Pokemon>();

        public int option = 0;

        public Dictionary<string, object> Selection { get; set; } = new Dictionary<string, object>();

        public SelectPokemonPage()
        {
            this.InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            await readFile();
        }
        private async Task readFile()
        {

            //string json = System.IO.File.ReadAllText(@"pokemonList.json");
            //Pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);

            StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            Windows.Storage.StorageFile sampleFile = await appFolder.GetFileAsync(@"pokemonList.json");

            string text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            Pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(text);

            foreach (Pokemon pokemon in Pokemons)
            {
                if (pokemon.captured == true)
                {
                    TemplatePokemon template = new TemplatePokemon(pokemon);
                    this.gvPokemonsPlayer1.Items.Add(template);
                    this.PokemonsAux1.Add(pokemon);
                }
            }

        }


        protected override void OnNavigatedTo(NavigationEventArgs e) // Terminado
        {
            // Metodo que sirve para heredar atributos de la page anterior
            base.OnNavigatedTo(e);
            var Padre = (SelectBattlePage)e.Parameter;
            this.option = Padre.option;
        }

        private void pokemon1Selected(object sender, SelectionChangedEventArgs e)
        {

            Pokemon selectedPokemon = PokemonsAux1[this.gvPokemonsPlayer1.SelectedIndex];

            Selection["p1"] = selectedPokemon;

            this.gvPokemonsPlayer2.Visibility = Visibility.Visible;

            foreach (Pokemon pokemon in PokemonsAux1)
            {
                if (!selectedPokemon.name.Equals(pokemon.name))
                {
                    this.PokemonsAux2.Add(pokemon);
                    TemplatePokemon template = new TemplatePokemon(pokemon);
                    this.gvPokemonsPlayer2.Items.Add(template);
                }
            }

            this.gvPokemonsPlayer1.IsItemClickEnabled = false;


        }

        private void pokemon2Selected(object sender, SelectionChangedEventArgs e)
        {

            Pokemon selectedPokemon = PokemonsAux2[this.gvPokemonsPlayer2.SelectedIndex];
            Selection["p2"] = selectedPokemon;
            Selection["option"] = this.option;
            Frame.Navigate(typeof(BattlePage), this);

            this.gvPokemonsPlayer1.IsItemClickEnabled = false;

        }
    }
}



