using Domain.Entities;
using Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Infraestructure.Productos
{
    public class ProductoModel
    {
        private Producto[] productos;
        DBProductos db = new DBProductos();
        
        //

        #region CRUD
        private List<Producto> productsList;
        public void Add(Producto p)
        {
            try
            {
                productsList.Add(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new SyntaxErrorException();
            }
        }

        public void Update(Producto p)
        {
            Producto prod = new Producto();
            
            int Id = p.Id;
            Console.WriteLine(Id);

            if (p is null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            prod = productsList.FirstOrDefault(_prod => _prod.Id == Id);

            if (prod is null)
            {
                throw new ArgumentException("El producto no fue encontrado.");
            }
            else
            {
                prod.Id = p.Id;
                prod.Descripcion = p.Descripcion;
                prod.Existencia = p.Existencia;
                prod.FechaVencimiento = p.FechaVencimiento;
                prod.Nombre = p.Nombre;
                prod.Precio = p.Precio;
                prod.UnidadMedida = p.UnidadMedida;

             

            }
        }

       

        public bool Delete(Producto p)
        {

            Producto prod;
            int Id = p.Id;
            if (p is null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            prod = productsList.FirstOrDefault(_prod => _prod.Id == Id);

            if (prod is null)
            {
                throw new ArgumentException("El producto no fue encontrado.");
            }
            else
            {
                productsList.Remove(p);
                return !productsList.Exists(producto => producto.Id == Id);
            }
        }
        public List<Producto> GetAll()
        {
            return productsList;
        }
        #endregion

        #region Queries
        public Producto GetProductoById(int id)
        {
            int index = GetIndexById(id);
            return index < 0 ? null : productos[index];
        }

        public Producto[] GetProductosByUnidadMedida(UnidadMedida um)
        {
            Producto[] tmp = null;
            if(productos == null)
            {
                return tmp;
            }
            foreach (Producto p in productos)
            {
                if(p.UnidadMedida == um)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }

        public Producto[] GetProductosByRangoPrecio(decimal from, decimal to)
        {
            Producto[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach (Producto p in productos)
            {
                if (p.Precio >= from && p.Precio <= to)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }

        public Producto[] GetProductosByVencimiento(DateTime dt)
        {
            Producto[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach (Producto p in productos)
            {
                if (p.FechaVencimiento.CompareTo(dt) <= 0)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }

        public int GetLastProductoId()
        {
            return productos == null ? 0 : productos[productos.Length - 1].Id;
        }

        public string GetProductosAsJson()
        {
            return JsonConvert.SerializeObject(productos);
        }
        #endregion

        #region Private method

        private void Add(Producto p,ref Producto[] pds)
        {
            if(pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds,tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }

        private int GetIndexById(int id)
        {
            int index = int.MinValue, i = 0;
            if(id <= 0)
            {
                throw new ArgumentException($"El id:{id} no puede ser negativo o cero.");
            }

            if(productos == null)
            {
                return index;
            }

            foreach(Producto p in productos)
            {
                if(p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }
        #endregion

        

        
    }
}
