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


            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += opcionVolver;

            //synthesizer = new SpeechSynthesizer();
            //mediaElement = new MediaElement();
            voiceReader = new VoiceReader();
            string texto = "¡Bienvenido a nuestra App Pokemon. Si quieres un lector de voz, habilitalo en nuestro menú!";
            voiceReader.LeerTexto(texto);


        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
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
        }


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




        private void opcionVolver(object sender, BackRequestedEventArgs e)
        {
            if (FrameMain.BackStack.Any())
            {
                FrameMain.GoBack();
            }
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e) 
        {

            //FrameMain.Navigate(typeof(InicioPage), this);
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
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
           
            //FrameMain.Navigate(typeof(InicioPage), this);
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
          
        }
        private void SymbolIcon_Pokedex_PointerReleased(object sender, PointerRoutedEventArgs e) 
        {
           
            FrameMain.Navigate(typeof(PokedexPage), this); 
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            //leerFrase("Pokedex");
        }
        private void SymbolIcon_Lucha_PointerReleased(object sender, PointerRoutedEventArgs e) 
        {
           
            FrameMain.Navigate(typeof(SelectBattlePage), this); 
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
           
        }
        private void SymbolIcon_MasInfo_PointerReleased(object sender, PointerRoutedEventArgs e) 
        {
            
            FrameMain.Navigate(typeof(MoreInformation), this); 
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            

        }
    }



}
