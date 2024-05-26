using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ipo2_pokedex
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PokedexPage : Page
    {

        List<Pokemon> Pokemons { get; set; }
        List<Pokemon> PokemonsAux { get; set; } = new List<Pokemon>();
        Boolean captured = false;
        private bool isVoiceReaderActive = false;
        private VoiceReader voiceReader;

        public PokedexPage()
        {
            this.InitializeComponent();

            this.Loaded += MainPage_Loaded;
            voiceReader = new VoiceReader();

        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Execute the readFile method here
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
                TemplatePokemon template = new TemplatePokemon(pokemon);
                this.gvPokemons.Items.Add(template);
                this.PokemonsAux.Add(pokemon);
            }

        }

        private async void writeFile()
        {

            //json =  JsonConvert.SerializeObject(Pokemons);
            //System.IO.File.WriteAllText(@"pokemonList.json", json);

            try
            {
               string json = JsonConvert.SerializeObject(Pokemons);
               // System.IO.File.WriteAllText(@"pokemonList.json", json);
                
                StorageFolder installedFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                Windows.Storage.StorageFile pokemonListInstalledFolder = await installedFolder.GetFileAsync(@"pokemonList.json");
                await Windows.Storage.FileIO.WriteTextAsync(pokemonListInstalledFolder, json);


                string path = installedFolder.Path;
                path = path.Replace("\\", "/");
                path = path.Replace("/bin/x64/Debug/AppX", "");
                path = path;

                StorageFolder localFolder = await StorageFolder.GetFolderFromPathAsync(@path);
                Windows.Storage.StorageFile pokemonListLocalFolder = await localFolder.GetFileAsync(@"pokemonList.json");
                await Windows.Storage.FileIO.WriteTextAsync(pokemonListLocalFolder, json);
                
            }
            catch (Exception ex) { 
                throw ex;
            }

            

        }

        private void searchPokemon(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            this.gvPokemons.Items.Clear();
            this.PokemonsAux.Clear();

            foreach (Pokemon p in Pokemons)
            {
                if (p.name.ToLower().Contains(this.tbSearch.Text.ToLower()))
                {
                    PokemonsAux.Add(p);
                    TemplatePokemon template = new TemplatePokemon(p);
                    this.gvPokemons.Items.Add(template);
                }

            }

        }

        private void pokemonSearch(object sender, SelectionChangedEventArgs e)
        {

            Pokemon pokemon = PokemonsAux[this.gvPokemons.SelectedIndex];
            Frame.Navigate(typeof(PokemonDetailPage), pokemon);
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.gvPokemons.Items.Clear();
            this.PokemonsAux.Clear();

            var button = sender as Button;
            /*if (button != null)
            {
                string texto = "Pokemons Capturados";
                voiceReader.LeerTexto(texto);
            }*/

            if (this.captured)
            {
                foreach (Pokemon p in Pokemons)
                {
                    if (button != null)
                    {
                        string texto = "Pokemons  No Capturados";
                        voiceReader.LeerTexto(texto);
                    }
                    PokemonsAux.Add(p);
                    TemplatePokemon template = new TemplatePokemon(p);
                    this.gvPokemons.Items.Add(template);
                    
                }
                captured = false;
            }
            else
            {
                foreach (Pokemon p in Pokemons)
                {
                    if (p.captured)
                    {
                        if (button != null)
                        {
                            string texto = "Pokemons Capturados";
                            voiceReader.LeerTexto(texto);
                        }
                        PokemonsAux.Add(p);
                        TemplatePokemon template = new TemplatePokemon(p);
                        this.gvPokemons.Items.Add(template);
                        
                    }
                }
                captured = true;
            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {

            foreach (Pokemon pokemon in Pokemons) { 
            
                if (pokemon.name.Equals("Charizard"))
                {
                    pokemon.name = "Chorizo";
                    break;
                }
            }


            writeFile();

            //string json = JsonConvert.SerializeObject(Pokemons);
            //System.IO.File.WriteAllText(@"pokemonList.json", json);
        }
    }
}
