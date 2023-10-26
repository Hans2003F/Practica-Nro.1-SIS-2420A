using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_P1
{
    internal class CelNuevoController
    {
        List<Celular_Nuevo> listCelNuevo = new List<Celular_Nuevo>();
        // 1.- Añadir 10 elemetos a celular_nuevo
        public void InsertarCelulares()
        {
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca="Samsung",
                Modelo="Galaxi A50",
                SO="Android",
                Ram=8,
                Almacenamineto=156,
                Fecha_Ingreso=Convert.ToDateTime("21/10/2015"),
                Precio=2100,
            });
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 15Pro",
                SO = "iOS",
                Ram = 8,
                Almacenamineto = 512,
                Fecha_Ingreso = Convert.ToDateTime("18/04/2022"),
                Precio = 10000,
            });
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "Galaxi A12",
                SO = "Android",
                Ram = 6,
                Almacenamineto = 64,
                Fecha_Ingreso = Convert.ToDateTime("08/10/2012"),
                Precio = 1500,
            });
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 14",
                SO = "iOS",
                Ram = 8,
                Almacenamineto = 256,
                Fecha_Ingreso = Convert.ToDateTime("05/11/2021"),
                Precio = 5000,
            });
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "Galaxi S10",
                SO = "Android",
                Ram = 8,
                Almacenamineto = 512,
                Fecha_Ingreso = Convert.ToDateTime("01/04/2017"),
                Precio = 5500,
            });
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 14Pro Max",
                SO = "iOS",
                Ram = 8,
                Almacenamineto = 256,
                Fecha_Ingreso = Convert.ToDateTime("10/08/2021"),
                Precio = 4000,
            });
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "Galaxi A50",
                SO = "Android",
                Ram = 8,
                Almacenamineto = 156,
                Fecha_Ingreso = Convert.ToDateTime("21/10/2015"),
                Precio = 2100,
            });
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "Galaxi A50",
                SO = "Android",
                Ram = 8,
                Almacenamineto = 156,
                Fecha_Ingreso = Convert.ToDateTime("21/10/2015"),
                Precio = 2100,
            });
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca = "Xiami",
                Modelo = "Redmi 12",
                SO = "Android",
                Ram = 8,
                Almacenamineto = 256,
                Fecha_Ingreso = Convert.ToDateTime("07/07/2021"),
                Precio = 1300,
            });
            listCelNuevo.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "Galaxi A12",
                SO = "Android",
                Ram = 6,
                Almacenamineto = 156,
                Fecha_Ingreso = Convert.ToDateTime("24/05/2022"),
                Precio = 1300,
            });
        }
        public void PromedioCel()
        {
            var promedio = listCelNuevo.Average(x => x.Precio);
            Console.WriteLine("El promedio de celulares es: " +promedio);
        }
        public void MarcaSamsung()
        {
            Console.WriteLine("Las marcas de los celulares nuevos Samsung son");
            foreach (var item in listCelNuevo)
            {
                if (item.Marca == "Samsung")
                {
                    Console.WriteLine("Marca:"+item.Marca+"\n Modelo: "+item.Modelo+"\n SO: "+item.SO);
                }
            }
        }
    }
}
