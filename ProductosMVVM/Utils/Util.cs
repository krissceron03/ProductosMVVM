using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosMVVM.Utils
{
    public class Util
    {
        private const string DBFileName = "Producto.db3";

        public const SQLiteOpenFlags Flags =
           SQLiteOpenFlags.ReadWrite |
           SQLiteOpenFlags.Create |
           SQLiteOpenFlags.SharedCache;

        public static string DataBasePath//como es multiplataforma se debe saber en donde se va a guardar
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
