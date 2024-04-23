using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        public PokedexPage()
        {
            this.InitializeComponent();


            //C:\Users\agust\Desktop\UCLM\3 CURSO\SEGUNDO CUATRIMESTRE\IPO2\LABORATORIO\POKEMON_PERSONAL\ipo2-pokedex\bin\x86\Debug\AppX

            string json = System.IO.File.ReadAllText(@"pokemonList.json");
            Pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);


            foreach(Pokemon pokemon in Pokemons)
            {
                TemplatePokemon template = new TemplatePokemon(pokemon);
                this.gvPokemons.Items.Add(template);
                this.PokemonsAux.Add(pokemon);
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
    }
}
