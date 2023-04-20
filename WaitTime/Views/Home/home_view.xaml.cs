using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaitTime.Views.Login;
using Xamarin.Forms;

namespace WaitTime.Views.Home
{
    /// <summary>
    /// Interaction logic for home_view.xaml
	/// Generated by Export Kit - Lightning Storm.
    /// </summary>
    public partial class home_view : ContentPage
    {
        public home_view()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked_apps(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new list_apps());
        }
    }
}
	