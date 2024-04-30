using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace ipo2_pokedex
{
    public sealed partial class TemplatePokemon : UserControl
    {
        public TemplatePokemon(Pokemon pokemon)
        {
            this.InitializeComponent();


            this.id.Text = pokemon.id.ToString();
            this.name.Text = pokemon.name;
            this.type.Text = pokemon.type;
            this.Image.Source = new BitmapImage(new Uri(pokemon.image));
            if (pokemon.captured)
            {
                this.pokeball.Visibility = Visibility.Visible;
            }


            string[] types = pokemon.type.Split(',');


            if (types.Length == 1)
            {
                SolidColorBrush brush = new SolidColorBrush(getColorByType(types[0]));
                gTemplate.Background = brush;

            }
            else
            {
                LinearGradientBrush gradientBrush = new LinearGradientBrush();
                gradientBrush.StartPoint = new Windows.Foundation.Point(0, 0);
                gradientBrush.EndPoint = new Windows.Foundation.Point(1, 1);
                gradientBrush.GradientStops.Add(new GradientStop() { Color = getColorByType(types[0]), Offset = 0.0 });
                gradientBrush.GradientStops.Add(new GradientStop() { Color = getColorByType(types[1]), Offset = 1.0 });
                gTemplate.Background = gradientBrush;
            }


        }

        private Color getColorByType(string type)
        {
            Color customColor;
            switch (type)
            {
                case "Grass":
                    customColor = Color.FromArgb(190, 40, 205, 93);
                    break;
                case "Fire":
                    customColor = Color.FromArgb(200, 205, 40, 40);
                    break;
                case "Water":
                    customColor = Color.FromArgb(190, 40, 142, 205);
                    break;
                case "Psychic":
                    customColor = Color.FromArgb(150, 169, 67, 101);
                    break;
                case "Bug":
                    customColor = Color.FromArgb(150, 40, 205, 93);
                    break;
                case "Dark":
                    customColor = Color.FromArgb(150, 67, 72, 82);
                    break;
                case "Dragon":
                    customColor = Color.FromArgb(150, 40, 142, 205);
                    break;
                case "Electric":
                    customColor = Color.FromArgb(150, 205, 205, 40);
                    break;
                case "Fighting":
                    customColor = Color.FromArgb(150, 151, 54, 70);
                    break;
                case "Fairy":
                    customColor = Color.FromArgb(150, 162, 108, 162);
                    break;
                case "Flying":
                    customColor = Color.FromArgb(150, 132, 146, 174);
                    break;
                case "Ghost":
                    customColor = Color.FromArgb(150, 91, 83, 149);
                    break;
                case "Ground":
                    customColor = Color.FromArgb(150, 147, 97, 68);
                    break;
                case "Ice":
                    customColor = Color.FromArgb(150, 97, 141, 144);
                    break;
                case "Normal":
                    customColor = Color.FromArgb(150, 106, 113, 119);
                    break;
                case "Poison":
                    customColor = Color.FromArgb(150, 96, 84, 152);
                    break;
                case "Rock":
                    customColor = Color.FromArgb(150, 137, 119, 75);
                    break;
                case "Steel":
                    customColor = Color.FromArgb(150, 116, 121, 139);
                    break;
            }
            return customColor;
        }



        private void Grid_PointerEntered(object sender, PointerRoutedEventArgs e)
        {

            //string hexColor = "#FF0000"; 
            //Color color = (Color)ColorConverter.ConvertFromString(hexColor);
            //SolidColorBrush backgroundBrush = new SolidColorBrush(color);
            //Window.Current.Content.Background = backgroundBrush;

        }
    }
}
