using Microsoft.Toolkit.Uwp.Notifications;
using PokemonNoelia;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;



// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ipo2_pokedex
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class BattlePage : Page
    {
        public Dictionary<string, object> Selection { get; set; } = new Dictionary<string, object>();
        public UserControl p1 = null;
        public UserControl p2 = null;
        private int option = 0;

        public Pokemon selectedPokemon1 = null;
        public Pokemon selectedPokemon2 = null;

        public int turn = 1;

        private bool isVoiceReaderActive = false;
        private VoiceReader voiceReader;

        public BattlePage()
        {
            this.InitializeComponent();
            voiceReader = new VoiceReader();




        }

        protected override void OnNavigatedTo(NavigationEventArgs e) // Terminado
        {
            // Metodo que sirve para heredar atributos de la page anterior
            base.OnNavigatedTo(e);
            var Parent = (SelectPokemonPage)e.Parameter;
            this.Selection = Parent.Selection;
            this.option = Parent.option;

            this.selectedPokemon1 = this.Selection["p1"] as Pokemon;
            this.selectedPokemon2 = this.Selection["p2"] as Pokemon;

            this.p1 = this.GetPokemon(this.Selection["p1"] as Pokemon);
            this.p2 = this.GetPokemon(this.Selection["p2"] as Pokemon);


            this.pokemon1.Children.Add(this.p1);
            this.pokemon2.Children.Add(this.p2);
            this.p1name.Text = this.selectedPokemon1.name;
            this.p2name.Text = this.selectedPokemon2.name;

            if (this.selectedPokemon1.ultraBeast)
            {
                this.p1ultrabeast.Opacity = 100;
                this.p1ultrabeast.IsEnabled = true;
            }


            if (this.selectedPokemon2.ultraBeast)
            {
                this.p2ultrabeast.Opacity = 100;
                this.p2ultrabeast.IsEnabled = true;
            }


        }





        private UserControl GetPokemon(Pokemon pokemon)
        {


            switch (pokemon.name)
            {
                case "Charizard":
                    CharizardASM charizard = new CharizardASM();
                    charizard.verFondo(false);
                    charizard.Vida = pokemon.health;
                    charizard.Energia = 100;
                    charizard.verNombre(false);
                    //charizard.verFilaEnergia(false);
                    //charizard.verFilaVida(false);
                    charizard.verPocionEnergia(false);
                    charizard.verPocionVida(false);
                    return charizard;
                case "Piplup":
                    PiplupMLTN piplup = new PiplupMLTN();
                    piplup.verFondo(false);
                    piplup.Vida = pokemon.health;
                    piplup.Energia = 100;
                    //piplup.verFilaEnergia(false);
                    //piplup.verFilaVida(false);
                    piplup.verNombre(false);
                    piplup.verPocionEnergia(false);
                    piplup.verPocionVida(false);

                    return piplup;
                case "Snorlax":
                    SnorlaxROC snorlax = new SnorlaxROC();
                    snorlax.verFondo(false);
                    snorlax.Vida = pokemon.health;
                    snorlax.Energia = 100;
                    //snorlax.verFilaEnergia(false);
                    //snorlax.verFilaVida(false);
                    snorlax.verNombre(false);
                    snorlax.verPocionEnergia(false);
                    snorlax.verPocionVida(false);
                    return snorlax;

                case "Articuno":
                    ArticunoACG articuno = new ArticunoACG();
                    articuno.verFondo(false);
                    articuno.Vida = pokemon.health;
                    articuno.Energia = 100;
                    //articuno.verFilaEnergia(false);
                    //articuno.verFilaVida(false);
                    articuno.verNombre(false);
                    articuno.verPocionEnergia(false);
                    articuno.verPocionVida(false);
                    return articuno;
                case "Pikachu":
                    PikachuAPCC pikachu = new PikachuAPCC();
                    pikachu.verFondo(false);
                    pikachu.Vida = pokemon.health;
                    pikachu.Energia = 100;
                    //pikachu.verFilaEnergia(false);
                    //pikachu.verFilaVida(false);
                    pikachu.verNombre(false);
                    pikachu.verPocionEnergia(false);
                    pikachu.verPocionVida(false);
                    return pikachu;

                case "Dragonite":
                    DragoniteCSD dragonite = new DragoniteCSD();
                    dragonite.verFondo(false);
                    dragonite.Vida = pokemon.health;
                    dragonite.Energia = 100;
                    //dragonite.verFilaEnergia(false);
                    //dragonite.verFilaVida(false);
                    dragonite.verNombre(false);
                    dragonite.verPocionEnergia(false);
                    dragonite.verPocionVida(false);
                    return dragonite;

                case "Gengar":
                    GengarJCC gengar = new GengarJCC();
                    gengar.verFondo(false);
                    gengar.Vida = pokemon.health;
                    gengar.Energia = 100;
                    //gengar.verFilaEnergia(false);
                    //gengar.verFilaVida(false);
                    gengar.verNombre(false);
                    gengar.verPocionEnergia(false);
                    gengar.verPocionVida(false);
                    return gengar;
                case "Grookey":
                    GrookeyJGPMP grookey = new GrookeyJGPMP();
                    grookey.verFondo(false);
                    grookey.Vida = pokemon.health;
                    grookey.Energia = 100;
                    //grookey.verFilaEnergia(false);
                    //grookey.verFilaVida(false);
                    grookey.verNombre(false);
                    grookey.verPocionEnergia(false);
                    grookey.verPocionVida(false);
                    return grookey;

                case "Lapras":
                    LaprasACE lapras = new LaprasACE();
                    lapras.verFondo(false);
                    lapras.Vida = pokemon.health;
                    lapras.Energia = 100;
                    //lapras.verFilaEnergia(false);
                    //lapras.verFilaVida(false);
                    lapras.verNombre(false);
                    lapras.verPocionEnergia(false);
                    lapras.verPocionVida(false);
                    return lapras;

                case "Scizor":
                    ScizorAPJ scizor = new ScizorAPJ();
                    scizor.verFondo(false);
                    scizor.Vida = pokemon.health;
                    scizor.Energia = 100;
                    //scizor.verFilaEnergia(false);
                    //scizor.verFilaVida(false);
                    scizor.verNombre(false);
                    scizor.verPocionEnergia(false);
                    scizor.verPocionVida(false);
                    return scizor;

                case "Toxicroak":
                    ToxicroackJPG toxicroak = new ToxicroackJPG();
                    toxicroak.verFondo(false);
                    toxicroak.Vida = pokemon.health;
                    toxicroak.Energia = 100;
                    //toxicroak.verFilaEnergia(false);
                    //toxicroak.verFilaVida(false);
                    toxicroak.verNombre(false);
                    toxicroak.verPocionEnergia(false);
                    toxicroak.verPocionVida(false);
                    return toxicroak;

                case "Squirtle":
                    SquirtleJRSL1 squirtle = new SquirtleJRSL1();
                    squirtle.verFondo(false);
                    squirtle.Vida = pokemon.health;
                    squirtle.Energia = 100;
                    //squirtle.verFilaEnergia(false);
                    //squirtle.verFilaVida(false);
                    squirtle.verNombre(false);
                    squirtle.verPocionEnergia(false);
                    squirtle.verPocionVida(false);
                    return squirtle;

                case "Chandelure":
                    ChandelureNDAA chandelure = new ChandelureNDAA();
                    chandelure.verFondo(false);
                    chandelure.Vida = pokemon.health;
                    chandelure.Energia=100;
                    chandelure.verNombre(false);
                    chandelure.verPocionEnergia(false);
                    chandelure.verPocionEnergia(false);
                    //chandelure.verFilaEnergia(false);
                    //chandelure.verFilaVida(false);
                    return chandelure;

            }

            return null;
        }


        public double GetDamageMultiplier(Pokemon attackingPokemon, Pokemon defedingPokemon)
        {
            double[,] typeChart =
            {
                //      Grass Fire Water Psychic Bug  Dark Dragon Electric Fighting Fairy Flying Ghost Ground Ice Normal Poison Rock Steel
                /* Grass */  { 1,   0.5, 2,    1,      2,    1,   1,     1,      1,       1,    2,    1,     0.5,    1,  1,      1,    1,    0.5 },
                /* Fire */   { 2,   1,   0.5,  1,      1,    1,   1,     1,      1,       1,    1,    1,     1,      2,  1,      1,    1,    2   },
                /* Water */  { 0.5, 2,   1,    1,      1,    1,   1,     2,      1,       1,    1,    1,     1,      1,  1,      1,    1,    1   },
                /* Psychic */{ 1,   1,   1,    0.5,   1,    2,   1,     1,      2,       1,    1,    2,     1,      1,  1,      1,    1,    1   },
                /* Bug */    { 0.5, 2,   1,    1,      1,    2,   1,     1,      0.5,     1,    0.5,  2,     1,      1,  1,      1,    2,    0.5 },
                /* Dark */   { 1,   1,   1,    2,      2,    0.5, 1,     1,      2,       2,    1,    0.5,   1,      1,  1,      1,    1,    1   },
                /* Dragon */ { 1,   1,   1,    1,      1,    1,   2,     1,      1,       0.5,  2,    1,     1,      1,  1,      1,    1,    0.5 },
                /* Electric */{ 1,  1,   2,    1,      1,    1,   0.5,   1,      1,       1,    1,    0.5,   2,      1,  1,      1,    1,    1   },
                /* Fighting */{ 1,   1,   1,    0.5,   2,    2,   1,     1,      1,       1,    0.5,  2,     1,      1,  2,      2,    1,    0.5 },
                /* Fairy */  { 1,   1,   1,    1,      1,    2,   2,     1,      2,       0.5,  1,    1,     1,      1,  1,      1,    2,    1   },
                /* Flying */ { 0.5, 1,   1,    1,      2,    1,   1,     2,      0.5,     1,    1,    1,     1,      0,  1,      1,    2,    1   },
                /* Ghost */  { 1,   1,   1,    2,      1,    2,   1,     1,      1,       1,    1,    2,     1,      1,  1,      0,    1,    1   },
                /* Ground */ { 2,   2,   1,    1,      1,    1,   1,     0,      1,       1,    1,    1,     1,      1,  1,      1,    1,    1   },
                /* Ice */    { 1,   0.5, 1,    1,      1,    2,   1,     1,      2,       1,    1,    1,     1,      2,  1,      1,    1,    0.5 },
                /* Normal */{ 1,   1,   1,    1,      1,    1,   1,     1,      1,       1,    1,    1,     1,      1,  1,      1,    1,    1   },
                /* Poison */{ 1,   1,   1,    1,      1,    1,   1,     1,      1,       1,    2,    1,     1,      1,  1,      0.5,  0.5,  1   },
                /* Rock */   { 1,   0.5, 2,    1,      2,    1,   1,     1,      2,       1,    0.5,  2,     1,      1,  1,      1,    1,    0.5 },
                /* Steel */  { 1,   2,   1,    1,      1,    1,   1,     1,      1,       1,    1,    1,     1,      2,  1,      1,    1,    0.5 }
            };


            int attackingIndex = GetTypeIndex(attackingPokemon.type);
            int defendingIndex = GetTypeIndex(defedingPokemon.type);

            if (attackingIndex == -1 || defendingIndex == -1)
            {
                throw new ArgumentException("Invalid Pokemon type");
            }

            if (attackingPokemon.ultraBeast)
            {
                return typeChart[attackingIndex, defendingIndex] + 0.7;
            }
            else
            {
                return typeChart[attackingIndex, defendingIndex];
            }



        }

        private static int GetTypeIndex(string type)
        {

            string[] incomingtypes = type.Split(',');

            string[] types =
            {
            "Grass", "Fire", "Water", "Psychic", "Bug", "Dark", "Dragon", "Electric", "Fighting",
            "Fairy", "Flying", "Ghost", "Ground", "Ice", "Normal", "Poison", "Rock", "Steel"
        };

            for (int i = 0; i < types.Length; i++)
            {
                if (types[i].Equals(incomingtypes[0], StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }

            return -1;
        }



        private async void p1StrongAttack(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 1)
            {
                this.disableAllButtons();
                notificarAtaqueTrasPulsarBoton(this.p1strong);
                pokemon1.Energia = pokemon1.Energia - 10;
                pokemon1.animacionAtaqueFuerte();
                await Task.Delay(7000);

                if (pokemon1.Energia <= 30)
                {
                    pokemon1.animacionCansado();
                }

                double damage = GetDamageMultiplier(this.selectedPokemon1, this.selectedPokemon2) * 35;
                pokemon2.Vida = pokemon2.Vida - damage;

                if (pokemon2.Vida <= 30)
                {
                    pokemon2.animacionHerido();
                }

                if (pokemon2.Vida <= 0)
                {
                    pokemon2.animacionDerrota();
                    turn = 0;
                    this.disableAllButtons();
                    endGame("El ganador es " + selectedPokemon1.name + "!");
                    string texto = "El ganador es" + selectedPokemon1.name;
                    voiceReader.LeerTexto(texto);
                }
                else
                {
                    turn = 2;
                    if (this.option == 2)
                    {
                        this.attactkIA();
                    }
                    else{
                        this.p1DisableButtons();
                    }
                    createNotification(selectedPokemon1, selectedPokemon2, this.p1strong.Content.ToString());
                }

            }
        }

        private async void p2StrongAttack(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 2)
            {
                this.disableAllButtons();
                notificarAtaqueTrasPulsarBoton(this.p2strong);
                pokemon2.Energia = pokemon2.Energia - 10;
                pokemon2.animacionAtaqueFuerte();
                await Task.Delay(7000);

                if (pokemon2.Energia <= 30)
                {
                    pokemon2.animacionCansado();
                }

                double damage = GetDamageMultiplier(this.selectedPokemon2, this.selectedPokemon1) * 15;
                pokemon1.Vida = pokemon1.Vida - damage;

                if (pokemon1.Vida <= 30)
                {
                    pokemon1.animacionHerido();
                }

                if (pokemon1.Vida <= 0)
                {
                    pokemon1.animacionDerrota();
                    turn = 0;
                    this.disableAllButtons();
                    endGame("El ganador es " + selectedPokemon2.name + "!");
                    string texto = "El ganador es" + selectedPokemon2.name;
                    voiceReader.LeerTexto(texto);
                }
                else
                {
                    turn = 1;
                    this.p2DisableButtons();
                    createNotification(selectedPokemon2, selectedPokemon1, this.p2strong.Content.ToString());
                }

            }
        }


        private async void p1WeakAttack(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 1)
            {
                this.disableAllButtons();
                notificarAtaqueTrasPulsarBoton(this.p1weak);
                pokemon1.animacionAtaqueFlojo();
                pokemon1.Energia = pokemon1.Energia - 5;
                await Task.Delay(7000);

                if (pokemon1.Energia <= 30)
                {
                    pokemon1.animacionCansado();
                }


                double damage = GetDamageMultiplier(this.selectedPokemon1, this.selectedPokemon2) * 10;
                pokemon2.Vida = pokemon2.Vida - damage;

                if (pokemon2.Vida <= 30)
                {
                    pokemon2.animacionHerido();
                }


                if (pokemon2.Vida <= 0)
                {
                    pokemon2.animacionDerrota();
                    turn = 0;
                    this.disableAllButtons();
                    endGame("El ganador es " + selectedPokemon1.name + "!");
                    string texto = "El ganador es" + selectedPokemon1.name;
                    voiceReader.LeerTexto(texto);
                }
                else
                {
                    turn = 2;
                    if (this.option == 2)
                    {
                        this.attactkIA();
                    }
                    else
                    {
                        this.p1DisableButtons();
                    }
                    createNotification(selectedPokemon1, selectedPokemon2, this.p1weak.Content.ToString());
                }

            }
        }

        private async void p2WeakAttack(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 2)
            {
                this.disableAllButtons();
                pokemon2.animacionAtaqueFlojo();
                notificarAtaqueTrasPulsarBoton(this.p2weak);
                pokemon2.Energia = pokemon2.Energia - 5;

                await Task.Delay(7000);

                if (pokemon2.Energia <= 30)
                {
                    pokemon2.animacionCansado();
                }

                double damage = GetDamageMultiplier(this.selectedPokemon2, this.selectedPokemon1) * 10;
                pokemon1.Vida = pokemon1.Vida - damage;

                if (pokemon1.Vida <= 30)
                {
                    pokemon1.animacionHerido();
                }


                if (pokemon1.Vida <= 0)
                {
                    pokemon1.animacionDerrota();
                    turn = 0;
                    this.disableAllButtons();
                    endGame("El ganador es " + selectedPokemon2.name + "!");
                    string texto = "El ganador es" + selectedPokemon2.name;
                    voiceReader.LeerTexto(texto);
                }
                else
                {
                    turn = 1;
                    this.p2DisableButtons();
                    createNotification(selectedPokemon2, selectedPokemon1, this.p2weak.Content.ToString());
                }

            }
        }

        private void p1Flee(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            int randomNumberInRange = new Random().Next(100);

            if (randomNumberInRange < 50)
            {
                var localSettings = ApplicationData.Current.LocalSettings;
                string appLanguage = localSettings.Values["AppLanguage"] as string;

                if (appLanguage == "en-GB")
                {
                    this.message.Text = this.selectedPokemon1.name + " fled correctly";
                    this.disableAllButtons();
                    endGame(this.selectedPokemon1.name + " fled correctly, Tie");
                    string texto = selectedPokemon1.name + " has run away. Tie";
                    voiceReader.LeerTexto(texto);
                }
                else if (appLanguage == "es-ES")
                {
                    this.message.Text = this.selectedPokemon1.name + " huyo correctamente";
                    this.disableAllButtons();
                    endGame(this.selectedPokemon1.name + " huyo correctamente, Empate");
                    string texto = selectedPokemon1.name + "ha huido. Empate";
                    voiceReader.LeerTexto(texto);
                }
               
            }
            else
            {
                var localSettings = ApplicationData.Current.LocalSettings;
                string appLanguage = localSettings.Values["AppLanguage"] as string;

                if (appLanguage == "en-GB")
                {
                    this.message.Text = this.selectedPokemon1.name + " couldn't escape";
                    string texto = selectedPokemon1.name + " couldn't escape";
                    voiceReader.LeerTexto(texto);
                }
                else if (appLanguage == "es-ES")
                {
                    this.message.Text = this.selectedPokemon1.name + " no pudo escapar";
                    string texto = selectedPokemon1.name + "no ha podido escapar";
                    voiceReader.LeerTexto(texto);
                }
                
                if (turn == 1)
                {
                    turn = 2;
                     if (this.option == 2)
                    {
                        this.attactkIA();
                    }
                    else{
                        this.p1DisableButtons();
                    }
                }
                else if (turn == 2)
                {
                    turn = 1;
                    this.p2DisableButtons();
                }
            }
        }

        private void p2Flee(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            int randomNumberInRange = new Random().Next(100);

            if (randomNumberInRange < 50)
            {
                this.message.Text = this.selectedPokemon2.name + " huyo correctamente";
                this.disableAllButtons();
                endGame(this.selectedPokemon2.name + " huyo correctamente, Empate");
                string texto = selectedPokemon1.name + "ha huido. Empate";
                voiceReader.LeerTexto(texto);
            }
            else
            {
                this.message.Text = this.selectedPokemon2.name + " no pudo escapar";
                string texto = selectedPokemon1.name + "no ha podido escapar";
                voiceReader.LeerTexto(texto);
                if (turn == 1)
                {
                    turn = 2;
                    this.p1DisableButtons();
                }
                else if (turn == 2)
                {
                    turn = 1;
                    this.p2DisableButtons();
                }
            }
        }

        private void attactkIA()
        {
            this.disableAllButtons();
            int random = new Random().Next(100);

            if (random >= 0 && random <= 45)
            {
                this.p2StrongAttack(null, null);
            }else if (random > 45 && random <= 90)
            {
                this.p2WeakAttack(null, null);
            }
            else
            {
                this.p2Flee(null, null);
            }
            turn = 1;
        }


        private async void p1doultrabeast(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 1)
            {
                if (selectedPokemon1.ultraBeast)
                {
                    pokemon1.animacionDefensa();
                }
            }
        }


        private async void p2doultrabeast(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 2)
            {
                if (selectedPokemon2.ultraBeast)
                {
                    pokemon2.animacionDefensa();
                }
            }
        }

        private void disableAllButtons()
        {
            this.p1flee.IsEnabled = false;
            this.p1strong.IsEnabled = false;
            this.p1weak.IsEnabled = false;
            this.p1ultrabeast.IsEnabled = false;

            this.p2flee.IsEnabled = false;
            this.p2strong.IsEnabled = false;
            this.p2weak.IsEnabled = false;
            this.p2ultrabeast.IsEnabled = false;
        }

        private void p1DisableButtons()
        {
            this.p1flee.IsEnabled = false;
            this.p1strong.IsEnabled = false;
            this.p1weak.IsEnabled = false;
            this.p1ultrabeast.IsEnabled = false;

            this.p2flee.IsEnabled = true;
            this.p2strong.IsEnabled = true;
            this.p2weak.IsEnabled = true;
            this.p2ultrabeast.IsEnabled = true;
        }

        private void p2DisableButtons()
        {
            this.p1flee.IsEnabled = true;
            this.p1strong.IsEnabled = true;
            this.p1weak.IsEnabled = true;
            this.p1ultrabeast.IsEnabled = true;

            this.p2flee.IsEnabled = false;
            this.p2strong.IsEnabled = false;
            this.p2weak.IsEnabled = false;
            this.p2ultrabeast.IsEnabled = false;
        }

        private void endGame(String message)
        {

            this.pokemon1.Children[0].Opacity = 20;
            this.pokemon2.Children[0].Opacity = 20;
            this.message.Text = message;
        }




        public void notificarAtaqueTrasPulsarBoton(Button btn)
        {
            if (turn == 1)
            {
                var localSettings = ApplicationData.Current.LocalSettings;
                string appLanguage = localSettings.Values["AppLanguage"] as string;

                if (appLanguage == "en-GB")
                {
                    this.message.Text = this.selectedPokemon1.name + " has used the attack " + btn.Content + ", turn of " + this.selectedPokemon2.name;
                    string texto = selectedPokemon1.name + "has used the attack" + btn.Content + ".turn of" + selectedPokemon2.name;
                    voiceReader.LeerTexto(texto);
                }
                else if (appLanguage == "es-ES")
                {
                    this.message.Text = this.selectedPokemon1.name + " ha utilizando el ataque " + btn.Content + ", turno de " + this.selectedPokemon2.name;
                    string texto = selectedPokemon1.name + "ha utilizado el" + btn.Content + ".Turno de" + selectedPokemon2.name;
                    voiceReader.LeerTexto(texto);
                }
                
            }
            else
            {
                var localSettings = ApplicationData.Current.LocalSettings;
                string appLanguage = localSettings.Values["AppLanguage"] as string;

                if (appLanguage == "en-GB")
                {
                    this.message.Text = this.selectedPokemon2.name + " has used the attack " + btn.Content + ", turn of " + this.selectedPokemon1.name;
                    string texto = selectedPokemon2.name + " has used the attack" + btn.Content + ".turn of" + selectedPokemon1.name;
                    voiceReader.LeerTexto(texto);
                }
                else if (appLanguage == "es-ES")
                {
                    this.message.Text = this.selectedPokemon2.name + " ha utilizando el ataque " + btn.Content + ", turno de " + this.selectedPokemon1.name;
                    string texto = selectedPokemon2.name + "ha utilizado el" + btn.Content + ".Turno de" + selectedPokemon1.name;
                    voiceReader.LeerTexto(texto);
                }

                
            }

        }

        public void notifyDefeat(Button btn) // Terminado
        {
            if (turn == 1)
            {
                var localSettings = ApplicationData.Current.LocalSettings;
                string appLanguage = localSettings.Values["AppLanguage"] as string;

                if (appLanguage == "en-GB")
                {
                    this.message.Text = this.selectedPokemon1.name + " has used the attack " + btn.Content + " and has defeated " + this.selectedPokemon2.name;
                    string texto = selectedPokemon1.name + "has used the attack" + btn.Content + " and has defeated " + selectedPokemon2.name;
                    voiceReader.LeerTexto(texto);
                }
                else if (appLanguage == "es-ES")
                {
                    this.message.Text = this.selectedPokemon1.name + " ha utilizando el ataque " + btn.Content + " y ha derrotado a " + this.selectedPokemon2.name;
                    string texto = selectedPokemon1.name + "ha utilizado el" + btn.Content + "y ha derrotado a " + selectedPokemon2.name;
                    voiceReader.LeerTexto(texto);
                }
               
            }
            else
            {
                var localSettings = ApplicationData.Current.LocalSettings;
                string appLanguage = localSettings.Values["AppLanguage"] as string;

                if (appLanguage == "en-GB")
                {
                    this.message.Text = this.selectedPokemon2.name + " has used the attack " + btn.Content + " and has defeated " + this.selectedPokemon1.name;
                    string texto = selectedPokemon2.name + "has used the attack" + btn.Content + " and has defeated " + selectedPokemon1.name;
                    voiceReader.LeerTexto(texto);
                }
                else if (appLanguage == "es-ES")
                {
                    this.message.Text = this.selectedPokemon2.name + " ha utilizando el ataque " + btn.Content + " y ha derrotado a " + this.selectedPokemon1.name;
                    string texto = selectedPokemon2.name + "ha utilizado el" + btn.Content + "y ha derrotado a" + selectedPokemon1.name;
                    voiceReader.LeerTexto(texto);
                }
                
            }

        }


        private void createNotification(Pokemon attack, Pokemon defend, string attackName)
        {


                 new ToastContentBuilder()
                .AddArgument("action", "Favoritos")
                .AddArgument("conversationId", 9813)
                .AddText(attack.name + " hizo ataque " + attackName)
                .AddText("Turno de " + defend.name)
                .AddInlineImage(new Uri(attack.image))
                .AddAppLogoOverride(new Uri("ms-appx:///Assets/images/icon/pokeball.png"), ToastGenericAppLogoCrop.Circle)
                .AddButton(new ToastButton()
                .SetContent("Mostrar Ventana")
                .AddArgument("action", "reply")
                )
                .Show();
            
        }

       

       

        private async void pocionR1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 1)
            {

                pokemon1.animacionDescasar();
                pokemon1.Vida = 100;
                await Task.Delay(7000);
            }
        }

        private async void pocionA1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 1)
            {


                pokemon1.animacionDescasar();
                pokemon1.Energia = 100;
                await Task.Delay(7000);
            }
        }

        private async void pocionR_Copiar1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 2)
            {

                pokemon2.animacionDescasar();
                pokemon2.Vida = 100;
                await Task.Delay(7000);
            }
        }

        private async void pocionA_copia1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (p1 is iPokemon pokemon1 && p2 is iPokemon pokemon2 && turn == 2)
            {

                pokemon2.animacionDescasar();
                pokemon2.Vida = 100;
                await Task.Delay(7000);
            }
        }
    }
}
