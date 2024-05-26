using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ipo2_pokedex
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MiniGamePage : Page
    {

        List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
        List<Pokemon> PokemonsSelected { get; set; } = new List<Pokemon>();
        private Pokemon GuessPokemon { get; set; } = new Pokemon();
        private string UpgradePokemon ="";
        private int Lifes = 3;
        private int PokemonsToWin = 6;
        private string p1nameAux;
        private string p2nameAux;
        private string p3nameAux;
        private string p4nameAux;

        private bool isVoiceReaderActive = false;
        private VoiceReader voiceReader;
        public MiniGamePage()
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
            StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            Windows.Storage.StorageFile sampleFile = await appFolder.GetFileAsync(@"pokemonList.json");

            string text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            Pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(text);


        

            foreach (Pokemon pokemon in Pokemons)
            {
                

                if (pokemon.captured)
                {
                    if (this.cbpokemonsupgrade.Items.Count == 0)
                    {
                        UpgradePokemon = pokemon.name;
                    }

                    this.cbpokemonsupgrade.Items.Add(pokemon.name);
                }
            }
            this.cbpokemonsupgrade.SelectedIndex = 0;

            this.generatePokemons();

        }

        private void generatePokemons()
        {
            HashSet<int> randmonNumbers = new HashSet<int>();
            this.PokemonsSelected = new List<Pokemon>();


            while (randmonNumbers.Count < 4)
            {
                int randomNumber = new Random().Next(Pokemons.Count);
                if (!randmonNumbers.Contains(randomNumber))
                {
                    randmonNumbers.Add(randomNumber);
                    PokemonsSelected.Add(Pokemons[randomNumber]);
                }
            }


            this.p1.Source = new BitmapImage(getPokemonType(this.PokemonsSelected[0]));
            this.p1image.Source = new BitmapImage(new Uri(this.PokemonsSelected[0].image));
            this.p1description.Text = this.PokemonsSelected[0].description.Replace(this.PokemonsSelected[0].name, "****");
            this.p1description.Text = this.p1description.Text.Replace(this.PokemonsSelected[0].name.ToUpper(), "****");
            this.p1name.Text = "****";
            p1nameAux = this.PokemonsSelected[0].name;
            this.p1types.Text = this.PokemonsSelected[0].type;

            this.p2.Source = new BitmapImage(getPokemonType(this.PokemonsSelected[1]));
            this.p2image.Source = new BitmapImage(new Uri(this.PokemonsSelected[1].image));
            this.p2description.Text = this.PokemonsSelected[1].description.Replace(this.PokemonsSelected[1].name, "****");
            this.p2description.Text = this.p2description.Text.Replace(this.PokemonsSelected[1].name.ToUpper(), "****");
            this.p2name.Text = "****";
            p2nameAux = this.PokemonsSelected[1].name;
            this.p2types.Text = this.PokemonsSelected[1].type;

            this.p3.Source = new BitmapImage(getPokemonType(this.PokemonsSelected[2]));
            this.p3image.Source = new BitmapImage(new Uri(this.PokemonsSelected[2].image));
            this.p3description.Text = this.PokemonsSelected[2].description.Replace(this.PokemonsSelected[2].name, "****");
            this.p3description.Text = this.p3description.Text.Replace(this.PokemonsSelected[2].name.ToUpper(), "****");
            this.p3name.Text = "****";
            p3nameAux = this.PokemonsSelected[2].name;
            this.p3types.Text = this.PokemonsSelected[2].type;

            this.p4.Source = new BitmapImage(getPokemonType(this.PokemonsSelected[3]));
            this.p4image.Source = new BitmapImage(new Uri(this.PokemonsSelected[3].image));
            this.p4description.Text = this.PokemonsSelected[3].description.Replace(this.PokemonsSelected[3].name, "****");
            this.p4description.Text = this.p4description.Text.Replace(this.PokemonsSelected[3].name.ToUpper(), "****");
            this.p4name.Text = "****";
            p4nameAux = this.PokemonsSelected[3].name;
            this.p4types.Text = this.PokemonsSelected[3].type;

            GuessPokemon = this.PokemonsSelected[new Random().Next(this.PokemonsSelected.Count - 1)];
            this.message.Text = this.message.Text + "¿Que Pokemon es " + GuessPokemon.name + "?";
            string texto = "¿Que Pokemon es " + GuessPokemon.name + "?";
            voiceReader.LeerTexto(texto);

        }

        private Uri getPokemonType(Pokemon pokemon)
        {

            string[] types = pokemon.type.Split(",");

            if (types[0].Equals("Dark") || types[0].Equals("Dragon") || types[0].Equals("Electric") || types[0].Equals("Fighting") || types[0].Equals("Fire")
                || types[0].Equals("Grass") || types[0].Equals("Psychic") || types[0].Equals("Steel") || types[0].Equals("Water"))
            {
                return new Uri("ms-appx:///Assets/images/cards/" + types[0] + ".png");
            }
            return new Uri("ms-appx:///Assets/images/cards/Empty.png");

        }

        private void selectPokemon(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            var element = sender as FrameworkElement;

            // Check if the element is not null
            if (element != null)
            {
                // Get the name of the clicked element
                string elementName = element.Name;
                switch (elementName)
                {

                    case "p1select":
                        if (p1nameAux.Equals(this.GuessPokemon.name))
                        {
                            this.selectionOk();
                        }
                        else
                        {
                            this.selectionError();
                        }
                        break;
                    case "p2select":
                        if (p2nameAux.Equals(this.GuessPokemon.name))
                        {
                            this.selectionOk();
                        }
                        else
                        {
                            this.selectionError();
                        }
                        break;
                    case "p3select":
                        if (p3nameAux.Equals(this.GuessPokemon.name))
                        {
                            this.selectionOk();
                        }
                        else
                        {
                            this.selectionError();
                        }
                        break;
                    case "p4select":
                        if (p4nameAux.Equals(this.GuessPokemon.name))
                        {
                            this.selectionOk();
                        }
                        else
                        {
                            this.selectionError();
                        }
                        break;


                }

            }
        }

        private void selectionOk()
        {
            if (this.Lifes <= 3 && this.Lifes >= 1 && this.PokemonsToWin >= 0)
            {
                this.PokemonsToWin = this.PokemonsToWin - 1;
                this.istars.Source = new BitmapImage(new Uri("ms-appx:///Assets/images/stars/star-" + (6 - this.PokemonsToWin) + ".png"));
                this.tbstars.Text = "Aciertos: " + (6 - this.PokemonsToWin) + " /6";
                if (this.PokemonsToWin == 0)
                {
                    this.message.Text = "Superaste el reto! Subiste 400 xp a tu Pokemon "+this.UpgradePokemon;
                    string texto = "Superaste el reto! Subiste 400 xp a tu Pokemon ";
                    voiceReader.LeerTexto(texto);
                }
                else
                {
                    this.message.Text = "Correcto! ";
                    string texto = "¡Correcto!";
                    voiceReader.LeerTexto(texto);
                    this.generatePokemons();
                }

            }
        }

        private void selectionError()
        {
            if (this.Lifes <= 3 && this.Lifes >= 0)
            {
                this.Lifes = this.Lifes - 1;
                this.tblifes.Text = "Vidas:" + this.Lifes + "/3";
                this.ilifes.Source = new BitmapImage(new Uri("ms-appx:///Assets/images/hearts/hearts-" + this.Lifes + ".png"));
                if (this.Lifes == 0)
                {
                    this.message.Text = "Has perdido!";
                    string texto = "Has perdido";
                    voiceReader.LeerTexto(texto);

                    this.p1select.Opacity = 40;
                    this.p1select.IsTapEnabled = false;

                    this.p2select.Opacity = 40;
                    this.p2select.IsTapEnabled = false;

                    this.p3select.Opacity = 40;
                    this.p3select.IsTapEnabled = false;

                    this.p4select.Opacity = 40;
                    this.p4select.IsTapEnabled = false;
                }
                else
                {
                    this.message.Text = "Te equivocaste de pokemon, te quedan " + this.Lifes + " vidas y " + this.PokemonsToWin + " Pokemons por acertar.";
                    string texto = "Te equivocaste de pokemon, te quedan " + this.Lifes + " vidas y " + this.PokemonsToWin + " Pokemons por acertar.";
                    voiceReader.LeerTexto(texto);
                }
            }
        }

        private async void createMessage(string message)
        {
            Windows.UI.Popups.MessageDialog dialog = new Windows.UI.Popups.MessageDialog("Element clicked: " + message);
            dialog.ShowAsync();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbpokemonsupgrade.SelectedItem != null)
            {
                string name = cbpokemonsupgrade.SelectedItem.ToString();
                this.UpgradePokemon = name;
            }
        }
    }


}
