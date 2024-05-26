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

        public MainPage()
        {
            this.InitializeComponent();


            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += opcionVolver;

            //synthesizer = new SpeechSynthesizer();
            //mediaElement = new MediaElement();
            voiceReader = new VoiceReader();


        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            isVoiceReaderActive = lector_de_voz.IsOn;
            string texto = "Lector de voz activado";
            voiceReader.LeerTexto(texto);
            if (!isVoiceReaderActive)
            {
                texto = "Lector de voz desactivado";
                voiceReader.LeerTexto(texto);
                // DetenerLectura();
                voiceReader.DetenerLectura();


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

            //FrameMain.Navigate(typeof(Acerca_De), this); 
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
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
           
            //FrameMain.Navigate(typeof(CombatePage), this); 
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
           
        }
        private void SymbolIcon_MasInfo_PointerReleased(object sender, PointerRoutedEventArgs e) 
        {
            
            //FrameMain.Navigate(typeof(Acerca_De), this); 
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            

        }
    }



}
