using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace ipo2_pokedex
{
    public sealed partial class SquirtleJRSL1 : UserControl, iPokemon
    {
        DispatcherTimer dtCuracion;
        int animation = 1;

        public double Vida { get => this.pbVida.Value; set => this.pbVida.Value = value; }
        public double Energia { get => this.pbProteccion.Value; set => this.pbProteccion.Value = value; }
        string iPokemon.Nombre { get => "Squirtle"; set => throw new NotImplementedException(); }
        public string Categoría { get => "Tortuguita"; set => throw new NotImplementedException(); }
        public string Tipo { get => "Agua"; set => throw new NotImplementedException(); }
        public double Altura { get => 0.5; set => throw new NotImplementedException(); }
        public double Peso { get => 9.0; set => throw new NotImplementedException(); }
        public string Evolucion { get => "Wartortle"; set => throw new NotImplementedException(); }
        public string Descripcion { get => "Tras nacer, se le hincha el lomo y se le forma un caparazón. Escupe poderosa espuma por la boca."; set => throw new NotImplementedException(); }

        public SquirtleJRSL1()
        {
            this.InitializeComponent();
        }
        void usarPocion(object sender, object e)
        {

            dtCuracion = new DispatcherTimer();
            dtCuracion.Interval = TimeSpan.FromMilliseconds(10);
            dtCuracion.Tick += subirVida;
            dtCuracion.Start();
            this.imPocion.Opacity = 0.5;
        }
        void subirVida(object sender, object e)
        {
            if (pbVida.Value < 100)
            {
                if (pbVida.Value > 0 && animation == 0)
                {
                    Storyboard sbRecuperar = (Storyboard)this.Resources["Recuperar"];
                    sbRecuperar.Begin();
                    animation = 1;
                }
                this.pbVida.Value += 0.25;
                if (pbVida.Value >= 100)

                    this.imPocion.Opacity = 0.0;
            }
            else
            {
                this.pbProteccion.Value += 0.25;
                if (pbProteccion.Value >= 100)
                    this.dtCuracion.Stop();
                this.imPocion.Opacity = 0.0;
            }
        }
        void Dañar(object sender, object e)
        {

            dtCuracion = new DispatcherTimer();
            dtCuracion.Interval = TimeSpan.FromMilliseconds(10);
            dtCuracion.Tick += bajarVida;
            dtCuracion.Start();
            this.imPocion.Opacity = 0.5;
        }
        void bajarVida(object sender, object e)
        {
            if (pbProteccion.Value > 0)
            {
                this.pbProteccion.Value -= 0.25;
                this.imPocion.Opacity = 0.0;
            }
            else
            {
                this.pbVida.Value -= 0.25;
                if (pbVida.Value <= 0)
                {
                    this.dtCuracion.Stop();
                    Storyboard sbDerrotado = (Storyboard)this.Resources["Derrotado"];
                    sbDerrotado.Begin();
                    animation = 0;
                }


                this.imPocion.Opacity = 0.0;
            }
        }
        void Pokeball_PointerReleased(object sender, object e)
        {
            if (Pokeball.IsTapEnabled)
            {
                Storyboard sbLiberar = (Storyboard)this.Resources["Liberar"];
                sbLiberar.Begin();
                Pokeball.IsTapEnabled = false;
            }

        }


        void Capturar(object sender, object e)
        {
            if (Squirtle.Opacity != 0)
            {
                Storyboard sbCapturar = (Storyboard)this.Resources["Capturar"];
                sbCapturar.Begin();
                Pokeball.IsTapEnabled = true;
            }
        }

        void QuitarGafas(object sender, object e)
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbQuitarGafas = (Storyboard)this.Resources["QuitarGafas"];
                sbQuitarGafas.Begin();
                Gafas.IsTapEnabled = false;
            }
        }

        void PonerGafas(object sender, object e)
        {
            if (Squirtle.Opacity != 0 && !Gafas.IsTapEnabled)
            {
                Storyboard sbPonerGafas = (Storyboard)this.Resources["PonerGafas"];
                sbPonerGafas.Begin();
                Gafas.IsTapEnabled = true;


            }
        }

        void Saludar(object sender, object e)
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbSaludar = (Storyboard)this.Resources["Saludar"];
                sbSaludar.Begin();
                Gafas.IsTapEnabled = true;
            }
        }

        void PistolaAgua(object sender, object e)
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbPistola = (Storyboard)this.Resources["PistoladeAgua"];
                sbPistola.Begin();
                Gafas.IsTapEnabled = true;
            }
        }

        void BurbujasA(object sender, object e)
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbBurbujas = (Storyboard)this.Resources["Burbujas"];
                sbBurbujas.Begin();
                Gafas.IsTapEnabled = true;
            }
        }

        public void verFondo(bool ver)
        {
            if (ver)
            {
                this.fondo.Visibility = Visibility.Visible;
            }
            else
            {
                this.fondo.Visibility = Visibility.Collapsed;
            }
        }

        public void verFilaVida(bool ver)
        {
            if (ver)
            {
                this.pbVida.Visibility = Visibility.Visible;
                this.imPocion.Visibility = Visibility.Visible;
            }
            else
            {
                this.pbVida.Visibility = Visibility.Collapsed;
                this.imPocion.Visibility = Visibility.Collapsed;
            }
        }

        public void verFilaEnergia(bool ver)
        {

            if (ver)
            {
                this.pbProteccion.Visibility = Visibility.Visible;
                this.imEscudo.Visibility = Visibility.Visible;
            }
            else
            {
                this.pbProteccion.Visibility = Visibility.Collapsed;
                this.imEscudo.Visibility = Visibility.Collapsed;
            }

        }

        public void verPocionVida(bool ver)
        {
            if (ver)
            {
                this.pbVida.Visibility = Visibility.Visible;
            }
            else
            {
                this.pbVida.Visibility = Visibility.Collapsed;
            }
        }

        public void verPocionEnergia(bool ver)
        {
            if (ver)
            {
                this.pbProteccion.Visibility = Visibility.Visible;
            }
            else
            {
                this.pbProteccion.Visibility = Visibility.Collapsed;
            }
        }

        public void verNombre(bool ver)
        {
            if (ver)
            {
                this.Nombre.Visibility = Visibility.Visible;
            }
            else
            {
                this.Nombre.Visibility = Visibility.Collapsed;
            }
        }

        public void activarAniIdle(bool activar)
        {
        }

        public void animacionAtaqueFlojo()
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbBurbujas = (Storyboard)this.Resources["Burbujas"];
                sbBurbujas.Begin();
                Gafas.IsTapEnabled = true;
            }
        }

        public void animacionAtaqueFuerte()
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbPistola = (Storyboard)this.Resources["PistoladeAgua"];
                sbPistola.Begin();
                Gafas.IsTapEnabled = true;
            }
        }

        public void animacionDefensa()
        {
            if (Squirtle.Opacity != 0 && !Gafas.IsTapEnabled)
            {
                Storyboard sbPonerGafas = (Storyboard)this.Resources["PonerGafas"];
                sbPonerGafas.Begin();
                Gafas.IsTapEnabled = true;


            }
        }

        public void animacionDescasar()
        {
            if (Squirtle.Opacity != 0 && !Gafas.IsTapEnabled)
            {
                Storyboard sbPonerGafas = (Storyboard)this.Resources["PonerGafas"];
                sbPonerGafas.Begin();
                Gafas.IsTapEnabled = true;


            }
        }

        public void animacionCansado()
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbQuitarGafas = (Storyboard)this.Resources["QuitarGafas"];
                sbQuitarGafas.Begin();
                Gafas.IsTapEnabled = false;
            }
        }

        public void animacionNoCansado()
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbSaludar = (Storyboard)this.Resources["Saludar"];
                sbSaludar.Begin();
                Gafas.IsTapEnabled = true;
            }
        }

        public void animacionHerido()
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbQuitarGafas = (Storyboard)this.Resources["QuitarGafas"];
                sbQuitarGafas.Begin();
                Gafas.IsTapEnabled = false;
            }
        }

        public void animacionNoHerido()
        {
            if (Squirtle.Opacity != 0 && Gafas.IsTapEnabled)
            {
                Storyboard sbSaludar = (Storyboard)this.Resources["Saludar"];
                sbSaludar.Begin();
                Gafas.IsTapEnabled = true;
            }
        }

        public void animacionDerrota()
        {
            Storyboard sbDerrotado = (Storyboard)this.Resources["Derrotado"];
            sbDerrotado.Begin();
            Gafas.IsTapEnabled = false;
        }
    }
}

