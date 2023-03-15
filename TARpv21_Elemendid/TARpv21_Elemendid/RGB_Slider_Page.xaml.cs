using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Xamarin.Forms.Xaml;

namespace TARpv21_Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RGB_Slider_Page : ContentPage
    {
        Label rlbl, blbl, glbl;
        Xamarin.Forms.BoxView box;
        private Slider slider1;
        private Slider slider2;
        private Slider slider3;
        int r, g, b;
        Stepper stp;
        Random rnd;
        Button btn;

        public RGB_Slider_Page()
        {
            rnd = new Random();
            box = new Xamarin.Forms.BoxView
            {
                Color = Color.Black,
                CornerRadius = 0,
                WidthRequest = 320,
                HeightRequest = 320,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            rlbl = new Label
            {
                Text = "..",
                TextColor = Color.Red
            };

            blbl = new Label
            {
                Text = "...",
                TextColor = Color.Blue
            };
            glbl = new Label
            {
                Text = "...",
                TextColor = Color.Green
            };

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

            Slider[] sliders = new Slider[3];

            for (int i = 0; i < sliders.Length; i++)
            {
                Slider slider = new Slider
                {
                    Minimum = 0,
                    Maximum = 100,
                    Value = 50,
                    AutomationId = $"slider{i + 1}" // set a unique AutomationId for each slider
                };
                slider.ValueChanged += OnSliderValueChanged;
                sliders[i] = slider;
                st.Children.Add(slider);
            }

            slider1 = sliders[0];
            slider2 = sliders[1];
            slider3 = sliders[2];

            st.Children.Add(box);
            st.Children.Add(rlbl);
            st.Children.Add(glbl);
            st.Children.Add(blbl);
            st.Children.Add(stp);
            st.Children.Add(btn);

            Content = st;
        }

        private void Random_Clicked(object sender, EventArgs e)
        {
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);

            rlbl.Text = String.Format("Red = {0:X2}", r);
            blbl.Text = String.Format("Blue = {0:X2}", b);
            glbl.Text = String.Format("Green = {0:X2}", g);

            box.Color = Color.FromRgb(r, b, g);

            slider1.Value = r;
            slider2.Value = g;
            slider3.Value = b;
        }

        private void Stp_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double newValue = e.NewValue;
            box.WidthRequest = newValue * 1.5;
            box.HeightRequest = newValue * 1.5;
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {

            if (sender == slider1)
            {
                rlbl.Text = String.Format("Red = {0:X2}", (int)args.NewValue);
            }
            else if (sender == slider3)
            {
                blbl.Text = String.Format("Blue = {0:X2}", (int)args.NewValue);
            }
            else if (sender == slider2)
            {
                glbl.Text = String.Format("Green = {0:X2}", (int)args.NewValue);
            }

            box.Color = Color.FromRgb((int)slider1.Value, (int)slider2.Value, (int)slider3.Value);
        }
    }
}