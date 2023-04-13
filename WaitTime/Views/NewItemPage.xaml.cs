using System;
using System.Collections.Generic;
using System.ComponentModel;
using WaitTime.Models;
using WaitTime.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaitTime.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}