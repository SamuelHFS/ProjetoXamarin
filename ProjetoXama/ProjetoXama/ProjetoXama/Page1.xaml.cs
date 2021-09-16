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

            Content = stk;

        }
    }
}