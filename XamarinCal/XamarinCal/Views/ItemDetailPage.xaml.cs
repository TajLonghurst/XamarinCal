using System.ComponentModel;
using Xamarin.Forms;
using XamarinCal.ViewModels;

namespace XamarinCal.Views
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