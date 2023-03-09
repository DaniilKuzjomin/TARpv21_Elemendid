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
        public Valgusfoor()
        {
            InitializeComponent();
        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            sisse = false;
            punane.BackgroundColor = Color.Gray;
            kollane.BackgroundColor = Color.Gray;
            roheline.BackgroundColor = Color.Gray;

        }



        private async void Sisse_Clicked(object sender, EventArgs e)
        {
            

            sisse = true;

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