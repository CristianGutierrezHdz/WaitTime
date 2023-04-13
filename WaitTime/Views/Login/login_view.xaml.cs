using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaitTime.Views.Home;
using Xamarin.Forms;

namespace WaitTime.Views.Login
{ 
    public partial class login_view : ContentPage
    {
        public login_view()
        {
            InitializeComponent();
        }
        // esto es un comentario ( prueba commit )




        private async void BtnIniciar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new home_view());
        }

        private async void Handle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new registro_view());
        }

    }
}
	