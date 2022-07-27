using NewNCRHack.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NewNCRHack.Views
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