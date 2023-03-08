using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21_Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start_Page : ContentPage
    {
        public Start_Page()
        {
            Button Textbtn = new Button
            {
                Text = "Text Page",
                BackgroundColor = Color.AliceBlue,
                TextColor = Color.Black
            };
            Button Timerbtn = new Button
            {
                Text = "Timer Page",
                BackgroundColor = Color.AliceBlue,
                TextColor = Color.Black
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Beige,
                Children = { Textbtn, Timerbtn }
            };
            Content = st;
            Textbtn.Clicked += Textbtn_Clicked;
            Timerbtn.Clicked += Timerbtn_Clicked;
        }

        private async void Timerbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }

        private async void Textbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Text_Page());
        }
    }
}