using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*La API web de ASP.NET puede serializar automáticamente su modelo a JSON, XML u otro formato, 
  y luego escribir los datos serializados en el cuerpo del mensaje de respuesta HTTP. 
  Mientras un cliente pueda leer el formato de serialización, puede deserializar el objeto. 
  La mayoría de los clientes pueden analizar XML o JSON. 
  Además, el cliente puede indicar qué formato desea al configurar el encabezado Aceptar en el mensaje de solicitud HTTP.*/

namespace productosWebAPI.Models
{
    /*Un modelo es un objeto que representa los datos en su aplicación, en este caso un Producto*/

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

    }
}