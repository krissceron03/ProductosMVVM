using ProductosMVVM.ViewModels;

namespace ProductosMVVM.Views;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
        BindingContext = new NuevoProductoViewModel();
    }
}