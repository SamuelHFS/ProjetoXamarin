using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoXama
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            StackLayout stk = new StackLayout()
            { 
                Orientation = StackOrientation.Vertical
            };
            Label lb1 = new Label()
            {
                Text = "curso Xamarin",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                BackgroundColor = Color.Black,
                Padding = new Thickness(10),
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center
            };
            stk.Children.Add(lb1);

            Label lb2 = new Label()
            {
                Text = "Banco de dados",
                FontSize = 20,
                TextColor = Color.Yellow,
            };

            Label lb3 = new Label()
            {
                Text = "Java Web (EE)",
                FontSize = 20,
                TextColor = Color.DarkRed,
            };

            StackLayout stk2 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal
            };

            stk2.Children.Add(lb2);
            stk2.Children.Add(lb3);

            stk.Children.Add(stk2);

            Image img = new Image()
            {
                Source = "jureg.png",
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            stk.Children.Add(img);
            Content = stk;

        }
    }
}