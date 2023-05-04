using System;
using WaitTime.Views.Home;
using WaitTime.Views.Login;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace WaitTime.Views
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage" /> class.
        /// </summary>
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void HomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new home_view());
        }

    }
}