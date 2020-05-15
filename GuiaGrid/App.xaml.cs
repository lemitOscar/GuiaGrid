using GuiaGrid.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuiaGrid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PageGrid();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
