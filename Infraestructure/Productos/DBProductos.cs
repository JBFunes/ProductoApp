using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infraestructure.Productos
{

    public class DBProductos
    {
        public static List<Producto> productos = new List<Producto>();
        string dirpath = Directory.GetCurrentDirectory();
        //obteniendo la ruta del archivo
        string path = Path.GetFullPath("ProductosData.json").Replace(@"\ProductosApp\bin\Debug\ProductosData.json", string.Empty) + @"\Infraestructure\Resources\ProductosData.json";

        public void Guardar()
        {
            Console.WriteLine(path);
            string texto = JsonConvert.SerializeObject(productos);
            File.WriteAllText(path, texto);
        }

        public void Cargar()
        {
            Console.WriteLine(path, "\n" + dirpath);
            string archivo = File.ReadAllText(path);
            productos = JsonConvert.DeserializeObject<List<Producto>>(archivo);

        }

        public void Insertar(Producto u)
        {
            Console.WriteLine(u);
            productos.Add(u);
            Guardar();
        }

        public List<Producto> GetProductos()
        {
            Cargar();
            return productos;
        }

        public void Eliminar(Producto producto)
        {
            productos.Remove(producto);
            Guardar();
        }

        public void printJson()
        {
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine(productos[i].ToString());
            }
        }
    }



}
