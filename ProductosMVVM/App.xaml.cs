using ProductosMVVM.Services;
using ProductosMVVM.Views;

namespace ProductosMVVM
{
    public partial class App : Application
    {
        public static ProductoRepository ProductoRepository { get; set; }
        public App()
        {
            InitializeComponent();
            ProductoRepository = new ProductoRepository();
            MainPage = new NavigationPage(new ProductoPage());
        }
    }
}