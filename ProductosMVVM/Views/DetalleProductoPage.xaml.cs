using ProductosMVVM.Models;
using ProductosMVVM.ViewModels;

namespace ProductosMVVM.Views;

public partial class DetalleProductoPage : ContentPage
{
    private readonly DetalleProductoViewModel _viewModel;
	public DetalleProductoPage(Producto Producto)
	{
		InitializeComponent();
		_viewModel = new DetalleProductoViewModel(Producto);
        BindingContext = _viewModel;
	}
    protected override async void OnAppearing() //se actualizan los datos
    {
        base.OnAppearing();
        CargarProductos();
    }

    private void CargarProductos()
    {
        _viewModel.CargarProductosAsync();
    }


}