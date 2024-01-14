using ProductosMVVM.Models;
using ProductosMVVM.ViewModels;

namespace ProductosMVVM.Views;

public partial class ProductoPage : ContentPage
{
    private readonly ProductoViewModel _viewModel;

    public ProductoPage()
	{
		InitializeComponent();
        
        _viewModel= new ProductoViewModel();
        BindingContext = _viewModel;

    }
    private async void MostrarDetalleProducto(object sender, SelectedItemChangedEventArgs e)
    {

        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new DetalleProductoPage(producto));

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