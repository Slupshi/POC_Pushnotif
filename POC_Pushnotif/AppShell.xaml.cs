using System;
using System.Collections.Generic;
using POC_Pushnotif.ViewModels;
using POC_Pushnotif.Views;
using Xamarin.Forms;

namespace POC_Pushnotif
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
