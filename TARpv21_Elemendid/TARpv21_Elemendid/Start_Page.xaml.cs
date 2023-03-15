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
        List<ContentPage> contentPages = new List<ContentPage>() { new Text_Page(), new Timer_Page(), new Box_Page(), new Valgusfoor(), new StepperSlider_Page(), new RGB_Slider_Page() };
        List<string> tekstid = new List<string> { "Text Page", "Timer Page", "Box Page", "Valgusfoor Page", "StepperSlider Page", "RGB Slider Page" };

        public Start_Page()
        {
            
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Beige,
            };
            for (int i = 0; i < contentPages.Count; i++)
            {
                Button button = new Button
                {
                    Text = tekstid[i],
                    TabIndex = i,
                    BackgroundColor = Color.LightCyan,
                    TextColor = Color.Black
                };
                button.Clicked += Navig_funktsion;
                st.Children.Add(button);
            }
            Content = st;
        }

        private async void Navig_funktsion(object sender, EventArgs e)
        {
            Button b = (Button)sender; /// = sender as Button;
            await Navigation.PushAsync(contentPages[b.TabIndex]);
        }
    }
}