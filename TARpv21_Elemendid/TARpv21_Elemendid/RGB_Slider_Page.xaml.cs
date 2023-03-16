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
    public partial class RGB_Slider_Page : ContentPage
    {

        BoxView box;
        List<Slider> sliders = new List<Slider>();
        List<Label> labels = new List<Label>();
        Stepper stp;
        Random rnd;
        Button btn;
        public RGB_Slider_Page2()
        {
            rnd = new Random();
            box = new BoxView
            {
                Color = Color.Red,
                CornerRadius = 0,
                WidthRequest = 320,
                HeightRequest = 320,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            for (int i = 0; i < 3; i++)
            {
                var label = new Label
                {
                    TextColor = i == 0 ? Color.Red : i == 1 ? Color.Green : Color.Blue
                };
                labels.Add(label);

                var slider = new Slider
                {
                    Minimum = 0,
                    Maximum = 255,
                    Value = 30,
                    MinimumTrackColor = Color.Red,
                    MaximumTrackColor = Color.Yellow,
                    ThumbColor = Color.Orange
                };
                slider.ValueChanged += OnSliderValueChanged;
                sliders.Add(slider);
            }

            stp = new Stepper
            {
                Minimum = 0,
                Maximum = 350,
                Value = 20,
                Increment = 5,
                HorizontalOptions = LayoutOptions.Center
            };
            stp.ValueChanged += Stp_ValueChanged;
            btn = new Button
            {
                Text = "Random color",
            };
            btn.Clicked += Random_Clicked;

            StackLayout st = new StackLayout();
            st.Children.Add(box);
            foreach (var slider in sliders)
            {
                st.Children.Add(slider);
                st.Children.Add(labels[sliders.IndexOf(slider)]);
            }
            st.Children.Add(stp);
            st.Children.Add(btn);

            Content = st;
        }

        private void Random_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
            {
                labels[0].Text = String.Format("Red = {0:X2}", r);
                labels[1].Text = String.Format("Green = {0:X2}", g);
                labels[2].Text = String.Format("Blue = {0:X2}", b);
            }
            else
            {
                // !
            }
            box.Color = Color.FromRgb(r, g, b);
            foreach (var slider in sliders)
            {
                slider.Value = sliders.IndexOf(slider) == 0 ? r : sliders.IndexOf(slider) == 1 ? g : b;
            }
        }

        private void Stp_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double newValue = e.NewValue;
            box.WidthRequest = newValue * 1.5;
            box.HeightRequest = newValue * 1.5;
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            int r = (int)sliders[0].Value;
            int g = (int)sliders[1].Value;
            int b = (int)sliders[2].Value;
            if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
            {
                labels[0].Text = String.Format("Red = {0:X2}", r);
                labels[1].Text = String.Format("Green = {0:X2}", g);
                labels[2].Text = String.Format("Blue = {0:X2}", b);
            }
            else
            {
                // !
            }
            box.Color = Color.FromRgb(r, g, b);
        }
    }
}
