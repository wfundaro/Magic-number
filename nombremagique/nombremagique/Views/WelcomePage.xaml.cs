﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nombremagique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
#pragma warning disable CS4014
            InfiniteRotation(star1, 5000);
            InfiniteRotation(star2, 7000);
            InfiniteRotation(star3, 9000);
            InfiniteScale(playButton, 1000);
#pragma warning restore CS4014
        }
        private async Task InfiniteRotation(View view, uint length)
        {
            while (true)
            {
                await view.RotateTo(360, length);
                view.Rotation = 0;
            }
        }
        private async Task InfiniteScale(View view, uint length)
        {
            while (true)
            {
                await view.ScaleTo(1.1, length);
                await view.ScaleTo(1.0, length);
            }
        }
        private void PlayButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GamePage());
        }
    }
}