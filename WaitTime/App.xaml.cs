using System;
using WaitTime.Services;
using WaitTime.Views;
using WaitTime.Views.AdobeDesing;
using WaitTime.Views.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaitTime
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new NavigationPage(new login_view());

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
