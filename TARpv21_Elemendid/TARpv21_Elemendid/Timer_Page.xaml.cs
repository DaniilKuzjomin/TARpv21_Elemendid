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
    public partial class Timer_Page : ContentPage
    {
        Button Tagasibtn;
        public Timer_Page()
        {
            InitializeComponent();
            Tagasibtn = new Button
            {
                Text = "Tagasi",
                BackgroundColor = Color.AliceBlue,
                TextColor = Color.Black
            };
            Tagasibtn.Clicked += Tagasibtn_Clicked;
            Stopbtn.Clicked += Stopbtn_Clicked;

            Content = new StackLayout { Children = {  Tagasibtn, lbl, Stopbtn} };
        }
        bool onoff = false;

        private void Stopbtn_Clicked(object sender, EventArgs e)
        {
            if (onoff)
            {
                onoff = false;
                Stopbtn.Text = "Lülita sisse";
            }
            else
            {
                onoff = true;
                Stopbtn.Text = "Lülita välja";
            }
            
        }

        private async void Tagasibtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void NaitaAeg()
        {
            while (onoff)
            {
                lbl.Text = DateTime.Now.ToString("T");
                await Task.Delay(1000);
            }
            
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            NaitaAeg();
        }
    }
}