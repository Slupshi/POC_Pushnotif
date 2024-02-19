using System;
using System.Collections.Generic;
using System.ComponentModel;
using POC_Pushnotif.Models;
using POC_Pushnotif.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POC_Pushnotif.Views
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