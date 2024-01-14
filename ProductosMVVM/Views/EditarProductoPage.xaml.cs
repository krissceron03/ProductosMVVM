using ProductosMVVM.Models;
using ProductosMVVM.ViewModels;

namespace ProductosMVVM.Views;

public partial class EditarProductoPage : ContentPage
{
	
	public EditarProductoPage(Producto producto)
	{
		InitializeComponent();
        BindingContext = new EditarProductoViewModel(producto);
    }
}