using System.Linq;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ipo2_pokedex
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += opcionVolver;

        }

        private void opcionVolver(object sender, BackRequestedEventArgs e)
        {
            if (FrameMain.BackStack.Any())
            {
                FrameMain.GoBack();
            }
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e) // Terminado
        {
            // Este boton sirve para que aparezca la pagina de "Inicio"
            //FrameMain.Navigate(typeof(InicioPage), this);
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
        }


        private void btn_Pokedex_Click(object sender, RoutedEventArgs e) // Terminado
        {
            // Este boton sirve para que aparezca la pagina de "Pokedex"
            FrameMain.Navigate(typeof(PokedexPage), this); // Este this es para que se le pase como parámetro a la pagina creada, la pagina anterior
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
        }



        private void btn_LuchaPokemon_Click(object sender, RoutedEventArgs e) // Terminado
        {
            // Este boton sirve para que aparezca la pagina de "CombatePokemon"
            //FrameMain.Navigate(typeof(CombatePage), this); // Este this es para que se le pase como parámetro a la pagina creada, la pagina anterior
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
        }

        private void btn_MasInfo_Click(object sender, RoutedEventArgs e) // Terminado
        {
            // Este boton sirve para que aparezca la pagina de "Acerca De"
            //FrameMain.Navigate(typeof(Acerca_De), this); // Este this es para que se le pase como parámetro a la pagina creada, la pagina anterior
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
        }
        private void Btn_Menu_Click(object sender, RoutedEventArgs e) // Terminado
        {
            // Este boton sirve para que el boton de las Tres rallitas de arriba a la izquierda oculte o haga aparecer el menu
            sView_Abajo_Principal.IsPaneOpen = !sView_Abajo_Principal.IsPaneOpen;
        }
        private void SymbolIcon_Home_PointerReleased(object sender, PointerRoutedEventArgs e) // Terminado
        {
            // Este boton sirve para que aparezca la pagina de "Inicio"
            //FrameMain.Navigate(typeof(InicioPage), this);
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            //leerFrase("Inicio");
        }
        private void SymbolIcon_Pokedex_PointerReleased(object sender, PointerRoutedEventArgs e) // Terminado
        {
            // Este Icono sirve para que aparezca la pagina de "Pokedex"
            FrameMain.Navigate(typeof(PokedexPage), this); // Este this es para que se le pase como parámetro a la pagina creada, la pagina anterior
            sView_Abajo_Principal.IsPaneOpen = false;
            sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            //leerFrase("Pokedex");
        }
        private void SymbolIcon_Lucha_PointerReleased(object sender, PointerRoutedEventArgs e) // Terminado
        {
            // Este Icono sirve para que aparezca la pagina de "CombatePokemon"
            //FrameMain.Navigate(typeof(CombatePage), this); // Este this es para que se le pase como parámetro a la pagina creada, la pagina anterior
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            //leerFrase("Combate Pokemon");
        }
        private void SymbolIcon_MasInfo_PointerReleased(object sender, PointerRoutedEventArgs e) // Terminado
        {
            // Este Icono sirve para que aparezca la pagina de "Acerca De"
            //FrameMain.Navigate(typeof(Acerca_De), this); // Este this es para que se le pase como parámetro a la pagina creada, la pagina anterior
            //sView_Abajo_Principal.IsPaneOpen = false;
            //sView_Abajo_Principal.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            //leerFrase("AcercaDe");

        }
    }



}
