using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21_Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        bool sisse = false;
        bool night = false;
        public Valgusfoor()
        {
            InitializeComponent();

            lbl1ClickFunc();
            lbl2ClickFunc();
            lbl3ClickFunc();

        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            sisse = false;
            punane.BackgroundColor = Color.Gray;
            kollane.BackgroundColor = Color.Gray;
            roheline.BackgroundColor = Color.Gray;
            lbl1Click.Text = "Punane";
            lbl2Click.Text = "Kollane";
            lbl3Click.Text = "Roheline";

        }

        private async void NReziim_Clicked(object sender, EventArgs e)
        {
            night = true;
            sisse = false;

            if (night)
            {
                while (night)
                {
                    punane.BackgroundColor = Color.Gray;
                    roheline.BackgroundColor = Color.Gray;


                    kollane.BackgroundColor = Color.Yellow;
                    await Task.Delay(700);
                    if (!night) break;
                    kollane.BackgroundColor = Color.Gray;
                    await Task.Delay(700);
                    if (!night) break;
                    kollane.BackgroundColor = Color.Yellow;
                    await Task.Delay(700);
                    if (!night) break;
                    kollane.BackgroundColor = Color.Gray;
                    await Task.Delay(700);
                    if (!night) break;
                    kollane.BackgroundColor = Color.Yellow;
                    await Task.Delay(700);
                    if (!night) break;
                    kollane.BackgroundColor = Color.Gray;
                }
            }
            
        }

        private async void VNReziim_Clicked(object sender, EventArgs e)
        {
            night = false;
            punane.BackgroundColor = Color.Gray;
            kollane.BackgroundColor = Color.Gray;
            roheline.BackgroundColor = Color.Gray;

        }

        void lbl1ClickFunc()
        {
            lbl1Click.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {

                    lbl1Click.Text = "Stopp!";

                })
            });
        }

        void lbl2ClickFunc()
        {
            lbl2Click.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {

                    lbl2Click.Text = "Oota!";

                })
            });
        }

        void lbl3ClickFunc()
        {
            lbl3Click.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {

                    lbl3Click.Text = "Mine!";

                })
            });
        }



        private async void Sisse_Clicked(object sender, EventArgs e)
        {
            sisse = true;
            night = false;

            if (sisse)
            {

                while (sisse)
                {

                    kollane.BackgroundColor = Color.Gray;
                    punane.BackgroundColor = Color.Gray;
                    roheline.BackgroundColor = Color.Gray;
                    await Task.Delay(200);
                    if (!sisse) break;
                    roheline.BackgroundColor= Color.Green;
                    await Task.Delay(1600);
                    if (!sisse) break;
                    roheline.BackgroundColor = Color.Gray;
                    await Task.Delay(600);
                    if (!sisse) break;
                    roheline.BackgroundColor = Color.Green;
                    await Task.Delay(600);
                    if (!sisse) break;
                    roheline.BackgroundColor = Color.Gray;
                    await Task.Delay(600);
                    if (!sisse) break;
                    roheline.BackgroundColor = Color.Green;
                    await Task.Delay(600);
                    if (!sisse) break;
                    roheline.BackgroundColor = Color.Gray;
                    await Task.Delay(600);
                    if (!sisse) break;
                    roheline.BackgroundColor = Color.Green;
                    await Task.Delay(600);
                    if (!sisse) break;
                    roheline.BackgroundColor = Color.Gray;
                    await Task.Delay(850);
                    if (!sisse) break;

                    kollane.BackgroundColor = Color.Yellow;
                    await Task.Delay(850);
                    if (!sisse) break;
                    kollane.BackgroundColor = Color.Gray;
                    await Task.Delay(850);
                    if (!sisse) break;

                    punane.BackgroundColor = Color.Red;
                    await Task.Delay(2000);
                    if (!sisse) break;
                    kollane.BackgroundColor = Color.Yellow;
                    await Task.Delay(800);
                    if (!sisse) break;
                    punane.BackgroundColor = Color.Gray;
                    kollane.BackgroundColor = Color.Gray;
                    await Task.Delay(600);
                    if (!sisse) break;
                    roheline.BackgroundColor = Color.Green;
                    await Task.Delay(1500);
                    if (!sisse) break;
                }
            }

            

        }

        

    }
}