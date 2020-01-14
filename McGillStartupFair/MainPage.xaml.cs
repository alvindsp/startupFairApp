using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace McGillStartupFair
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage);
            backgroundImage.Source = ImageSource.FromResource("McGillStartupFair.Assets.Images.mcgillBackground.jpg", assembly);
            logo.Source = ImageSource.FromResource("McGillStartupFair.Assets.Images.dobson2.png", assembly);
        }
    }
}
