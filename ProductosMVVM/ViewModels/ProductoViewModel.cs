using ProductosMVVM.Models;
using ProductosMVVM.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductosMVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]//hace que se cargue automaticamente
    public class ProductoViewModel
    {
        public Producto producto { get; set; }
        public ObservableCollection<Producto> ListaProductos { get; set; }
        public ProductoViewModel()
        {
            ListaProductos = new ObservableCollection<Producto>(App.ProductoRepository.GetAll());
        }
        //Funcionalidad al botón
        public ICommand CrearProducto =>
            new Command(async() =>
            {
               await App.Current.MainPage.Navigation.PushAsync(new NuevoProductoPage());
            });

        public async void CargarProductosAsync()
        {
            ListaProductos = new ObservableCollection<Producto>(App.ProductoRepository.GetAll());
        }


        /*public ICommand MostrarDetalleProducto =>
          new Command<Producto>(async (producto) =>
        {

          await App.Current.MainPage.Navigation.PushAsync(new DetalleProductoPage(producto.IdProducto));
        });
        public ICommand MostrarDetalleCommand => new Command<Producto>(MostrarDetalle);

        private async void MostrarDetalle(Producto producto)
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetalleProductoPage(producto));
        }*/



    }
}
