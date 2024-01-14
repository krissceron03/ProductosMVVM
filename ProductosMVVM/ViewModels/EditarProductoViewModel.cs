using ProductosMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductosMVVM.ViewModels
{
    public class EditarProductoViewModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Producto ProductoP { get; set; }

        public EditarProductoViewModel(Producto producto)
        {
            if (producto != null)
            {
                Nombre = producto.Nombre;
                Descripcion = producto.Descripcion;
                Cantidad = producto.Cantidad;
                ProductoP = producto;
            }
        }

        public ICommand EditarProducto =>
            new Command(async () =>
            {
                Producto producto = new Producto
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    Cantidad = Cantidad,
                    IdProducto=ProductoP.IdProducto//ya puedo ver el producto actual que quiero modificar
                };
                App.ProductoRepository.Update(producto);
                await App.Current.MainPage.Navigation.PopAsync();
            });
    }
}
