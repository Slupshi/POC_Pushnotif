using System.ComponentModel;
using POC_Pushnotif.ViewModels;
using Xamarin.Forms;

namespace POC_Pushnotif.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}