using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nombremagique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarsView : ContentView
    {
        public StarsView()
        {
            InitializeComponent();
#pragma warning disable CS4014
            InfiniteRotation(star1, 5000);
            InfiniteRotation(star2, 7000);
            InfiniteRotation(star3, 9000);
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
    }
}