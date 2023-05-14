﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        // Creamos la matriz de productos y sus precios
        string[] productos = { "Paracetamol", "Ibuprofeno", "Salbutamol", "Tramal", "Ramipril", "Aspirina" };
        int[] precios = { 150, 300, 1000, 1300, 1325, 215 };

        // Inicializamos las variables de compra
        int precioTotal = 0;
        bool seguirComprando = true;

        // Iniciamos el ciclo de compra
        while (seguirComprando)
        {
            // Mostramos la tabla de productos con sus precios
            Console.WriteLine("Tabla de precios:");
            Console.WriteLine("=====================================");
            Console.WriteLine("| Producto    | Precio             |");
            Console.WriteLine("=====================================");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("| " + productos[i].PadRight(12) + "| " + precios[i].ToString().PadLeft(18) + "|");
            }
            Console.WriteLine("=====================================");

            // Pedimos al usuario el producto que quiere comprar
            Console.Write("\n¿Qué producto quieres comprar?: ");
            string productoElegido = Console.ReadLine();

            // Buscamos el índice del producto elegido
            int indiceProducto = Array.IndexOf(productos, productoElegido);

            // Pedimos al usuario la cantidad de pastillas que quiere comprar
            Console.Write("¿Cuántas pastillas de " + productoElegido + " quieres comprar?: ");
            int cantidadpastillas = int.Parse(Console.ReadLine());

            // Calculamos el precio total de la compra del usuario
            int precioCompra = precios[indiceProducto] * cantidadpastillas;
            precioTotal += precioCompra;

            // Creamos la tabla de compra del usuario
            Console.WriteLine("\nTabla de compra:");
            Console.WriteLine("=====================================");
            Console.WriteLine("| Producto    | Precio     | Cantidad   |");
            Console.WriteLine("=====================================");
            Console.WriteLine("| " + productoElegido.PadRight(12) + "| " + precios[indiceProducto].ToString().PadLeft(10) + "| " + cantidadpastillas.ToString().PadLeft(8) + "|");
            Console.WriteLine("=====================================");
            Console.WriteLine("| Total              | " + precioCompra.ToString().PadLeft(10) + "|         |");
            Console.WriteLine("=====================================");

            // Preguntamos al usuario si quiere seguir comprando
            Console.Write("\n¿Quieres seguir comprando? (s/n): ");
            string respuesta = Console.ReadLine();
            seguirComprando = respuesta == "s";
        }

        // Mostramos el precio total de la compra
        Console.WriteLine("\nEl precio total de tu compra es: " + precioTotal.ToString().PadLeft(20));

        // Mostramos el mensaje de finalización
        Console.WriteLine("\n¡Gracias por tu compra!");
    }
}
