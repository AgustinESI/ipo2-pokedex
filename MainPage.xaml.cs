using System.Linq;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using System;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.Globalization;
using Windows.Storage;
using Windows.ApplicationModel.Resources.Core;
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ipo2_pokedex
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public partial class MainPage : Page
    {
        //private SpeechSynthesizer synthesizer;
        //private MediaElement mediaElement;
        private bool isVoiceReaderActive = false;
        private VoiceReader voiceReader;
        private bool previousToggleState = false;

        public MainPage()
        {
            this.InitializeComponent();

            if (Application.Current.RequestedTheme == ApplicationTheme.Dark)
            {
                this.RequestedTheme = ElementTheme.Dark;
            }
            else
            {
                this.RequestedTheme = ElementTheme.Light;
            }
            FrameMain.Navigate(typeof(InicioPage), this);
            sView_Abajo_Principal.IsPaneOpen = true;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += opcionVolver;

            //synthesizer = new SpeechSynthesizer();
            //mediaElement = new MediaElement();
            voiceReader = new VoiceReader();
            string texto = "¡Bienvenido a nuestra aplicación Pokemon.";
            voiceReader.LeerTexto(texto);



            var localSettings = ApplicationData.Current.LocalSettings;
            string userLanguage = localSettings.Values["AppLanguage"] as string;
            userLanguage = "es-ES";
           // if (userLanguage == null)
            //{
                // Si no hay preferencia almacenada, usar el idioma del sistema
                // string systemLanguage = Windows.System.UserProfile.GlobalizationPreferences.Languages[0];
                // userLanguage = systemLanguage.StartsWith("es") ? "es-ES" : "en-GB";
                
            //}

            if (userLanguage == "es-ES")
            {
                SelectIdioma.IsOn = false;
                ApplicationLanguages.PrimaryLanguageOverride = "es-ES";
            }
            else
            {
                SelectIdioma.IsOn = true;
                ApplicationLanguages.PrimaryLanguageOverride = "en-GB";
            }
        }

        /* private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
         {
             bool currentToggleState = lector_de_voz.IsOn; // Obtener el estado actual del ToggleSwitch

             // Verificar si el estado actual es diferente al estado anterior
             if (currentToggleState != previousToggleState)
             {
                 isVoiceReaderActive = currentToggleState; // Actualizar el estado del lector de voz

                 // Actualizar el estado anterior del ToggleSwitch
                 previousToggleState = currentToggleState;

                 string texto = isVoiceReaderActive ? "Lector de voz activado" : "Lector de voz desactivado";
                 voiceReader.LeerTexto(texto);

                 if (!isVoiceReaderActive)
                 {
                     // Detener el lector de voz
                     voiceReader.DetenerLectura();
                 }
             }
             else
             {
                 // Si el estado del ToggleSwitch no ha cambiado, detener el lector de voz si está desactivado
                 if (!currentToggleState)
                 {
                     voiceReader.DetenerLectura();
                 }
             }
         }*/


        /* private void DetenerLectura()
         {
             mediaElement.Stop();
         }*/

        /*private async void LeerTexto(string texto)
        {
            if (isVoiceReaderActive)
            {
                var stream = await synthesizer.SynthesizeTextToStreamAsync(texto);
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
        }*/

        private void ToggleThemeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.RequestedTheme == ElementTheme.Light)
            {
                SetDarkTheme();
            }
            else
            {
                SetLightTheme();
            }
        }

        private void SetDarkTheme()
        {
            this.RequestedTheme = ElementTheme.Dark;
        }

        private void SetLightTheme()
        {
            this.RequestedTheme = ElementTheme.Light;
        }


        private void opcionVolver(object sender, BackRequestedEventArgs e)
        {
            if (FrameMain.BackStack.Any())
            {
                FrameMain.GoBack();
            }
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e) 
        {

            FrameMain.Navigate(typeof(InicioPage), this);
            sView_Abajo_Principal.IsPaneOpen = true;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            var button = sender as Button;
            if (button != null)
            {
                string texto = button.Content.ToString();
                voiceReader.LeerTexto(texto);
            }
        }

        private void btn_MiniJuego_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(typeof(MiniGamePage), this); 
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            if (btn_MiniJuego != null)
            {
                string texto = btn_MiniJuego.Content.ToString();
                voiceReader.LeerTexto(texto);
            }
        }


        private void btn_Pokedex_Click(object sender, RoutedEventArgs e) 
        {
            // Este boton sirve para que aparezca la pagina de "Pokedex"
            FrameMain.Navigate(typeof(PokedexPage), this); 
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            if (btn_Pokedex != null)
            {
                string texto = btn_Pokedex.Content.ToString();
                voiceReader.LeerTexto(texto);
            }
        }

        private void btn_LuchaPokemon_Click(object sender, RoutedEventArgs e) 
        {
            FrameMain.Navigate(typeof(SelectBattlePage), this);
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            var button = sender as Button;
            if (button != null)
            {
                string texto = button.Content.ToString();
                voiceReader.LeerTexto(texto);
            }
        }

        private void btn_MasInfo_Click(object sender, RoutedEventArgs e) 
        {

            FrameMain.Navigate(typeof(MoreInformation), this); 
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            var button = sender as Button;
            if (button != null)
            {
                string texto = button.Content.ToString();
                voiceReader.LeerTexto(texto);
            }
        }
        private void Btn_Menu_Click(object sender, RoutedEventArgs e) 
        {
           
            sView_Abajo_Principal.IsPaneOpen = !sView_Abajo_Principal.IsPaneOpen;
        }
        private void SymbolIcon_Home_PointerReleased(object sender, PointerRoutedEventArgs e) 
        {
           
            FrameMain.Navigate(typeof(InicioPage), this);
            sView_Abajo_Principal.IsPaneOpen = true;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            var button = sender as Button;
            if (button != null)
            {
                string texto = button.Content.ToString();
                voiceReader.LeerTexto(texto);
            }

        }
        private void SymbolIcon_Pokedex_PointerReleased(object sender, PointerRoutedEventArgs e) 
        {
           
            FrameMain.Navigate(typeof(PokedexPage), this); 
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            var button = sender as Button;
            if (button != null)
            {
                string texto = button.Content.ToString();
                voiceReader.LeerTexto(texto);
            }
        }
        private void SymbolIcon_Lucha_PointerReleased(object sender, PointerRoutedEventArgs e) 
        {
           
            FrameMain.Navigate(typeof(SelectBattlePage), this); 
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            var button = sender as Button;
            if (button != null)
            {
                string texto = button.Content.ToString();
                voiceReader.LeerTexto(texto);
            }

        }
        private void SymbolIcon_MasInfo_PointerReleased(object sender, PointerRoutedEventArgs e) 
        {
            
            FrameMain.Navigate(typeof(MoreInformation), this); 
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            var button = sender as Button;
            if (button != null)
            {
                string texto = button.Content.ToString();
                voiceReader.LeerTexto(texto);
            }


        }

        private void UpdateLanguage(string languageCode)
        {
            // Aquí actualizas los textos de la UI con los recursos correspondientes al idioma seleccionado.
            if (languageCode == "en")
            {
                btn_Inicio.Content = "Home";
                btn_MiniJuego.Content = "Mini Game";
                btn_Pokedex.Content = "Pokedex";
                btn_LuchaPokemon.Content = "Battle Pokemon";
                btn_MasInfo.Content = "More Info";
                SelectIdioma.Header = "Language";
                Tema.Content = "Light/Dark Theme";
                //lector_de_voz.Header = "Voice reades";
                // Actualiza otros elementos de la UI según sea necesario
            }
            else if (languageCode == "es")
            {
                btn_Inicio.Content = "Inicio";
                btn_MiniJuego.Content = "Mini Juego";
                btn_Pokedex.Content = "Pokedex";
                btn_LuchaPokemon.Content = "Lucha Pokemon";
                btn_MasInfo.Content = "Más Info";
                SelectIdioma.Header = "Idioma";
                Tema.Content = "Tema Claro/Oscuro";
               // lector_de_voz.Header = "Lector de voz";
                // Actualiza otros elementos de la UI según sea necesario
            }
        }

        private void SelectIdioma_Toggled(object sender, RoutedEventArgs e)
        {
            var localSettings = ApplicationData.Current.LocalSettings;

            if (SelectIdioma.IsOn)
            {
                ApplicationLanguages.PrimaryLanguageOverride = "en-GB";
                localSettings.Values["AppLanguage"] = "en-GB";
                UpdateLanguage("en");
            }
            else
            {
                ApplicationLanguages.PrimaryLanguageOverride = "es-ES";
                localSettings.Values["AppLanguage"] = "es-ES";
                UpdateLanguage("es");
            }

            FrameMain.Navigate(typeof(InicioPage), this);
            sView_Abajo_Principal.IsPaneOpen = true;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;


        }

        


    }



}
