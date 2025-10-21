using DesaDigitalApp.Models;
using DesaDigitalApp.PageModels;

namespace DesaDigitalApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}