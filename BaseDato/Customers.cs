using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDato
{
    public class Customers // El modificador de acceso public permite que la clase pueda ser accedida desde cualquier parte
    {
        // Definimos los parametros que nos permitirà leer y modificar los datos
        // Los metodos {get; set;} nos permitiran obtener, leer y modificar el valor de las propiedades 
        public string CustomerID { get; set; } // Definimos la propiedad para obtener el CustomerID
        public string CompanyName { get; set; } // Definimos la propiedad para obtener el CompanyName
        public string ContactName { get; set; } // Definimos la propiedad para obtener el ContactName
        public string ContactTitle { get; set; } // Definimos la propiedad para obtener el ContactTitle
        public string Address { get; set; } // Definimos la propiedad para obtener el Address
        public string City { get; set; } // Definimos la propiedad para obtener el City
        public object Region { get; set; } // Definimos la propiedad para obtener el Region
        public string PostalCode { get; set; } // Definimos la propiedad para obtener el PostalCode
        public string Country { get; set; } // Definimos la propiedad para obtener el Country
        public string Phone { get; set; } // Definimos la propiedad para obtener el Phone
        public string Fax { get; set; } // Definimos la propiedad para obtener el Fax
    }
}
