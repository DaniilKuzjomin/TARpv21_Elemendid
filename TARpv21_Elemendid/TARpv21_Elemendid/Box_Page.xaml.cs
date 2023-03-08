using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21_Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Box_Page : ContentPage
    {
        Button Tagasibtn;
        BoxView box;
        public Box_Page()
        {
            box = new BoxView
            {
                Color = Color.Chocolate,
                CornerRadius= 10,
                WidthRequest= 20,
                HeightRequest= 30,
                HorizontalOptions= LayoutOptions.Center,
                VerticalOptions= LayoutOptions.Center,
            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box.GestureRecognizers.Add(tap);
            Tagasibtn = new Button
            {
                Text = "Tagasi",
                BackgroundColor = Color.AliceBlue,
                TextColor = Color.Black
            };
            Tagasibtn.Clicked += Tagasibtn_Clicked;
            Content = new StackLayout { Children = { Tagasibtn, box } };
        }

        Random rnd;
        int x = 10;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            

            if (box.Height > DeviceDisplay.MainDisplayInfo.Height || box.Width > DeviceDisplay.MainDisplayInfo.Width)
            {
                box.WidthRequest = box.Width - 1000;
                box.HeightRequest = box.Height - 1200;
            }
            else
            {
                rnd= new Random();
                box.Color= Color.FromRgb(rnd.Next(0,255), rnd.Next(0, 255), rnd.Next(0, 255));
                //x += 10;
                //box.CornerRadius= x;
                box.WidthRequest = box.Width + 5;
                box.HeightRequest= box.Height + 7;
                box.Rotation += 10;
            }

            try
            {
                Vibration.Vibrate();
                var a = TimeSpan.FromSeconds(0.5);
                Vibration.Vibrate(a);
            }
            catch (Exception)
            {
            }

        }

        private async void Tagasibtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}