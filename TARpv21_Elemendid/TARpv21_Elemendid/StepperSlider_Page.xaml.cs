﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21_Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepperSlider_Page : ContentPage
    {
        Stepper stp;
        Slider sld;
        Label lbl;


        
        public StepperSlider_Page()
        {
            stp = new Stepper
            {
                Minimum = 0,
                Maximum = 100,
                Value = 20,
                Increment= 5
            };
            stp.ValueChanged += Stp_ValueChanged;
            lbl = new Label
            {
                Text= "TTHK",
                FontSize= stp.Value,
            };
            sld = new Slider
            {
                Minimum = stp.Minimum,
                Maximum = stp.Maximum,
                Value = stp.Value,
                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black
            };
            sld.ValueChanged += Stp_ValueChanged;
            List<Object> objects = new List<Object> { stp, sld, lbl };
            AbsoluteLayout abs = new AbsoluteLayout();
            double y = 0;
            foreach (var item in objects)
            {
                y = y + 0.2;
                AbsoluteLayout.SetLayoutBounds((BindableObject)item, new Rectangle(0.1, y, 300, 100));
                AbsoluteLayout.SetLayoutFlags((BindableObject)item, AbsoluteLayoutFlags.PositionProportional);
                abs.Children.Add((View)item);
            }
            Content = abs;

        }

        private void Stp_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbl.FontSize = e.NewValue;
        }
    }
}