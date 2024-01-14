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
    public class DetalleProductoViewModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Producto ProductoP { get; set; }
        

        public DetalleProductoViewModel(Producto Producto)
        {
            if (Producto != null)
            {
                Nombre = Producto.Nombre;
                Descripcion = Producto.Descripcion;
                Cantidad = Producto.Cantidad;
                ProductoP = Producto;
            }
            
        }
        public async void CargarProductosAsync()
        {
            Nombre = ProductoP.Nombre;
            Descripcion = ProductoP.Descripcion;
            Cantidad = ProductoP.Cantidad;
            
        }

        //FALTA LO DE BORRAR Y EDITAR
        public ICommand OnClickBorrar =>
            new Command(async () =>
            {
                
                    App.ProductoRepository.Delete(ProductoP.IdProducto);
                    await App.Current.MainPage.Navigation.PushAsync(new ProductoPage());
                    Console.WriteLine("Se eliminó");
              
            });
        

        public ICommand OnClickEditar =>
            new Command(async () =>
            {

                await App.Current.MainPage.Navigation.PushAsync(new EditarProductoPage(ProductoP));
            });
    }
}
