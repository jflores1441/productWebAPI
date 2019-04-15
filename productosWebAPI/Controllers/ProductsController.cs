using productosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace productosWebAPI.Controllers
{
    /*En la API web, un controlador es un objeto que maneja solicitudes HTTP. 
     Agregaremos un controlador que puede devolver una lista de productos o un solo producto especificado por ID.
     NOTA: Si ha utilizado ASP.NET MVC, ya está familiarizado con los controladores. 
     Los controladores de API web son similares a los controladores MVC, pero heredan la clase ApiController en lugar de la clase Controller .
    */
    public class ProductsController : ApiController
    {
        /* Para mantener el ejemplo simple, los productos se almacenan en una matriz fija dentro de la clase de controlador. 
         * Por supuesto, en una aplicación real, debería consultar una base de datos o utilizar algún otro origen de datos externo.*/
        Product[] products = new Product[]
        {
            new Product {Id=1, Name="Sopa de Tomate", Category="Recetas", Price=21},
            new Product {Id=2, Name="yo-yo", Category="Juguetes", Price=12},
            new Product {Id=3, Name="Alacena", Category="Muebles", Price=3000}
        };


       
        /// <summary>
        /// El GetAllProductsmétodo devuelve la lista completa de productos como un tipo IEnumerable <Producto> .
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts() // api / products
        {
            return products;
        }

        /// <summary>
        /// El GetProductmétodo busca un solo producto por su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetProduct(int id) // api / products / id
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
